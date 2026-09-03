using Microsoft.Extensions.Configuration;

namespace Dell.CloudIq.Api.Test;

/// <summary>Base class for all Dell CloudIQ API integration tests.</summary>
/// <param name="testOutputHelper">The xUnit test output helper for logging.</param>
abstract public class TestBase(ITestOutputHelper testOutputHelper)
{
	/// <summary>
	/// User secrets supply the credentials for a local run; CLOUDIQ_-prefixed environment variables
	/// let CI supply the same values from repository secrets.
	/// </summary>
	private static readonly IConfiguration Configuration = new ConfigurationBuilder()
		.AddUserSecrets<TestBase>()
		.AddEnvironmentVariables("CLOUDIQ_")
		.Build();

	/// <summary>Gets the logger for the current test.</summary>
	public ILogger Logger { get; } = testOutputHelper.BuildLogger();

	/// <summary>Gets the cancellation token for the current test.</summary>
	protected static CancellationToken CancellationToken => TestContext.Current.CancellationToken;

	/// <summary>
	/// Gets a value indicating whether CloudIQ credentials are configured. Without them the tests
	/// that talk to CloudIQ cannot run, so they are skipped rather than failed — a runner with no
	/// credentials must not break the build, or a tag never reaches nuget.org.
	/// </summary>
	public static bool HasCredentials =>
		!string.IsNullOrWhiteSpace(Configuration["ClientId"])
		&& !string.IsNullOrWhiteSpace(Configuration["ClientSecret"])
		&& !string.IsNullOrWhiteSpace(Configuration["BaseUri"]);

	/// <summary>
	/// Creates a client for talking to CloudIQ, skipping the calling test when no credentials are
	/// configured.
	/// </summary>
	/// <returns>A <see cref="CloudIqClient"/> configured from user secrets or the environment.</returns>
	protected CloudIqClient CreateClient() => new(GetClientOptions(), Logger);

	/// <summary>Builds <see cref="CloudIqClientOptions"/> from the test configuration.</summary>
	/// <returns>A configured <see cref="CloudIqClientOptions"/> instance.</returns>
	private static CloudIqClientOptions GetClientOptions()
	{
		Assert.SkipUnless(
			HasCredentials,
			"CloudIQ credentials are not configured. Set ClientId, ClientSecret and BaseUri in user secrets (see userSecrets.example.json), or as CLOUDIQ_ClientId, CLOUDIQ_ClientSecret and CLOUDIQ_BaseUri environment variables.");

		return new CloudIqClientOptions
		{
			ClientId = Configuration["ClientId"]!,
			ClientSecret = Configuration["ClientSecret"]!,
			BaseUri = Configuration["BaseUri"]!
		};
	}
}
