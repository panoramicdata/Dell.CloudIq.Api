namespace Dell.CloudIq.Api.Test;

/// <summary>Integration tests for Dell CloudIQ system endpoints.</summary>
/// <param name="testOutputHelper">The xUnit test output helper.</param>
public class GetSystemTests(ITestOutputHelper testOutputHelper) : TestBase(testOutputHelper)
{
	/// <summary>Verifies that GetFirmwaresAsync returns a non-null collection.</summary>
	[Fact]
	public async Task GetFirmwares_ReturnsList()
		=> await AssertCollectionAsync(
			client => client.System.GetFirmwaresAsync(cancellationToken: CancellationToken));

	/// <summary>Verifies that GetHciSystemAsync returns the correct firmware by ID.</summary>
	[Fact]
	public async Task GetFirmware_ReturnsFirmware()
		=> await AssertFirstItemFetchableByIdAsync(
			client => client.System.GetFirmwaresAsync(cancellationToken: CancellationToken),
			(client, id) => client.System.GetHciSystemAsync(id, cancellationToken: CancellationToken),
			firmware => firmware.Id,
			hciSystem => hciSystem.Id);

	/// <summary>Verifies that GetHciSystemsAsync returns a non-null collection.</summary>
	[Fact]
	public async Task GetHciSystems_ReturnsList()
		=> await AssertCollectionAsync(
			client => client.System.GetHciSystemsAsync(cancellationToken: CancellationToken));

	/// <summary>Verifies that GetHciSystemAsync returns the correct HCI system by ID.</summary>
	[Fact]
	public async Task GetHciSystem_ReturnsSystem()
		=> await AssertFirstItemFetchableByIdAsync(
			client => client.System.GetHciSystemsAsync(cancellationToken: CancellationToken),
			(client, id) => client.System.GetHciSystemAsync(id, cancellationToken: CancellationToken),
			hciSystem => hciSystem.Id);

	/// <summary>Verifies that GetNetworkSystemsAsync returns a non-null collection.</summary>
	[Fact]
	public async Task GetNetworkSystems_ReturnsList()
		=> await AssertCollectionAsync(
			client => client.System.GetNetworkSystemsAsync(cancellationToken: CancellationToken));

	/// <summary>Verifies that GetNetworkSystemAsync returns the correct network system by ID.</summary>
	[Fact]
	public async Task GetNetworkSystem_ReturnsNetworkSystem()
		=> await AssertFirstItemFetchableByIdAsync(
			client => client.System.GetNetworkSystemsAsync(cancellationToken: CancellationToken),
			(client, id) => client.System.GetNetworkSystemAsync(id, cancellationToken: CancellationToken),
			networkSystem => networkSystem.Id);

	/// <summary>Verifies that GetServerSystemsAsync returns a non-null collection.</summary>
	[Fact]
	public async Task GetServerSystems_ReturnsList()
		=> await AssertCollectionAsync(
			client => client.System.GetServerSystemsAsync(cancellationToken: CancellationToken));

	/// <summary>Verifies that GetServerSystemAsync returns the correct server system by ID.</summary>
	[Fact]
	public async Task GetServerSystem_ReturnsServerSystem()
		=> await AssertFirstItemFetchableByIdAsync(
			client => client.System.GetServerSystemsAsync(cancellationToken: CancellationToken),
			(client, id) => client.System.GetServerSystemAsync(id, cancellationToken: CancellationToken),
			serverSystem => serverSystem.Id);

	/// <summary>Verifies that GetStorageSystemsAsync returns a non-null collection.</summary>
	[Fact]
	public async Task GetStorageSystems_ReturnsList()
		=> await AssertCollectionAsync(
			client => client.System.GetStorageSystemsAsync(cancellationToken: CancellationToken));

	/// <summary>Verifies that GetStorageSystemAsync returns the correct storage system by ID.</summary>
	[Fact]
	public async Task GetStorageSystem_ReturnsServerSystem()
		=> await AssertFirstItemFetchableByIdAsync(
			client => client.System.GetStorageSystemsAsync(cancellationToken: CancellationToken),
			(client, id) => client.System.GetStorageSystemAsync(id, cancellationToken: CancellationToken),
			storageSystem => storageSystem.Id);

	/// <summary>Verifies that GetSystemsAsync returns a non-null collection.</summary>
	[Fact]
	public async Task GetSystems_ReturnsList()
		=> await AssertCollectionAsync(client => client.System.GetSystemsAsync());

	/// <summary>Verifies that GetSystemsAllAsync retrieves all systems across all pages.</summary>
	[Fact]
	public async Task GetSystemsAll_ReturnsAll()
		=> await AssertCollectionAsync(
			client => client.System.GetSystemsAllAsync(cancellationToken: CancellationToken));

	/// <summary>Verifies that GetSystemsAllAsync with a filter retrieves only matching systems.</summary>
	[Fact]
	public async Task GetSystemsAll_WithFilter_ReturnsAllFiltered()
		=> await AssertCollectionAsync(
			client => client.System.GetSystemsAllAsync(filter: "type eq 'POWEREDGE'", cancellationToken: CancellationToken));

	/// <summary>Verifies that GetSystemAsync returns the correct system by ID.</summary>
	[Fact]
	public async Task GetSystem_ReturnsSystem()
		=> await AssertFirstItemFetchableByIdAsync(
			client => client.System.GetSystemsAsync(),
			(client, id) => client.System.GetSystemAsync(id, cancellationToken: CancellationToken),
			system => system.Id);

	/// <summary>Verifies that GetSystemsAsync with a filter returns only matching systems.</summary>
	[Fact]
	public async Task GetSystems_WithFilter_ReturnsList()
		=> await AssertCollectionAsync(client => client.System.GetSystemsAsync(filter: "type eq 'POWEREDGE'"));

	/// <summary>Verifies that GetSystemsAsync with a select list returns only the requested properties.</summary>
	[Fact]
	public async Task GetSystems_WithSelect_ReturnsList()
		=> await AssertCollectionAsync(client => client.System.GetSystemsAsync(select: ["id", "model"]));

	/// <summary>Verifies that GetSystemsAsync with an invalid filter throws an <see cref="ApiException"/>.</summary>
	[Fact]
	public async Task GetSystems_WithInvalidFilter_ReturnsError()
	{
		var client = CreateClient();

		var act = () => client.System.GetSystemsAsync(filter: "<string>");
		var exception = await act.Should().ThrowAsync<ApiException>();
		exception.Which.StatusCode.Should().Be(System.Net.HttpStatusCode.InternalServerError);

		var errorResponse = JsonSerializer.Deserialize<ErrorResponse>(exception.Which.Content!);

		errorResponse.Should().NotBeNull();
		errorResponse!.Messages.First().Message.Should().Contain("Invalid Filter");
	}
}
