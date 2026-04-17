using Microsoft.Extensions.Configuration;

namespace Dell.CloudIq.Api.Test;

/// <summary>Base class for all Dell CloudIQ API integration tests.</summary>
/// <param name="testOutputHelper">The xUnit test output helper for logging.</param>
abstract public class TestBase(ITestOutputHelper testOutputHelper)
{
	/// <summary>Gets the logger for the current test.</summary>
	public ILogger Logger { get; } = testOutputHelper.BuildLogger();

	/// <summary>Gets the cancellation token for the current test.</summary>
	protected static CancellationToken CancellationToken => TestContext.Current.CancellationToken;

	/// <summary>Builds <see cref="CloudIqClientOptions"/> from user secrets configuration.</summary>
	/// <returns>A configured <see cref="CloudIqClientOptions"/> instance.</returns>
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
