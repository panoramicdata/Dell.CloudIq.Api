namespace Dell.CloudIq.Api;

/// <summary>
/// The server system object.
/// </summary>
public class ServerSystem : CloudIqSystemBase
{
	/// <summary>
	/// Location of the aisle where the device or appliance can be found.
	/// </summary>
	[JsonPropertyName("aisle_location")]
	public string? AisleLocation { get; set; }

	/// <summary>
	/// Asset tag of the device or appliance.
	/// </summary>
	[JsonPropertyName("asset_tag")]
	public string? AssetTag { get; set; }

	/// <summary>
	/// Version of the BIOS.
	/// </summary>
	[JsonPropertyName("bios_version")]
	public string? BiosVersion { get; set; }

	/// <summary>
	/// Name of the Multi Chassis Management group
	/// </summary>
	[JsonPropertyName("chassis_group")]
	public string? ChassisGroup { get; set; }

	/// <summary>
	/// Comma separated ids of OMEs sending data for a system.
	/// </summary>
	[JsonPropertyName("collected_by")]
	public string? CollectedBy { get; set; }

	/// <summary>
	/// OME which collects the system data.
	/// </summary>
	[JsonPropertyName("compute_manager_id")]
	public string? ComputeManagerId { get; set; }

	/// <summary>
	/// Percentage of CPU usage.
	/// </summary>
	[JsonPropertyName("cpu_usage_percent")]
	public long? CpuUsagePercent { get; set; }

	/// <summary>
	/// Location of the datacenter where the device or appliance can be found.
	/// </summary>
	[JsonPropertyName("datacenter_location")]
	public string? DatacenterLocation { get; set; }

	/// <summary>
	/// Type of Server, whether server or chassis.
	/// </summary>
	[JsonPropertyName("device_type")]
	public string? DeviceType { get; set; }

	/// <summary>
	/// Numeric version of Service Tag to use for telephone call routing when contacting Support.
	/// </summary>
	[JsonPropertyName("express_service_code")]
	public string? ExpressServiceCode { get; set; }

	/// <summary>
	/// The Management Controller DNS Name. MC for Chassis is Management Module (MM), the MC for PowerEdge is iDRAC.
	/// </summary>
	[JsonPropertyName("idrac_dns_name")]
	public string? IdracDnsName { get; set; }

	/// <summary>
	/// Inlet temperature of a system.
	/// </summary>
	[JsonPropertyName("inlet_temperature")]
	public long? InletTemperature { get; set; }

	/// <summary>
	/// Service Tag of the lead chassis in the Multi Chassis Management group
	/// </summary>
	[JsonPropertyName("lead_chassis_service_tag")]
	public string? LeadChassisServiceTag { get; set; }

	/// <summary>
	/// The license associated with the system.
	/// </summary>
	[JsonPropertyName("license")]
	public string? License { get; set; }

	/// <summary>
	/// Percentage of memory usage for the system.
	/// </summary>
	[JsonPropertyName("memory_usage_percent")]
	public long? MemoryUsagePercent { get; set; }

	/// <summary>
	/// Power consumed by the system.
	/// </summary>
	[JsonPropertyName("power_consumption")]
	public long? PowerConsumption { get; set; }

	/// <summary>
	/// This identifies if server is Powered On or Powered Off.
	/// </summary>
	[JsonPropertyName("power_state")]
	public string? PowerState { get; set; }

	/// <summary>
	/// Location of the rack where the device or appliance can be found.
	/// </summary>
	[JsonPropertyName("rack_location")]
	public string? RackLocation { get; set; }

	/// <summary>
	/// Role of the chassis in the Multi Chassis Management group.
	/// </summary>
	[JsonPropertyName("role")]
	public string? Role { get; set; }

	/// <summary>
	/// Location of the room where the device or appliance can be found.
	/// </summary>
	[JsonPropertyName("room_location")]
	public string? RoomLocation { get; set; }

	/// <summary>
	/// Service tag of the system.
	/// </summary>
	[JsonPropertyName("service_tag")]
	public string? ServiceTag { get; set; }

	/// <summary>
	/// Location of the slot where the device or appliance can be found.
	/// </summary>
	[JsonPropertyName("slot_location")]
	public string? SlotLocation { get; set; }

	/// <summary>
	/// Percentage of I/O usage of the system board.
	/// </summary>
	[JsonPropertyName("system_board_io_usage_percent")]
	public long? SystemBoardIoUsagePercent { get; set; }

	/// <summary>
	/// Percentage of system use.
	/// </summary>
	[JsonPropertyName("system_usage_percent")]
	public long? SystemUsagePercent { get; set; }
}
