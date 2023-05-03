using FluentAssertions;
using Microsoft.Extensions.Logging;
using Xunit.Abstractions;

namespace Dell.CloudIq.Api.Test;
public class GetComputeHostsTests : TestBase
{
	private readonly ITestOutputHelper _testOutputHelper;
	private readonly ILogger _logger;

	public GetComputeHostsTests(ITestOutputHelper testOutputHelper)
	{
		_testOutputHelper = testOutputHelper;
		_logger = testOutputHelper.BuildLogger();
	}

	[Fact]
	public async Task GetComputeHosts_ReturnsList()
	{
		var clientOptions = GetClientOptions();
		var client = new CloudIQClient(clientOptions, _logger);

		var computeHosts = await client.Compute.GetHostsAsync();

		computeHosts.Should().NotBeNull();
	}

	[Fact]
	public async Task GetComputeHost_ReturnsHost()
	{
		var clientOptions = GetClientOptions();
		var client = new CloudIQClient(clientOptions, _logger);

		var computeHosts = await client.Compute.GetHostsAsync();

		computeHosts.Should().NotBeNull();
		var firstHost = computeHosts.Results.First();

		if (firstHost?.Id != null)
		{
			var host = await client.Compute.GetHostAsync(firstHost.Id);
			host.Should().NotBeNull();
			host.Id.Should().Be(firstHost.Id);
		}
	}
}