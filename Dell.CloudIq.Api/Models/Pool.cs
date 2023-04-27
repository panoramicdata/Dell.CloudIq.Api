namespace Dell.CloudIq.Api;

/// <summary>
/// The pool object.
/// </summary>
public partial class Pool
{
	/// <summary>
	/// Identifier of the pool.
	/// </summary>
	[JsonProperty("id", Required = Newtonsoft.Json.Required.Always)]
	[Required(AllowEmptyStrings = true)]
	public string Id { get; set; }

	/// <summary>
	/// Unique identifier for the device or appliance.
	/// </summary>
	[JsonProperty("system_id", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public string SystemId { get; set; }

	/// <summary>
	/// Type of the system.
	/// </summary>
	[JsonProperty("system_type", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public string SystemType { get; set; }

	/// <summary>
	/// Available capacity - Unit: bytes
	/// </summary>
	[JsonProperty("free_size", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public long FreeSize { get; set; }

	/// <summary>
	/// Number of health issues that are present on the pool.
	/// </summary>
	[JsonProperty("issue_count", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public long IssueCount { get; set; }

	/// <summary>
	/// User defined tags.
	/// </summary>
	[JsonProperty("tags", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public object Tags { get; set; }

	/// <summary>
	/// Name of the pool.
	/// </summary>
	[JsonProperty("object_name", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public string ObjectName { get; set; }

	/// <summary>
	/// Identifier of the object, defined by the system.
	/// </summary>
	[JsonProperty("object_native_id", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public string ObjectNativeId { get; set; }

	/// <summary>
	/// Type of the object, which is always POOL.
	/// </summary>
	[JsonProperty("object_type", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public string ObjectType { get; set; }

	/// <summary>
	/// Percentage of pool capacity that is provisioned.
	/// </summary>
	[JsonProperty("subscribed_percent", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public double SubscribedPercent { get; set; }

	/// <summary>
	/// Total subscribed capacity of the pool - Unit: bytes
	/// </summary>
	[JsonProperty("subscribed_size", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public long SubscribedSize { get; set; }

	/// <summary>
	/// User defined tags.
	/// </summary>
	[JsonProperty("system_tags", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public object SystemTags { get; set; }

	/// <summary>
	/// Model of the system.
	/// </summary>
	[JsonProperty("system_model", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public string SystemModel { get; set; }

	/// <summary>
	/// Name of the system.
	/// </summary>
	[JsonProperty("system_name", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public string SystemName { get; set; }

	/// <summary>
	/// Predicted time that the pool will become full.
	/// </summary>
	[JsonProperty("time_to_full_prediction", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public string TimeToFullPrediction { get; set; }

	/// <summary>
	/// Total capacity of the pool - Unit: bytes
	/// </summary>
	[JsonProperty("total_size", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public long TotalSize { get; set; }

	/// <summary>
	/// The type of pool.
	/// </summary>
	[JsonProperty("type", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public string Type { get; set; }

	/// <summary>
	/// Percentage of pool capacity that is being used.
	/// </summary>
	[JsonProperty("used_percent", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public double UsedPercent { get; set; }

	/// <summary>
	/// Capacity of the pool that is being used - Unit: bytes
	/// </summary>
	[JsonProperty("used_size", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public long UsedSize { get; set; }

	private IDictionary<string, object> _additionalProperties;

	[JsonExtensionData]
	public IDictionary<string, object> AdditionalProperties
	{
		get { return _additionalProperties ?? (_additionalProperties = new Dictionary<string, object>()); }
		set { _additionalProperties = value; }
	}
}
