namespace Dell.CloudIq.Api;

/// <summary>
/// Properties of a metric-metadata instance as available from a specific resource type.
/// </summary>
public class MetricMetadataInstance
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

	/// <summary>Gets or sets the metric category (performance or space).</summary>
	[JsonPropertyName("category")]
	[JsonConverter(typeof(JsonStringEnumMemberConverter))]
	public MetricMetadataCategory? Category { get; set; }

	/// <summary>Gets or sets the metric type (fact, rate, or counter).</summary>
	[JsonPropertyName("type")]
	[JsonConverter(typeof(JsonStringEnumMemberConverter))]
	public MetricMetadataType? Type { get; set; }

	/// <summary>Gets or sets the units for this metric.</summary>
	[JsonPropertyName("units")]
	[JsonConverter(typeof(JsonStringEnumMemberConverter))]
	public MetricMetadataUnits? Units { get; set; }

	/// <summary>Gets or sets the resource type this metric applies to.</summary>
	[JsonPropertyName("resource_type")]
	[StringLength(int.MaxValue, MinimumLength = 1)]

	[JsonConverter(typeof(JsonStringEnumMemberConverter))]
	public MetricMetadataResourceType? ResourceType { get; set; }

	/// <summary>Gets or sets the collection interval for this metric.</summary>
	[JsonPropertyName("interval")]
	[StringLength(int.MaxValue, MinimumLength = 1)]
	[JsonConverter(typeof(JsonStringEnumMemberConverter))]
	public MetricsInterval? Interval { get; set; }

	private IDictionary<string, object>? _additionalProperties;

	/// <summary>Gets or sets additional properties not explicitly defined in the schema.</summary>
	[JsonExtensionData]
	public IDictionary<string, object> AdditionalProperties
	{
		get { return _additionalProperties ??= new Dictionary<string, object>(); }
		set { _additionalProperties = value; }
	}
}
