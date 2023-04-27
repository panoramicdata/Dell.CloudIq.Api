namespace Dell.CloudIQ.Api;

/// <summary>
/// The volume object.
/// </summary>
public partial class Volume
{
	/// <summary>
	/// Identifier of the volume.
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
	/// Type of the system for the volume.
	/// </summary>
	[JsonProperty("system_type", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public string SystemType { get; set; }

	/// <summary>
	/// The allocated size of the volume - Unit: bytes
	/// </summary>
	[JsonProperty("allocated_size", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public long AllocatedSize { get; set; }

	/// <summary>
	/// The bandwidth consumed by the volume. Aggregated for a rolling average over the last 24 hours - Unit: bytes/s
	/// </summary>
	[JsonProperty("bandwidth", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public long Bandwidth { get; set; }

	/// <summary>
	/// Consistency group name of the volume.
	/// </summary>
	[JsonProperty("consistency_group_name", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public string ConsistencyGroupName { get; set; }

	/// <summary>
	/// The data reduction percent for the volume.
	/// </summary>
	[JsonProperty("data_reduction_percent", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public double DataReductionPercent { get; set; }

	/// <summary>
	/// The data reduction ratio for the volume.
	/// </summary>
	[JsonProperty("data_reduction_ratio", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public double DataReductionRatio { get; set; }

	/// <summary>
	/// The data reduction capacity saved for the volume - Unit: bytes
	/// </summary>
	[JsonProperty("data_reduction_saved_size", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public long DataReductionSavedSize { get; set; }

	/// <summary>
	/// The IO limit policy name for the volume.
	/// </summary>
	[JsonProperty("io_limit_policy_name", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public string IoLimitPolicyName { get; set; }

	/// <summary>
	/// The IOPS for the volume. Aggregated for a rolling average over the last 24 hours - Unit: IO/s
	/// </summary>
	[JsonProperty("iops", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public long Iops { get; set; }

	/// <summary>
	/// Identifies whether the volume is compressed or deduplicated.
	/// </summary>
	[JsonProperty("is_compressed_or_deduped", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public string IsCompressedOrDeduped { get; set; }

	/// <summary>
	/// Identifies whether the volume has thin provisioning enabled.
	/// </summary>
	[JsonProperty("is_thin_enabled", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public bool IsThinEnabled { get; set; }

	/// <summary>
	/// Number of health issues that are present on the volume.
	/// </summary>
	[JsonProperty("issue_count", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public long IssueCount { get; set; }

	/// <summary>
	/// User defined tags.
	/// </summary>
	[JsonProperty("tags", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public object Tags { get; set; }

	/// <summary>
	/// The latency for the volume. Aggregated for a rolling average over the last 24 hours - Unit: microseconds
	/// </summary>
	[JsonProperty("latency", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public long Latency { get; set; }

	/// <summary>
	/// The logical size for the volume - Unit: bytes
	/// </summary>
	[JsonProperty("logical_size", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public long LogicalSize { get; set; }

	/// <summary>
	/// The name of the volume.
	/// </summary>
	[JsonProperty("object_name", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public string ObjectName { get; set; }

	/// <summary>
	/// Identifier of the object, defined by the system.
	/// </summary>
	[JsonProperty("object_native_id", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public string ObjectNativeId { get; set; }

	/// <summary>
	/// Type of the object, which is either LUN or VOLUME.
	/// </summary>
	[JsonProperty("object_type", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public string ObjectType { get; set; }

	/// <summary>
	/// The pool identifier for the volume.
	/// </summary>
	[JsonProperty("pool_id", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public string PoolId { get; set; }

	/// <summary>
	/// The pool name for the volume.
	/// </summary>
	[JsonProperty("pool_name", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public string PoolName { get; set; }

	/// <summary>
	/// Type of the pool.
	/// </summary>
	[JsonProperty("pool_type", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public string PoolType { get; set; }

	/// <summary>
	/// The snapshot count for the volume.
	/// </summary>
	[JsonProperty("snapshot_count", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public long SnapshotCount { get; set; }

	/// <summary>
	/// The snapshot policy for the volume.
	/// </summary>
	[JsonProperty("snapshot_policy", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public string SnapshotPolicy { get; set; }

	/// <summary>
	/// The snapshot size for the volume - Unit: bytes
	/// </summary>
	[JsonProperty("snapshot_size", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public long SnapshotSize { get; set; }

	/// <summary>
	/// The storage resource identifier for the volume.
	/// </summary>
	[JsonProperty("storage_resource_id", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public string StorageResourceId { get; set; }

	/// <summary>
	/// The storage resource native identifier for the volume.
	/// </summary>
	[JsonProperty("storage_resource_native_id", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public string StorageResourceNativeId { get; set; }

	/// <summary>
	/// User defined tags.
	/// </summary>
	[JsonProperty("system_tags", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public object SystemTags { get; set; }

	/// <summary>
	/// The model of the system.
	/// </summary>
	[JsonProperty("system_model", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public string SystemModel { get; set; }

	/// <summary>
	/// Name of the system for the volume.
	/// </summary>
	[JsonProperty("system_name", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public string SystemName { get; set; }

	/// <summary>
	/// The total provisioned size of the volume - Unit: bytes
	/// </summary>
	[JsonProperty("total_size", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public long TotalSize { get; set; }

	/// <summary>
	/// The type of the volume, such as standalone, generic, or regular.
	/// </summary>
	[JsonProperty("type", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public string Type { get; set; }

	/// <summary>
	/// The used size of the volume - Unit: bytes
	/// </summary>
	[JsonProperty("used_size", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public long UsedSize { get; set; }

	/// <summary>
	/// The unique used size of the volume - Unit: bytes
	/// </summary>
	[JsonProperty("used_size_unique", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public long UsedSizeUnique { get; set; }

	private IDictionary<string, object> _additionalProperties;

	[JsonExtensionData]
	public IDictionary<string, object> AdditionalProperties
	{
		get { return _additionalProperties ?? (_additionalProperties = new Dictionary<string, object>()); }
		set { _additionalProperties = value; }
	}
}
