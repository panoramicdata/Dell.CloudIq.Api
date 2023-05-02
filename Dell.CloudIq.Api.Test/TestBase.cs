using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dell.CloudIq.Api.Test;
public class TestBase
{
	protected CloudIQClientOptions GetClientOptions()
	{
		var builder = new ConfigurationBuilder()
			.AddUserSecrets<TestBase>();

		var configuration = builder.Build();

		return new CloudIQClientOptions { 
			ClientId = configuration["ClientId"] ?? throw new ArgumentNullException(nameof(CloudIQClientOptions.ClientId)),
			ClientSecret = configuration["ClientSecret"] ?? throw new ArgumentNullException(nameof(CloudIQClientOptions.ClientSecret)),
			BaseUri = configuration["BaseUri"] ?? throw new ArgumentNullException(nameof(CloudIQClientOptions.BaseUri))
		};
	}
}
