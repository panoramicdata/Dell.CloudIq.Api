namespace Dell.CloudIq.Api;

/// <summary>
/// Properties of a metric-metadata instance as available from a specific resource type.
/// </summary>
public partial class MetricMetadataInstance
{
	/// <summary>
	/// Unique identifier of a metric metadata resource.
	/// </summary>
	[JsonProperty("id")]
	public string Id { get; set; }

	/// <summary>
	/// Name of the metric.
	/// </summary>
	[JsonProperty("name")]
	[StringLength(64)]
	[RegularExpression(@"^[a-zA-Z0-9_]+$")]
	public string Name { get; set; }

	/// <summary>
	/// Description of metric content, meaning, and usage.
	/// </summary>
	[JsonProperty("description")]
	public string Description { get; set; }

	[JsonProperty("category")]
	public MetricMetadataCategoryEnum Category { get; set; }

	[JsonProperty("type")]
	[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
	public MetricMetadataTypeEnum Type { get; set; }

	[JsonProperty("units")]
	[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
	public MetricMetadataUnitsEnum Units { get; set; }

	[JsonProperty("resource_type")]
	[StringLength(int.MaxValue, MinimumLength = 1)]
	[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
	public MetricMetadataResourceTypeEnum ResourceType { get; set; }

	[JsonProperty("interval")]
	[StringLength(int.MaxValue, MinimumLength = 1)]
	[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
	public MetricsIntervalEnum Interval { get; set; }

	private IDictionary<string, object> _additionalProperties;

	[JsonExtensionData]
	public IDictionary<string, object> AdditionalProperties
	{
		get { return _additionalProperties ?? (_additionalProperties = new Dictionary<string, object>()); }
		set { _additionalProperties = value; }
	}
}
