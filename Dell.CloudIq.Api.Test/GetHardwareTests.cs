namespace Dell.CloudIq.Api.Test;

public class GetHardwareTests(ITestOutputHelper testOutputHelper) : TestBase(testOutputHelper)
{
	[Fact]
	public async Task GetESXiHosts_ReturnsList()
	{
		var clientOptions = GetClientOptions();
		var client = new CloudIqClient(clientOptions, Logger);

		var eSXiHosts = await client.Hardware.GetEsxiHostsAsync(cancellationToken: CancellationToken);

		eSXiHosts.Should().BeOfType<CollectionResponse<EsxiHost>>();
		eSXiHosts.Should().NotBeNull();
	}

	[Fact]
	public async Task GetESXiHostsAll_ReturnsAll()
	{
		var clientOptions = GetClientOptions();
		var client = new CloudIqClient(clientOptions, Logger);

		var eSXiHosts = await client.Hardware.GetEsxiHostsAllAsync(cancellationToken: CancellationToken);

		eSXiHosts.Should().BeOfType<CollectionResponse<EsxiHost>>();
		eSXiHosts.Should().NotBeNull();
	}

	[Fact]
	public async Task GetESXiHost_ReturnsESXiHost()
	{
		var clientOptions = GetClientOptions();
		var client = new CloudIqClient(clientOptions, Logger);

		var eSXiHosts = await client.Hardware.GetEsxiHostsAsync(cancellationToken: CancellationToken);

		eSXiHosts.Should().BeOfType<CollectionResponse<EsxiHost>>();
		eSXiHosts.Should().NotBeNull();
		if (eSXiHosts.Results.Count != 0)
		{
			var firstESXiHost = eSXiHosts.Results.First();

			var ESXiHost = await client.Hardware.GetEsxiHostAsync(firstESXiHost.Id, cancellationToken: CancellationToken);
			ESXiHost.Should().NotBeNull();
			ESXiHost.Id.Should().Be(firstESXiHost.Id);
		}
	}

	[Fact]
	public async Task GetPorts_ReturnsList()
	{
		var clientOptions = GetClientOptions();
		var client = new CloudIqClient(clientOptions, Logger);

		var ports = await client.Hardware.GetPortsAsync(cancellationToken: CancellationToken);

		ports.Should().BeOfType<CollectionResponse<Port>>();
		ports.Should().NotBeNull();
	}

	[Fact]
	public async Task GetPort_ReturnsPort()
	{
		var clientOptions = GetClientOptions();
		var client = new CloudIqClient(clientOptions, Logger);

		var ports = await client.Hardware.GetPortsAsync(cancellationToken: CancellationToken);

		ports.Should().BeOfType<CollectionResponse<Port>>();
		ports.Should().NotBeNull();
		if (ports.Results.Count != 0)
		{
			var firstPort = ports.Results.First();

			var port = await client.Hardware.GetPortAsync(firstPort.Id, cancellationToken: CancellationToken);
			port.Should().NotBeNull();
			port.Id.Should().Be(firstPort.Id);
		}
	}
}