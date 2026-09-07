namespace Dell.CloudIq.Api.Test;

/// <summary>Integration tests for Dell CloudIQ storage endpoints.</summary>
/// <param name="testOutputHelper">The xUnit test output helper.</param>
public class GetStorageTests(ITestOutputHelper testOutputHelper) : TestBase(testOutputHelper)
{
	/// <summary>Verifies that GetStorageGroupsAsync returns a non-null collection.</summary>
	[Fact]
	public async Task GetStorageGroups_ReturnsList()
		=> await AssertCollectionAsync(
			client => client.Storage.GetStorageGroupsAsync(cancellationToken: CancellationToken));

	/// <summary>Verifies that GetStorageGroupAsync returns the correct storage group by ID.</summary>
	[Fact]
	public async Task GetStorageGroup_ReturnsGroup()
		=> await AssertFirstItemFetchableByIdAsync(
			client => client.Storage.GetStorageGroupsAsync(cancellationToken: CancellationToken),
			(client, id) => client.Storage.GetStorageGroupAsync(id, cancellationToken: CancellationToken),
			storageGroup => storageGroup.Id);
}
