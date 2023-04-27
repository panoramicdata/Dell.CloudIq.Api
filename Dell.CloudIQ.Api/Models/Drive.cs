namespace Dell.CloudIQ.Api;

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
	[JsonProperty("system_id", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public string SystemId { get; set; }

	/// <summary>
	/// DEPRECATED - Unique identifier for the device or appliance.
	/// </summary>
	[JsonProperty("system", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	[System.Obsolete]
	public string System { get; set; }

	/// <summary>
	/// System type for the drive.
	/// </summary>
	[JsonProperty("system_type", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public string SystemType { get; set; }

	/// <summary>
	/// Object identifier of datastore which is using this drive.
	/// </summary>
	[JsonProperty("data_store_id", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public string DataStoreId { get; set; }

	/// <summary>
	/// Name of datastore which is using this drive.
	/// </summary>
	[JsonProperty("data_store_name", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public string DataStoreName { get; set; }

	/// <summary>
	/// Type of disk technology, such as HDD or SDD.
	/// </summary>
	[JsonProperty("disk_technology", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public string DiskTechnology { get; set; }

	/// <summary>
	/// Type of disk technology, such as HDD or SDD.
	/// </summary>
	[JsonProperty("disk_technology_multilingual", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public string DiskTechnologyMultilingual { get; set; }

	/// <summary>
	/// Drive metadata of the drive.
	/// </summary>
	[JsonProperty("drive_metadata", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public string DriveMetadata { get; set; }

	/// <summary>
	/// Enclosure number of the drive used in host.
	/// </summary>
	[JsonProperty("enclosure", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public long Enclosure { get; set; }

	/// <summary>
	/// Estimated number of days left before drive will reach specified write endurance and must be replaced.
	/// </summary>
	[JsonProperty("endurance_days", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public long EnduranceDays { get; set; }

	/// <summary>
	/// Percentage of write endurance left, based on specified maximum write endurance of drive.
	/// </summary>
	[JsonProperty("endurance_percent", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public long EndurancePercent { get; set; }

	/// <summary>
	/// Endurance state of the drive.
	/// </summary>
	[JsonProperty("endurance_state", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public string EnduranceState { get; set; }

	/// <summary>
	/// Free Size of the drive - Unit: bytes
	/// </summary>
	[JsonProperty("free_size", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public long FreeSize { get; set; }

	/// <summary>
	/// Host object identifier of drive located.
	/// </summary>
	[JsonProperty("host_id", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public string HostId { get; set; }

	/// <summary>
	/// Host name of drive located.
	/// </summary>
	[JsonProperty("host_name", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public string HostName { get; set; }

	/// <summary>
	/// Number of health issues that are present on the drive.
	/// </summary>
	[JsonProperty("issue_count", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public long IssueCount { get; set; }

	/// <summary>
	/// Model name of the drive.
	/// </summary>
	[JsonProperty("model", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public string Model { get; set; }

	/// <summary>
	/// Name of the drive.
	/// </summary>
	[JsonProperty("object_name", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public string ObjectName { get; set; }

	/// <summary>
	/// Identifier of the object, defined by the system.
	/// </summary>
	[JsonProperty("object_native_id", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public string ObjectNativeId { get; set; }

	/// <summary>
	/// Type of the drive.
	/// </summary>
	[JsonProperty("object_type", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public string ObjectType { get; set; }

	/// <summary>
	/// Part number of the drive.
	/// </summary>
	[JsonProperty("part_number", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public string PartNumber { get; set; }

	/// <summary>
	/// Pool identifier.
	/// </summary>
	[JsonProperty("pool_id", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public string PoolId { get; set; }

	/// <summary>
	/// Name of the pool.
	/// </summary>
	[JsonProperty("pool_name", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public string PoolName { get; set; }

	/// <summary>
	/// Protocol type used by the drive.
	/// </summary>
	[JsonProperty("protocol", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public string Protocol { get; set; }

	/// <summary>
	/// RAID group type.
	/// </summary>
	[JsonProperty("raid_group_type", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public string RaidGroupType { get; set; }

	/// <summary>
	/// The drive speed (RPM).
	/// </summary>
	[JsonProperty("rpm", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public long Rpm { get; set; }

	/// <summary>
	/// Serial number of the drive.
	/// </summary>
	[JsonProperty("serial_number", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public string SerialNumber { get; set; }

	/// <summary>
	/// Size of the drive - Unit: bytes
	/// </summary>
	[JsonProperty("size", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public long Size { get; set; }

	/// <summary>
	/// Slot number of the drive located in host.
	/// </summary>
	[JsonProperty("slot", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public long Slot { get; set; }

	/// <summary>
	/// State of the drive.
	/// </summary>
	[JsonProperty("state", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public string State { get; set; }

	/// <summary>
	/// System model of the drive.
	/// </summary>
	[JsonProperty("system_model", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public string SystemModel { get; set; }

	/// <summary>
	/// System name of the drive.
	/// </summary>
	[JsonProperty("system_name", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public string SystemName { get; set; }

	/// <summary>
	/// Tier type of the drive, such as Flash, Performance, or Capacity.
	/// </summary>
	[JsonProperty("tier_type", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public string TierType { get; set; }

	/// <summary>
	/// Used Size of the drive - Unit: bytes
	/// </summary>
	[JsonProperty("used_size", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public long UsedSize { get; set; }

	/// <summary>
	/// Vendor of the drive.
	/// </summary>
	[JsonProperty("vendor", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public string Vendor { get; set; }

	/// <summary>
	/// Version of the drive.
	/// </summary>
	[JsonProperty("version", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public string Version { get; set; }

	private IDictionary<string, object> _additionalProperties;

	[JsonExtensionData]
	public IDictionary<string, object> AdditionalProperties
	{
		get { return _additionalProperties ?? (_additionalProperties = new Dictionary<string, object>()); }
		set { _additionalProperties = value; }
	}
}
