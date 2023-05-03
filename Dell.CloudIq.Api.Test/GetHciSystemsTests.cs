using FluentAssertions;
using Microsoft.Extensions.Logging;
using Xunit.Abstractions;

namespace Dell.CloudIq.Api.Test;
public class GetHciSystemsTests : TestBase
{
	private readonly ITestOutputHelper _testOutputHelper;
	private readonly ILogger _logger;

	public GetHciSystemsTests(ITestOutputHelper testOutputHelper)
	{
		_testOutputHelper = testOutputHelper;
		_logger = testOutputHelper.BuildLogger();
	}

	[Fact]
	public async Task GetSystems_ReturnsList()
	{
		var clientOptions = GetClientOptions();
		var client = new CloudIQClient(clientOptions, _logger);

		var systems = await client.Hci.GetSystemsAsync();

		systems.Should().NotBeNull();
	}

	[Fact]
	public async Task GetSystem_ReturnsSystem()
	{
		var clientOptions = GetClientOptions();
		var client = new CloudIQClient(clientOptions, _logger);

		var hciSystems = await client.Hci.GetSystemsAsync();

		hciSystems.Should().NotBeNull();
		var firstSystem = hciSystems.Results.FirstOrDefault();

		if (firstSystem?.Id != null)
		{
			var system = await client.Hci.GetSystemAsync(firstSystem.Id);
			system.Should().NotBeNull();
			system.Id.Should().Be(firstSystem.Id);
		}
	}

}