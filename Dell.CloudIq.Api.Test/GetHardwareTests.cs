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

		eSXiHosts.Should().BeOfType<CollectionResponse<EsxiHost>>();
		eSXiHosts.Should().NotBeNull();
	}

	[Fact]
	public async Task GetESXiHost_ReturnsESXiHost()
	{
		var clientOptions = GetClientOptions();
		var client = new CloudIQClient(clientOptions, Logger);

		var eSXiHosts = await client.Hardware.GetEsxiHostsAsync();

		eSXiHosts.Should().BeOfType<CollectionResponse<EsxiHost>>();
		eSXiHosts.Should().NotBeNull();
		if (eSXiHosts.Results.Any())
		{
			var firstESXiHost = eSXiHosts.Results.First();

			var ESXiHost = await client.Hardware.GetEsxiHostAsync(firstESXiHost.Id);
			ESXiHost.Should().NotBeNull();
			ESXiHost.Id.Should().Be(firstESXiHost.Id);
		}
	}

	[Fact]
	public async Task GetPorts_ReturnsList()
	{
		var clientOptions = GetClientOptions();
		var client = new CloudIQClient(clientOptions, Logger);

		var ports = await client.Hardware.GetPortsAsync();

		ports.Should().BeOfType<CollectionResponse<Port>>();
		ports.Should().NotBeNull();
	}

	[Fact]
	public async Task GetPort_ReturnsPort()
	{
		var clientOptions = GetClientOptions();
		var client = new CloudIQClient(clientOptions, Logger);

		var ports = await client.Hardware.GetPortsAsync();

		ports.Should().BeOfType<CollectionResponse<Port>>();
		ports.Should().NotBeNull();
		if (ports.Results.Any())
		{
			var firstPort = ports.Results.First();

			var port = await client.Hardware.GetPortAsync(firstPort.Id);
			port.Should().NotBeNull();
			port.Id.Should().Be(firstPort.Id);
		}
	}
}