using FluentAssertions;
using Xunit.Abstractions;

namespace Dell.CloudIq.Api.Test;
public class GetComputeHostsTests : TestBase
{
	public GetComputeHostsTests(ITestOutputHelper testOutputHelper) : base(testOutputHelper)
	{
	}

	[Fact]
	public async Task GetComputeHosts_ReturnsList()
	{
		var clientOptions = GetClientOptions();
		var client = new CloudIQClient(clientOptions, Logger);

		var computeHosts = await client.Compute.GetHostsAsync();

		computeHosts.Should().NotBeNull();
	}

	[Fact]
	public async Task GetComputeHost_ReturnsHost()
	{
		var clientOptions = GetClientOptions();
		var client = new CloudIQClient(clientOptions, Logger);

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