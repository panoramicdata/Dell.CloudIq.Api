namespace Dell.CloudIq.Api;

/// <summary>
/// Metrics Query Responses
/// </summary>
public class MetricsResponseEntries : CloudIqModel
{
	/// <summary>Gets or sets the list of metric names included in this response.</summary>
	[JsonPropertyName("metrics")]
	public List<string>? Metrics { get; set; }

	/// <summary>Gets or sets the list of per-resource metric result entries.</summary>
	[JsonPropertyName("results")]
	[MinLength(1)]
	public List<MetricsResponseEntry>? Results { get; set; }
}
