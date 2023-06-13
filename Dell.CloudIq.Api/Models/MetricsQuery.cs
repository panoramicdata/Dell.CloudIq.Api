namespace Dell.CloudIq.Api;

/// <summary>
/// Metrics query operation request body, specifying the desired metrics.
/// <br/>
/// </summary>
public class MetricsQuery
{
	[JsonPropertyName("resource_type")]

	[StringLength(int.MaxValue, MinimumLength = 1)]
	[JsonConverter(typeof(JsonStringEnumMemberConverter))]
	public MetricMetadataResourceType? ResourceType { get; set; }

	/// <summary>
	/// List of resource ids for which to get metrics. All ids must be of the
	/// <br/>resource_type specified above.
	/// <br/>
	/// </summary>
	[JsonPropertyName("ids")]
	[Required]
	[MinLength(1)]
	[MaxLength(999)]
	public List<string> Ids { get; set; } = new List<string>();

	/// <summary>
	/// List of desired metric names.
	/// <br/>Must be valid for resource_type, according to metric catalog.
	/// <br/>
	/// </summary>
	[JsonPropertyName("metrics")]
	[Required]
	[MinLength(1)]
	[MaxLength(99)]
	public List<string> Metrics { get; set; } = new List<string>();

	[JsonPropertyName("interval")]
	[StringLength(int.MaxValue, MinimumLength = 1)]
	[JsonConverter(typeof(JsonStringEnumMemberConverter))]
	public MetricsInterval? Interval { get; set; }

	/// <summary>
	/// The beginning timestamp for the query. Metrics _greater than_ this time will
	/// <br/>be returned.  Default is the earliest timestamp available for the
	/// <br/>requested metrics.
	/// <br/>Passing the highest timestamp from the prior metrics report will
	/// <br/>ensure that no duplicates or excluded metrics occur.
	/// <br/>
	/// </summary>
	[JsonPropertyName("from")]
	public long? From { get; set; }

	/// <summary>
	/// The ending timestamp for the query. Metrics _less than or equal to_ this
	/// <br/>time will be returned.  Default is the latest timestamp available for the
	/// <br/>requested metrics.
	/// <br/>
	/// </summary>
	[JsonPropertyName("to")]
	public long? To { get; set; }

	private IDictionary<string, object>? _additionalProperties;

	[JsonExtensionData]
	public IDictionary<string, object> AdditionalProperties
	{
		get { return _additionalProperties ??= new Dictionary<string, object>(); }
		set { _additionalProperties = value; }
	}

}
