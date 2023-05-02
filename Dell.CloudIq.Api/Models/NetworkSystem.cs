namespace Dell.CloudIq.Api;

/// <summary>
/// The network system object.
/// </summary>
public partial class NetworkSystem
{
	/// <summary>
	/// Identifier of the system.
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
	/// Number of bit errors across all ports on the system.
	/// </summary>
	[JsonProperty("bit_errors")]
	public long BitErrors { get; set; }

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
	/// Chassis World Wide Name (WWN) of the switch.
	/// </summary>
	[JsonProperty("chassis_wwn")]
	public string ChassisWwn { get; set; }

	/// <summary>
	/// CloudIQ Collector GDS identifier.
	/// </summary>
	[JsonProperty("ciqc")]
	public string Ciqc { get; set; }

	/// <summary>
	/// Name of the CloudIQ Collector.
	/// </summary>
	[JsonProperty("ciqc_name")]
	public string CiqcName { get; set; }

	/// <summary>
	/// Name of the city where the system is located.
	/// </summary>
	[JsonProperty("city")]
	public string City { get; set; }

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
	/// Total number of congested ports on the switch.
	/// </summary>
	[JsonProperty("congested_ports")]
	public long CongestedPorts { get; set; }

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
	/// Amount of CPU usage.
	/// </summary>
	[JsonProperty("cpu_utilization")]
	public double CpuUtilization { get; set; }

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
	/// Unique identifier for the system.
	/// </summary>
	[JsonProperty("display_identifier")]
	public string DisplayIdentifier { get; set; }

	/// <summary>
	/// Number of FC ports with errors.
	/// </summary>
	[JsonProperty("error_fc_ports")]
	public long ErrorFcPorts { get; set; }

	/// <summary>
	/// Number of GE ports with errors.
	/// </summary>
	[JsonProperty("error_ge_ports")]
	public long ErrorGePorts { get; set; }

	/// <summary>
	/// Total number of ports with errors.
	/// </summary>
	[JsonProperty("error_ports")]
	public long ErrorPorts { get; set; }

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
	/// Incrementing errors for the system.
	/// </summary>
	[JsonProperty("incrementing_bit_errors")]
	public long IncrementingBitErrors { get; set; }

	/// <summary>
	/// Incrementing link resets for the system.
	/// </summary>
	[JsonProperty("incrementing_link_resets")]
	public long IncrementingLinkResets { get; set; }

	/// <summary>
	/// IPv4 address of the system.
	/// </summary>
	[JsonProperty("ipv4_address")]
	public string Ipv4Address { get; set; }

	/// <summary>
	/// IPv6 address of the system.
	/// </summary>
	[JsonProperty("ipv6_address")]
	public string Ipv6Address { get; set; }

	/// <summary>
	/// Time of last contact with the system.
	/// </summary>
	[JsonProperty("last_contact_timestamp")]
	public System.DateTimeOffset LastContactTimestamp { get; set; }

	/// <summary>
	/// Number of link resets across all ports on the system.
	/// </summary>
	[JsonProperty("link_resets")]
	public long LinkResets { get; set; }

	/// <summary>
	/// Location where the system can be found.
	/// </summary>
	[JsonProperty("location")]
	public string Location { get; set; }

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
	/// Total number of FC ports that are offline.
	/// </summary>
	[JsonProperty("offline_fc_ports")]
	public long OfflineFcPorts { get; set; }

	/// <summary>
	/// Total number of GE ports that are offline.
	/// </summary>
	[JsonProperty("offline_ge_ports")]
	public long OfflineGePorts { get; set; }

	/// <summary>
	/// Total number of ports that are offline.
	/// </summary>
	[JsonProperty("offline_ports")]
	public long OfflinePorts { get; set; }

	/// <summary>
	/// Total number of FC ports that are online.
	/// </summary>
	[JsonProperty("online_fc_ports")]
	public long OnlineFcPorts { get; set; }

	/// <summary>
	/// Total number of GE ports that are online.
	/// </summary>
	[JsonProperty("online_ge_ports")]
	public long OnlineGePorts { get; set; }

	/// <summary>
	/// Total number of ports that are online.
	/// </summary>
	[JsonProperty("online_ports")]
	public long OnlinePorts { get; set; }

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
	/// Number of ports with over 80 percent utilization.
	/// </summary>
	[JsonProperty("ports_over_80_percent")]
	public long PortsOver80Percent { get; set; }

	/// <summary>
	/// Serial number of the system.
	/// </summary>
	[JsonProperty("serial_number")]
	public string SerialNumber { get; set; }

	/// <summary>
	/// Name of the site where the system is located.
	/// </summary>
	[JsonProperty("site_name")]
	public string SiteName { get; set; }

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
	/// The switch MAC property.
	/// </summary>
	[JsonProperty("switch_mac")]
	public string SwitchMac { get; set; }

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
	/// Total number of FC ports on the system.
	/// </summary>
	[JsonProperty("total_fc_ports")]
	public long TotalFcPorts { get; set; }

	/// <summary>
	/// Total number of GE ports on the system.
	/// </summary>
	[JsonProperty("total_ge_ports")]
	public long TotalGePorts { get; set; }

	/// <summary>
	/// Total number of ports on the system.
	/// </summary>
	[JsonProperty("total_ports")]
	public long TotalPorts { get; set; }

	/// <summary>
	/// Type of the system.
	/// </summary>
	[JsonProperty("type")]
	public string Type { get; set; }

	/// <summary>
	/// Time since last reboot of the system.
	/// </summary>
	[JsonProperty("uptime")]
	public long Uptime { get; set; }

	/// <summary>
	/// Overall bandwidth utilization of the system.
	/// </summary>
	[JsonProperty("utilization")]
	public double Utilization { get; set; }

	/// <summary>
	/// Name of the vendor who makes the system.
	/// </summary>
	[JsonProperty("vendor")]
	public string Vendor { get; set; }

	/// <summary>
	/// Current firmware version of the system.
	/// </summary>
	[JsonProperty("version")]
	public string Version { get; set; }

	/// <summary>
	/// World Wide Name (WWN) of the component.
	/// </summary>
	[JsonProperty("wwn")]
	public string Wwn { get; set; }

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
