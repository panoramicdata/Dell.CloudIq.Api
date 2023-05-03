namespace Dell.CloudIq.Api;

/// <summary>
/// Metrics Response Entry
/// </summary>
public partial class MetricsResponseEntry
{
	[JsonPropertyName("id")]
	[StringLength(int.MaxValue, MinimumLength = 1)]
	public string? Id { get; set; } = null;

	[JsonPropertyName("timestamps")]
	public List<MetricsValueEntry> Timestamps { get; set; } = null;

	private IDictionary<string, object> _additionalProperties;

	[JsonExtensionData]
	public IDictionary<string, object> AdditionalProperties
	{
		get { return _additionalProperties ?? (_additionalProperties = new Dictionary<string, object>()); }
		set { _additionalProperties = value; }
	}

}
