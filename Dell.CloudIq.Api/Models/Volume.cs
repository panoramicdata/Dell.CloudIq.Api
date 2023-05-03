namespace Dell.CloudIq.Api;

/// <summary>
/// The volume object.
/// </summary>
public partial class Volume
{
	/// <summary>
	/// Identifier of the volume.
	/// </summary>
	[JsonPropertyName("id")]

	public string? Id { get; set; } = null;

	/// <summary>
	/// Unique identifier for the device or appliance.
	/// </summary>
	[JsonPropertyName("system_id")]
	public string? SystemId { get; set; } = null;

	/// <summary>
	/// Type of the system for the volume.
	/// </summary>
	[JsonPropertyName("system_type")]
	public string? SystemType { get; set; } = null;

	/// <summary>
	/// The allocated size of the volume - Unit: bytes
	/// </summary>
	[JsonPropertyName("allocated_size")]
	public long? AllocatedSize { get; set; } = null;

	/// <summary>
	/// The bandwidth consumed by the volume. Aggregated for a rolling average over the last 24 hours - Unit: bytes/s
	/// </summary>
	[JsonPropertyName("bandwidth")]
	public long? Bandwidth { get; set; } = null;

	/// <summary>
	/// Consistency group name of the volume.
	/// </summary>
	[JsonPropertyName("consistency_group_name")]
	public string? ConsistencyGroupName { get; set; } = null;

	/// <summary>
	/// The data reduction percent for the volume.
	/// </summary>
	[JsonPropertyName("data_reduction_percent")]
	public double? DataReductionPercent { get; set; } = null;

	/// <summary>
	/// The data reduction ratio for the volume.
	/// </summary>
	[JsonPropertyName("data_reduction_ratio")]
	public double? DataReductionRatio { get; set; } = null;

	/// <summary>
	/// The data reduction capacity saved for the volume - Unit: bytes
	/// </summary>
	[JsonPropertyName("data_reduction_saved_size")]
	public long? DataReductionSavedSize { get; set; } = null;

	/// <summary>
	/// The IO limit policy name for the volume.
	/// </summary>
	[JsonPropertyName("io_limit_policy_name")]
	public string? IoLimitPolicyName { get; set; } = null;

	/// <summary>
	/// The IOPS for the volume. Aggregated for a rolling average over the last 24 hours - Unit: IO/s
	/// </summary>
	[JsonPropertyName("iops")]
	public long? Iops { get; set; } = null;

	/// <summary>
	/// Identifies whether the volume is compressed or deduplicated.
	/// </summary>
	[JsonPropertyName("is_compressed_or_deduped")]
	public string? IsCompressedOrDeduped { get; set; } = null;

	/// <summary>
	/// Identifies whether the volume has thin provisioning enabled.
	/// </summary>
	[JsonPropertyName("is_thin_enabled")]
	public bool? IsThinEnabled { get; set; } = null;

	/// <summary>
	/// Number of health issues that are present on the volume.
	/// </summary>
	[JsonPropertyName("issue_count")]
	public long? IssueCount { get; set; } = null;

	/// <summary>
	/// User defined tags.
	/// </summary>
	[JsonPropertyName("tags")]
	public object? Tags { get; set; } = null;

	/// <summary>
	/// The latency for the volume. Aggregated for a rolling average over the last 24 hours - Unit: microseconds
	/// </summary>
	[JsonPropertyName("latency")]
	public long? Latency { get; set; } = null;

	/// <summary>
	/// The logical size for the volume - Unit: bytes
	/// </summary>
	[JsonPropertyName("logical_size")]
	public long? LogicalSize { get; set; } = null;

	/// <summary>
	/// The name of the volume.
	/// </summary>
	[JsonPropertyName("object_name")]
	public string? ObjectName { get; set; } = null;

	/// <summary>
	/// Identifier of the object, defined by the system.
	/// </summary>
	[JsonPropertyName("object_native_id")]
	public string? ObjectNativeId { get; set; } = null;

	/// <summary>
	/// Type of the object, which is either LUN or VOLUME.
	/// </summary>
	[JsonPropertyName("object_type")]
	public string? ObjectType { get; set; } = null;

	/// <summary>
	/// The pool identifier for the volume.
	/// </summary>
	[JsonPropertyName("pool_id")]
	public string? PoolId { get; set; } = null;

	/// <summary>
	/// The pool name for the volume.
	/// </summary>
	[JsonPropertyName("pool_name")]
	public string? PoolName { get; set; } = null;

	/// <summary>
	/// Type of the pool.
	/// </summary>
	[JsonPropertyName("pool_type")]
	public string? PoolType { get; set; } = null;

	/// <summary>
	/// The snapshot count for the volume.
	/// </summary>
	[JsonPropertyName("snapshot_count")]
	public long? SnapshotCount { get; set; } = null;

	/// <summary>
	/// The snapshot policy for the volume.
	/// </summary>
	[JsonPropertyName("snapshot_policy")]
	public string? SnapshotPolicy { get; set; } = null;

	/// <summary>
	/// The snapshot size for the volume - Unit: bytes
	/// </summary>
	[JsonPropertyName("snapshot_size")]
	public long? SnapshotSize { get; set; } = null;

	/// <summary>
	/// The storage resource identifier for the volume.
	/// </summary>
	[JsonPropertyName("storage_resource_id")]
	public string? StorageResourceId { get; set; } = null;

	/// <summary>
	/// The storage resource native identifier for the volume.
	/// </summary>
	[JsonPropertyName("storage_resource_native_id")]
	public string? StorageResourceNativeId { get; set; } = null;

	/// <summary>
	/// User defined tags.
	/// </summary>
	[JsonPropertyName("system_tags")]
	public object? SystemTags { get; set; } = null;

	/// <summary>
	/// The model of the system.
	/// </summary>
	[JsonPropertyName("system_model")]
	public string? SystemModel { get; set; } = null;

	/// <summary>
	/// Name of the system for the volume.
	/// </summary>
	[JsonPropertyName("system_name")]
	public string? SystemName { get; set; } = null;

	/// <summary>
	/// The total provisioned size of the volume - Unit: bytes
	/// </summary>
	[JsonPropertyName("total_size")]
	public long? TotalSize { get; set; } = null;

	/// <summary>
	/// The type of the volume, such as standalone, generic, or regular.
	/// </summary>
	[JsonPropertyName("type")]
	public string? Type { get; set; } = null;

	/// <summary>
	/// The used size of the volume - Unit: bytes
	/// </summary>
	[JsonPropertyName("used_size")]
	public long? UsedSize { get; set; } = null;

	/// <summary>
	/// The unique used size of the volume - Unit: bytes
	/// </summary>
	[JsonPropertyName("used_size_unique")]
	public long? UsedSizeUnique { get; set; } = null;

	private IDictionary<string, object> _additionalProperties;

	[JsonExtensionData]
	public IDictionary<string, object> AdditionalProperties
	{
		get { return _additionalProperties ?? (_additionalProperties = new Dictionary<string, object>()); }
		set { _additionalProperties = value; }
	}
}
