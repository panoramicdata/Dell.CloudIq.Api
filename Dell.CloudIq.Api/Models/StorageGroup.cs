namespace Dell.CloudIq.Api;

/// <summary>
/// The Vmax StorageGroups.
/// </summary>
public partial class StorageGroup
{
	/// <summary>
	/// The system ID.
	/// </summary>
	[JsonPropertyName("id")]
	
	public string Id { get; set; }

	/// <summary>
	/// Unique identifier for the system.
	/// </summary>
	[JsonPropertyName("system_id")]
	public string SystemId { get; set; }

	/// <summary>
	/// Type of the system for the storage group.
	/// </summary>
	[JsonPropertyName("system_type")]
	public string SystemType { get; set; }

	/// <summary>
	/// The Allocated capacity - Unit: bytes
	/// </summary>
	[JsonPropertyName("allocated_size")]
	public long AllocatedSize { get; set; }

	/// <summary>
	/// Last time when the configuration data has been collected.
	/// </summary>
	[JsonPropertyName("collection_timestamp")]
	public long CollectionTimestamp { get; set; }

	/// <summary>
	/// The SG compliance.
	/// </summary>
	[JsonPropertyName("compliance")]
	public string Compliance { get; set; }

	/// <summary>
	/// The Compression ratio for the SG
	/// </summary>
	[JsonPropertyName("compressionratio")]
	public double Compressionratio { get; set; }

	/// <summary>
	/// The compression percent.
	/// </summary>
	[JsonPropertyName("compression_saved_percent")]
	public double CompressionSavedPercent { get; set; }

	/// <summary>
	/// PowerMax OS version.
	/// </summary>
	[JsonPropertyName("current_ucode")]
	public string CurrentUcode { get; set; }

	/// <summary>
	/// Storage group efficiency data reduction ratio.
	/// </summary>
	[JsonPropertyName("data_reduction_ratio")]
	public double DataReductionRatio { get; set; }

	/// <summary>
	/// Storage group efficiency data reduction state.
	/// </summary>
	[JsonPropertyName("data_reduction_state")]
	public bool DataReductionState { get; set; }

	/// <summary>
	/// The Array given name.
	/// </summary>
	[JsonPropertyName("display_name")]
	public string DisplayName { get; set; }

	/// <summary>
	/// Storage group capacity effective used - Unit: bytes
	/// </summary>
	[JsonPropertyName("effective_used")]
	public long EffectiveUsed { get; set; }

	/// <summary>
	/// The emulation associated with the SG.
	/// </summary>
	[JsonPropertyName("emulation")]
	public string Emulation { get; set; }

	/// <summary>
	/// The Free subscribe capacity - Unit: bytes
	/// </summary>
	[JsonPropertyName("free_size")]
	public long FreeSize { get; set; }

	/// <summary>
	/// If the SG has compression enable.
	/// </summary>
	[JsonPropertyName("is_compression_enabled")]
	public bool IsCompressionEnabled { get; set; }

	/// <summary>
	/// If the SG is SRDF protected.
	/// </summary>
	[JsonPropertyName("is_srdf_protected")]
	public bool IsSrdfProtected { get; set; }

	/// <summary>
	/// User defined tags.
	/// </summary>
	[JsonPropertyName("tags")]
	public object Tags { get; set; }

	/// <summary>
	/// Masking Views
	/// </summary>
	[JsonPropertyName("masking_view_count")]
	public long MaskingViewCount { get; set; }

	/// <summary>
	/// The Array model.
	/// </summary>
	[JsonPropertyName("model")]
	public string Model { get; set; }

	/// <summary>
	/// Name of the array.
	/// </summary>
	[JsonPropertyName("object_name")]
	public string ObjectName { get; set; }

	/// <summary>
	/// If its a child is the parent storage group id.
	/// </summary>
	[JsonPropertyName("parent_storage_group_id")]
	public string ParentStorageGroupId { get; set; }

	/// <summary>
	/// Storage group capacity physical used - Unit: bytes
	/// </summary>
	[JsonPropertyName("physical_used")]
	public long PhysicalUsed { get; set; }

	/// <summary>
	/// Storage group capacity provisioned - Unit: bytes
	/// </summary>
	[JsonPropertyName("provisioned")]
	public long Provisioned { get; set; }

	/// <summary>
	/// Array Serial Number.
	/// </summary>
	[JsonPropertyName("serial_number")]
	public string SerialNumber { get; set; }

	/// <summary>
	/// The service level.
	/// </summary>
	[JsonPropertyName("service_level_id")]
	public string ServiceLevelId { get; set; }

	/// <summary>
	/// The service level Name.
	/// </summary>
	[JsonPropertyName("service_level_name")]
	public string ServiceLevelName { get; set; }

	/// <summary>
	/// Storage group efficiency snapshot physical used - Unit: bytes
	/// </summary>
	[JsonPropertyName("snaphot_physical_used")]
	public long SnaphotPhysicalUsed { get; set; }

	/// <summary>
	/// The total  number of Snapshots associated with the SG.
	/// </summary>
	[JsonPropertyName("snapshot_count")]
	public long SnapshotCount { get; set; }

	/// <summary>
	/// Storage group efficiency snapshot data reduction ratio.
	/// </summary>
	[JsonPropertyName("snapshot_drr_ratio")]
	public double SnapshotDrrRatio { get; set; }

	/// <summary>
	/// Storage group efficiency snapshot effective used - Unit: bytes
	/// </summary>
	[JsonPropertyName("snapshot_effective_used")]
	public long SnapshotEffectiveUsed { get; set; }

	/// <summary>
	/// Storage group efficiency snapshot resources percent.
	/// </summary>
	[JsonPropertyName("snapshot_resources_percent")]
	public double SnapshotResourcesPercent { get; set; }

	/// <summary>
	/// The Storage Resource Pool Id
	/// </summary>
	[JsonPropertyName("storage_resource_pool_id")]
	public string StorageResourcePoolId { get; set; }

	/// <summary>
	/// The Storage Resource Pool name
	/// </summary>
	[JsonPropertyName("storage_resource_pool_name")]
	public string StorageResourcePoolName { get; set; }

	/// <summary>
	/// The total Subscribe capacity - Unit: bytes
	/// </summary>
	[JsonPropertyName("subscribed_size")]
	public long SubscribedSize { get; set; }

	/// <summary>
	/// User defined tags.
	/// </summary>
	[JsonPropertyName("system_tags")]
	public object SystemTags { get; set; }

	/// <summary>
	/// The Total capacity - Unit: bytes
	/// </summary>
	[JsonPropertyName("total_size")]
	public long TotalSize { get; set; }

	/// <summary>
	/// The type of SG (CHILD/PARENT/STANDALONE)
	/// </summary>
	[JsonPropertyName("type")]
	public string Type { get; set; }

	/// <summary>
	/// Version of Managment Software
	/// </summary>
	[JsonPropertyName("unisphereversion")]
	public string Unisphereversion { get; set; }

	/// <summary>
	/// Storage group efficiency unreducible data - Unit: bytes
	/// </summary>
	[JsonPropertyName("unreducible_data")]
	public long UnreducibleData { get; set; }

	/// <summary>
	/// The total  number of Volumes associated with the SG.
	/// </summary>
	[JsonPropertyName("volume_count")]
	public long VolumeCount { get; set; }

	private IDictionary<string, object> _additionalProperties;

	[JsonExtensionData]
	public IDictionary<string, object> AdditionalProperties
	{
		get { return _additionalProperties ?? (_additionalProperties = new Dictionary<string, object>()); }
		set { _additionalProperties = value; }
	}
}
