using Divergic.Logging.Xunit;
using Microsoft.Extensions.Configuration;
using Xunit.Abstractions;

namespace Dell.CloudIq.Api.Test;
abstract public class TestBase
{
	public ICacheLogger Logger { get; }

	protected TestBase(ITestOutputHelper testOutputHelper)
	{
		Logger = testOutputHelper.BuildLogger();
	}

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
