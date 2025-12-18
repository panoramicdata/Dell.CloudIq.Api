namespace Dell.CloudIq.Api.Test;

public class GetSystemTests(ITestOutputHelper testOutputHelper) : TestBase(testOutputHelper)
{
	[Fact]
	public async Task GetFirmwares_ReturnsList()
	{
		var clientOptions = GetClientOptions();
		var client = new CloudIqClient(clientOptions, Logger);

		var firmwares = await client.System.GetFirmwaresAsync(cancellationToken: CancellationToken);

		firmwares.Should().BeOfType<CollectionResponse<Firmware>>();
		firmwares.Should().NotBeNull();
	}

	[Fact]
	public async Task GetFirmware_ReturnsFirmware()
	{
		var clientOptions = GetClientOptions();
		var client = new CloudIqClient(clientOptions, Logger);

		var firmwares = await client.System.GetFirmwaresAsync(cancellationToken: CancellationToken);

		firmwares.Should().BeOfType<CollectionResponse<Firmware>>();
		firmwares.Should().NotBeNull();

		if (firmwares.Results.Count != 0)
		{
			var firstFirmware = firmwares.Results.First();

			var firmware = await client.System.GetHciSystemAsync(firstFirmware.Id, cancellationToken: CancellationToken);
			firmware.Should().NotBeNull();
			firmware.Id.Should().Be(firstFirmware.Id);
		}
	}

	[Fact]
	public async Task GetHciSystems_ReturnsList()
	{
		var clientOptions = GetClientOptions();
		var client = new CloudIqClient(clientOptions, Logger);

		var hciSystems = await client.System.GetHciSystemsAsync(cancellationToken: CancellationToken);

		hciSystems.Should().BeOfType<CollectionResponse<HciSystem>>();
		hciSystems.Should().NotBeNull();
	}

	[Fact]
	public async Task GetHciSystem_ReturnsSystem()
	{
		var clientOptions = GetClientOptions();
		var client = new CloudIqClient(clientOptions, Logger);

		var hciSystems = await client.System.GetHciSystemsAsync(cancellationToken: CancellationToken);

		hciSystems.Should().BeOfType<CollectionResponse<HciSystem>>();
		hciSystems.Should().NotBeNull();

		if (hciSystems.Results.Count != 0)
		{
			var firstSystem = hciSystems.Results.First();

			var system = await client.System.GetHciSystemAsync(firstSystem.Id, cancellationToken: CancellationToken);
			system.Should().NotBeNull();
			system.Id.Should().Be(firstSystem.Id);
		}
	}

	[Fact]
	public async Task GetNetworkSystems_ReturnsList()
	{
		var clientOptions = GetClientOptions();
		var client = new CloudIqClient(clientOptions, Logger);

		var networkSystems = await client.System.GetNetworkSystemsAsync(cancellationToken: CancellationToken);

		networkSystems.Should().BeOfType<CollectionResponse<NetworkSystem>>();
		networkSystems.Should().NotBeNull();
	}

	[Fact]
	public async Task GetNetworkSystem_ReturnsNetworkSystem()
	{
		var clientOptions = GetClientOptions();
		var client = new CloudIqClient(clientOptions, Logger);

		var networkSystems = await client.System.GetNetworkSystemsAsync(cancellationToken: CancellationToken);

		networkSystems.Should().BeOfType<CollectionResponse<NetworkSystem>>();
		networkSystems.Should().NotBeNull();

		if (networkSystems.Results.Count != 0)
		{
			var firstNetworkSystem = networkSystems.Results.First();

			var networkSystem = await client.System.GetNetworkSystemAsync(firstNetworkSystem.Id, cancellationToken: CancellationToken);
			networkSystem.Should().NotBeNull();
			networkSystem.Id.Should().Be(firstNetworkSystem.Id);
		}
	}

	[Fact]
	public async Task GetServerSystems_ReturnsList()
	{
		var clientOptions = GetClientOptions();
		var client = new CloudIqClient(clientOptions, Logger);

		var serverSystems = await client.System.GetServerSystemsAsync(cancellationToken: CancellationToken);

		serverSystems.Should().BeOfType<CollectionResponse<ServerSystem>>();
		serverSystems.Should().NotBeNull();
	}

	[Fact]
	public async Task GetServerSystem_ReturnsServerSystem()
	{
		var clientOptions = GetClientOptions();
		var client = new CloudIqClient(clientOptions, Logger);

		var serverSystems = await client.System.GetServerSystemsAsync(cancellationToken: CancellationToken);

		serverSystems.Should().BeOfType<CollectionResponse<ServerSystem>>();
		serverSystems.Should().NotBeNull();

		if (serverSystems.Results.Count != 0)
		{
			var firstServerSystem = serverSystems.Results.First();

			var serverSystem = await client.System.GetServerSystemAsync(firstServerSystem.Id, cancellationToken: CancellationToken);
			serverSystem.Should().NotBeNull();
			serverSystem.Id.Should().Be(firstServerSystem.Id);
		}
	}

	[Fact]
	public async Task GetStorageSystems_ReturnsList()
	{
		var clientOptions = GetClientOptions();
		var client = new CloudIqClient(clientOptions, Logger);

		var storageSystems = await client.System.GetStorageSystemsAsync(cancellationToken: CancellationToken);

		storageSystems.Should().BeOfType<CollectionResponse<StorageSystem>>();
		storageSystems.Should().NotBeNull();
	}

	[Fact]
	public async Task GetStorageSystem_ReturnsServerSystem()
	{
		var clientOptions = GetClientOptions();
		var client = new CloudIqClient(clientOptions, Logger);

		var storageSystems = await client.System.GetStorageSystemsAsync(cancellationToken: CancellationToken);

		storageSystems.Should().BeOfType<CollectionResponse<StorageSystem>>();
		storageSystems.Should().NotBeNull();

		if (storageSystems.Results.Count != 0)
		{
			var firstSstorageSystem = storageSystems.Results.First();

			var storageSystem = await client.System.GetStorageSystemAsync(firstSstorageSystem.Id, cancellationToken: CancellationToken);
			storageSystem.Should().NotBeNull();
			storageSystem.Id.Should().Be(firstSstorageSystem.Id);
		}
	}

	[Fact]
	public async Task GetSystems_ReturnsList()
	{
		var clientOptions = GetClientOptions();
		var client = new CloudIqClient(clientOptions, Logger);

		var systems = await client.System.GetSystemsAsync();

		systems.Should().BeOfType<CollectionResponse<CloudIQSystem>>();
		systems.Should().NotBeNull();
	}

	[Fact]
	public async Task GetSystemsAll_ReturnsAll()
	{
		var clientOptions = GetClientOptions();
		var client = new CloudIqClient(clientOptions, Logger);

		var systems = await client.System.GetSystemsAllAsync(cancellationToken: CancellationToken);

		systems.Should().BeOfType<CollectionResponse<CloudIQSystem>>();
		systems.Should().NotBeNull();
	}

	[Fact]
	public async Task GetSystemsAll_WithFilter_ReturnsAllFiltered()
	{
		var clientOptions = GetClientOptions();
		var client = new CloudIqClient(clientOptions, Logger);

		var systems = await client.System.GetSystemsAllAsync(filter: "type eq 'POWEREDGE'", cancellationToken: CancellationToken);

		systems.Should().BeOfType<CollectionResponse<CloudIQSystem>>();
		systems.Should().NotBeNull();
	}

	[Fact]
	public async Task GetSystem_ReturnsSystem()
	{
		var clientOptions = GetClientOptions();
		var client = new CloudIqClient(clientOptions, Logger);

		var systems = await client.System.GetSystemsAsync();

		systems.Should().BeOfType<CollectionResponse<CloudIQSystem>>();
		systems.Should().NotBeNull();

		if (systems.Results.Count != 0)
		{
			var firstSystem = systems.Results.First();

			var system = await client.System.GetSystemAsync(firstSystem.Id, cancellationToken: CancellationToken);
			system.Should().NotBeNull();
			system.Id.Should().Be(firstSystem.Id);
		}
	}

	[Fact]
	public async Task GetSystems_WithFilter_ReturnsList()
	{
		var clientOptions = GetClientOptions();
		var client = new CloudIqClient(clientOptions, Logger);

		var systems = await client.System.GetSystemsAsync(filter: "type eq 'POWEREDGE'");

		systems.Should().BeOfType<CollectionResponse<CloudIQSystem>>();
		systems.Should().NotBeNull();
	}

	[Fact]
	public async Task GetSystems_WithSelect_ReturnsList()
	{
		var clientOptions = GetClientOptions();
		var client = new CloudIqClient(clientOptions, Logger);

		var systems = await client.System.GetSystemsAsync(select: ["id", "model"]);

		systems.Should().BeOfType<CollectionResponse<CloudIQSystem>>();
		systems.Should().NotBeNull();
	}

	[Fact]
	public async Task GetSystems_WithInvalidFilter_ReturnsError()
	{
		var clientOptions = GetClientOptions();
		var client = new CloudIqClient(clientOptions, Logger);

		var act = () => client.System.GetSystemsAsync(filter: "<string>");
		var exception = await act.Should().ThrowAsync<ApiException>();
		exception.Which.StatusCode.Should().Be(System.Net.HttpStatusCode.InternalServerError);

		var errorResponse = JsonSerializer.Deserialize<ErrorResponse>(exception.Which.Content!);

		errorResponse.Should().NotBeNull();
		errorResponse!.Messages.First().Message.Should().Contain("Invalid Filter");
	}
}
