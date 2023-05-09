using Dell.CloudIq.Api.Interfaces.Extensions;
using FluentAssertions;
using Microsoft.Extensions.Logging;
using Refit;
using System.Text.Json;
using Xunit.Abstractions;

namespace Dell.CloudIq.Api.Test;
public class GetSystemTests : TestBase
{
	public GetSystemTests(ITestOutputHelper testOutputHelper) : base(testOutputHelper)
	{
	}

	[Fact]
	public async Task GetFirmwares_ReturnsList()
	{
		var clientOptions = GetClientOptions();
		var client = new CloudIQClient(clientOptions, Logger);

		var firmwares = await client.System.GetFirmwaresAsync();

		firmwares.Should().BeOfType<CollectionResponse<Firmware>>();
		firmwares.Should().NotBeNull();
	}

	[Fact]
	public async Task GetFirmware_ReturnsFirmware()
	{
		var clientOptions = GetClientOptions();
		var client = new CloudIQClient(clientOptions, Logger);

		var firmwares = await client.System.GetFirmwaresAsync();

		firmwares.Should().BeOfType<CollectionResponse<Firmware>>();
		firmwares.Should().NotBeNull();

		if (firmwares.Results.Any())
		{
			var firstFirmware = firmwares.Results.First();

			var firmware = await client.System.GetHciSystemAsync(firstFirmware.Id);
			firmware.Should().NotBeNull();
			firmware.Id.Should().Be(firstFirmware.Id);
		}
	}

	[Fact]
	public async Task GetHciSystems_ReturnsList()
	{
		var clientOptions = GetClientOptions();
		var client = new CloudIQClient(clientOptions, Logger);

		var hciSystems = await client.System.GetHciSystemsAsync();

		hciSystems.Should().BeOfType<CollectionResponse<HciSystem>>();
		hciSystems.Should().NotBeNull();
	}

	[Fact]
	public async Task GetHciSystem_ReturnsSystem()
	{
		var clientOptions = GetClientOptions();
		var client = new CloudIQClient(clientOptions, Logger);

		var hciSystems = await client.System.GetHciSystemsAsync();

		hciSystems.Should().BeOfType<CollectionResponse<HciSystem>>();
		hciSystems.Should().NotBeNull();

		if (hciSystems.Results.Any())
		{
			var firstSystem = hciSystems.Results.First();

			var system = await client.System.GetHciSystemAsync(firstSystem.Id);
			system.Should().NotBeNull();
			system.Id.Should().Be(firstSystem.Id);
		}
	}

	[Fact]
	public async Task GetNetworkSystems_ReturnsList()
	{
		var clientOptions = GetClientOptions();
		var client = new CloudIQClient(clientOptions, Logger);

		var networkSystems = await client.System.GetNetworkSystemsAsync();

		networkSystems.Should().BeOfType<CollectionResponse<NetworkSystem>>();
		networkSystems.Should().NotBeNull();
	}

	[Fact]
	public async Task GetNetworkSystem_ReturnsNetworkSystem()
	{
		var clientOptions = GetClientOptions();
		var client = new CloudIQClient(clientOptions, Logger);

		var networkSystems = await client.System.GetNetworkSystemsAsync();

		networkSystems.Should().BeOfType<CollectionResponse<NetworkSystem>>();
		networkSystems.Should().NotBeNull();

		if (networkSystems.Results.Any())
		{
			var firstNetworkSystem = networkSystems.Results.First();

			var networkSystem = await client.System.GetNetworkSystemAsync(firstNetworkSystem.Id);
			networkSystem.Should().NotBeNull();
			networkSystem.Id.Should().Be(firstNetworkSystem.Id);
		}
	}

	[Fact]
	public async Task GetServerSystems_ReturnsList()
	{
		var clientOptions = GetClientOptions();
		var client = new CloudIQClient(clientOptions, Logger);

		var serverSystems = await client.System.GetServerSystemsAsync();

		serverSystems.Should().BeOfType<CollectionResponse<ServerSystem>>();
		serverSystems.Should().NotBeNull();
	}

	[Fact]
	public async Task GetServerSystem_ReturnsServerSystem()
	{
		var clientOptions = GetClientOptions();
		var client = new CloudIQClient(clientOptions, Logger);

		var serverSystems = await client.System.GetServerSystemsAsync();

		serverSystems.Should().BeOfType<CollectionResponse<ServerSystem>>();
		serverSystems.Should().NotBeNull();

		if (serverSystems.Results.Any())
		{
			var firstServerSystem = serverSystems.Results.First();

			var serverSystem = await client.System.GetServerSystemAsync(firstServerSystem.Id);
			serverSystem.Should().NotBeNull();
			serverSystem.Id.Should().Be(firstServerSystem.Id);
		}
	}

	[Fact]
	public async Task GetStorageSystems_ReturnsList()
	{
		var clientOptions = GetClientOptions();
		var client = new CloudIQClient(clientOptions, Logger);

		var storageSystems = await client.System.GetStorageSystemsAsync();

		storageSystems.Should().BeOfType<CollectionResponse<StorageSystem>>();
		storageSystems.Should().NotBeNull();
	}

	[Fact]
	public async Task GetStorageSystem_ReturnsServerSystem()
	{
		var clientOptions = GetClientOptions();
		var client = new CloudIQClient(clientOptions, Logger);

		var storageSystems = await client.System.GetStorageSystemsAsync();

		storageSystems.Should().BeOfType<CollectionResponse<StorageSystem>>();
		storageSystems.Should().NotBeNull();

		if (storageSystems.Results.Any())
		{
			var firstSstorageSystem = storageSystems.Results.First();

			var storageSystem = await client.System.GetStorageSystemAsync(firstSstorageSystem.Id);
			storageSystem.Should().NotBeNull();
			storageSystem.Id.Should().Be(firstSstorageSystem.Id);
		}
	}

	[Fact]
	public async Task GetSystems_ReturnsList()
	{
		var clientOptions = GetClientOptions();
		var client = new CloudIQClient(clientOptions, Logger);

		var systems = await client.System.GetSystemsAsync();

		systems.Should().BeOfType<CollectionResponse<CloudIQSystem>>();
		systems.Should().NotBeNull();
	}

	[Fact]
	public async Task GetSystemsAll_ReturnsAll()
	{
		var clientOptions = GetClientOptions();
		var client = new CloudIQClient(clientOptions, Logger);

		var systems = await client.System.GetSystemsAllAsync();

		systems.Should().BeOfType<CollectionResponse<CloudIQSystem>>();
		systems.Should().NotBeNull();
	}

	[Fact]
	public async Task GetSystem_ReturnsSystem()
	{
		var clientOptions = GetClientOptions();
		var client = new CloudIQClient(clientOptions, Logger);

		var systems = await client.System.GetSystemsAsync();

		systems.Should().BeOfType<CollectionResponse<CloudIQSystem>>();
		systems.Should().NotBeNull();

		if (systems.Results.Any())
		{
			var firstSystem = systems.Results.First();

			var system = await client.System.GetSystemAsync(firstSystem.Id);
			system.Should().NotBeNull();
			system.Id.Should().Be(firstSystem.Id);
		}
	}

	[Fact]
	public async Task GetSystems_WithFilter_ReturnsList()
	{
		var clientOptions = GetClientOptions();
		var client = new CloudIQClient(clientOptions, Logger);

		var systems = await client.System.GetSystemsAsync(filter: "type eq 'POWEREDGE'");

		systems.Should().BeOfType<CollectionResponse<CloudIQSystem>>();
		systems.Should().NotBeNull();
	}

	[Fact]
	public async Task GetSystems_WithSelect_ReturnsList()
	{
		var clientOptions = GetClientOptions();
		var client = new CloudIQClient(clientOptions, Logger);

		var systems = await client.System.GetSystemsAsync(select: new() { "id", "model" });

		systems.Should().BeOfType<CollectionResponse<CloudIQSystem>>();
		systems.Should().NotBeNull();
	}

	[Fact]
	public async Task GetSystems_WithInvalidFilter_ReturnsError()
	{
		var clientOptions = GetClientOptions();
		var client = new CloudIQClient(clientOptions, Logger);

		var exception = await Assert.ThrowsAsync<ApiException>(() => client.System.GetSystemsAsync(filter: "<string>"));
		exception.StatusCode.Should().Be(System.Net.HttpStatusCode.InternalServerError);

		var errorResponse = JsonSerializer.Deserialize<ErrorResponse>(exception.Content!);

		if (errorResponse is not null)
		{
			errorResponse.Messages.First().Message.Should().Contain("Invalid Filter");
		}
	}
}
