using Microsoft.Extensions.Configuration;

namespace Dell.CloudIq.Api.Test;
public class TestBase
{
	protected CloudIQClientOptions GetClientOptions()
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
