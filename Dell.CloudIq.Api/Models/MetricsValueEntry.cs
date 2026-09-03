namespace Dell.CloudIq.Api;

/// <summary>
/// Metrics Value Entry
/// </summary>
public class MetricsValueEntry : CloudIqModel
{
	/// <summary>Gets or sets the timestamp for this set of metric values.</summary>
	[JsonPropertyName("timestamp")]
	public string? Timestamp { get; set; }

	/// <summary>Gets or sets the ordered list of metric values corresponding to the requested metrics at this timestamp.</summary>
	[JsonPropertyName("values")]
	public List<double>? Values { get; set; }
}
