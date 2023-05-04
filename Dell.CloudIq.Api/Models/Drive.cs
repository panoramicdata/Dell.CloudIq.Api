namespace Dell.CloudIq.Api;

/// <summary>
/// The drive object.
/// </summary>
public partial class Drive
{
	/// <summary>
	/// Identifier of the drive.
	/// </summary>
	[JsonPropertyName("id")]

	public string Id { get; set; } = string.Empty;

	/// <summary>
	/// Unique identifier for the device or appliance.
	/// </summary>
	[JsonPropertyName("system_id")]
	public string? SystemId { get; set; }

	/// <summary>
	/// System type for the drive.
	/// </summary>
	[JsonPropertyName("system_type")]
	public string? SystemType { get; set; }

	/// <summary>
	/// Object identifier of datastore which is using this drive.
	/// </summary>
	[JsonPropertyName("data_store_id")]
	public string? DataStoreId { get; set; }

	/// <summary>
	/// Name of datastore which is using this drive.
	/// </summary>
	[JsonPropertyName("data_store_name")]
	public string? DataStoreName { get; set; }

	/// <summary>
	/// Type of disk technology, such as HDD or SDD.
	/// </summary>
	[JsonPropertyName("disk_technology")]
	public string? DiskTechnology { get; set; }

	/// <summary>
	/// Type of disk technology, such as HDD or SDD.
	/// </summary>
	[JsonPropertyName("disk_technology_multilingual")]
	public string? DiskTechnologyMultilingual { get; set; }

	/// <summary>
	/// Drive metadata of the drive.
	/// </summary>
	[JsonPropertyName("drive_metadata")]
	public string? DriveMetadata { get; set; }

	/// <summary>
	/// Enclosure number of the drive used in host.
	/// </summary>
	[JsonPropertyName("enclosure")]
	public long? Enclosure { get; set; }

	/// <summary>
	/// Estimated number of days left before drive will reach specified write endurance and must be replaced.
	/// </summary>
	[JsonPropertyName("endurance_days")]
	public long? EnduranceDays { get; set; }

	/// <summary>
	/// Percentage of write endurance left, based on specified maximum write endurance of drive.
	/// </summary>
	[JsonPropertyName("endurance_percent")]
	public long? EndurancePercent { get; set; }

	/// <summary>
	/// Endurance state of the drive.
	/// </summary>
	[JsonPropertyName("endurance_state")]
	public string? EnduranceState { get; set; }

	/// <summary>
	/// Free Size of the drive - Unit: bytes
	/// </summary>
	[JsonPropertyName("free_size")]
	public long? FreeSize { get; set; }

	/// <summary>
	/// Host object identifier of drive located.
	/// </summary>
	[JsonPropertyName("host_id")]
	public string? HostId { get; set; }

	/// <summary>
	/// Host name of drive located.
	/// </summary>
	[JsonPropertyName("host_name")]
	public string? HostName { get; set; }

	/// <summary>
	/// Number of health issues that are present on the drive.
	/// </summary>
	[JsonPropertyName("issue_count")]
	public long? IssueCount { get; set; }

	/// <summary>
	/// Model name of the drive.
	/// </summary>
	[JsonPropertyName("model")]
	public string? Model { get; set; }

	/// <summary>
	/// Name of the drive.
	/// </summary>
	[JsonPropertyName("object_name")]
	public string? ObjectName { get; set; }

	/// <summary>
	/// Identifier of the object, defined by the system.
	/// </summary>
	[JsonPropertyName("object_native_id")]
	public string? ObjectNativeId { get; set; }

	/// <summary>
	/// Type of the drive.
	/// </summary>
	[JsonPropertyName("object_type")]
	public string? ObjectType { get; set; }

	/// <summary>
	/// Part number of the drive.
	/// </summary>
	[JsonPropertyName("part_number")]
	public string? PartNumber { get; set; }

	/// <summary>
	/// Pool identifier.
	/// </summary>
	[JsonPropertyName("pool_id")]
	public string? PoolId { get; set; }

	/// <summary>
	/// Name of the pool.
	/// </summary>
	[JsonPropertyName("pool_name")]
	public string? PoolName { get; set; }

	/// <summary>
	/// Protocol type used by the drive.
	/// </summary>
	[JsonPropertyName("protocol")]
	public string? Protocol { get; set; }

	/// <summary>
	/// RAID group type.
	/// </summary>
	[JsonPropertyName("raid_group_type")]
	public string? RaidGroupType { get; set; }

	/// <summary>
	/// The drive speed (RPM).
	/// </summary>
	[JsonPropertyName("rpm")]
	public long? Rpm { get; set; }

	/// <summary>
	/// Serial number of the drive.
	/// </summary>
	[JsonPropertyName("serial_number")]
	public string? SerialNumber { get; set; }

	/// <summary>
	/// Size of the drive - Unit: bytes
	/// </summary>
	[JsonPropertyName("size")]
	public long? Size { get; set; }

	/// <summary>
	/// Slot number of the drive located in host.
	/// </summary>
	[JsonPropertyName("slot")]
	public long? Slot { get; set; }

	/// <summary>
	/// State of the drive.
	/// </summary>
	[JsonPropertyName("state")]
	public string? State { get; set; }

	/// <summary>
	/// System model of the drive.
	/// </summary>
	[JsonPropertyName("system_model")]
	public string? SystemModel { get; set; }

	/// <summary>
	/// System name of the drive.
	/// </summary>
	[JsonPropertyName("system_name")]
	public string? SystemName { get; set; }

	/// <summary>
	/// Tier type of the drive, such as Flash, Performance, or Capacity.
	/// </summary>
	[JsonPropertyName("tier_type")]
	public string? TierType { get; set; }

	/// <summary>
	/// Used Size of the drive - Unit: bytes
	/// </summary>
	[JsonPropertyName("used_size")]
	public long? UsedSize { get; set; }

	/// <summary>
	/// Vendor of the drive.
	/// </summary>
	[JsonPropertyName("vendor")]
	public string? Vendor { get; set; }

	/// <summary>
	/// Version of the drive.
	/// </summary>
	[JsonPropertyName("version")]
	public string? Version { get; set; }

	private IDictionary<string, object>? _additionalProperties;

	[JsonExtensionData]
	public IDictionary<string, object> AdditionalProperties
	{
		get { return _additionalProperties ??= new Dictionary<string, object>(); }
		set { _additionalProperties = value; }
	}
}
