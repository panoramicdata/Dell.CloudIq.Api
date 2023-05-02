namespace Dell.CloudIq.Api;

/// <summary>
/// The Vmax StorageGroups.
/// </summary>
public partial class StorageGroup
{
	/// <summary>
	/// The system ID.
	/// </summary>
	[JsonProperty("id", Required = Newtonsoft.Json.Required.Always)]
	[Required(AllowEmptyStrings = true)]
	public string Id { get; set; }

	/// <summary>
	/// Unique identifier for the system.
	/// </summary>
	[JsonProperty("system_id")]
	public string SystemId { get; set; }

	/// <summary>
	/// Type of the system for the storage group.
	/// </summary>
	[JsonProperty("system_type")]
	public string SystemType { get; set; }

	/// <summary>
	/// The Allocated capacity - Unit: bytes
	/// </summary>
	[JsonProperty("allocated_size")]
	public long AllocatedSize { get; set; }

	/// <summary>
	/// Last time when the configuration data has been collected.
	/// </summary>
	[JsonProperty("collection_timestamp")]
	public long CollectionTimestamp { get; set; }

	/// <summary>
	/// The SG compliance.
	/// </summary>
	[JsonProperty("compliance")]
	public string Compliance { get; set; }

	/// <summary>
	/// The Compression ratio for the SG
	/// </summary>
	[JsonProperty("compressionratio")]
	public double Compressionratio { get; set; }

	/// <summary>
	/// The compression percent.
	/// </summary>
	[JsonProperty("compression_saved_percent")]
	public double CompressionSavedPercent { get; set; }

	/// <summary>
	/// PowerMax OS version.
	/// </summary>
	[JsonProperty("current_ucode")]
	public string CurrentUcode { get; set; }

	/// <summary>
	/// Storage group efficiency data reduction ratio.
	/// </summary>
	[JsonProperty("data_reduction_ratio")]
	public double DataReductionRatio { get; set; }

	/// <summary>
	/// Storage group efficiency data reduction state.
	/// </summary>
	[JsonProperty("data_reduction_state")]
	public bool DataReductionState { get; set; }

	/// <summary>
	/// The Array given name.
	/// </summary>
	[JsonProperty("display_name")]
	public string DisplayName { get; set; }

	/// <summary>
	/// Storage group capacity effective used - Unit: bytes
	/// </summary>
	[JsonProperty("effective_used")]
	public long EffectiveUsed { get; set; }

	/// <summary>
	/// The emulation associated with the SG.
	/// </summary>
	[JsonProperty("emulation")]
	public string Emulation { get; set; }

	/// <summary>
	/// The Free subscribe capacity - Unit: bytes
	/// </summary>
	[JsonProperty("free_size")]
	public long FreeSize { get; set; }

	/// <summary>
	/// If the SG has compression enable.
	/// </summary>
	[JsonProperty("is_compression_enabled")]
	public bool IsCompressionEnabled { get; set; }

	/// <summary>
	/// If the SG is SRDF protected.
	/// </summary>
	[JsonProperty("is_srdf_protected")]
	public bool IsSrdfProtected { get; set; }

	/// <summary>
	/// User defined tags.
	/// </summary>
	[JsonProperty("tags")]
	public object Tags { get; set; }

	/// <summary>
	/// Masking Views
	/// </summary>
	[JsonProperty("masking_view_count")]
	public long MaskingViewCount { get; set; }

	/// <summary>
	/// The Array model.
	/// </summary>
	[JsonProperty("model")]
	public string Model { get; set; }

	/// <summary>
	/// Name of the array.
	/// </summary>
	[JsonProperty("object_name")]
	public string ObjectName { get; set; }

	/// <summary>
	/// If its a child is the parent storage group id.
	/// </summary>
	[JsonProperty("parent_storage_group_id")]
	public string ParentStorageGroupId { get; set; }

	/// <summary>
	/// Storage group capacity physical used - Unit: bytes
	/// </summary>
	[JsonProperty("physical_used")]
	public long PhysicalUsed { get; set; }

	/// <summary>
	/// Storage group capacity provisioned - Unit: bytes
	/// </summary>
	[JsonProperty("provisioned")]
	public long Provisioned { get; set; }

	/// <summary>
	/// Array Serial Number.
	/// </summary>
	[JsonProperty("serial_number")]
	public string SerialNumber { get; set; }

	/// <summary>
	/// The service level.
	/// </summary>
	[JsonProperty("service_level_id")]
	public string ServiceLevelId { get; set; }

	/// <summary>
	/// The service level Name.
	/// </summary>
	[JsonProperty("service_level_name")]
	public string ServiceLevelName { get; set; }

	/// <summary>
	/// Storage group efficiency snapshot physical used - Unit: bytes
	/// </summary>
	[JsonProperty("snaphot_physical_used")]
	public long SnaphotPhysicalUsed { get; set; }

	/// <summary>
	/// The total  number of Snapshots associated with the SG.
	/// </summary>
	[JsonProperty("snapshot_count")]
	public long SnapshotCount { get; set; }

	/// <summary>
	/// Storage group efficiency snapshot data reduction ratio.
	/// </summary>
	[JsonProperty("snapshot_drr_ratio")]
	public double SnapshotDrrRatio { get; set; }

	/// <summary>
	/// Storage group efficiency snapshot effective used - Unit: bytes
	/// </summary>
	[JsonProperty("snapshot_effective_used")]
	public long SnapshotEffectiveUsed { get; set; }

	/// <summary>
	/// Storage group efficiency snapshot resources percent.
	/// </summary>
	[JsonProperty("snapshot_resources_percent")]
	public double SnapshotResourcesPercent { get; set; }

	/// <summary>
	/// The Storage Resource Pool Id
	/// </summary>
	[JsonProperty("storage_resource_pool_id")]
	public string StorageResourcePoolId { get; set; }

	/// <summary>
	/// The Storage Resource Pool name
	/// </summary>
	[JsonProperty("storage_resource_pool_name")]
	public string StorageResourcePoolName { get; set; }

	/// <summary>
	/// The total Subscribe capacity - Unit: bytes
	/// </summary>
	[JsonProperty("subscribed_size")]
	public long SubscribedSize { get; set; }

	/// <summary>
	/// User defined tags.
	/// </summary>
	[JsonProperty("system_tags")]
	public object SystemTags { get; set; }

	/// <summary>
	/// The Total capacity - Unit: bytes
	/// </summary>
	[JsonProperty("total_size")]
	public long TotalSize { get; set; }

	/// <summary>
	/// The type of SG (CHILD/PARENT/STANDALONE)
	/// </summary>
	[JsonProperty("type")]
	public string Type { get; set; }

	/// <summary>
	/// Version of Managment Software
	/// </summary>
	[JsonProperty("unisphereversion")]
	public string Unisphereversion { get; set; }

	/// <summary>
	/// Storage group efficiency unreducible data - Unit: bytes
	/// </summary>
	[JsonProperty("unreducible_data")]
	public long UnreducibleData { get; set; }

	/// <summary>
	/// The total  number of Volumes associated with the SG.
	/// </summary>
	[JsonProperty("volume_count")]
	public long VolumeCount { get; set; }

	private IDictionary<string, object> _additionalProperties;

	[JsonExtensionData]
	public IDictionary<string, object> AdditionalProperties
	{
		get { return _additionalProperties ?? (_additionalProperties = new Dictionary<string, object>()); }
		set { _additionalProperties = value; }
	}
}
