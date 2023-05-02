namespace Dell.CloudIq.Api;

/// <summary>
/// Metric Metadata Instances
/// </summary>
public partial class MetricMetadataInstances
{
	[JsonProperty("results")]
	public List<MetricMetadataInstance> Results { get; set; }



	private IDictionary<string, object> _additionalProperties;

	[JsonExtensionData]
	public IDictionary<string, object> AdditionalProperties
	{
		get { return _additionalProperties ?? (_additionalProperties = new Dictionary<string, object>()); }
		set { _additionalProperties = value; }
	}

}
