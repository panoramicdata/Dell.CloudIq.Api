using Dell.CloudIq.Api.Exceptions;
using Microsoft.Extensions.Logging;
using System.Net.Http.Headers;

namespace Dell.CloudIq.Api;

internal class AuthenticatedHttpClientHandler : HttpClientHandler
{
	private readonly CloudIQClientOptions _clientOptions;
	private readonly ILogger _logger;
	private string? _apiToken;

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
		if (string.IsNullOrEmpty(_apiToken))
		{
			_apiToken = await GenerateApiTokenAsync(cancellationToken);
		}
		// TODO: Implement the authentication
		// This code is simply to make the code compile and should be removed
		await Task.Delay(500);
		return null!;
	}

	private async Task<string> GenerateApiTokenAsync(CancellationToken cancellationToken)
	{
		using var httpClient = new HttpClient()
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

		return stringResponse;
	}
}