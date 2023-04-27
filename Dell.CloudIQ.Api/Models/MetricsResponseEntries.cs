namespace Dell.CloudIQ.Api;

/// <summary>
/// Metrics Query Responses
/// </summary>
public partial class MetricsResponseEntries
{
	[JsonProperty("metrics", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public List<string> Metrics { get; set; }

	[JsonProperty("results", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	[MinLength(1)]
	public List<MetricsResponseEntry> Results { get; set; }

	private IDictionary<string, object> _additionalProperties;

	[JsonExtensionData]
	public IDictionary<string, object> AdditionalProperties
	{
		get { return _additionalProperties ?? (_additionalProperties = new Dictionary<string, object>()); }
		set { _additionalProperties = value; }
	}
}
