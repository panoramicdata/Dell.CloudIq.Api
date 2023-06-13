namespace Dell.CloudIq.Api;

/// <summary>
/// The Vmax Storage Resource Pool.
/// </summary>
public class Srp
{
	/// <summary>
	/// The system ID.
	/// </summary>
	[JsonPropertyName("id")]

	public string Id { get; set; } = string.Empty;

	/// <summary>
	/// Unique identifier for the system.
	/// </summary>
	[JsonPropertyName("system_id")]
	public string? SystemId { get; set; }

	/// <summary>
	/// The type of the system.
	/// </summary>
	[JsonPropertyName("system_type")]
	public string? SystemType { get; set; }

	/// <summary>
	/// Percentage of the subscribed capacity.
	/// </summary>
	[JsonPropertyName("allocated_subscribed_percent")]
	public double? AllocatedSubscribedPercent { get; set; }

	/// <summary>
	/// The used subscribe capacity - Unit: bytes
	/// </summary>
	[JsonPropertyName("allocated_subscribed_size")]
	public long? AllocatedSubscribedSize { get; set; }

	/// <summary>
	/// SRP capacity for CKD data reduction percent.
	/// </summary>
	[JsonPropertyName("ckd_data_reduction_data_reducing_percent")]
	public double? CkdDataReductionDataReducingPercent { get; set; }

	/// <summary>
	/// SRP Capacity for CKD data reduction effective used data reduction disabled - Unit: bytes
	/// </summary>
	[JsonPropertyName("ckd_data_reduction_effective_used_data_reduction_disabled")]
	public long? CkdDataReductionEffectiveUsedDataReductionDisabled { get; set; }

	/// <summary>
	/// SRP capacity for CKD data reduction effective used enabled and reducing - Unit: bytes
	/// </summary>
	[JsonPropertyName("ckd_data_reduction_effective_used_enabled_and_reducing")]
	public long? CkdDataReductionEffectiveUsedEnabledAndReducing { get; set; }

	/// <summary>
	/// SRP capacity for CKD data reduction effective used enabled and unevaluated - Unit: bytes
	/// </summary>
	[JsonPropertyName("ckd_data_reduction_effective_used_enabled_and_unevaluated")]
	public long? CkdDataReductionEffectiveUsedEnabledAndUnevaluated { get; set; }

	/// <summary>
	/// SRP capacity for CKD A data reduction effective used enabled and unreducible - Unit: bytes
	/// </summary>
	[JsonPropertyName("ckd_data_reduction_effective_used_enabled_and_unreducible")]
	public long? CkdDataReductionEffectiveUsedEnabledAndUnreducible { get; set; }

	/// <summary>
	/// SRP capacity for CKD data reduction physical used data reduction disabled - Unit: bytes
	/// </summary>
	[JsonPropertyName("ckd_data_reduction_physical_used_data_reduction_disabled")]
	public long? CkdDataReductionPhysicalUsedDataReductionDisabled { get; set; }

	/// <summary>
	/// SRP capacity for CKD data reduction physical used enabled and reducing - Unit: bytes
	/// </summary>
	[JsonPropertyName("ckd_data_reduction_physical_used_enabled_and_reducing")]
	public long? CkdDataReductionPhysicalUsedEnabledAndReducing { get; set; }

	/// <summary>
	/// SRP capacity for CKD data reduction physical used enabled and unevaluated - Unit: bytes
	/// </summary>
	[JsonPropertyName("ckd_data_reduction_physical_used_enabled_and_unevaluated")]
	public long? CkdDataReductionPhysicalUsedEnabledAndUnevaluated { get; set; }

	/// <summary>
	/// SRP capacity for CKD data reduction physical used enabled and unreducible - Unit: bytes
	/// </summary>
	[JsonPropertyName("ckd_data_reduction_physical_used_enabled_and_unreducible")]
	public long? CkdDataReductionPhysicalUsedEnabledAndUnreducible { get; set; }

	/// <summary>
	/// SRP capacity for CKD data reduction ratio to one.
	/// </summary>
	[JsonPropertyName("ckd_data_reduction_ratio_to_one")]
	public double? CkdDataReductionRatioToOne { get; set; }

	/// <summary>
	/// SRP capacity for CKD data reduction savings - Unit: bytes
	/// </summary>
	[JsonPropertyName("ckd_data_reduction_savings")]
	public long? CkdDataReductionSavings { get; set; }

	/// <summary>
	/// SRP Capacity for CKD effective capacity resources free - Unit: bytes
	/// </summary>
	[JsonPropertyName("ckd_effective_capacity_resources_free")]
	public long? CkdEffectiveCapacityResourcesFree { get; set; }

	/// <summary>
	/// SRP capacity for CKD effective capacity resources total - Unit: bytes
	/// </summary>
	[JsonPropertyName("ckd_effective_capacity_resources_total")]
	public long? CkdEffectiveCapacityResourcesTotal { get; set; }

	/// <summary>
	/// SRP capacity for CKD effective capacity resources used - Unit: bytes
	/// </summary>
	[JsonPropertyName("ckd_effective_capacity_resources_used")]
	public long? CkdEffectiveCapacityResourcesUsed { get; set; }

	/// <summary>
	/// SRP capacity for CKD effective capacity usage free - Unit: bytes
	/// </summary>
	[JsonPropertyName("ckd_effective_capacity_usage_free")]
	public long? CkdEffectiveCapacityUsageFree { get; set; }

	/// <summary>
	/// SRP capacity for CKD effective capacity usage snapshots used - Unit: bytes
	/// </summary>
	[JsonPropertyName("ckd_effective_capacity_usage_snapshot_used")]
	public long? CkdEffectiveCapacityUsageSnapshotUsed { get; set; }

	/// <summary>
	/// SRP capacity for CKD effective capacity usage user used - Unit: bytes
	/// </summary>
	[JsonPropertyName("ckd_effective_capacity_usage_user_used")]
	public long? CkdEffectiveCapacityUsageUserUsed { get; set; }

	/// <summary>
	/// SRP capacity for CKD effective free - Unit: bytes
	/// </summary>
	[JsonPropertyName("ckd_effective_free")]
	public long? CkdEffectiveFree { get; set; }

	/// <summary>
	/// SRP capacity for CKD effective physical free - Unit: bytes
	/// </summary>
	[JsonPropertyName("ckd_effective_physical_free")]
	public long? CkdEffectivePhysicalFree { get; set; }

	/// <summary>
	/// SRP capacity for CKD effective physical target - Unit: bytes
	/// </summary>
	[JsonPropertyName("ckd_effective_physical_target")]
	public long? CkdEffectivePhysicalTarget { get; set; }

	/// <summary>
	/// SRP capacity for CKD effective physical total - Unit: bytes
	/// </summary>
	[JsonPropertyName("ckd_effective_physical_total")]
	public long? CkdEffectivePhysicalTotal { get; set; }

	/// <summary>
	/// SRP capacity for CKD-FBCKD A effective physical used - Unit: bytes
	/// </summary>
	[JsonPropertyName("ckd_effective_physical_used")]
	public long? CkdEffectivePhysicalUsed { get; set; }

	/// <summary>
	/// SRP capacity for CKD-FCKD BA effective target - Unit: bytes
	/// </summary>
	[JsonPropertyName("ckd_effective_target")]
	public long? CkdEffectiveTarget { get; set; }

	/// <summary>
	/// SRP capacity for CKD effective total - Unit: bytes
	/// </summary>
	[JsonPropertyName("ckd_effective_total")]
	public long? CkdEffectiveTotal { get; set; }

	/// <summary>
	/// SRP capacity for CKD effective used - Unit: bytes
	/// </summary>
	[JsonPropertyName("ckd_effective_used")]
	public long? CkdEffectiveUsed { get; set; }

	/// <summary>
	/// SRP capacity for CKD effective used percent.
	/// </summary>
	[JsonPropertyName("ckd_effective_used_percent")]
	public double? CkdEffectiveUsedPercent { get; set; }

	/// <summary>
	/// SRP capacity for CKD provisioned effective - Unit: bytes
	/// </summary>
	[JsonPropertyName("ckd_provisioned_effective")]
	public long? CkdProvisionedEffective { get; set; }

	/// <summary>
	/// SRP capacity for CKD provisioned percent.
	/// </summary>
	[JsonPropertyName("ckd_provisioned_provisioned_percent")]
	public double? CkdProvisionedProvisionedPercent { get; set; }

	/// <summary>
	/// SRP capacity for CKD provisioned used - Unit: bytes
	/// </summary>
	[JsonPropertyName("ckd_provisioned_used")]
	public long? CkdProvisionedUsed { get; set; }

	/// <summary>
	/// SRP capacity for CKD snapshot effective used percent.
	/// </summary>
	[JsonPropertyName("ckd_snapshot_effective_used_percent")]
	public double? CkdSnapshotEffectiveUsedPercent { get; set; }

	/// <summary>
	/// SRP capacity for CKD snapshot physical used percent.
	/// </summary>
	[JsonPropertyName("ckd_snapshot_physical_used_percent")]
	public double? CkdSnapshotPhysicalUsedPercent { get; set; }

	/// <summary>
	/// SRP capacity for CKD snapshot resource used - Unit: bytes
	/// </summary>
	[JsonPropertyName("ckd_snapshot_resource_used")]
	public long? CkdSnapshotResourceUsed { get; set; }

	/// <summary>
	/// Last time when the configuration data has been collected.
	/// </summary>
	[JsonPropertyName("collection_timestamp")]
	public long? CollectionTimestamp { get; set; }

	/// <summary>
	/// PowerMax OS version.
	/// </summary>
	[JsonPropertyName("current_ucode")]
	public string? CurrentUcode { get; set; }

	/// <summary>
	/// The Data reduction percent.
	/// </summary>
	[JsonPropertyName("data_reduction_enabled_percent")]
	public double? DataReductionEnabledPercent { get; set; }

	/// <summary>
	/// The Data reduction ratio.
	/// </summary>
	[JsonPropertyName("data_reduction_savings")]
	public double? DataReductionSavings { get; set; }

	/// <summary>
	/// Identifies if the Storage Resource Pool has compression.
	/// </summary>
	[JsonPropertyName("data_reduction_state")]
	public string? DataReductionState { get; set; }

	/// <summary>
	/// SRP efficiency deduplication and compression - Unit: bytes
	/// </summary>
	[JsonPropertyName("deduplication_and_compression_savings")]
	public long? DeduplicationAndCompressionSavings { get; set; }

	/// <summary>
	/// A description of the Storage Resource Pool.
	/// </summary>
	[JsonPropertyName("description")]
	public string? Description { get; set; }

	/// <summary>
	/// The Array given name.
	/// </summary>
	[JsonPropertyName("display_name")]
	public string? DisplayName { get; set; }

	/// <summary>
	/// SRP efficiency DDR on reducible.
	/// </summary>
	[JsonPropertyName("drr_on_reducible_only_to_one")]
	public double? DrrOnReducibleOnlyToOne { get; set; }

	/// <summary>
	/// The Effective Capacity used on the Storage Resource Pool.
	/// </summary>
	[JsonPropertyName("effective_capacity")]
	public double? EffectiveCapacity { get; set; }

	/// <summary>
	/// SRP capacity for FBA data reducing percent.
	/// </summary>
	[JsonPropertyName("fba_data_reduction_data_reducing_percent")]
	public double? FbaDataReductionDataReducingPercent { get; set; }

	/// <summary>
	/// SRP capacity for FBA data reduction effective used data reduction disabled - Unit: bytes
	/// </summary>
	[JsonPropertyName("fba_data_reduction_effective_used_data_reduction_disabled")]
	public long? FbaDataReductionEffectiveUsedDataReductionDisabled { get; set; }

	/// <summary>
	/// SRP capacity for FBA data reduction effective used enabled and reducing - Unit: bytes
	/// </summary>
	[JsonPropertyName("fba_data_reduction_effective_used_enabled_and_reducing")]
	public long? FbaDataReductionEffectiveUsedEnabledAndReducing { get; set; }

	/// <summary>
	/// SRP capacity for FBA data reduction effective used enabled and unevaluated - Unit: bytes
	/// </summary>
	[JsonPropertyName("fba_data_reduction_effective_used_enabled_and_unevaluated")]
	public long? FbaDataReductionEffectiveUsedEnabledAndUnevaluated { get; set; }

	/// <summary>
	/// SRP capacity for FBA data reduction effective used enabled and unreducible - Unit: bytes
	/// </summary>
	[JsonPropertyName("fba_data_reduction_effective_used_enabled_and_unreducible")]
	public long? FbaDataReductionEffectiveUsedEnabledAndUnreducible { get; set; }

	/// <summary>
	/// SRP Capacity for FBA data reduction physical used data reduction disabled - Unit: bytes
	/// </summary>
	[JsonPropertyName("fba_data_reduction_physical_used_data_reduction_disabled")]
	public long? FbaDataReductionPhysicalUsedDataReductionDisabled { get; set; }

	/// <summary>
	/// SRP capacity for FBA data reduction physical used enabled and reducing - Unit: bytes
	/// </summary>
	[JsonPropertyName("fba_data_reduction_physical_used_enabled_and_reducing")]
	public long? FbaDataReductionPhysicalUsedEnabledAndReducing { get; set; }

	/// <summary>
	/// SRP capacity for FBA data reduction physical used enabled and unevaluated - Unit: bytes
	/// </summary>
	[JsonPropertyName("fba_data_reduction_physical_used_enabled_and_unevaluated")]
	public long? FbaDataReductionPhysicalUsedEnabledAndUnevaluated { get; set; }

	/// <summary>
	/// SRP capacity for FBA data reduction physical used enabled and unreducible - Unit: bytes
	/// </summary>
	[JsonPropertyName("fba_data_reduction_physical_used_enabled_and_unreducible")]
	public long? FbaDataReductionPhysicalUsedEnabledAndUnreducible { get; set; }

	/// <summary>
	/// SRP capacity for FBA data reduction ratio to one.
	/// </summary>
	[JsonPropertyName("fba_data_reduction_ratio_to_one")]
	public double? FbaDataReductionRatioToOne { get; set; }

	/// <summary>
	/// SRP capacity for FBA data reduction savings - Unit: bytes
	/// </summary>
	[JsonPropertyName("fba_data_reduction_savings")]
	public long? FbaDataReductionSavings { get; set; }

	/// <summary>
	/// SRP capacity for FBA effective capacity resources free - Unit: bytes
	/// </summary>
	[JsonPropertyName("fba_effective_capacity_resources_free")]
	public long? FbaEffectiveCapacityResourcesFree { get; set; }

	/// <summary>
	/// SRP capacity for FBA effective capacity resources total - Unit: bytes
	/// </summary>
	[JsonPropertyName("fba_effective_capacity_resources_total")]
	public long? FbaEffectiveCapacityResourcesTotal { get; set; }

	/// <summary>
	/// SRP capacity for FBA effective capacity resources used - Unit: bytes
	/// </summary>
	[JsonPropertyName("fba_effective_capacity_resources_used")]
	public long? FbaEffectiveCapacityResourcesUsed { get; set; }

	/// <summary>
	/// SRP capacity for FBA effective capacity usage free - Unit: bytes
	/// </summary>
	[JsonPropertyName("fba_effective_capacity_usage_free")]
	public long? FbaEffectiveCapacityUsageFree { get; set; }

	/// <summary>
	/// SRP capacity for FBA effective capacity usage snapshots used - Unit: bytes
	/// </summary>
	[JsonPropertyName("fba_effective_capacity_usage_snapshot_used")]
	public long? FbaEffectiveCapacityUsageSnapshotUsed { get; set; }

	/// <summary>
	/// SRP capacity for FBA effective capacity usage user used - Unit: bytes
	/// </summary>
	[JsonPropertyName("fba_effective_capacity_usage_user_used")]
	public long? FbaEffectiveCapacityUsageUserUsed { get; set; }

	/// <summary>
	/// SRP capacity for FBA effective free - Unit: bytes
	/// </summary>
	[JsonPropertyName("fba_effective_free")]
	public long? FbaEffectiveFree { get; set; }

	/// <summary>
	/// SRP capacity for FBA effective physical free - Unit: bytes
	/// </summary>
	[JsonPropertyName("fba_effective_physical_free")]
	public long? FbaEffectivePhysicalFree { get; set; }

	/// <summary>
	/// SRP capacity for FBA effective physical target - Unit: bytes
	/// </summary>
	[JsonPropertyName("fba_effective_physical_target")]
	public long? FbaEffectivePhysicalTarget { get; set; }

	/// <summary>
	/// SRP capacity for FBA effective physical total - Unit: bytes
	/// </summary>
	[JsonPropertyName("fba_effective_physical_total")]
	public long? FbaEffectivePhysicalTotal { get; set; }

	/// <summary>
	/// SRP capacity for FBA effective physical used - Unit: bytes
	/// </summary>
	[JsonPropertyName("fba_effective_physical_used")]
	public long? FbaEffectivePhysicalUsed { get; set; }

	/// <summary>
	/// SRP capacity for FBA effective target - Unit: bytes
	/// </summary>
	[JsonPropertyName("fba_effective_target")]
	public long? FbaEffectiveTarget { get; set; }

	/// <summary>
	/// SRP capacity for FBA effective total - Unit: bytes
	/// </summary>
	[JsonPropertyName("fba_effective_total")]
	public long? FbaEffectiveTotal { get; set; }

	/// <summary>
	/// SRP capacity for FBA effective used - Unit: bytes
	/// </summary>
	[JsonPropertyName("fba_effective_used")]
	public long? FbaEffectiveUsed { get; set; }

	/// <summary>
	/// SRP capacity for FBA effective used percent.
	/// </summary>
	[JsonPropertyName("fba_effective_used_percent")]
	public double? FbaEffectiveUsedPercent { get; set; }

	/// <summary>
	/// SRP capacity for FBA provisioned effective - Unit: bytes
	/// </summary>
	[JsonPropertyName("fba_provisioned_effective")]
	public long? FbaProvisionedEffective { get; set; }

	/// <summary>
	/// SRP capacity for FBA provisioned percent.
	/// </summary>
	[JsonPropertyName("fba_provisioned_provisioned_percent")]
	public double? FbaProvisionedProvisionedPercent { get; set; }

	/// <summary>
	/// SRP capacity for FBA provisioned used - Unit: bytes
	/// </summary>
	[JsonPropertyName("fba_provisioned_used")]
	public long? FbaProvisionedUsed { get; set; }

	/// <summary>
	/// SRP capacity for FBA snapshot effective used percent.
	/// </summary>
	[JsonPropertyName("fba_snapshot_effective_used_percent")]
	public double? FbaSnapshotEffectiveUsedPercent { get; set; }

	/// <summary>
	/// SRP capacity for FBA snapshot physical used percent.
	/// </summary>
	[JsonPropertyName("fba_snapshot_physical_used_percent")]
	public double? FbaSnapshotPhysicalUsedPercent { get; set; }

	/// <summary>
	/// SRP capacity for FBA snapshot resource used - Unit: bytes
	/// </summary>
	[JsonPropertyName("fba_snapshot_resource_used")]
	public long? FbaSnapshotResourceUsed { get; set; }

	/// <summary>
	/// The free Snapshot capacity - Unit: bytes
	/// </summary>
	[JsonPropertyName("free_snapshot_size")]
	public long? FreeSnapshotSize { get; set; }

	/// <summary>
	/// The free subscribe capacity - Unit: bytes
	/// </summary>
	[JsonPropertyName("free_subscribed_size")]
	public long? FreeSubscribedSize { get; set; }

	/// <summary>
	/// The free physical capacity - Unit: bytes
	/// </summary>
	[JsonPropertyName("free_usable_size")]
	public long? FreeUsableSize { get; set; }

	/// <summary>
	/// Does this DRP have CKD Capacity Data?
	/// </summary>
	[JsonPropertyName("has_ckd_capacity")]
	public bool? HasCkdCapacity { get; set; }

	/// <summary>
	/// Does this DRP have FBA Capacity Data?
	/// </summary>
	[JsonPropertyName("has_fba_capacity")]
	public bool? HasFbaCapacity { get; set; }

	/// <summary>
	/// The Array model.
	/// </summary>
	[JsonPropertyName("model")]
	public string? Model { get; set; }

	/// <summary>
	/// Name of the array.
	/// </summary>
	[JsonPropertyName("object_name")]
	public string? ObjectName { get; set; }

	/// <summary>
	/// The overall efficiency.
	/// </summary>
	[JsonPropertyName("overall_efficiency")]
	public double? OverallEfficiency { get; set; }

	/// <summary>
	/// SRP efficiency pattern detection - Unit: bytes
	/// </summary>
	[JsonPropertyName("pattern_detection_savings")]
	public long? PatternDetectionSavings { get; set; }

	/// <summary>
	/// SRP efficiency reducible data - Unit: bytes
	/// </summary>
	[JsonPropertyName("reducible_data")]
	public long? ReducibleData { get; set; }

	/// <summary>
	/// Percentage of Data Reduction.
	/// </summary>
	[JsonPropertyName("reserved_capacity_percent")]
	public double? ReservedCapacityPercent { get; set; }

	/// <summary>
	/// Array Serial Number.
	/// </summary>
	[JsonPropertyName("serial_number")]
	public string? SerialNumber { get; set; }

	/// <summary>
	/// The snapshot savings
	/// </summary>
	[JsonPropertyName("snapshot_savings")]
	public double? SnapshotSavings { get; set; }

	/// <summary>
	/// The thin savings.
	/// </summary>
	[JsonPropertyName("thin_savings")]
	public double? ThinSavings { get; set; }

	/// <summary>
	/// The total Snapshot capacity - Unit: bytes
	/// </summary>
	[JsonPropertyName("total_snapshot_size")]
	public long? TotalSnapshotSize { get; set; }

	/// <summary>
	/// The total subscribe capacity - Unit: bytes
	/// </summary>
	[JsonPropertyName("total_subscribed_size")]
	public long? TotalSubscribedSize { get; set; }

	/// <summary>
	/// The total physical capacity - Unit: bytes
	/// </summary>
	[JsonPropertyName("total_usable_size")]
	public long? TotalUsableSize { get; set; }

	/// <summary>
	/// Software Management Version.
	/// </summary>
	[JsonPropertyName("unisphereversion")]
	public string? Unisphereversion { get; set; }

	/// <summary>
	/// SRP efficiency unreduicible data - Unit: bytes
	/// </summary>
	[JsonPropertyName("unreducible_data")]
	public long? UnreducibleData { get; set; }

	/// <summary>
	/// Percentage of the subscribed capacity.
	/// </summary>
	[JsonPropertyName("used_snapshot_percent")]
	public double? UsedSnapshotPercent { get; set; }

	/// <summary>
	/// The used Snapshot capacity - Unit: bytes
	/// </summary>
	[JsonPropertyName("used_snapshot_size")]
	public long? UsedSnapshotSize { get; set; }

	/// <summary>
	/// The used percentage of physical capacity.
	/// </summary>
	[JsonPropertyName("used_usable_percent")]
	public double? UsedUsablePercent { get; set; }

	/// <summary>
	/// The used physical capacity - Unit: bytes
	/// </summary>
	[JsonPropertyName("used_usable_size")]
	public long? UsedUsableSize { get; set; }

	private IDictionary<string, object>? _additionalProperties;

	[JsonExtensionData]
	public IDictionary<string, object> AdditionalProperties
	{
		get { return _additionalProperties ??= new Dictionary<string, object>(); }
		set { _additionalProperties = value; }
	}
}
