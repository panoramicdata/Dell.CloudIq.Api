namespace Dell.CloudIq.Api;

/// <summary>
/// Metrics Response Entry
/// </summary>
public class MetricsResponseEntry
{
	[JsonPropertyName("id")]
	[StringLength(int.MaxValue, MinimumLength = 1)]
	public string Id { get; set; } = string.Empty;

	[JsonPropertyName("timestamps")]
	public List<MetricsValueEntry>? Timestamps { get; set; }

	private IDictionary<string, object>? _additionalProperties;

	[JsonExtensionData]
	public IDictionary<string, object> AdditionalProperties
	{
		get { return _additionalProperties ??= new Dictionary<string, object>(); }
		set { _additionalProperties = value; }
	}

}
