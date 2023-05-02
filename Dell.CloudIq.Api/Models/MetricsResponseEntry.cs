namespace Dell.CloudIq.Api;

/// <summary>
/// Metrics Response Entry
/// </summary>
public partial class MetricsResponseEntry
{
	[JsonProperty("id")]
	[StringLength(int.MaxValue, MinimumLength = 1)]
	public string Id { get; set; }

	[JsonProperty("timestamps")]
	public List<MetricsValueEntry> Timestamps { get; set; }

	private IDictionary<string, object> _additionalProperties;

	[JsonExtensionData]
	public IDictionary<string, object> AdditionalProperties
	{
		get { return _additionalProperties ?? (_additionalProperties = new Dictionary<string, object>()); }
		set { _additionalProperties = value; }
	}

}
