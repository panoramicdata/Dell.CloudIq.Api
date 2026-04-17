namespace Dell.CloudIq.Api.Test;

/// <summary>Integration tests for Dell CloudIQ metrics endpoints.</summary>
/// <param name="testOutputHelper">The xUnit test output helper.</param>
public class GetMetricsTests(ITestOutputHelper testOutputHelper) : TestBase(testOutputHelper)
{
	/// <summary>Verifies that GetMetricMetadataCollectionAsync returns a non-null collection.</summary>
	[Fact]
	public async Task GetMetricMetadataCollection_ReturnsCollection()
	{
		var clientOptions = GetClientOptions();
		var client = new CloudIqClient(clientOptions, Logger);

		var metricMetadatas = await client.Metrics.GetMetricMetadataCollectionAsync(cancellationToken: CancellationToken);

		metricMetadatas.Should().BeOfType<MetricMetadataInstances>();
		metricMetadatas.Should().NotBeNull();
	}

	/// <summary>Verifies that GetMetricMetadataInstanceAsync returns the correct instance by ID.</summary>
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