using Dell.CloudIq.Api.Exceptions;
using Microsoft.Extensions.Logging;
using System.Net.Http.Headers;
using System.Text.Json;
using System.Text.Json.Nodes;

namespace Dell.CloudIq.Api;

internal class AuthenticatedHttpClientHandler : HttpClientHandler
{
	private readonly CloudIQClientOptions _clientOptions;
	private readonly ILogger _logger;
	private ApiToken? _apiToken;
	private readonly JsonSerializerOptions _serializerOptions = new()
	{
		WriteIndented = true
	};

	public AuthenticatedHttpClientHandler(
		CloudIQClientOptions clientOptions,
		ILogger logger)
	{
		_clientOptions = clientOptions;
		_logger = logger;
	}

	protected override async Task<HttpResponseMessage> SendAsync(
		HttpRequestMessage request,
		CancellationToken cancellationToken)
	{
		var requestId = Guid.NewGuid();
		if (_apiToken is null)
		{
			_apiToken = await GenerateApiTokenAsync(cancellationToken);
		}

		request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", _apiToken.AccessToken);

		if (_logger.IsEnabled(LogLevel.Debug))
		{
			var url = request.RequestUri!.ToString();
			var headers = string.Join("\n", request.Headers.Select(h => $"{h.Key}: {string.Join(", ", h.Value.Select(v => v))}"));
			var body = request.Content is not null
				? await request.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false) 
				: string.Empty;

			try
			{
				if (!string.IsNullOrWhiteSpace(body))
				{
					var jObject = JsonSerializer.Deserialize<object>(body);
					if (jObject is not null)
					{
						body = JsonSerializer.Serialize(jObject, options: _serializerOptions);
					}
				}
			}
			catch (Exception ex)
			{
				_logger.LogWarning(ex, "Could not reformat JSON request body: {Message}", ex.Message);
			}
			
			_logger.LogDebug("{RequestId}: REQUEST: URL: {Url}\nHeaders: {Headers}\nBody: {Body}", requestId, url, headers, body);
		}

		var httpResponse = await base
			.SendAsync(request, cancellationToken)
			.ConfigureAwait(false);

		return httpResponse;
	}

	private async Task<ApiToken> GenerateApiTokenAsync(CancellationToken cancellationToken)
	{
		using var httpClient = new HttpClient
		{
			BaseAddress = new ($"{_clientOptions.BaseUri}/auth/oauth/v2/token")
		};

		var request = new HttpRequestMessage(HttpMethod.Post, string.Empty);

		var keyValues = new List<KeyValuePair<string, string>>
		{
			new KeyValuePair<string, string>("grant_type", "client_credentials"),
			new KeyValuePair<string, string>("client_id", _clientOptions.ClientId),
			new KeyValuePair<string, string>("client_secret", _clientOptions.ClientSecret)
		};

		request.Content = new FormUrlEncodedContent(keyValues);
		request.Content.Headers.ContentType = new MediaTypeWithQualityHeaderValue("application/x-www-form-urlencoded")
		{
			CharSet = "UTF-8"
		};

		var response = await httpClient
			.SendAsync(request, cancellationToken)
			.ConfigureAwait(false);

		if (!response.IsSuccessStatusCode)
		{
			throw new AuthenticationException();
		}

		var stringResponse = await response
			.Content
			.ReadAsStringAsync(cancellationToken)
			.ConfigureAwait(false);

		var tokenResponse = JsonSerializer.Deserialize<ApiToken>(stringResponse);

		return tokenResponse ?? throw new AuthenticationException("ApiToken not returned.");
	}
}