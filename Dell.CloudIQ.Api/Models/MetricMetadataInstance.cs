namespace Dell.CloudIq.Api;

/// <summary>
/// Properties of a metric-metadata instance as available from a specific resource type.
/// </summary>
public partial class MetricMetadataInstance
{
	/// <summary>
	/// Unique identifier of a metric metadata resource.
	/// </summary>
	[JsonProperty("id", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public string Id { get; set; }

	/// <summary>
	/// Name of the metric.
	/// </summary>
	[JsonProperty("name", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	[StringLength(64)]
	[RegularExpression(@"^[a-zA-Z0-9_]+$")]
	public string Name { get; set; }

	/// <summary>
	/// Description of metric content, meaning, and usage.
	/// </summary>
	[JsonProperty("description", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public string Description { get; set; }

	[JsonProperty("category", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public MetricMetadataCategoryEnum Category { get; set; }

	[JsonProperty("type", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
	public MetricMetadataTypeEnum Type { get; set; }

	[JsonProperty("units", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
	public MetricMetadataUnitsEnum Units { get; set; }

	[JsonProperty("resource_type", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	[StringLength(int.MaxValue, MinimumLength = 1)]
	[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
	public MetricMetadataResourceTypeEnum ResourceType { get; set; }

	[JsonProperty("interval", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
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
