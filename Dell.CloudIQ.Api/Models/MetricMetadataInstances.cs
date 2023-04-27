namespace Dell.CloudIQ.Api;

/// <summary>
/// Metric Metadata Instances
/// </summary>
public partial class MetricMetadataInstances
{
	[JsonProperty("results", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public List<MetricMetadataInstance> Results { get; set; }



	private IDictionary<string, object> _additionalProperties;

	[JsonExtensionData]
	public IDictionary<string, object> AdditionalProperties
	{
		get { return _additionalProperties ?? (_additionalProperties = new Dictionary<string, object>()); }
		set { _additionalProperties = value; }
	}

}
