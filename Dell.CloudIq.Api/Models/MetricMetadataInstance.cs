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
	public string Id { get; set; } = string.Empty;

	/// <summary>
	/// Name of the metric.
	/// </summary>
	[JsonPropertyName("name")]
	[StringLength(64)]
	[RegularExpression(@"^[a-zA-Z0-9_]+$")]
	public string? Name { get; set; }

	/// <summary>
	/// Description of metric content, meaning, and usage.
	/// </summary>
	[JsonPropertyName("description")]
	public string? Description { get; set; }

	[JsonPropertyName("category")]
	[JsonConverter(typeof(JsonStringEnumMemberConverter))]
	public MetricMetadataCategory? Category { get; set; }

	[JsonPropertyName("type")]
	[JsonConverter(typeof(JsonStringEnumMemberConverter))]
	public MetricMetadataType? Type { get; set; }

	[JsonPropertyName("units")]
	[JsonConverter(typeof(JsonStringEnumMemberConverter))]
	public MetricMetadataUnits? Units { get; set; }

	[JsonPropertyName("resource_type")]
	[StringLength(int.MaxValue, MinimumLength = 1)]

	[JsonConverter(typeof(JsonStringEnumMemberConverter))]
	public MetricMetadataResourceType? ResourceType { get; set; }

	[JsonPropertyName("interval")]
	[StringLength(int.MaxValue, MinimumLength = 1)]
	[JsonConverter(typeof(JsonStringEnumMemberConverter))]
	public MetricsInterval? Interval { get; set; }

	private IDictionary<string, object>? _additionalProperties;

	[JsonExtensionData]
	public IDictionary<string, object> AdditionalProperties
	{
		get { return _additionalProperties ??= new Dictionary<string, object>(); }
		set { _additionalProperties = value; }
	}
}
