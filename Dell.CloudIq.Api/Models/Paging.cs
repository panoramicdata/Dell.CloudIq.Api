namespace Dell.CloudIq.Api;

/// <summary>
/// Contains paging reponse data
/// </summary>
public partial class Paging
{
	/// <summary>
	/// This the the collection size, not the reponse size.
	/// </summary>
	[JsonProperty("total_instances")]
	public long TotalInstances { get; set; }

	[JsonProperty("first")]
	public string First { get; set; }

	[JsonProperty("last")]
	public string Last { get; set; }

	[JsonProperty("next")]
	public string Next { get; set; }

	[JsonProperty("prev")]
	public string Prev { get; set; }

	private IDictionary<string, object> _additionalProperties;

	[JsonExtensionData]
	public IDictionary<string, object> AdditionalProperties
	{
		get { return _additionalProperties ?? (_additionalProperties = new Dictionary<string, object>()); }
		set { _additionalProperties = value; }
	}
}
