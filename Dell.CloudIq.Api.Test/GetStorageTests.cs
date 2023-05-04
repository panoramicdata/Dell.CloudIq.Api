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
	public async Task GetGroups_ReturnsList()
	{
		var clientOptions = GetClientOptions();
		var client = new CloudIQClient(clientOptions, Logger);

		var groups = await client.Storage.GetGroupsAsync();

		groups.Should().NotBeNull();
	}

	[Fact]
	public async Task GetGroup_ReturnsGroup()
	{
		var clientOptions = GetClientOptions();
		var client = new CloudIQClient(clientOptions, Logger);

		var storageGroups = await client.Storage.GetGroupsAsync();

		storageGroups.Should().NotBeNull();
		if (storageGroups.Results.Any())
		{
			var firstGroup = storageGroups.Results.First();

			var group = await client.Storage.GetGroupAsync(firstGroup.Id);
			group.Should().NotBeNull();
			group.Id.Should().Be(firstGroup.Id);
		}
	}
}