using Divergic.Logging.Xunit;
using Microsoft.Extensions.Configuration;
using Xunit.Abstractions;

namespace Dell.CloudIq.Api.Test;
abstract public class TestBase
{
	public ICacheLogger Logger { get; }

	public TestBase(ITestOutputHelper testOutputHelper)
	{
		Logger = testOutputHelper.BuildLogger();
	}

	protected static CloudIQClientOptions GetClientOptions()
	{
		var builder = new ConfigurationBuilder()
			.AddUserSecrets<TestBase>();

		var configuration = builder.Build();

		return new CloudIQClientOptions
		{
			ClientId = configuration["ClientId"] ?? throw new ArgumentNullException(nameof(CloudIQClientOptions.ClientId)),
			ClientSecret = configuration["ClientSecret"] ?? throw new ArgumentNullException(nameof(CloudIQClientOptions.ClientSecret)),
			BaseUri = configuration["BaseUri"] ?? throw new ArgumentNullException(nameof(CloudIQClientOptions.BaseUri))
		};
	}
}
