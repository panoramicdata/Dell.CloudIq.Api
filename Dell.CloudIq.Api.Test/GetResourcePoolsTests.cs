using FluentAssertions;
using Microsoft.Extensions.Logging;
using Xunit.Abstractions;

namespace Dell.CloudIq.Api.Test;
public class GetResourcePoolsTests : TestBase
{
	private readonly ITestOutputHelper _testOutputHelper;
	private readonly ILogger _logger;

	public GetResourcePoolsTests(ITestOutputHelper testOutputHelper)
	{
		_testOutputHelper = testOutputHelper;
		_logger = testOutputHelper.BuildLogger();
	}

	[Fact]
	public async Task GetPools_ReturnsList()
	{
		var clientOptions = GetClientOptions();
		var client = new CloudIQClient(clientOptions, _logger);

		var systems = await client.Resource.GetPoolsAsync();

		systems.Should().NotBeNull();
	}

	[Fact]
	public async Task GetPool_ReturnsPool()
	{
		var clientOptions = GetClientOptions();
		var client = new CloudIQClient(clientOptions, _logger);

		var resourcePools = await client.Resource.GetPoolsAsync();

		resourcePools.Should().NotBeNull();
		var firstPool = resourcePools.Results.FirstOrDefault();

		if (firstPool?.Id != null)
		{
			var pool = await client.Resource.GetPoolAsync(firstPool.Id);
			pool.Should().NotBeNull();
			pool.Id.Should().Be(firstPool.Id);
		}
	}

}