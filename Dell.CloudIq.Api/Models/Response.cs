namespace Dell.CloudIq.Api;

public partial class Response
{
	[JsonPropertyName("paging")]
	public Paging Paging { get; set; }

	[JsonPropertyName("results")]
	public List<MetricMetadataInstance> Results { get; set; }

	private IDictionary<string, object> _additionalProperties;

	[JsonExtensionData]
	public IDictionary<string, object> AdditionalProperties
	{
		get { return _additionalProperties ?? (_additionalProperties = new Dictionary<string, object>()); }
		set { _additionalProperties = value; }
	}
}
