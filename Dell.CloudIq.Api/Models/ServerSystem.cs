namespace Dell.CloudIq.Api;

/// <summary>
/// The server system object.
/// </summary>
public partial class ServerSystem
{
	/// <summary>
	/// Identifier for the system.
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
	/// Type of the system.
	/// </summary>
	[JsonProperty("system_type")]
	public string SystemType { get; set; }

	/// <summary>
	/// Location of the aisle where the device or appliance can be found.
	/// </summary>
	[JsonProperty("aisle_location")]
	public string AisleLocation { get; set; }

	/// <summary>
	/// Asset tag of the device or appliance.
	/// </summary>
	[JsonProperty("asset_tag")]
	public string AssetTag { get; set; }

	/// <summary>
	/// Version of the BIOS.
	/// </summary>
	[JsonProperty("bios_version")]
	public string BiosVersion { get; set; }

	/// <summary>
	/// Impact point of highest impacting issue in the capacity health category.
	/// </summary>
	[JsonProperty("capacity_impact")]
	public long CapacityImpact { get; set; }

	/// <summary>
	/// Total number of issues in the capacity health category.
	/// </summary>
	[JsonProperty("capacity_issue_count")]
	public long CapacityIssueCount { get; set; }

	/// <summary>
	/// Name of the Multi Chassis Management group
	/// </summary>
	[JsonProperty("chassis_group")]
	public string ChassisGroup { get; set; }

	/// <summary>
	/// Name of the city where the system is located.
	/// </summary>
	[JsonProperty("city")]
	public string City { get; set; }

	/// <summary>
	/// Comma separated ids of OMEs sending data for a system.
	/// </summary>
	[JsonProperty("collected_by")]
	public string CollectedBy { get; set; }

	/// <summary>
	/// OME which collects the system data.
	/// </summary>
	[JsonProperty("compute_manager_id")]
	public string ComputeManagerId { get; set; }

	/// <summary>
	/// Impact point of highest impacting issue in the configuration health category.
	/// </summary>
	[JsonProperty("configuration_impact")]
	public long ConfigurationImpact { get; set; }

	/// <summary>
	/// Total number of issues in the configuration health category.
	/// </summary>
	[JsonProperty("configuration_issue_count")]
	public long ConfigurationIssueCount { get; set; }

	/// <summary>
	/// Connectivity status.
	/// </summary>
	[JsonProperty("connectivity_status")]
	public string ConnectivityStatus { get; set; }

	/// <summary>
	/// Type of the service contract of the system.
	/// </summary>
	[JsonProperty("contract_coverage_type")]
	public string ContractCoverageType { get; set; }

	/// <summary>
	/// Expiration date for the service contract of the system.
	/// </summary>
	[JsonProperty("contract_expiration_date_timestamp")]
	public System.DateTimeOffset ContractExpirationDateTimestamp { get; set; }

	/// <summary>
	/// Name of the country where the system is located.
	/// </summary>
	[JsonProperty("country")]
	public string Country { get; set; }

	/// <summary>
	/// Percentage of CPU usage.
	/// </summary>
	[JsonProperty("cpu_usage_percent")]
	public long CpuUsagePercent { get; set; }

	/// <summary>
	/// Impact point of highest impacting issue in the data protection health category.
	/// </summary>
	[JsonProperty("data_protection_impact")]
	public long DataProtectionImpact { get; set; }

	/// <summary>
	/// Total number of issues in the data protection health category.
	/// </summary>
	[JsonProperty("data_protection_issue_count")]
	public long DataProtectionIssueCount { get; set; }

	/// <summary>
	/// Location of the datacenter where the device or appliance can be found.
	/// </summary>
	[JsonProperty("datacenter_location")]
	public string DatacenterLocation { get; set; }

	/// <summary>
	/// Type of Server, whether server or chassis.
	/// </summary>
	[JsonProperty("device_type")]
	public string DeviceType { get; set; }

	/// <summary>
	/// Unique identifier for the system.
	/// </summary>
	[JsonProperty("display_identifier")]
	public string DisplayIdentifier { get; set; }

	/// <summary>
	/// Numeric version of Service Tag to use for telephone call routing when contacting Support.
	/// </summary>
	[JsonProperty("express_service_code")]
	public string ExpressServiceCode { get; set; }

	/// <summary>
	/// Health connectivity status.
	/// </summary>
	[JsonProperty("health_connectivity_status")]
	public string HealthConnectivityStatus { get; set; }

	/// <summary>
	/// Total amount of health issues.
	/// </summary>
	[JsonProperty("health_issue_count")]
	public long HealthIssueCount { get; set; }

	/// <summary>
	/// Health score of the system.
	/// </summary>
	[JsonProperty("health_score")]
	public long HealthScore { get; set; }

	/// <summary>
	/// Health state of the system.
	/// </summary>
	[JsonProperty("health_state")]
	public string HealthState { get; set; }

	/// <summary>
	/// The Management Controller DNS Name. MC for Chassis is Management Module (MM), the MC for PowerEdge is iDRAC.
	/// </summary>
	[JsonProperty("idrac_dns_name")]
	public string IdracDnsName { get; set; }

	/// <summary>
	/// Inlet temperature of a system.
	/// </summary>
	[JsonProperty("inlet_temperature")]
	public long InletTemperature { get; set; }

	/// <summary>
	/// The IP address of the system.
	/// </summary>
	[JsonProperty("ipv4_address")]
	public string Ipv4Address { get; set; }

	/// <summary>
	/// The IPv6 address of the system.
	/// </summary>
	[JsonProperty("ipv6_address")]
	public string Ipv6Address { get; set; }

	/// <summary>
	/// Time of last contact with the system.
	/// </summary>
	[JsonProperty("last_contact_timestamp")]
	public System.DateTimeOffset LastContactTimestamp { get; set; }

	/// <summary>
	/// Service Tag of the lead chassis in the Multi Chassis Management group
	/// </summary>
	[JsonProperty("lead_chassis_service_tag")]
	public string LeadChassisServiceTag { get; set; }

	/// <summary>
	/// The license associated with the system.
	/// </summary>
	[JsonProperty("license")]
	public string License { get; set; }

	/// <summary>
	/// Location where the system can be found.
	/// </summary>
	[JsonProperty("location")]
	public string Location { get; set; }

	/// <summary>
	/// Percentage of memory usage for the system.
	/// </summary>
	[JsonProperty("memory_usage_percent")]
	public long MemoryUsagePercent { get; set; }

	/// <summary>
	/// Model of the system.
	/// </summary>
	[JsonProperty("model")]
	public string Model { get; set; }

	/// <summary>
	/// Name of the system.
	/// </summary>
	[JsonProperty("object_name")]
	public string ObjectName { get; set; }

	/// <summary>
	/// Impact point of highest impacting issue in the performance health category.
	/// </summary>
	[JsonProperty("performance_impact")]
	public long PerformanceImpact { get; set; }

	/// <summary>
	/// Total number of issues in the performance health category.
	/// </summary>
	[JsonProperty("performance_issue_count")]
	public long PerformanceIssueCount { get; set; }

	/// <summary>
	/// Power consumed by the system.
	/// </summary>
	[JsonProperty("power_consumption")]
	public long PowerConsumption { get; set; }

	/// <summary>
	/// This identifies if server is Powered On or Powered Off.
	/// </summary>
	[JsonProperty("power_state")]
	public string PowerState { get; set; }

	/// <summary>
	/// Location of the rack where the device or appliance can be found.
	/// </summary>
	[JsonProperty("rack_location")]
	public string RackLocation { get; set; }

	/// <summary>
	/// Role of the chassis in the Multi Chassis Management group.
	/// </summary>
	[JsonProperty("role")]
	public string Role { get; set; }

	/// <summary>
	/// Location of the room where the device or appliance can be found.
	/// </summary>
	[JsonProperty("room_location")]
	public string RoomLocation { get; set; }

	/// <summary>
	/// Serial number of the system.
	/// </summary>
	[JsonProperty("serial_number")]
	public string SerialNumber { get; set; }

	/// <summary>
	/// Service tag of the system.
	/// </summary>
	[JsonProperty("service_tag")]
	public string ServiceTag { get; set; }

	/// <summary>
	/// Name of the site where the system is located.
	/// </summary>
	[JsonProperty("site_name")]
	public string SiteName { get; set; }

	/// <summary>
	/// Location of the slot where the device or appliance can be found.
	/// </summary>
	[JsonProperty("slot_location")]
	public string SlotLocation { get; set; }

	/// <summary>
	/// Name of the state where the system is located.
	/// </summary>
	[JsonProperty("state")]
	public string State { get; set; }

	/// <summary>
	/// Street address 1 of where the system is located.
	/// </summary>
	[JsonProperty("street_address_1")]
	public string StreetAddress1 { get; set; }

	/// <summary>
	/// Street address 2 of where the system is located.
	/// </summary>
	[JsonProperty("street_address_2")]
	public string StreetAddress2 { get; set; }

	/// <summary>
	/// Percentage of I/O usage of the system board.
	/// </summary>
	[JsonProperty("system_board_io_usage_percent")]
	public long SystemBoardIoUsagePercent { get; set; }

	/// <summary>
	/// Health impact for the system.
	/// </summary>
	[JsonProperty("system_health_impact")]
	public long SystemHealthImpact { get; set; }

	/// <summary>
	/// Total amount of health issues for the system.
	/// </summary>
	[JsonProperty("system_health_issue_count")]
	public long SystemHealthIssueCount { get; set; }

	/// <summary>
	/// User defined tags.
	/// </summary>
	[JsonProperty("system_tags")]
	public object SystemTags { get; set; }

	/// <summary>
	/// Percentage of system use.
	/// </summary>
	[JsonProperty("system_usage_percent")]
	public long SystemUsagePercent { get; set; }

	/// <summary>
	/// Type of the system.
	/// </summary>
	[JsonProperty("type")]
	public string Type { get; set; }

	/// <summary>
	/// Name of the vendor who makes the system.
	/// </summary>
	[JsonProperty("vendor")]
	public string Vendor { get; set; }

	/// <summary>
	/// iDRAC Firmware Version of the system.
	/// </summary>
	[JsonProperty("version")]
	public string Version { get; set; }

	/// <summary>
	/// State ZIP code of where the system is located.
	/// </summary>
	[JsonProperty("zip_code")]
	public string ZipCode { get; set; }

	private IDictionary<string, object> _additionalProperties;

	[JsonExtensionData]
	public IDictionary<string, object> AdditionalProperties
	{
		get { return _additionalProperties ?? (_additionalProperties = new Dictionary<string, object>()); }
		set { _additionalProperties = value; }
	}
}
