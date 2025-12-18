namespace Dell.CloudIq.Api.Test;

public class GetMetricsTests(ITestOutputHelper testOutputHelper) : TestBase(testOutputHelper)
{
	[Fact]
	public async Task GetMetricMetadataCollection_ReturnsCollection()
	{
		var clientOptions = GetClientOptions();
		var client = new CloudIqClient(clientOptions, Logger);

		var metricMetadatas = await client.Metrics.GetMetricMetadataCollectionAsync(cancellationToken: CancellationToken);

		metricMetadatas.Should().BeOfType<MetricMetadataInstances>();
		metricMetadatas.Should().NotBeNull();
	}

	[Fact]
	public async Task GetMetricMetadataInstance_ReturnsMetricMetadataInstance()
	{
		var clientOptions = GetClientOptions();
		var client = new CloudIqClient(clientOptions, Logger);

		var metricMetadatas = await client.Metrics.GetMetricMetadataCollectionAsync(cancellationToken: CancellationToken);

		metricMetadatas.Should().BeOfType<MetricMetadataInstances>();
		metricMetadatas.Should().NotBeNull();
		if (metricMetadatas.Results.Count != 0)
		{
			var firstMetricMetadata = metricMetadatas.Results.First();

			var metricMetadataInstance = await client.Metrics.GetMetricMetadataInstanceAsync(firstMetricMetadata.Id, cancellationToken: CancellationToken);
			metricMetadataInstance.Should().NotBeNull();
			metricMetadataInstance.Id.Should().Be(firstMetricMetadata.Id);
		}
	}
}