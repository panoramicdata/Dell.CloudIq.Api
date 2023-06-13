namespace Dell.CloudIq.Api;

public class Response
{
	[JsonPropertyName("paging")]
	public Paging Paging { get; set; } = new();

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
