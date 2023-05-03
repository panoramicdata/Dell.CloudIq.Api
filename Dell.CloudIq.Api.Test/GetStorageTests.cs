using FluentAssertions;
using Microsoft.Extensions.Logging;
using Xunit.Abstractions;

namespace Dell.CloudIq.Api.Test;
public class GetStorageTests : TestBase
{
	private readonly ITestOutputHelper _testOutputHelper;
	private readonly ILogger _logger;

	public GetStorageTests(ITestOutputHelper testOutputHelper)
	{
		_testOutputHelper = testOutputHelper;
		_logger = testOutputHelper.BuildLogger();
	}

	[Fact]
	public async Task GetSystems_ReturnsList()
	{
		var clientOptions = GetClientOptions();
		var client = new CloudIQClient(clientOptions, _logger);

		var systems = await client.Storage.GetSystemsAsync();

		systems.Should().NotBeNull();
	}

	[Fact]
	public async Task GetSystem_ReturnsSystem()
	{
		var clientOptions = GetClientOptions();
		var client = new CloudIQClient(clientOptions, _logger);

		var storageSystems = await client.Storage.GetSystemsAsync();

		storageSystems.Should().NotBeNull();
		var firstSystem = storageSystems.Results.FirstOrDefault();

		if (firstSystem?.Id != null)
		{
			var system = await client.Storage.GetSystemAsync(firstSystem.Id);
			system.Should().NotBeNull();
			system.Id.Should().Be(firstSystem.Id);
		}
	}

	[Fact]
	public async Task GetGroups_ReturnsList()
	{
		var clientOptions = GetClientOptions();
		var client = new CloudIQClient(clientOptions, _logger);

		var groups = await client.Storage.GetGroupsAsync();

		groups.Should().NotBeNull();
	}

	[Fact]
	public async Task GetGroup_ReturnsGroup()
	{
		var clientOptions = GetClientOptions();
		var client = new CloudIQClient(clientOptions, _logger);

		var storageGroups = await client.Storage.GetGroupsAsync();

		storageGroups.Should().NotBeNull();
		var firstGroup = storageGroups.Results.FirstOrDefault();

		if (firstGroup?.Id != null)
		{
			var group = await client.Storage.GetSystemAsync(firstGroup.Id);
			group.Should().NotBeNull();
			group.Id.Should().Be(firstGroup.Id);
		}
	}
}