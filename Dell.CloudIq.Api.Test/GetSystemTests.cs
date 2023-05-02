using FluentAssertions;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;
using System;
using Xunit.Abstractions;

namespace Dell.CloudIq.Api.Test;
public class GetSystemTests : TestBase
{
	private readonly ITestOutputHelper _testOutputHelper;
	private readonly ILogger _logger;

	public GetSystemTests(ITestOutputHelper testOutputHelper)
	{
		_testOutputHelper = testOutputHelper;
		_logger = testOutputHelper.BuildLogger();
	}

	[Fact]
	public async Task GetSystems_ReturnsList()
	{ 
		var clientOptions = GetClientOptions();
		var client = new CloudIQClient(clientOptions, _logger);

		var systems = await client.System.GetSystemsAsync();
		
		systems.Should().NotBeNull();
	}

	[Fact]
	public async Task GetSystems_WithFilter_ReturnsList()
	{
		var clientOptions = GetClientOptions();
		var client = new CloudIQClient(clientOptions, _logger);

		var systems = await client.System.GetSystemsAsync(filter: "type eq 'POWEREDGE'");

		systems.Should().NotBeNull();
	}

	[Fact]
	public async Task GetSystems_WithSelect_ReturnsList()
	{
		var clientOptions = GetClientOptions();
		var client = new CloudIQClient(clientOptions, _logger);

		var systems = await client.System.GetSystemsAsync(select:new(){"id","model"});

		systems.Should().NotBeNull();
	}
}
