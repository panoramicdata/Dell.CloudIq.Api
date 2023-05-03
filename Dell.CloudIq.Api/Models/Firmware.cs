namespace Dell.CloudIq.Api;

/// <summary>
/// Firmware information of the system. This includes the version of firmware on the system.
/// </summary>
public partial class Firmware
{
	/// <summary>
	/// Identifier of the data firmware system.
	/// </summary>
	[JsonPropertyName("id")]

	public string? Id { get; set; } = null;

	/// <summary>
	/// System for which firmware information is for.
	/// </summary>
	[JsonPropertyName("system_id")]
	public string? SystemId { get; set; } = null;

	/// <summary>
	/// Type of system for which firmware information is for.
	/// </summary>
	[JsonPropertyName("system_type")]
	public string? SystemType { get; set; } = null;

	/// <summary>
	/// Aisle Location of the system associated with the Firmware.
	/// </summary>
	[JsonPropertyName("aisle_location")]
	public string? AisleLocation { get; set; } = null;

	/// <summary>
	/// BaseLine firmware Version or the latest firmware version of the component for the system.
	/// </summary>
	[JsonPropertyName("baseline_version")]
	public string? BaselineVersion { get; set; } = null;

	/// <summary>
	/// Compliance Message whether upgrade needed is urgent, recommended or optional.
	/// </summary>
	[JsonPropertyName("compliance_message")]
	public string? ComplianceMessage { get; set; } = null;

	/// <summary>
	/// Data center Location of the system associated with the Firmware
	/// </summary>
	[JsonPropertyName("datacenter_location")]
	public string? DatacenterLocation { get; set; } = null;

	/// <summary>
	/// Detailed name of the firmware.
	/// </summary>
	[JsonPropertyName("details")]
	public string? Details { get; set; } = null;

	/// <summary>
	/// Description of the firmware associated with Component Id.
	/// </summary>
	[JsonPropertyName("device_description")]
	public string? DeviceDescription { get; set; } = null;

	/// <summary>
	/// Date when the firmware was installed.
	/// </summary>
	[JsonPropertyName("installation_date")]
	public long? InstallationDate { get; set; } = null;

	/// <summary>
	/// Firmware system IP Address.
	/// </summary>
	[JsonPropertyName("ip_address")]
	public string? IpAddress { get; set; } = null;

	/// <summary>
	/// IPv4 Address of the system associated with the firmware information.
	/// </summary>
	[JsonPropertyName("ipv4_address")]
	public string? Ipv4Address { get; set; } = null;

	/// <summary>
	/// IPv6 Address of the system associated with the firmware information.
	/// </summary>
	[JsonPropertyName("ipv6_address")]
	public string? Ipv6Address { get; set; } = null;

	/// <summary>
	/// Firmware Location.
	/// </summary>
	[JsonPropertyName("location")]
	public string? Location { get; set; } = null;

	/// <summary>
	/// Rack Location of the system associated with the Firmware.
	/// </summary>
	[JsonPropertyName("rack_location")]
	public string? RackLocation { get; set; } = null;

	/// <summary>
	/// Room Location of the system associated with the Firmware
	/// </summary>
	[JsonPropertyName("room_location")]
	public string? RoomLocation { get; set; } = null;

	/// <summary>
	/// Service tag of the system.
	/// </summary>
	[JsonPropertyName("service_tag")]
	public string? ServiceTag { get; set; } = null;

	/// <summary>
	/// Slot Location of the system associated with the Firmware.
	/// </summary>
	[JsonPropertyName("slot_location")]
	public string? SlotLocation { get; set; } = null;

	/// <summary>
	/// Type of the software ex. BIOS, firmware, driver.
	/// </summary>
	[JsonPropertyName("software_type")]
	public string? SoftwareType { get; set; } = null;

	/// <summary>
	/// Identifies the specific model of the server.
	/// </summary>
	[JsonPropertyName("system_model")]
	public string? SystemModel { get; set; } = null;

	/// <summary>
	/// System Name of the system associated with the Firmware.
	/// </summary>
	[JsonPropertyName("system_name")]
	public string? SystemName { get; set; } = null;

	/// <summary>
	/// Version of firmware.
	/// </summary>
	[JsonPropertyName("version")]
	public string? Version { get; set; } = null;

	private IDictionary<string, object> _additionalProperties;

	[JsonExtensionData]
	public IDictionary<string, object> AdditionalProperties
	{
		get { return _additionalProperties ?? (_additionalProperties = new Dictionary<string, object>()); }
		set { _additionalProperties = value; }
	}
}
