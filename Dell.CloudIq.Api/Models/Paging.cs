namespace Dell.CloudIq.Api;

/// <summary>
/// Contains paging reponse data
/// </summary>
public partial class Paging
{
	/// <summary>
	/// This the the collection size, not the reponse size.
	/// </summary>
	[JsonPropertyName("total_instances")]
	public long? TotalInstances { get; set; } = null;

	[JsonPropertyName("first")]
	public string? First { get; set; } = null;

	[JsonPropertyName("last")]
	public string? Last { get; set; } = null;

	[JsonPropertyName("next")]
	public string? Next { get; set; } = null;

	[JsonPropertyName("prev")]
	public string? Prev { get; set; } = null;

	private IDictionary<string, object> _additionalProperties;

	[JsonExtensionData]
	public IDictionary<string, object> AdditionalProperties
	{
		get { return _additionalProperties ?? (_additionalProperties = new Dictionary<string, object>()); }
		set { _additionalProperties = value; }
	}
}
