namespace Dell.CloudIq.Api;

/// <summary>
/// A paginated response containing metric metadata instances.
/// </summary>
public class Response : CloudIqModel
{
	/// <summary>Gets or sets the paging metadata for this response.</summary>
	[JsonPropertyName("paging")]
	public Paging Paging { get; set; } = new();

	/// <summary>Gets or sets the list of metric metadata instance results.</summary>
	[JsonPropertyName("results")]
	public List<MetricMetadataInstance> Results { get; set; } = [];
}
