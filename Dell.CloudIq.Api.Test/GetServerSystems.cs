using FluentAssertions;
using Microsoft.Extensions.Logging;
using Xunit.Abstractions;

namespace Dell.CloudIq.Api.Test;
public class GetServerSystemsTests : TestBase
{
	private readonly ITestOutputHelper _testOutputHelper;
	private readonly ILogger _logger;

	public GetServerSystemsTests(ITestOutputHelper testOutputHelper)
	{
		_testOutputHelper = testOutputHelper;
		_logger = testOutputHelper.BuildLogger();
	}

	[Fact]
	public async Task GetSystems_ReturnsList()
	{
		var clientOptions = GetClientOptions();
		var client = new CloudIQClient(clientOptions, _logger);

		var systems = await client.Server.GetSystemsAsync();

		systems.Should().NotBeNull();
	}

	[Fact]
	public async Task GetSystem_ReturnsSystem()
	{
		var clientOptions = GetClientOptions();
		var client = new CloudIQClient(clientOptions, _logger);

		var serverSystems = await client.Server.GetSystemsAsync();

		serverSystems.Should().NotBeNull();
		var firstSystem = serverSystems.Results.FirstOrDefault();

		if (firstSystem?.Id != null)
		{
			var system = await client.Server.GetSystemAsync(firstSystem.Id);
			system.Should().NotBeNull();
			system.Id.Should().Be(firstSystem.Id);
		}
	}

}