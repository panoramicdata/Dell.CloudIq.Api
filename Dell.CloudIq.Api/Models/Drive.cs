namespace Dell.CloudIq.Api;

/// <summary>
/// The drive object.
/// </summary>
public partial class Drive
{
	/// <summary>
	/// Identifier of the drive.
	/// </summary>
	[JsonProperty("id", Required = Newtonsoft.Json.Required.Always)]
	[Required(AllowEmptyStrings = true)]
	public string Id { get; set; }

	/// <summary>
	/// Unique identifier for the device or appliance.
	/// </summary>
	[JsonProperty("system_id")]
	public string SystemId { get; set; }

	/// <summary>
	/// System type for the drive.
	/// </summary>
	[JsonProperty("system_type")]
	public string SystemType { get; set; }

	/// <summary>
	/// Object identifier of datastore which is using this drive.
	/// </summary>
	[JsonProperty("data_store_id")]
	public string DataStoreId { get; set; }

	/// <summary>
	/// Name of datastore which is using this drive.
	/// </summary>
	[JsonProperty("data_store_name")]
	public string DataStoreName { get; set; }

	/// <summary>
	/// Type of disk technology, such as HDD or SDD.
	/// </summary>
	[JsonProperty("disk_technology")]
	public string DiskTechnology { get; set; }

	/// <summary>
	/// Type of disk technology, such as HDD or SDD.
	/// </summary>
	[JsonProperty("disk_technology_multilingual")]
	public string DiskTechnologyMultilingual { get; set; }

	/// <summary>
	/// Drive metadata of the drive.
	/// </summary>
	[JsonProperty("drive_metadata")]
	public string DriveMetadata { get; set; }

	/// <summary>
	/// Enclosure number of the drive used in host.
	/// </summary>
	[JsonProperty("enclosure")]
	public long Enclosure { get; set; }

	/// <summary>
	/// Estimated number of days left before drive will reach specified write endurance and must be replaced.
	/// </summary>
	[JsonProperty("endurance_days")]
	public long EnduranceDays { get; set; }

	/// <summary>
	/// Percentage of write endurance left, based on specified maximum write endurance of drive.
	/// </summary>
	[JsonProperty("endurance_percent")]
	public long EndurancePercent { get; set; }

	/// <summary>
	/// Endurance state of the drive.
	/// </summary>
	[JsonProperty("endurance_state")]
	public string EnduranceState { get; set; }

	/// <summary>
	/// Free Size of the drive - Unit: bytes
	/// </summary>
	[JsonProperty("free_size")]
	public long FreeSize { get; set; }

	/// <summary>
	/// Host object identifier of drive located.
	/// </summary>
	[JsonProperty("host_id")]
	public string HostId { get; set; }

	/// <summary>
	/// Host name of drive located.
	/// </summary>
	[JsonProperty("host_name")]
	public string HostName { get; set; }

	/// <summary>
	/// Number of health issues that are present on the drive.
	/// </summary>
	[JsonProperty("issue_count")]
	public long IssueCount { get; set; }

	/// <summary>
	/// Model name of the drive.
	/// </summary>
	[JsonProperty("model")]
	public string Model { get; set; }

	/// <summary>
	/// Name of the drive.
	/// </summary>
	[JsonProperty("object_name")]
	public string ObjectName { get; set; }

	/// <summary>
	/// Identifier of the object, defined by the system.
	/// </summary>
	[JsonProperty("object_native_id")]
	public string ObjectNativeId { get; set; }

	/// <summary>
	/// Type of the drive.
	/// </summary>
	[JsonProperty("object_type")]
	public string ObjectType { get; set; }

	/// <summary>
	/// Part number of the drive.
	/// </summary>
	[JsonProperty("part_number")]
	public string PartNumber { get; set; }

	/// <summary>
	/// Pool identifier.
	/// </summary>
	[JsonProperty("pool_id")]
	public string PoolId { get; set; }

	/// <summary>
	/// Name of the pool.
	/// </summary>
	[JsonProperty("pool_name")]
	public string PoolName { get; set; }

	/// <summary>
	/// Protocol type used by the drive.
	/// </summary>
	[JsonProperty("protocol")]
	public string Protocol { get; set; }

	/// <summary>
	/// RAID group type.
	/// </summary>
	[JsonProperty("raid_group_type")]
	public string RaidGroupType { get; set; }

	/// <summary>
	/// The drive speed (RPM).
	/// </summary>
	[JsonProperty("rpm")]
	public long Rpm { get; set; }

	/// <summary>
	/// Serial number of the drive.
	/// </summary>
	[JsonProperty("serial_number")]
	public string SerialNumber { get; set; }

	/// <summary>
	/// Size of the drive - Unit: bytes
	/// </summary>
	[JsonProperty("size")]
	public long Size { get; set; }

	/// <summary>
	/// Slot number of the drive located in host.
	/// </summary>
	[JsonProperty("slot")]
	public long Slot { get; set; }

	/// <summary>
	/// State of the drive.
	/// </summary>
	[JsonProperty("state")]
	public string State { get; set; }

	/// <summary>
	/// System model of the drive.
	/// </summary>
	[JsonProperty("system_model")]
	public string SystemModel { get; set; }

	/// <summary>
	/// System name of the drive.
	/// </summary>
	[JsonProperty("system_name")]
	public string SystemName { get; set; }

	/// <summary>
	/// Tier type of the drive, such as Flash, Performance, or Capacity.
	/// </summary>
	[JsonProperty("tier_type")]
	public string TierType { get; set; }

	/// <summary>
	/// Used Size of the drive - Unit: bytes
	/// </summary>
	[JsonProperty("used_size")]
	public long UsedSize { get; set; }

	/// <summary>
	/// Vendor of the drive.
	/// </summary>
	[JsonProperty("vendor")]
	public string Vendor { get; set; }

	/// <summary>
	/// Version of the drive.
	/// </summary>
	[JsonProperty("version")]
	public string Version { get; set; }

	private IDictionary<string, object> _additionalProperties;

	[JsonExtensionData]
	public IDictionary<string, object> AdditionalProperties
	{
		get { return _additionalProperties ?? (_additionalProperties = new Dictionary<string, object>()); }
		set { _additionalProperties = value; }
	}
}
