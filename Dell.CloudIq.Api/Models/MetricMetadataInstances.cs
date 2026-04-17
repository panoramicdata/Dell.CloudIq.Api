namespace Dell.CloudIq.Api;

/// <summary>
/// Metric Metadata Instances
/// </summary>
public class MetricMetadataInstances
{
	/// <summary>Gets or sets the list of metric metadata instances.</summary>
	[JsonPropertyName("results")]
	public List<MetricMetadataInstance> Results { get; set; } = [];



	private IDictionary<string, object>? _additionalProperties;

	/// <summary>Gets or sets additional properties not explicitly defined in the schema.</summary>
	[JsonExtensionData]
	public IDictionary<string, object> AdditionalProperties
	{
		get { return _additionalProperties ??= new Dictionary<string, object>(); }
		set { _additionalProperties = value; }
	}

}
