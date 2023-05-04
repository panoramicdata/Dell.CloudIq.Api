using FluentAssertions;
using Microsoft.Extensions.Logging;
using Xunit.Abstractions;

namespace Dell.CloudIq.Api.Test;
public class GetStorageTests : TestBase
{
	public GetStorageTests(ITestOutputHelper testOutputHelper) : base(testOutputHelper)
	{
	}

	[Fact]
	public async Task GetStorageGroups_ReturnsList()
	{
		var clientOptions = GetClientOptions();
		var client = new CloudIQClient(clientOptions, Logger);

		var storageGroups = await client.Storage.GetStorageGroupsAsync();

		storageGroups.Should().BeOfType<CollectionResponse<StorageGroup>>();
		storageGroups.Should().NotBeNull();
	}

	[Fact]
	public async Task GetStorageGroup_ReturnsGroup()
	{
		var clientOptions = GetClientOptions();
		var client = new CloudIQClient(clientOptions, Logger);

		var storageGroups = await client.Storage.GetStorageGroupsAsync();

		storageGroups.Should().BeOfType<CollectionResponse<StorageGroup>>();
		storageGroups.Should().NotBeNull();
		if (storageGroups.Results.Any())
		{
			var firstStorageGroup = storageGroups.Results.First();

			var storageGroup = await client.Storage.GetStorageGroupAsync(firstStorageGroup.Id);
			storageGroup.Should().NotBeNull();
			storageGroup.Id.Should().Be(firstStorageGroup.Id);
		}
	}
}