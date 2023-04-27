namespace Dell.CloudIq.Api;

/// <summary>
/// Contains paging reponse data
/// </summary>
public partial class Paging
{
	/// <summary>
	/// This the the collection size, not the reponse size.
	/// </summary>
	[JsonProperty("total_instances", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public long TotalInstances { get; set; }

	[JsonProperty("first", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public string First { get; set; }

	[JsonProperty("last", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public string Last { get; set; }

	[JsonProperty("next", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public string Next { get; set; }

	[JsonProperty("prev", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public string Prev { get; set; }

	private IDictionary<string, object> _additionalProperties;

	[JsonExtensionData]
	public IDictionary<string, object> AdditionalProperties
	{
		get { return _additionalProperties ?? (_additionalProperties = new Dictionary<string, object>()); }
		set { _additionalProperties = value; }
	}
}
