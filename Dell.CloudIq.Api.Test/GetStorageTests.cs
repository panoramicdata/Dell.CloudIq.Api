namespace Dell.CloudIq.Api.Test;

public class GetStorageTests(ITestOutputHelper testOutputHelper) : TestBase(testOutputHelper)
{
	[Fact]
	public async Task GetStorageGroups_ReturnsList()
	{
		var clientOptions = GetClientOptions();
		var client = new CloudIqClient(clientOptions, Logger);

		var storageGroups = await client.Storage.GetStorageGroupsAsync(cancellationToken: CancellationToken);

		storageGroups.Should().BeOfType<CollectionResponse<StorageGroup>>();
		storageGroups.Should().NotBeNull();
	}

	[Fact]
	public async Task GetStorageGroup_ReturnsGroup()
	{
		var clientOptions = GetClientOptions();
		var client = new CloudIqClient(clientOptions, Logger);

		var storageGroups = await client.Storage.GetStorageGroupsAsync(cancellationToken: CancellationToken);

		storageGroups.Should().BeOfType<CollectionResponse<StorageGroup>>();
		storageGroups.Should().NotBeNull();
		if (storageGroups.Results.Count != 0)
		{
			var firstStorageGroup = storageGroups.Results.First();

			var storageGroup = await client.Storage.GetStorageGroupAsync(firstStorageGroup.Id, cancellationToken: CancellationToken);
			storageGroup.Should().NotBeNull();
			storageGroup.Id.Should().Be(firstStorageGroup.Id);
		}
	}
}