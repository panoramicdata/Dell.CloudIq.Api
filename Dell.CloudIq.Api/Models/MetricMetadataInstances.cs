namespace Dell.CloudIq.Api;

/// <summary>
/// Metric Metadata Instances
/// </summary>
public class MetricMetadataInstances : CloudIqModel
{
	/// <summary>Gets or sets the list of metric metadata instances.</summary>
	[JsonPropertyName("results")]
	public List<MetricMetadataInstance> Results { get; set; } = [];
}
