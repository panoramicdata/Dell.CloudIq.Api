namespace Dell.CloudIq.Api.Test;

/// <summary>Integration tests for Dell CloudIQ hardware endpoints.</summary>
/// <param name="testOutputHelper">The xUnit test output helper.</param>
public class GetHardwareTests(ITestOutputHelper testOutputHelper) : TestBase(testOutputHelper)
{
	/// <summary>Verifies that GetEsxiHostsAsync returns a non-null collection.</summary>
	[Fact]
	public async Task GetESXiHosts_ReturnsList()
		=> await AssertCollectionAsync(
			client => client.Hardware.GetEsxiHostsAsync(cancellationToken: CancellationToken));

	/// <summary>Verifies that GetEsxiHostsAllAsync retrieves all ESXi hosts across all pages.</summary>
	[Fact]
	public async Task GetESXiHostsAll_ReturnsAll()
		=> await AssertCollectionAsync(
			client => client.Hardware.GetEsxiHostsAllAsync(cancellationToken: CancellationToken));

	/// <summary>Verifies that GetEsxiHostAsync returns the correct ESXi host by ID.</summary>
	[Fact]
	public async Task GetESXiHost_ReturnsESXiHost()
		=> await AssertFirstItemFetchableByIdAsync(
			client => client.Hardware.GetEsxiHostsAsync(cancellationToken: CancellationToken),
			(client, id) => client.Hardware.GetEsxiHostAsync(id, cancellationToken: CancellationToken),
			esxiHost => esxiHost.Id);

	/// <summary>Verifies that GetPortsAsync returns a non-null collection.</summary>
	[Fact]
	public async Task GetPorts_ReturnsList()
		=> await AssertCollectionAsync(
			client => client.Hardware.GetPortsAsync(cancellationToken: CancellationToken));

	/// <summary>Verifies that GetPortAsync returns the correct port by ID.</summary>
	[Fact]
	public async Task GetPort_ReturnsPort()
		=> await AssertFirstItemFetchableByIdAsync(
			client => client.Hardware.GetPortsAsync(cancellationToken: CancellationToken),
			(client, id) => client.Hardware.GetPortAsync(id, cancellationToken: CancellationToken),
			port => port.Id);
}
