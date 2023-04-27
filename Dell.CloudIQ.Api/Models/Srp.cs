namespace Dell.CloudIQ.Api;

/// <summary>
/// The Vmax Storage Resource Pool.
/// </summary>
public partial class Srp
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
	/// DEPRECATED - Unique identifier for the system.
	/// </summary>
	[JsonProperty("system", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	[System.Obsolete]
	public string System { get; set; }

	/// <summary>
	/// The type of the system.
	/// </summary>
	[JsonProperty("system_type", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public string SystemType { get; set; }

	/// <summary>
	/// Percentage of the subscribed capacity.
	/// </summary>
	[JsonProperty("allocated_subscribed_percent", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public double AllocatedSubscribedPercent { get; set; }

	/// <summary>
	/// The used subscribe capacity - Unit: bytes
	/// </summary>
	[JsonProperty("allocated_subscribed_size", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public long AllocatedSubscribedSize { get; set; }

	/// <summary>
	/// SRP capacity for CKD data reduction percent.
	/// </summary>
	[JsonProperty("ckd_data_reduction_data_reducing_percent", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public double CkdDataReductionDataReducingPercent { get; set; }

	/// <summary>
	/// SRP Capacity for CKD data reduction effective used data reduction disabled - Unit: bytes
	/// </summary>
	[JsonProperty("ckd_data_reduction_effective_used_data_reduction_disabled", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public long CkdDataReductionEffectiveUsedDataReductionDisabled { get; set; }

	/// <summary>
	/// SRP capacity for CKD data reduction effective used enabled and reducing - Unit: bytes
	/// </summary>
	[JsonProperty("ckd_data_reduction_effective_used_enabled_and_reducing", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public long CkdDataReductionEffectiveUsedEnabledAndReducing { get; set; }

	/// <summary>
	/// SRP capacity for CKD data reduction effective used enabled and unevaluated - Unit: bytes
	/// </summary>
	[JsonProperty("ckd_data_reduction_effective_used_enabled_and_unevaluated", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public long CkdDataReductionEffectiveUsedEnabledAndUnevaluated { get; set; }

	/// <summary>
	/// SRP capacity for CKD A data reduction effective used enabled and unreducible - Unit: bytes
	/// </summary>
	[JsonProperty("ckd_data_reduction_effective_used_enabled_and_unreducible", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public long CkdDataReductionEffectiveUsedEnabledAndUnreducible { get; set; }

	/// <summary>
	/// SRP capacity for CKD data reduction physical used data reduction disabled - Unit: bytes
	/// </summary>
	[JsonProperty("ckd_data_reduction_physical_used_data_reduction_disabled", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public long CkdDataReductionPhysicalUsedDataReductionDisabled { get; set; }

	/// <summary>
	/// SRP capacity for CKD data reduction physical used enabled and reducing - Unit: bytes
	/// </summary>
	[JsonProperty("ckd_data_reduction_physical_used_enabled_and_reducing", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public long CkdDataReductionPhysicalUsedEnabledAndReducing { get; set; }

	/// <summary>
	/// SRP capacity for CKD data reduction physical used enabled and unevaluated - Unit: bytes
	/// </summary>
	[JsonProperty("ckd_data_reduction_physical_used_enabled_and_unevaluated", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public long CkdDataReductionPhysicalUsedEnabledAndUnevaluated { get; set; }

	/// <summary>
	/// SRP capacity for CKD data reduction physical used enabled and unreducible - Unit: bytes
	/// </summary>
	[JsonProperty("ckd_data_reduction_physical_used_enabled_and_unreducible", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public long CkdDataReductionPhysicalUsedEnabledAndUnreducible { get; set; }

	/// <summary>
	/// SRP capacity for CKD data reduction ratio to one.
	/// </summary>
	[JsonProperty("ckd_data_reduction_ratio_to_one", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public double CkdDataReductionRatioToOne { get; set; }

	/// <summary>
	/// SRP capacity for CKD data reduction savings - Unit: bytes
	/// </summary>
	[JsonProperty("ckd_data_reduction_savings", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public long CkdDataReductionSavings { get; set; }

	/// <summary>
	/// SRP Capacity for CKD effective capacity resources free - Unit: bytes
	/// </summary>
	[JsonProperty("ckd_effective_capacity_resources_free", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public long CkdEffectiveCapacityResourcesFree { get; set; }

	/// <summary>
	/// SRP capacity for CKD effective capacity resources total - Unit: bytes
	/// </summary>
	[JsonProperty("ckd_effective_capacity_resources_total", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public long CkdEffectiveCapacityResourcesTotal { get; set; }

	/// <summary>
	/// SRP capacity for CKD effective capacity resources used - Unit: bytes
	/// </summary>
	[JsonProperty("ckd_effective_capacity_resources_used", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public long CkdEffectiveCapacityResourcesUsed { get; set; }

	/// <summary>
	/// SRP capacity for CKD effective capacity usage free - Unit: bytes
	/// </summary>
	[JsonProperty("ckd_effective_capacity_usage_free", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public long CkdEffectiveCapacityUsageFree { get; set; }

	/// <summary>
	/// SRP capacity for CKD effective capacity usage snapshots used - Unit: bytes
	/// </summary>
	[JsonProperty("ckd_effective_capacity_usage_snapshot_used", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public long CkdEffectiveCapacityUsageSnapshotUsed { get; set; }

	/// <summary>
	/// SRP capacity for CKD effective capacity usage user used - Unit: bytes
	/// </summary>
	[JsonProperty("ckd_effective_capacity_usage_user_used", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public long CkdEffectiveCapacityUsageUserUsed { get; set; }

	/// <summary>
	/// SRP capacity for CKD effective free - Unit: bytes
	/// </summary>
	[JsonProperty("ckd_effective_free", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public long CkdEffectiveFree { get; set; }

	/// <summary>
	/// SRP capacity for CKD effective physical free - Unit: bytes
	/// </summary>
	[JsonProperty("ckd_effective_physical_free", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public long CkdEffectivePhysicalFree { get; set; }

	/// <summary>
	/// SRP capacity for CKD effective physical target - Unit: bytes
	/// </summary>
	[JsonProperty("ckd_effective_physical_target", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public long CkdEffectivePhysicalTarget { get; set; }

	/// <summary>
	/// SRP capacity for CKD effective physical total - Unit: bytes
	/// </summary>
	[JsonProperty("ckd_effective_physical_total", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public long CkdEffectivePhysicalTotal { get; set; }

	/// <summary>
	/// SRP capacity for CKD-FBCKD A effective physical used - Unit: bytes
	/// </summary>
	[JsonProperty("ckd_effective_physical_used", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public long CkdEffectivePhysicalUsed { get; set; }

	/// <summary>
	/// SRP capacity for CKD-FCKD BA effective target - Unit: bytes
	/// </summary>
	[JsonProperty("ckd_effective_target", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public long CkdEffectiveTarget { get; set; }

	/// <summary>
	/// SRP capacity for CKD effective total - Unit: bytes
	/// </summary>
	[JsonProperty("ckd_effective_total", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public long CkdEffectiveTotal { get; set; }

	/// <summary>
	/// SRP capacity for CKD effective used - Unit: bytes
	/// </summary>
	[JsonProperty("ckd_effective_used", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public long CkdEffectiveUsed { get; set; }

	/// <summary>
	/// SRP capacity for CKD effective used percent.
	/// </summary>
	[JsonProperty("ckd_effective_used_percent", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public double CkdEffectiveUsedPercent { get; set; }

	/// <summary>
	/// SRP capacity for CKD provisioned effective - Unit: bytes
	/// </summary>
	[JsonProperty("ckd_provisioned_effective", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public long CkdProvisionedEffective { get; set; }

	/// <summary>
	/// SRP capacity for CKD provisioned percent.
	/// </summary>
	[JsonProperty("ckd_provisioned_provisioned_percent", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public double CkdProvisionedProvisionedPercent { get; set; }

	/// <summary>
	/// SRP capacity for CKD provisioned used - Unit: bytes
	/// </summary>
	[JsonProperty("ckd_provisioned_used", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public long CkdProvisionedUsed { get; set; }

	/// <summary>
	/// SRP capacity for CKD snapshot effective used percent.
	/// </summary>
	[JsonProperty("ckd_snapshot_effective_used_percent", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public double CkdSnapshotEffectiveUsedPercent { get; set; }

	/// <summary>
	/// SRP capacity for CKD snapshot physical used percent.
	/// </summary>
	[JsonProperty("ckd_snapshot_physical_used_percent", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public double CkdSnapshotPhysicalUsedPercent { get; set; }

	/// <summary>
	/// SRP capacity for CKD snapshot resource used - Unit: bytes
	/// </summary>
	[JsonProperty("ckd_snapshot_resource_used", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public long CkdSnapshotResourceUsed { get; set; }

	/// <summary>
	/// Last time when the configuration data has been collected.
	/// </summary>
	[JsonProperty("collection_timestamp", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public long CollectionTimestamp { get; set; }

	/// <summary>
	/// PowerMax OS version.
	/// </summary>
	[JsonProperty("current_ucode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public string CurrentUcode { get; set; }

	/// <summary>
	/// The Data reduction percent.
	/// </summary>
	[JsonProperty("data_reduction_enabled_percent", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public double DataReductionEnabledPercent { get; set; }

	/// <summary>
	/// The Data reduction ratio.
	/// </summary>
	[JsonProperty("data_reduction_savings", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public double DataReductionSavings { get; set; }

	/// <summary>
	/// Identifies if the Storage Resource Pool has compression.
	/// </summary>
	[JsonProperty("data_reduction_state", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public string DataReductionState { get; set; }

	/// <summary>
	/// SRP efficiency deduplication and compression - Unit: bytes
	/// </summary>
	[JsonProperty("deduplication_and_compression_savings", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public long DeduplicationAndCompressionSavings { get; set; }

	/// <summary>
	/// A description of the Storage Resource Pool.
	/// </summary>
	[JsonProperty("description", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public string Description { get; set; }

	/// <summary>
	/// The Array given name.
	/// </summary>
	[JsonProperty("display_name", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public string DisplayName { get; set; }

	/// <summary>
	/// SRP efficiency DDR on reducible.
	/// </summary>
	[JsonProperty("drr_on_reducible_only_to_one", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public double DrrOnReducibleOnlyToOne { get; set; }

	/// <summary>
	/// The Effective Capacity used on the Storage Resource Pool.
	/// </summary>
	[JsonProperty("effective_capacity", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public double EffectiveCapacity { get; set; }

	/// <summary>
	/// SRP capacity for FBA data reducing percent.
	/// </summary>
	[JsonProperty("fba_data_reduction_data_reducing_percent", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public double FbaDataReductionDataReducingPercent { get; set; }

	/// <summary>
	/// SRP capacity for FBA data reduction effective used data reduction disabled - Unit: bytes
	/// </summary>
	[JsonProperty("fba_data_reduction_effective_used_data_reduction_disabled", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public long FbaDataReductionEffectiveUsedDataReductionDisabled { get; set; }

	/// <summary>
	/// SRP capacity for FBA data reduction effective used enabled and reducing - Unit: bytes
	/// </summary>
	[JsonProperty("fba_data_reduction_effective_used_enabled_and_reducing", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public long FbaDataReductionEffectiveUsedEnabledAndReducing { get; set; }

	/// <summary>
	/// SRP capacity for FBA data reduction effective used enabled and unevaluated - Unit: bytes
	/// </summary>
	[JsonProperty("fba_data_reduction_effective_used_enabled_and_unevaluated", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public long FbaDataReductionEffectiveUsedEnabledAndUnevaluated { get; set; }

	/// <summary>
	/// SRP capacity for FBA data reduction effective used enabled and unreducible - Unit: bytes
	/// </summary>
	[JsonProperty("fba_data_reduction_effective_used_enabled_and_unreducible", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public long FbaDataReductionEffectiveUsedEnabledAndUnreducible { get; set; }

	/// <summary>
	/// SRP Capacity for FBA data reduction physical used data reduction disabled - Unit: bytes
	/// </summary>
	[JsonProperty("fba_data_reduction_physical_used_data_reduction_disabled", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public long FbaDataReductionPhysicalUsedDataReductionDisabled { get; set; }

	/// <summary>
	/// SRP capacity for FBA data reduction physical used enabled and reducing - Unit: bytes
	/// </summary>
	[JsonProperty("fba_data_reduction_physical_used_enabled_and_reducing", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public long FbaDataReductionPhysicalUsedEnabledAndReducing { get; set; }

	/// <summary>
	/// SRP capacity for FBA data reduction physical used enabled and unevaluated - Unit: bytes
	/// </summary>
	[JsonProperty("fba_data_reduction_physical_used_enabled_and_unevaluated", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public long FbaDataReductionPhysicalUsedEnabledAndUnevaluated { get; set; }

	/// <summary>
	/// SRP capacity for FBA data reduction physical used enabled and unreducible - Unit: bytes
	/// </summary>
	[JsonProperty("fba_data_reduction_physical_used_enabled_and_unreducible", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public long FbaDataReductionPhysicalUsedEnabledAndUnreducible { get; set; }

	/// <summary>
	/// SRP capacity for FBA data reduction ratio to one.
	/// </summary>
	[JsonProperty("fba_data_reduction_ratio_to_one", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public double FbaDataReductionRatioToOne { get; set; }

	/// <summary>
	/// SRP capacity for FBA data reduction savings - Unit: bytes
	/// </summary>
	[JsonProperty("fba_data_reduction_savings", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public long FbaDataReductionSavings { get; set; }

	/// <summary>
	/// SRP capacity for FBA effective capacity resources free - Unit: bytes
	/// </summary>
	[JsonProperty("fba_effective_capacity_resources_free", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public long FbaEffectiveCapacityResourcesFree { get; set; }

	/// <summary>
	/// SRP capacity for FBA effective capacity resources total - Unit: bytes
	/// </summary>
	[JsonProperty("fba_effective_capacity_resources_total", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public long FbaEffectiveCapacityResourcesTotal { get; set; }

	/// <summary>
	/// SRP capacity for FBA effective capacity resources used - Unit: bytes
	/// </summary>
	[JsonProperty("fba_effective_capacity_resources_used", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public long FbaEffectiveCapacityResourcesUsed { get; set; }

	/// <summary>
	/// SRP capacity for FBA effective capacity usage free - Unit: bytes
	/// </summary>
	[JsonProperty("fba_effective_capacity_usage_free", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public long FbaEffectiveCapacityUsageFree { get; set; }

	/// <summary>
	/// SRP capacity for FBA effective capacity usage snapshots used - Unit: bytes
	/// </summary>
	[JsonProperty("fba_effective_capacity_usage_snapshot_used", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public long FbaEffectiveCapacityUsageSnapshotUsed { get; set; }

	/// <summary>
	/// SRP capacity for FBA effective capacity usage user used - Unit: bytes
	/// </summary>
	[JsonProperty("fba_effective_capacity_usage_user_used", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public long FbaEffectiveCapacityUsageUserUsed { get; set; }

	/// <summary>
	/// SRP capacity for FBA effective free - Unit: bytes
	/// </summary>
	[JsonProperty("fba_effective_free", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public long FbaEffectiveFree { get; set; }

	/// <summary>
	/// SRP capacity for FBA effective physical free - Unit: bytes
	/// </summary>
	[JsonProperty("fba_effective_physical_free", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public long FbaEffectivePhysicalFree { get; set; }

	/// <summary>
	/// SRP capacity for FBA effective physical target - Unit: bytes
	/// </summary>
	[JsonProperty("fba_effective_physical_target", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public long FbaEffectivePhysicalTarget { get; set; }

	/// <summary>
	/// SRP capacity for FBA effective physical total - Unit: bytes
	/// </summary>
	[JsonProperty("fba_effective_physical_total", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public long FbaEffectivePhysicalTotal { get; set; }

	/// <summary>
	/// SRP capacity for FBA effective physical used - Unit: bytes
	/// </summary>
	[JsonProperty("fba_effective_physical_used", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public long FbaEffectivePhysicalUsed { get; set; }

	/// <summary>
	/// SRP capacity for FBA effective target - Unit: bytes
	/// </summary>
	[JsonProperty("fba_effective_target", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public long FbaEffectiveTarget { get; set; }

	/// <summary>
	/// SRP capacity for FBA effective total - Unit: bytes
	/// </summary>
	[JsonProperty("fba_effective_total", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public long FbaEffectiveTotal { get; set; }

	/// <summary>
	/// SRP capacity for FBA effective used - Unit: bytes
	/// </summary>
	[JsonProperty("fba_effective_used", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public long FbaEffectiveUsed { get; set; }

	/// <summary>
	/// SRP capacity for FBA effective used percent.
	/// </summary>
	[JsonProperty("fba_effective_used_percent", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public double FbaEffectiveUsedPercent { get; set; }

	/// <summary>
	/// SRP capacity for FBA provisioned effective - Unit: bytes
	/// </summary>
	[JsonProperty("fba_provisioned_effective", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public long FbaProvisionedEffective { get; set; }

	/// <summary>
	/// SRP capacity for FBA provisioned percent.
	/// </summary>
	[JsonProperty("fba_provisioned_provisioned_percent", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public double FbaProvisionedProvisionedPercent { get; set; }

	/// <summary>
	/// SRP capacity for FBA provisioned used - Unit: bytes
	/// </summary>
	[JsonProperty("fba_provisioned_used", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public long FbaProvisionedUsed { get; set; }

	/// <summary>
	/// SRP capacity for FBA snapshot effective used percent.
	/// </summary>
	[JsonProperty("fba_snapshot_effective_used_percent", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public double FbaSnapshotEffectiveUsedPercent { get; set; }

	/// <summary>
	/// SRP capacity for FBA snapshot physical used percent.
	/// </summary>
	[JsonProperty("fba_snapshot_physical_used_percent", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public double FbaSnapshotPhysicalUsedPercent { get; set; }

	/// <summary>
	/// SRP capacity for FBA snapshot resource used - Unit: bytes
	/// </summary>
	[JsonProperty("fba_snapshot_resource_used", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public long FbaSnapshotResourceUsed { get; set; }

	/// <summary>
	/// The free Snapshot capacity - Unit: bytes
	/// </summary>
	[JsonProperty("free_snapshot_size", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public long FreeSnapshotSize { get; set; }

	/// <summary>
	/// The free subscribe capacity - Unit: bytes
	/// </summary>
	[JsonProperty("free_subscribed_size", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public long FreeSubscribedSize { get; set; }

	/// <summary>
	/// The free physical capacity - Unit: bytes
	/// </summary>
	[JsonProperty("free_usable_size", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public long FreeUsableSize { get; set; }

	/// <summary>
	/// Does this DRP have CKD Capacity Data?
	/// </summary>
	[JsonProperty("has_ckd_capacity", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public bool HasCkdCapacity { get; set; }

	/// <summary>
	/// Does this DRP have FBA Capacity Data?
	/// </summary>
	[JsonProperty("has_fba_capacity", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public bool HasFbaCapacity { get; set; }

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
	/// The overall efficiency.
	/// </summary>
	[JsonProperty("overall_efficiency", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public double OverallEfficiency { get; set; }

	/// <summary>
	/// SRP efficiency pattern detection - Unit: bytes
	/// </summary>
	[JsonProperty("pattern_detection_savings", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public long PatternDetectionSavings { get; set; }

	/// <summary>
	/// SRP efficiency reducible data - Unit: bytes
	/// </summary>
	[JsonProperty("reducible_data", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public long ReducibleData { get; set; }

	/// <summary>
	/// Percentage of Data Reduction.
	/// </summary>
	[JsonProperty("reserved_capacity_percent", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public double ReservedCapacityPercent { get; set; }

	/// <summary>
	/// Array Serial Number.
	/// </summary>
	[JsonProperty("serial_number", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public string SerialNumber { get; set; }

	/// <summary>
	/// The snapshot savings
	/// </summary>
	[JsonProperty("snapshot_savings", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public double SnapshotSavings { get; set; }

	/// <summary>
	/// The thin savings.
	/// </summary>
	[JsonProperty("thin_savings", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public double ThinSavings { get; set; }

	/// <summary>
	/// The total Snapshot capacity - Unit: bytes
	/// </summary>
	[JsonProperty("total_snapshot_size", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public long TotalSnapshotSize { get; set; }

	/// <summary>
	/// The total subscribe capacity - Unit: bytes
	/// </summary>
	[JsonProperty("total_subscribed_size", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public long TotalSubscribedSize { get; set; }

	/// <summary>
	/// The total physical capacity - Unit: bytes
	/// </summary>
	[JsonProperty("total_usable_size", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public long TotalUsableSize { get; set; }

	/// <summary>
	/// Software Management Version.
	/// </summary>
	[JsonProperty("unisphereversion", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public string Unisphereversion { get; set; }

	/// <summary>
	/// SRP efficiency unreduicible data - Unit: bytes
	/// </summary>
	[JsonProperty("unreducible_data", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public long UnreducibleData { get; set; }

	/// <summary>
	/// Percentage of the subscribed capacity.
	/// </summary>
	[JsonProperty("used_snapshot_percent", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public double UsedSnapshotPercent { get; set; }

	/// <summary>
	/// The used Snapshot capacity - Unit: bytes
	/// </summary>
	[JsonProperty("used_snapshot_size", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public long UsedSnapshotSize { get; set; }

	/// <summary>
	/// The used percentage of physical capacity.
	/// </summary>
	[JsonProperty("used_usable_percent", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public double UsedUsablePercent { get; set; }

	/// <summary>
	/// The used physical capacity - Unit: bytes
	/// </summary>
	[JsonProperty("used_usable_size", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public long UsedUsableSize { get; set; }

	private IDictionary<string, object> _additionalProperties;

	[JsonExtensionData]
	public IDictionary<string, object> AdditionalProperties
	{
		get { return _additionalProperties ?? (_additionalProperties = new Dictionary<string, object>()); }
		set { _additionalProperties = value; }
	}
}
