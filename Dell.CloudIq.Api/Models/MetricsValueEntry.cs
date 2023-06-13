namespace Dell.CloudIq.Api;

/// <summary>
/// Metrics Value Entry
/// </summary>
public class MetricsValueEntry
{
	[JsonPropertyName("timestamp")]
	public string? Timestamp { get; set; }

	[JsonPropertyName("values")]
	public List<double>? Values { get; set; }

	private IDictionary<string, object>? _additionalProperties;

	[JsonExtensionData]
	public IDictionary<string, object> AdditionalProperties
	{
		get { return _additionalProperties ??= new Dictionary<string, object>(); }
		set { _additionalProperties = value; }
	}
}
