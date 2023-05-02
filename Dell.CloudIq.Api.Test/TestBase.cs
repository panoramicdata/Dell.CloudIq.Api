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
			.SetBasePath(Environment.CurrentDirectory)
			.AddUserSecrets<CloudIQClientOptions>();

		var configuration = builder.Build();

		return new CloudIQClientOptions { 
			ClientId = configuration["Config:ClientId"] ?? throw new ArgumentNullException(nameof(CloudIQClientOptions.ClientId)),
			ClientSecret = configuration["Config:ClientSecret"] ?? throw new ArgumentNullException(nameof(CloudIQClientOptions.ClientSecret)),
			BaseUri = configuration["Config:BaseUri"] ?? throw new ArgumentNullException(nameof(CloudIQClientOptions.BaseUri))
		};
	}
}
