using FluentAssertions;
using Microsoft.Extensions.Logging.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dell.CloudIq.Api.Test;
public class GetSystemTests : TestBase
{
	[Fact]
	public async Task GetSystems_ReturnsList()
	{ 
		var clientOptions = GetClientOptions();
		var client = new CloudIQClient(clientOptions, NullLogger.Instance);

		var systems = await client.System.GetSystemsAsync();
		
		systems.Should().NotBeNull();
	}
}
