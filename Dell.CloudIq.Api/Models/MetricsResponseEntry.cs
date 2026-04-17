namespace Dell.CloudIq.Api;

/// <summary>
/// Metrics Response Entry
/// </summary>
public class MetricsResponseEntry
{
	/// <summary>Gets or sets the resource identifier for these metric values.</summary>
	[JsonPropertyName("id")]
	[StringLength(int.MaxValue, MinimumLength = 1)]
	public string Id { get; set; } = string.Empty;

	/// <summary>Gets or sets the list of timestamped metric value entries for this resource.</summary>
	[JsonPropertyName("timestamps")]
	public List<MetricsValueEntry>? Timestamps { get; set; }

	private IDictionary<string, object>? _additionalProperties;

	/// <summary>Gets or sets additional properties not explicitly defined in the schema.</summary>
	[JsonExtensionData]
	public IDictionary<string, object> AdditionalProperties
	{
		get { return _additionalProperties ??= new Dictionary<string, object>(); }
		set { _additionalProperties = value; }
	}

}
