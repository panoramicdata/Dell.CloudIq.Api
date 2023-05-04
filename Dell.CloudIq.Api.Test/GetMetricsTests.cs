using FluentAssertions;
using Microsoft.Extensions.Logging;
using Xunit.Abstractions;

namespace Dell.CloudIq.Api.Test;
public class GetMetricsTests : TestBase
{
	public GetMetricsTests(ITestOutputHelper testOutputHelper) : base(testOutputHelper)
	{
	}

	[Fact]
	public async Task GetMetricMetadataCollection_ReturnsCollection()
	{
		var clientOptions = GetClientOptions();
		var client = new CloudIQClient(clientOptions, Logger);

		var metricMetadatas = await client.Metrics.GetMetricMetadataCollectionAsync();

		metricMetadatas.Should().NotBeNull();
	}

	[Fact]
	public async Task GetMetricMetadataInstance_ReturnsESXiHost()
	{
		var clientOptions = GetClientOptions();
		var client = new CloudIQClient(clientOptions, Logger);

		var metricMetadatas = await client.Metrics.GetMetricMetadataCollectionAsync();

		metricMetadatas.Should().NotBeNull();
		if (metricMetadatas.Results.Any())
		{
			var firstMetricMetadata = metricMetadatas.Results.First();

			var metricMetadataInstance = await client.Metrics.GetMetricMetadataInstanceAsync(firstMetricMetadata.Id);
			metricMetadataInstance.Should().NotBeNull();
			metricMetadataInstance.Id.Should().Be(firstMetricMetadata.Id);
		}
	}
}