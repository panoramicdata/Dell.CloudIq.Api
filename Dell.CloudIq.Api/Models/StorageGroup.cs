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
	[JsonProperty("system_id", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public string SystemId { get; set; }

	/// <summary>
	/// Type of the system for the storage group.
	/// </summary>
	[JsonProperty("system_type", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public string SystemType { get; set; }

	/// <summary>
	/// The Allocated capacity - Unit: bytes
	/// </summary>
	[JsonProperty("allocated_size", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public long AllocatedSize { get; set; }

	/// <summary>
	/// Last time when the configuration data has been collected.
	/// </summary>
	[JsonProperty("collection_timestamp", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public long CollectionTimestamp { get; set; }

	/// <summary>
	/// The SG compliance.
	/// </summary>
	[JsonProperty("compliance", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public string Compliance { get; set; }

	/// <summary>
	/// The Compression ratio for the SG
	/// </summary>
	[JsonProperty("compressionratio", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public double Compressionratio { get; set; }

	/// <summary>
	/// The compression percent.
	/// </summary>
	[JsonProperty("compression_saved_percent", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public double CompressionSavedPercent { get; set; }

	/// <summary>
	/// PowerMax OS version.
	/// </summary>
	[JsonProperty("current_ucode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public string CurrentUcode { get; set; }

	/// <summary>
	/// Storage group efficiency data reduction ratio.
	/// </summary>
	[JsonProperty("data_reduction_ratio", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public double DataReductionRatio { get; set; }

	/// <summary>
	/// Storage group efficiency data reduction state.
	/// </summary>
	[JsonProperty("data_reduction_state", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public bool DataReductionState { get; set; }

	/// <summary>
	/// The Array given name.
	/// </summary>
	[JsonProperty("display_name", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public string DisplayName { get; set; }

	/// <summary>
	/// Storage group capacity effective used - Unit: bytes
	/// </summary>
	[JsonProperty("effective_used", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public long EffectiveUsed { get; set; }

	/// <summary>
	/// The emulation associated with the SG.
	/// </summary>
	[JsonProperty("emulation", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public string Emulation { get; set; }

	/// <summary>
	/// The Free subscribe capacity - Unit: bytes
	/// </summary>
	[JsonProperty("free_size", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public long FreeSize { get; set; }

	/// <summary>
	/// If the SG has compression enable.
	/// </summary>
	[JsonProperty("is_compression_enabled", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public bool IsCompressionEnabled { get; set; }

	/// <summary>
	/// If the SG is SRDF protected.
	/// </summary>
	[JsonProperty("is_srdf_protected", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public bool IsSrdfProtected { get; set; }

	/// <summary>
	/// User defined tags.
	/// </summary>
	[JsonProperty("tags", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public object Tags { get; set; }

	/// <summary>
	/// Masking Views
	/// </summary>
	[JsonProperty("masking_view_count", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public long MaskingViewCount { get; set; }

	/// <summary>
	/// The Array model.
	/// </summary>
	[JsonProperty("model", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public string Model { get; set; }

	/// <summary>
	/// Name of the array.
	/// </summary>
	[JsonProperty("object_name", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public string ObjectName { get; set; }

	/// <summary>
	/// If its a child is the parent storage group id.
	/// </summary>
	[JsonProperty("parent_storage_group_id", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public string ParentStorageGroupId { get; set; }

	/// <summary>
	/// Storage group capacity physical used - Unit: bytes
	/// </summary>
	[JsonProperty("physical_used", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public long PhysicalUsed { get; set; }

	/// <summary>
	/// Storage group capacity provisioned - Unit: bytes
	/// </summary>
	[JsonProperty("provisioned", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public long Provisioned { get; set; }

	/// <summary>
	/// Array Serial Number.
	/// </summary>
	[JsonProperty("serial_number", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public string SerialNumber { get; set; }

	/// <summary>
	/// The service level.
	/// </summary>
	[JsonProperty("service_level_id", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public string ServiceLevelId { get; set; }

	/// <summary>
	/// The service level Name.
	/// </summary>
	[JsonProperty("service_level_name", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public string ServiceLevelName { get; set; }

	/// <summary>
	/// Storage group efficiency snapshot physical used - Unit: bytes
	/// </summary>
	[JsonProperty("snaphot_physical_used", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public long SnaphotPhysicalUsed { get; set; }

	/// <summary>
	/// The total  number of Snapshots associated with the SG.
	/// </summary>
	[JsonProperty("snapshot_count", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public long SnapshotCount { get; set; }

	/// <summary>
	/// Storage group efficiency snapshot data reduction ratio.
	/// </summary>
	[JsonProperty("snapshot_drr_ratio", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public double SnapshotDrrRatio { get; set; }

	/// <summary>
	/// Storage group efficiency snapshot effective used - Unit: bytes
	/// </summary>
	[JsonProperty("snapshot_effective_used", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public long SnapshotEffectiveUsed { get; set; }

	/// <summary>
	/// Storage group efficiency snapshot resources percent.
	/// </summary>
	[JsonProperty("snapshot_resources_percent", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public double SnapshotResourcesPercent { get; set; }

	/// <summary>
	/// The Storage Resource Pool Id
	/// </summary>
	[JsonProperty("storage_resource_pool_id", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public string StorageResourcePoolId { get; set; }

	/// <summary>
	/// The Storage Resource Pool name
	/// </summary>
	[JsonProperty("storage_resource_pool_name", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public string StorageResourcePoolName { get; set; }

	/// <summary>
	/// The total Subscribe capacity - Unit: bytes
	/// </summary>
	[JsonProperty("subscribed_size", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public long SubscribedSize { get; set; }

	/// <summary>
	/// User defined tags.
	/// </summary>
	[JsonProperty("system_tags", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public object SystemTags { get; set; }

	/// <summary>
	/// The Total capacity - Unit: bytes
	/// </summary>
	[JsonProperty("total_size", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public long TotalSize { get; set; }

	/// <summary>
	/// The type of SG (CHILD/PARENT/STANDALONE)
	/// </summary>
	[JsonProperty("type", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public string Type { get; set; }

	/// <summary>
	/// Version of Managment Software
	/// </summary>
	[JsonProperty("unisphereversion", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public string Unisphereversion { get; set; }

	/// <summary>
	/// Storage group efficiency unreducible data - Unit: bytes
	/// </summary>
	[JsonProperty("unreducible_data", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public long UnreducibleData { get; set; }

	/// <summary>
	/// The total  number of Volumes associated with the SG.
	/// </summary>
	[JsonProperty("volume_count", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public long VolumeCount { get; set; }

	private IDictionary<string, object> _additionalProperties;

	[JsonExtensionData]
	public IDictionary<string, object> AdditionalProperties
	{
		get { return _additionalProperties ?? (_additionalProperties = new Dictionary<string, object>()); }
		set { _additionalProperties = value; }
	}
}
