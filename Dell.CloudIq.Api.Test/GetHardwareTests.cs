using FluentAssertions;
using Microsoft.Extensions.Logging;
using Xunit.Abstractions;

namespace Dell.CloudIq.Api.Test;
public class GetHardwareTests : TestBase
{
	public GetHardwareTests(ITestOutputHelper testOutputHelper) : base(testOutputHelper)
	{
	}

	[Fact]
	public async Task GetESXiHosts_ReturnsList()
	{
		var clientOptions = GetClientOptions();
		var client = new CloudIQClient(clientOptions, Logger);

		var eSXiHosts = await client.Hardware.GetEsxiHostsAsync();

		eSXiHosts.Should().NotBeNull();
	}

	[Fact]
	public async Task GetESXiHost_ReturnsESXiHost()
	{
		var clientOptions = GetClientOptions();
		var client = new CloudIQClient(clientOptions, Logger);

		var eSXiHosts = await client.Hardware.GetEsxiHostsAsync();

		eSXiHosts.Should().NotBeNull();
		if (eSXiHosts.Results.Any())
		{
			var firstESXiHost = eSXiHosts.Results.First();

			var ESXiHost = await client.Hardware.GetEsxiHostAsync(firstESXiHost.Id);
			ESXiHost.Should().NotBeNull();
			ESXiHost.Id.Should().Be(firstESXiHost.Id);
		}
	}
}