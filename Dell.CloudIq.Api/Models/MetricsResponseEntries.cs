namespace Dell.CloudIq.Api;

/// <summary>
/// Metrics Query Responses
/// </summary>
public class MetricsResponseEntries
{
	/// <summary>Gets or sets the list of metric names included in this response.</summary>
	[JsonPropertyName("metrics")]
	public List<string>? Metrics { get; set; }

	/// <summary>Gets or sets the list of per-resource metric result entries.</summary>
	[JsonPropertyName("results")]
	[MinLength(1)]
	public List<MetricsResponseEntry>? Results { get; set; }

	private IDictionary<string, object>? _additionalProperties;

	/// <summary>Gets or sets additional properties not explicitly defined in the schema.</summary>
	[JsonExtensionData]
	public IDictionary<string, object> AdditionalProperties
	{
		get { return _additionalProperties ??= new Dictionary<string, object>(); }
		set { _additionalProperties = value; }
	}
}
