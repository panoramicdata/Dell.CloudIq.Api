using Microsoft.Extensions.Configuration;

namespace Dell.CloudIq.Api.Test;

abstract public class TestBase(ITestOutputHelper testOutputHelper)
{
	public ILogger Logger { get; } = testOutputHelper.BuildLogger();

	protected static CancellationToken CancellationToken => TestContext.Current.CancellationToken;

	protected static CloudIqClientOptions GetClientOptions()
	{
		var builder = new ConfigurationBuilder()
			.AddUserSecrets<TestBase>();

		var configuration = builder.Build();

		return new CloudIqClientOptions
		{
			ClientId = configuration["ClientId"] ?? throw new ArgumentNullException(nameof(CloudIqClientOptions.ClientId)),
			ClientSecret = configuration["ClientSecret"] ?? throw new ArgumentNullException(nameof(CloudIqClientOptions.ClientSecret)),
			BaseUri = configuration["BaseUri"] ?? throw new ArgumentNullException(nameof(CloudIqClientOptions.BaseUri))
		};
	}
}
