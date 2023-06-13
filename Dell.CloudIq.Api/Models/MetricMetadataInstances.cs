namespace Dell.CloudIq.Api;

/// <summary>
/// Metric Metadata Instances
/// </summary>
public class MetricMetadataInstances
{
	[JsonPropertyName("results")]
	public List<MetricMetadataInstance> Results { get; set; } = new();



	private IDictionary<string, object>? _additionalProperties;

	[JsonExtensionData]
	public IDictionary<string, object> AdditionalProperties
	{
		get { return _additionalProperties ??= new Dictionary<string, object>(); }
		set { _additionalProperties = value; }
	}

}
