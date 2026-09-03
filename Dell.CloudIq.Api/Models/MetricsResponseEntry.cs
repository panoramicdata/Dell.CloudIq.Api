namespace Dell.CloudIq.Api;

/// <summary>
/// Metrics Response Entry
/// </summary>
public class MetricsResponseEntry : CloudIqModel
{
	/// <summary>Gets or sets the resource identifier for these metric values.</summary>
	[JsonPropertyName("id")]
	[StringLength(int.MaxValue, MinimumLength = 1)]
	public string Id { get; set; } = string.Empty;

	/// <summary>Gets or sets the list of timestamped metric value entries for this resource.</summary>
	[JsonPropertyName("timestamps")]
	public List<MetricsValueEntry>? Timestamps { get; set; }
}
