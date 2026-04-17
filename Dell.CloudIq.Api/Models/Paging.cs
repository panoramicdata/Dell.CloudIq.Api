namespace Dell.CloudIq.Api;

/// <summary>
/// Contains paging reponse data
/// </summary>
public class Paging
{
	/// <summary>
	/// This the the collection size, not the reponse size.
	/// </summary>
	[JsonPropertyName("total_instances")]
	public long? TotalInstances { get; set; }

	/// <summary>Gets or sets the URL to the first page of results.</summary>
	[JsonPropertyName("first")]
	public string? First { get; set; }

	/// <summary>Gets or sets the URL to the last page of results.</summary>
	[JsonPropertyName("last")]
	public string? Last { get; set; }

	/// <summary>Gets or sets the URL to the next page of results.</summary>
	[JsonPropertyName("next")]
	public string? Next { get; set; }

	/// <summary>Gets or sets the URL to the previous page of results.</summary>
	[JsonPropertyName("prev")]
	public string? Prev { get; set; }

	private IDictionary<string, object>? _additionalProperties;

	/// <summary>Gets or sets additional properties not explicitly defined in the schema.</summary>
	[JsonExtensionData]
	public IDictionary<string, object> AdditionalProperties
	{
		get { return _additionalProperties ??= new Dictionary<string, object>(); }
		set { _additionalProperties = value; }
	}
}
