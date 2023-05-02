using Microsoft.Extensions.Logging;

namespace Dell.CloudIq.Api;

internal class AuthenticatedHttpClientHandler : HttpClientHandler
{
	private readonly CloudIQClientOptions _clientOptions;
	private readonly ILogger _logger;

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
		// TODO: Implement the authentication
		// This code is simply to make the code compile and should be removed
		await Task.Delay(500);
		return null!;
	}
}