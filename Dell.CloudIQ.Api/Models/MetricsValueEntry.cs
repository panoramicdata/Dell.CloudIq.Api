namespace Dell.CloudIQ.Api;

/// <summary>
/// Metrics Value Entry
/// </summary>
public partial class MetricsValueEntry
{
	[JsonProperty("timestamp", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public string Timestamp { get; set; }

	[JsonProperty("values", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public List<double> Values { get; set; }

	private IDictionary<string, object> _additionalProperties;

	[JsonExtensionData]
	public IDictionary<string, object> AdditionalProperties
	{
		get { return _additionalProperties ?? (_additionalProperties = new Dictionary<string, object>()); }
		set { _additionalProperties = value; }
	}
}
