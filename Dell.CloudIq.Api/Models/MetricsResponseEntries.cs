namespace Dell.CloudIq.Api;

/// <summary>
/// Metrics Query Responses
/// </summary>
public class MetricsResponseEntries
{
	[JsonPropertyName("metrics")]
	public List<string>? Metrics { get; set; }

	[JsonPropertyName("results")]
	[MinLength(1)]
	public List<MetricsResponseEntry>? Results { get; set; }

	private IDictionary<string, object>? _additionalProperties;

	[JsonExtensionData]
	public IDictionary<string, object> AdditionalProperties
	{
		get { return _additionalProperties ??= new Dictionary<string, object>(); }
		set { _additionalProperties = value; }
	}
}
