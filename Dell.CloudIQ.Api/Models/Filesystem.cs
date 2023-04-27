namespace Dell.CloudIq.Api;

/// <summary>
/// The file system object.
/// </summary>
public partial class Filesystem
{
	/// <summary>
	/// Identifier of the file system.
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
	/// DEPRECATED - Unique identifier for the device or appliance.
	/// </summary>
	[JsonProperty("system", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	[System.Obsolete]
	public string System { get; set; }

	/// <summary>
	/// The system type for the file system.
	/// </summary>
	[JsonProperty("system_type", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public string SystemType { get; set; }

	/// <summary>
	/// The allocated size of the file system - Unit: bytes
	/// </summary>
	[JsonProperty("allocated_size", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public long AllocatedSize { get; set; }

	/// <summary>
	/// The data reduction percent for the file system.
	/// </summary>
	[JsonProperty("data_reduction_percent", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public double DataReductionPercent { get; set; }

	/// <summary>
	/// The data reduction ratio for the file system.
	/// </summary>
	[JsonProperty("data_reduction_ratio", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public double DataReductionRatio { get; set; }

	/// <summary>
	/// The data reduction saved size for the file system - Unit: bytes
	/// </summary>
	[JsonProperty("data_reduction_saved_size", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public long DataReductionSavedSize { get; set; }

	/// <summary>
	/// Identifies whether the file system has thin provisioning enabled.
	/// </summary>
	[JsonProperty("is_thin_enabled", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public bool IsThinEnabled { get; set; }

	/// <summary>
	/// Number of health issues that are present on the file system.
	/// </summary>
	[JsonProperty("issue_count", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public long IssueCount { get; set; }

	/// <summary>
	/// User defined tags.
	/// </summary>
	[JsonProperty("tags", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public object Tags { get; set; }

	/// <summary>
	/// Name of the file system.
	/// </summary>
	[JsonProperty("object_name", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public string ObjectName { get; set; }

	/// <summary>
	/// The NAS server ID.
	/// </summary>
	[JsonProperty("nas_server_id", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public string NasServerId { get; set; }

	/// <summary>
	/// The NAS server name for the file system.
	/// </summary>
	[JsonProperty("nas_server_name", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public string NasServerName { get; set; }

	/// <summary>
	/// Identifier of the object, defined by the system.
	/// </summary>
	[JsonProperty("object_native_id", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public string ObjectNativeId { get; set; }

	/// <summary>
	/// Type of the object.
	/// </summary>
	[JsonProperty("object_type", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public string ObjectType { get; set; }

	/// <summary>
	/// The performance policy name for the file system.
	/// </summary>
	[JsonProperty("performance_policy_name", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public string PerformancePolicyName { get; set; }

	/// <summary>
	/// The pool identifier for the file system.
	/// </summary>
	[JsonProperty("pool_id", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public string PoolId { get; set; }

	/// <summary>
	/// Name of the pool.
	/// </summary>
	[JsonProperty("pool_name", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public string PoolName { get; set; }

	/// <summary>
	/// Type of the pool.
	/// </summary>
	[JsonProperty("pool_type", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public string PoolType { get; set; }

	/// <summary>
	/// The protection policy name for the file system.
	/// </summary>
	[JsonProperty("protection_policy_name", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public string ProtectionPolicyName { get; set; }

	/// <summary>
	/// The storage resource identifier for the file system.
	/// </summary>
	[JsonProperty("storage_resource_id", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public string StorageResourceId { get; set; }

	/// <summary>
	/// The storage resource native identifier for the file system.
	/// </summary>
	[JsonProperty("storage_resource_native_id", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public string StorageResourceNativeId { get; set; }

	/// <summary>
	/// The supported protocols for the file system.
	/// </summary>
	[JsonProperty("supported_protocols", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public string SupportedProtocols { get; set; }

	/// <summary>
	/// User defined tags.
	/// </summary>
	[JsonProperty("system_tags", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public object SystemTags { get; set; }

	/// <summary>
	/// The model of the system for the file system.
	/// </summary>
	[JsonProperty("system_model", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public string SystemModel { get; set; }

	/// <summary>
	/// The name of the system.
	/// </summary>
	[JsonProperty("system_name", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public string SystemName { get; set; }

	/// <summary>
	/// The time to full prediction for the file system.
	/// </summary>
	[JsonProperty("time_to_full_prediction", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public string TimeToFullPrediction { get; set; }

	/// <summary>
	/// The total size of the file system - Unit: bytes
	/// </summary>
	[JsonProperty("total_size", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public long TotalSize { get; set; }

	/// <summary>
	/// The type of the file system.
	/// </summary>
	[JsonProperty("type", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public string Type { get; set; }

	/// <summary>
	/// Percentage used for the file system.
	/// </summary>
	[JsonProperty("used_percent", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public double UsedPercent { get; set; }

	/// <summary>
	/// Size used for the file system - Unit: bytes
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
