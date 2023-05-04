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
	public long? TotalInstances { get; set; }

	[JsonPropertyName("first")]
	public string? First { get; set; }

	[JsonPropertyName("last")]
	public string? Last { get; set; }

	[JsonPropertyName("next")]
	public string? Next { get; set; }

	[JsonPropertyName("prev")]
	public string? Prev { get; set; }

	private IDictionary<string, object>? _additionalProperties;

	[JsonExtensionData]
	public IDictionary<string, object> AdditionalProperties
	{
		get { return _additionalProperties ??= new Dictionary<string, object>(); }
		set { _additionalProperties = value; }
	}
}
