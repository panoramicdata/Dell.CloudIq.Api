using FluentAssertions;
using Microsoft.Extensions.Logging;
using Xunit.Abstractions;

namespace Dell.CloudIq.Api.Test;
public class GetNetworksSystemsTests : TestBase
{
	private readonly ITestOutputHelper _testOutputHelper;
	private readonly ILogger _logger;

	public GetNetworksSystemsTests(ITestOutputHelper testOutputHelper)
	{
		_testOutputHelper = testOutputHelper;
		_logger = testOutputHelper.BuildLogger();
	}

	[Fact]
	public async Task GetSystems_ReturnsList()
	{
		var clientOptions = GetClientOptions();
		var client = new CloudIQClient(clientOptions, _logger);

		var systems = await client.Network.GetSystemsAsync();

		systems.Should().NotBeNull();
	}

	[Fact]
	public async Task GetSystem_ReturnsSystem()
	{
		var clientOptions = GetClientOptions();
		var client = new CloudIQClient(clientOptions, _logger);

		var networkSystems = await client.Network.GetSystemsAsync();

		networkSystems.Should().NotBeNull();
		var firstSystem = networkSystems.Results.FirstOrDefault();

		if (firstSystem?.Id != null)
		{
			var system = await client.Network.GetSystemAsync(firstSystem.Id);
			system.Should().NotBeNull();
			system.Id.Should().Be(firstSystem.Id);
		}
	}

}