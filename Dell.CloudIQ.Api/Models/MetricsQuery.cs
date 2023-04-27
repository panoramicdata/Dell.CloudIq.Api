namespace Dell.CloudIq.Api;

/// <summary>
/// Metrics query operation request body, specifying the desired metrics.
/// <br/>
/// </summary>
public partial class MetricsQuery
{
	[JsonProperty("resource_type", Required = Newtonsoft.Json.Required.Always)]
	[Required(AllowEmptyStrings = true)]
	[StringLength(int.MaxValue, MinimumLength = 1)]
	[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
	public MetricMetadataResourceTypeEnum ResourceType { get; set; }

	/// <summary>
	/// List of resource ids for which to get metrics. All ids must be of the 
	/// <br/>resource_type specified above.
	/// <br/>
	/// </summary>
	[JsonProperty("ids", Required = Newtonsoft.Json.Required.Always)]
	[Required]
	[MinLength(1)]
	[MaxLength(999)]
	public List<string> Ids { get; set; } = new List<string>();

	/// <summary>
	/// List of desired metric names. 
	/// <br/>Must be valid for resource_type, according to metric catalog.
	/// <br/>
	/// </summary>
	[JsonProperty("metrics", Required = Newtonsoft.Json.Required.Always)]
	[Required]
	[MinLength(1)]
	[MaxLength(99)]
	public List<string> Metrics { get; set; } = new List<string>();

	[JsonProperty("interval", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	[StringLength(int.MaxValue, MinimumLength = 1)]
	[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
	public MetricsIntervalEnum Interval { get; set; }

	/// <summary>
	/// The beginning timestamp for the query. Metrics _greater than_ this time will 
	/// <br/>be returned.  Default is the earliest timestamp available for the 
	/// <br/>requested metrics. 
	/// <br/>Passing the highest timestamp from the prior metrics report will
	/// <br/>ensure that no duplicates or excluded metrics occur.
	/// <br/>
	/// </summary>
	[JsonProperty("from", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public System.DateTimeOffset From { get; set; }

	/// <summary>
	/// The ending timestamp for the query. Metrics _less than or equal to_ this 
	/// <br/>time will be returned.  Default is the latest timestamp available for the 
	/// <br/>requested metrics.
	/// <br/>
	/// </summary>
	[JsonProperty("to", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public System.DateTimeOffset To { get; set; }

	private IDictionary<string, object> _additionalProperties;

	[JsonExtensionData]
	public IDictionary<string, object> AdditionalProperties
	{
		get { return _additionalProperties ?? (_additionalProperties = new Dictionary<string, object>()); }
		set { _additionalProperties = value; }
	}

}
