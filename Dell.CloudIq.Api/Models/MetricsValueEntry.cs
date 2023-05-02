namespace Dell.CloudIq.Api;

/// <summary>
/// Metrics Value Entry
/// </summary>
public partial class MetricsValueEntry
{
	[JsonProperty("timestamp")]
	public string Timestamp { get; set; }

	[JsonProperty("values")]
	public List<double> Values { get; set; }

	private IDictionary<string, object> _additionalProperties;

	[JsonExtensionData]
	public IDictionary<string, object> AdditionalProperties
	{
		get { return _additionalProperties ?? (_additionalProperties = new Dictionary<string, object>()); }
		set { _additionalProperties = value; }
	}
}
