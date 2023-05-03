namespace Dell.CloudIq.Api;

/// <summary>
/// Properties of a metric-metadata instance as available from a specific resource type.
/// </summary>
public partial class MetricMetadataInstance
{
	/// <summary>
	/// Unique identifier of a metric metadata resource.
	/// </summary>
	[JsonPropertyName("id")]
	public string? Id { get; set; } = null;

	/// <summary>
	/// Name of the metric.
	/// </summary>
	[JsonPropertyName("name")]
	[StringLength(64)]
	[RegularExpression(@"^[a-zA-Z0-9_]+$")]
	public string? Name { get; set; } = null;

	/// <summary>
	/// Description of metric content, meaning, and usage.
	/// </summary>
	[JsonPropertyName("description")]
	public string? Description { get; set; } = null;

	[JsonPropertyName("category")]
	[JsonConverter(typeof(JsonStringEnumMemberConverter))]
	public MetricMetadataCategory? Category { get; set; } = null;

	[JsonPropertyName("type")]
	[JsonConverter(typeof(JsonStringEnumMemberConverter))]
	public MetricMetadataType? Type { get; set; } = null;

	[JsonPropertyName("units")]
	[JsonConverter(typeof(JsonStringEnumMemberConverter))]
	public MetricMetadataUnits? Units { get; set; } = null;

	[JsonPropertyName("resource_type")]
	[StringLength(int.MaxValue, MinimumLength = 1)]

	[JsonConverter(typeof(JsonStringEnumMemberConverter))]
	public MetricMetadataResourceType? ResourceType { get; set; } = null;

	[JsonPropertyName("interval")]
	[StringLength(int.MaxValue, MinimumLength = 1)]
	[JsonConverter(typeof(JsonStringEnumMemberConverter))]
	public MetricsInterval? Interval { get; set; } = null;

	private IDictionary<string, object>? _additionalProperties;

	[JsonExtensionData]
	public IDictionary<string, object> AdditionalProperties
	{
		get { return _additionalProperties ?? (_additionalProperties = new Dictionary<string, object>()); }
		set { _additionalProperties = value; }
	}
}
