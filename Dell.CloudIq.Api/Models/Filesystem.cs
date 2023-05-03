namespace Dell.CloudIq.Api;

/// <summary>
/// The file system object.
/// </summary>
public partial class Filesystem
{
	/// <summary>
	/// Identifier of the file system.
	/// </summary>
	[JsonPropertyName("id")]

	public string? Id { get; set; } = null;

	/// <summary>
	/// Unique identifier for the device or appliance.
	/// </summary>
	[JsonPropertyName("system_id")]
	public string? SystemId { get; set; } = null;

	/// <summary>
	/// The system type for the file system.
	/// </summary>
	[JsonPropertyName("system_type")]
	public string? SystemType { get; set; } = null;

	/// <summary>
	/// The allocated size of the file system - Unit: bytes
	/// </summary>
	[JsonPropertyName("allocated_size")]
	public long? AllocatedSize { get; set; } = null;

	/// <summary>
	/// The data reduction percent for the file system.
	/// </summary>
	[JsonPropertyName("data_reduction_percent")]
	public double? DataReductionPercent { get; set; } = null;

	/// <summary>
	/// The data reduction ratio for the file system.
	/// </summary>
	[JsonPropertyName("data_reduction_ratio")]
	public double? DataReductionRatio { get; set; } = null;

	/// <summary>
	/// The data reduction saved size for the file system - Unit: bytes
	/// </summary>
	[JsonPropertyName("data_reduction_saved_size")]
	public long? DataReductionSavedSize { get; set; } = null;

	/// <summary>
	/// Identifies whether the file system has thin provisioning enabled.
	/// </summary>
	[JsonPropertyName("is_thin_enabled")]
	public bool? IsThinEnabled { get; set; } = null;

	/// <summary>
	/// Number of health issues that are present on the file system.
	/// </summary>
	[JsonPropertyName("issue_count")]
	public long? IssueCount { get; set; } = null;

	/// <summary>
	/// User defined tags.
	/// </summary>
	[JsonPropertyName("tags")]
	public object? Tags { get; set; } = null;

	/// <summary>
	/// Name of the file system.
	/// </summary>
	[JsonPropertyName("object_name")]
	public string? ObjectName { get; set; } = null;

	/// <summary>
	/// The NAS server ID.
	/// </summary>
	[JsonPropertyName("nas_server_id")]
	public string? NasServerId { get; set; } = null;

	/// <summary>
	/// The NAS server name for the file system.
	/// </summary>
	[JsonPropertyName("nas_server_name")]
	public string? NasServerName { get; set; } = null;

	/// <summary>
	/// Identifier of the object, defined by the system.
	/// </summary>
	[JsonPropertyName("object_native_id")]
	public string? ObjectNativeId { get; set; } = null;

	/// <summary>
	/// Type of the object.
	/// </summary>
	[JsonPropertyName("object_type")]
	public string? ObjectType { get; set; } = null;

	/// <summary>
	/// The performance policy name for the file system.
	/// </summary>
	[JsonPropertyName("performance_policy_name")]
	public string? PerformancePolicyName { get; set; } = null;

	/// <summary>
	/// The pool identifier for the file system.
	/// </summary>
	[JsonPropertyName("pool_id")]
	public string? PoolId { get; set; } = null;

	/// <summary>
	/// Name of the pool.
	/// </summary>
	[JsonPropertyName("pool_name")]
	public string? PoolName { get; set; } = null;

	/// <summary>
	/// Type of the pool.
	/// </summary>
	[JsonPropertyName("pool_type")]
	public string? PoolType { get; set; } = null;

	/// <summary>
	/// The protection policy name for the file system.
	/// </summary>
	[JsonPropertyName("protection_policy_name")]
	public string? ProtectionPolicyName { get; set; } = null;

	/// <summary>
	/// The storage resource identifier for the file system.
	/// </summary>
	[JsonPropertyName("storage_resource_id")]
	public string? StorageResourceId { get; set; } = null;

	/// <summary>
	/// The storage resource native identifier for the file system.
	/// </summary>
	[JsonPropertyName("storage_resource_native_id")]
	public string? StorageResourceNativeId { get; set; } = null;

	/// <summary>
	/// The supported protocols for the file system.
	/// </summary>
	[JsonPropertyName("supported_protocols")]
	public string? SupportedProtocols { get; set; } = null;

	/// <summary>
	/// User defined tags.
	/// </summary>
	[JsonPropertyName("system_tags")]
	public object? SystemTags { get; set; } = null;

	/// <summary>
	/// The model of the system for the file system.
	/// </summary>
	[JsonPropertyName("system_model")]
	public string? SystemModel { get; set; } = null;

	/// <summary>
	/// The name of the system.
	/// </summary>
	[JsonPropertyName("system_name")]
	public string? SystemName { get; set; } = null;

	/// <summary>
	/// The time to full prediction for the file system.
	/// </summary>
	[JsonPropertyName("time_to_full_prediction")]
	public string? TimeToFullPrediction { get; set; } = null;

	/// <summary>
	/// The total size of the file system - Unit: bytes
	/// </summary>
	[JsonPropertyName("total_size")]
	public long? TotalSize { get; set; } = null;

	/// <summary>
	/// The type of the file system.
	/// </summary>
	[JsonPropertyName("type")]
	public string? Type { get; set; } = null;

	/// <summary>
	/// Percentage used for the file system.
	/// </summary>
	[JsonPropertyName("used_percent")]
	public double? UsedPercent { get; set; } = null;

	/// <summary>
	/// Size used for the file system - Unit: bytes
	/// </summary>
	[JsonPropertyName("used_size")]
	public long? UsedSize { get; set; } = null;

	private IDictionary<string, object>? _additionalProperties;

	[JsonExtensionData]
	public IDictionary<string, object> AdditionalProperties
	{
		get { return _additionalProperties ??= new Dictionary<string, object>(); }
		set { _additionalProperties = value; }
	}
}
