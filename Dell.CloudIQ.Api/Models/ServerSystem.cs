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
	[JsonProperty("system_id", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public string SystemId { get; set; }

	/// <summary>
	/// DEPRECATED - Unique identifier for the device or appliance.
	/// </summary>
	[JsonProperty("system", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	[System.Obsolete]
	public string System { get; set; }

	/// <summary>
	/// Type of the system.
	/// </summary>
	[JsonProperty("system_type", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public string SystemType { get; set; }

	/// <summary>
	/// Location of the aisle where the device or appliance can be found.
	/// </summary>
	[JsonProperty("aisle_location", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public string AisleLocation { get; set; }

	/// <summary>
	/// Asset tag of the device or appliance.
	/// </summary>
	[JsonProperty("asset_tag", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public string AssetTag { get; set; }

	/// <summary>
	/// Version of the BIOS.
	/// </summary>
	[JsonProperty("bios_version", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public string BiosVersion { get; set; }

	/// <summary>
	/// Impact point of highest impacting issue in the capacity health category.
	/// </summary>
	[JsonProperty("capacity_impact", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public long CapacityImpact { get; set; }

	/// <summary>
	/// Total number of issues in the capacity health category.
	/// </summary>
	[JsonProperty("capacity_issue_count", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public long CapacityIssueCount { get; set; }

	/// <summary>
	/// Name of the Multi Chassis Management group
	/// </summary>
	[JsonProperty("chassis_group", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public string ChassisGroup { get; set; }

	/// <summary>
	/// Name of the city where the system is located.
	/// </summary>
	[JsonProperty("city", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public string City { get; set; }

	/// <summary>
	/// Comma separated ids of OMEs sending data for a system.
	/// </summary>
	[JsonProperty("collected_by", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public string CollectedBy { get; set; }

	/// <summary>
	/// OME which collects the system data.
	/// </summary>
	[JsonProperty("compute_manager_id", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public string ComputeManagerId { get; set; }

	/// <summary>
	/// Impact point of highest impacting issue in the configuration health category.
	/// </summary>
	[JsonProperty("configuration_impact", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public long ConfigurationImpact { get; set; }

	/// <summary>
	/// Total number of issues in the configuration health category.
	/// </summary>
	[JsonProperty("configuration_issue_count", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public long ConfigurationIssueCount { get; set; }

	/// <summary>
	/// Connectivity status.
	/// </summary>
	[JsonProperty("connectivity_status", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public string ConnectivityStatus { get; set; }

	/// <summary>
	/// Type of the service contract of the system.
	/// </summary>
	[JsonProperty("contract_coverage_type", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public string ContractCoverageType { get; set; }

	/// <summary>
	/// Expiration date for the service contract of the system.
	/// </summary>
	[JsonProperty("contract_expiration_date_timestamp", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public System.DateTimeOffset ContractExpirationDateTimestamp { get; set; }

	/// <summary>
	/// Name of the country where the system is located.
	/// </summary>
	[JsonProperty("country", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public string Country { get; set; }

	/// <summary>
	/// Percentage of CPU usage.
	/// </summary>
	[JsonProperty("cpu_usage_percent", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public long CpuUsagePercent { get; set; }

	/// <summary>
	/// Impact point of highest impacting issue in the data protection health category.
	/// </summary>
	[JsonProperty("data_protection_impact", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public long DataProtectionImpact { get; set; }

	/// <summary>
	/// Total number of issues in the data protection health category.
	/// </summary>
	[JsonProperty("data_protection_issue_count", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public long DataProtectionIssueCount { get; set; }

	/// <summary>
	/// Location of the datacenter where the device or appliance can be found.
	/// </summary>
	[JsonProperty("datacenter_location", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public string DatacenterLocation { get; set; }

	/// <summary>
	/// Type of Server, whether server or chassis.
	/// </summary>
	[JsonProperty("device_type", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public string DeviceType { get; set; }

	/// <summary>
	/// Unique identifier for the system.
	/// </summary>
	[JsonProperty("display_identifier", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public string DisplayIdentifier { get; set; }

	/// <summary>
	/// Numeric version of Service Tag to use for telephone call routing when contacting Support.
	/// </summary>
	[JsonProperty("express_service_code", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public string ExpressServiceCode { get; set; }

	/// <summary>
	/// Health connectivity status.
	/// </summary>
	[JsonProperty("health_connectivity_status", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public string HealthConnectivityStatus { get; set; }

	/// <summary>
	/// Total amount of health issues.
	/// </summary>
	[JsonProperty("health_issue_count", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public long HealthIssueCount { get; set; }

	/// <summary>
	/// Health score of the system.
	/// </summary>
	[JsonProperty("health_score", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public long HealthScore { get; set; }

	/// <summary>
	/// Health state of the system.
	/// </summary>
	[JsonProperty("health_state", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public string HealthState { get; set; }

	/// <summary>
	/// The Management Controller DNS Name. MC for Chassis is Management Module (MM), the MC for PowerEdge is iDRAC.
	/// </summary>
	[JsonProperty("idrac_dns_name", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public string IdracDnsName { get; set; }

	/// <summary>
	/// Inlet temperature of a system.
	/// </summary>
	[JsonProperty("inlet_temperature", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public long InletTemperature { get; set; }

	/// <summary>
	/// The IP address of the system.
	/// </summary>
	[JsonProperty("ipv4_address", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public string Ipv4Address { get; set; }

	/// <summary>
	/// The IPv6 address of the system.
	/// </summary>
	[JsonProperty("ipv6_address", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public string Ipv6Address { get; set; }

	/// <summary>
	/// Time of last contact with the system.
	/// </summary>
	[JsonProperty("last_contact_timestamp", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public System.DateTimeOffset LastContactTimestamp { get; set; }

	/// <summary>
	/// Service Tag of the lead chassis in the Multi Chassis Management group
	/// </summary>
	[JsonProperty("lead_chassis_service_tag", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public string LeadChassisServiceTag { get; set; }

	/// <summary>
	/// The license associated with the system.
	/// </summary>
	[JsonProperty("license", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public string License { get; set; }

	/// <summary>
	/// Location where the system can be found.
	/// </summary>
	[JsonProperty("location", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public string Location { get; set; }

	/// <summary>
	/// Percentage of memory usage for the system.
	/// </summary>
	[JsonProperty("memory_usage_percent", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public long MemoryUsagePercent { get; set; }

	/// <summary>
	/// Model of the system.
	/// </summary>
	[JsonProperty("model", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public string Model { get; set; }

	/// <summary>
	/// Name of the system.
	/// </summary>
	[JsonProperty("object_name", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public string ObjectName { get; set; }

	/// <summary>
	/// Impact point of highest impacting issue in the performance health category.
	/// </summary>
	[JsonProperty("performance_impact", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public long PerformanceImpact { get; set; }

	/// <summary>
	/// Total number of issues in the performance health category.
	/// </summary>
	[JsonProperty("performance_issue_count", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public long PerformanceIssueCount { get; set; }

	/// <summary>
	/// Power consumed by the system.
	/// </summary>
	[JsonProperty("power_consumption", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public long PowerConsumption { get; set; }

	/// <summary>
	/// This identifies if server is Powered On or Powered Off.
	/// </summary>
	[JsonProperty("power_state", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public string PowerState { get; set; }

	/// <summary>
	/// Location of the rack where the device or appliance can be found.
	/// </summary>
	[JsonProperty("rack_location", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public string RackLocation { get; set; }

	/// <summary>
	/// Role of the chassis in the Multi Chassis Management group.
	/// </summary>
	[JsonProperty("role", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public string Role { get; set; }

	/// <summary>
	/// Location of the room where the device or appliance can be found.
	/// </summary>
	[JsonProperty("room_location", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public string RoomLocation { get; set; }

	/// <summary>
	/// Serial number of the system.
	/// </summary>
	[JsonProperty("serial_number", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public string SerialNumber { get; set; }

	/// <summary>
	/// Service tag of the system.
	/// </summary>
	[JsonProperty("service_tag", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public string ServiceTag { get; set; }

	/// <summary>
	/// Name of the site where the system is located.
	/// </summary>
	[JsonProperty("site_name", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public string SiteName { get; set; }

	/// <summary>
	/// Location of the slot where the device or appliance can be found.
	/// </summary>
	[JsonProperty("slot_location", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public string SlotLocation { get; set; }

	/// <summary>
	/// Name of the state where the system is located.
	/// </summary>
	[JsonProperty("state", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public string State { get; set; }

	/// <summary>
	/// Street address 1 of where the system is located.
	/// </summary>
	[JsonProperty("street_address_1", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public string StreetAddress1 { get; set; }

	/// <summary>
	/// Street address 2 of where the system is located.
	/// </summary>
	[JsonProperty("street_address_2", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public string StreetAddress2 { get; set; }

	/// <summary>
	/// Percentage of I/O usage of the system board.
	/// </summary>
	[JsonProperty("system_board_io_usage_percent", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public long SystemBoardIoUsagePercent { get; set; }

	/// <summary>
	/// Health impact for the system.
	/// </summary>
	[JsonProperty("system_health_impact", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public long SystemHealthImpact { get; set; }

	/// <summary>
	/// Total amount of health issues for the system.
	/// </summary>
	[JsonProperty("system_health_issue_count", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public long SystemHealthIssueCount { get; set; }

	/// <summary>
	/// User defined tags.
	/// </summary>
	[JsonProperty("system_tags", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public object SystemTags { get; set; }

	/// <summary>
	/// Percentage of system use.
	/// </summary>
	[JsonProperty("system_usage_percent", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public long SystemUsagePercent { get; set; }

	/// <summary>
	/// Type of the system.
	/// </summary>
	[JsonProperty("type", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public string Type { get; set; }

	/// <summary>
	/// Name of the vendor who makes the system.
	/// </summary>
	[JsonProperty("vendor", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public string Vendor { get; set; }

	/// <summary>
	/// iDRAC Firmware Version of the system.
	/// </summary>
	[JsonProperty("version", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public string Version { get; set; }

	/// <summary>
	/// State ZIP code of where the system is located.
	/// </summary>
	[JsonProperty("zip_code", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public string ZipCode { get; set; }

	private IDictionary<string, object> _additionalProperties;

	[JsonExtensionData]
	public IDictionary<string, object> AdditionalProperties
	{
		get { return _additionalProperties ?? (_additionalProperties = new Dictionary<string, object>()); }
		set { _additionalProperties = value; }
	}
}
