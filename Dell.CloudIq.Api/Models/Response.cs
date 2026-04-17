namespace Dell.CloudIq.Api;

/// <summary>
/// A paginated response containing metric metadata instances.
/// </summary>
public class Response
{
	/// <summary>Gets or sets the paging metadata for this response.</summary>
	[JsonPropertyName("paging")]
	public Paging Paging { get; set; } = new();

	/// <summary>Gets or sets the list of metric metadata instance results.</summary>
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
