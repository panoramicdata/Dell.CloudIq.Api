namespace Dell.CloudIq.Api;

/// <summary>
/// Firmware information of the system. This includes the version of firmware on the system.
/// </summary>
public partial class Firmware
{
	/// <summary>
	/// Identifier of the data firmware system.
	/// </summary>
	[JsonProperty("id", Required = Newtonsoft.Json.Required.Always)]
	[Required(AllowEmptyStrings = true)]
	public string Id { get; set; }

	/// <summary>
	/// System for which firmware information is for.
	/// </summary>
	[JsonProperty("system_id")]
	public string SystemId { get; set; }

	/// <summary>
	/// Type of system for which firmware information is for.
	/// </summary>
	[JsonProperty("system_type")]
	public string SystemType { get; set; }

	/// <summary>
	/// Aisle Location of the system associated with the Firmware.
	/// </summary>
	[JsonProperty("aisle_location")]
	public string AisleLocation { get; set; }

	/// <summary>
	/// BaseLine firmware Version or the latest firmware version of the component for the system.
	/// </summary>
	[JsonProperty("baseline_version")]
	public string BaselineVersion { get; set; }

	/// <summary>
	/// Compliance Message whether upgrade needed is urgent, recommended or optional.
	/// </summary>
	[JsonProperty("compliance_message")]
	public string ComplianceMessage { get; set; }

	/// <summary>
	/// Data center Location of the system associated with the Firmware
	/// </summary>
	[JsonProperty("datacenter_location")]
	public string DatacenterLocation { get; set; }

	/// <summary>
	/// Detailed name of the firmware.
	/// </summary>
	[JsonProperty("details")]
	public string Details { get; set; }

	/// <summary>
	/// Description of the firmware associated with Component Id.
	/// </summary>
	[JsonProperty("device_description")]
	public string DeviceDescription { get; set; }

	/// <summary>
	/// Date when the firmware was installed.
	/// </summary>
	[JsonProperty("installation_date")]
	public long InstallationDate { get; set; }

	/// <summary>
	/// Firmware system IP Address.
	/// </summary>
	[JsonProperty("ip_address")]
	public string IpAddress { get; set; }

	/// <summary>
	/// IPv4 Address of the system associated with the firmware information.
	/// </summary>
	[JsonProperty("ipv4_address")]
	public string Ipv4Address { get; set; }

	/// <summary>
	/// IPv6 Address of the system associated with the firmware information.
	/// </summary>
	[JsonProperty("ipv6_address")]
	public string Ipv6Address { get; set; }

	/// <summary>
	/// Firmware Location.
	/// </summary>
	[JsonProperty("location")]
	public string Location { get; set; }

	/// <summary>
	/// Rack Location of the system associated with the Firmware.
	/// </summary>
	[JsonProperty("rack_location")]
	public string RackLocation { get; set; }

	/// <summary>
	/// Room Location of the system associated with the Firmware
	/// </summary>
	[JsonProperty("room_location")]
	public string RoomLocation { get; set; }

	/// <summary>
	/// Service tag of the system.
	/// </summary>
	[JsonProperty("service_tag")]
	public string ServiceTag { get; set; }

	/// <summary>
	/// Slot Location of the system associated with the Firmware.
	/// </summary>
	[JsonProperty("slot_location")]
	public string SlotLocation { get; set; }

	/// <summary>
	/// Type of the software ex. BIOS, firmware, driver.
	/// </summary>
	[JsonProperty("software_type")]
	public string SoftwareType { get; set; }

	/// <summary>
	/// Identifies the specific model of the server.
	/// </summary>
	[JsonProperty("system_model")]
	public string SystemModel { get; set; }

	/// <summary>
	/// System Name of the system associated with the Firmware.
	/// </summary>
	[JsonProperty("system_name")]
	public string SystemName { get; set; }

	/// <summary>
	/// Version of firmware.
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
