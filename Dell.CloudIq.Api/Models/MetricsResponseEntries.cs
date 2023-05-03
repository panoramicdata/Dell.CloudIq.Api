namespace Dell.CloudIq.Api;

/// <summary>
/// Metrics Query Responses
/// </summary>
public partial class MetricsResponseEntries
{
	[JsonPropertyName("metrics")]
	public List<string>? Metrics { get; set; } = null;

	[JsonPropertyName("results")]
	[MinLength(1)]
	public List<MetricsResponseEntry>? Results { get; set; } = null;

	private IDictionary<string, object>? _additionalProperties;

	[JsonExtensionData]
	public IDictionary<string, object> AdditionalProperties
	{
		get { return _additionalProperties ?? (_additionalProperties = new Dictionary<string, object>()); }
		set { _additionalProperties = value; }
	}
}
