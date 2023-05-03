namespace Dell.CloudIq.Api;

/// <summary>
/// The network system object.
/// </summary>
public partial class NetworkSystem
{
	/// <summary>
	/// Identifier of the system.
	/// </summary>
	[JsonPropertyName("id")]

	public string? Id { get; set; } = null;

	/// <summary>
	/// Unique identifier for the device or appliance.
	/// </summary>
	[JsonPropertyName("system_id")]
	public string? SystemId { get; set; } = null;

	/// <summary>
	/// Type of the system.
	/// </summary>
	[JsonPropertyName("system_type")]
	public string? SystemType { get; set; } = null;

	/// <summary>
	/// Number of bit errors across all ports on the system.
	/// </summary>
	[JsonPropertyName("bit_errors")]
	public long? BitErrors { get; set; } = null;

	/// <summary>
	/// Impact point of highest impacting issue in the capacity health category.
	/// </summary>
	[JsonPropertyName("capacity_impact")]
	public long? CapacityImpact { get; set; } = null;

	/// <summary>
	/// Total number of issues in the capacity health category.
	/// </summary>
	[JsonPropertyName("capacity_issue_count")]
	public long? CapacityIssueCount { get; set; } = null;

	/// <summary>
	/// Chassis World Wide Name (WWN) of the switch.
	/// </summary>
	[JsonPropertyName("chassis_wwn")]
	public string? ChassisWwn { get; set; } = null;

	/// <summary>
	/// CloudIQ Collector GDS identifier.
	/// </summary>
	[JsonPropertyName("ciqc")]
	public string? Ciqc { get; set; } = null;

	/// <summary>
	/// Name of the CloudIQ Collector.
	/// </summary>
	[JsonPropertyName("ciqc_name")]
	public string? CiqcName { get; set; } = null;

	/// <summary>
	/// Name of the city where the system is located.
	/// </summary>
	[JsonPropertyName("city")]
	public string? City { get; set; } = null;

	/// <summary>
	/// Impact point of highest impacting issue in the configuration health category.
	/// </summary>
	[JsonPropertyName("configuration_impact")]
	public long? ConfigurationImpact { get; set; } = null;

	/// <summary>
	/// Total number of issues in the configuration health category.
	/// </summary>
	[JsonPropertyName("configuration_issue_count")]
	public long? ConfigurationIssueCount { get; set; } = null;

	/// <summary>
	/// Total number of congested ports on the switch.
	/// </summary>
	[JsonPropertyName("congested_ports")]
	public long? CongestedPorts { get; set; } = null;

	/// <summary>
	/// Connectivity status.
	/// </summary>
	[JsonPropertyName("connectivity_status")]
	public string? ConnectivityStatus { get; set; } = null;

	/// <summary>
	/// Type of the service contract of the system.
	/// </summary>
	[JsonPropertyName("contract_coverage_type")]
	public string? ContractCoverageType { get; set; } = null;

	/// <summary>
	/// Expiration date for the service contract of the system.
	/// </summary>
	[JsonPropertyName("contract_expiration_date_timestamp")]
	public long? ContractExpirationDateTimestamp { get; set; } = null;

	/// <summary>
	/// Name of the country where the system is located.
	/// </summary>
	[JsonPropertyName("country")]
	public string? Country { get; set; } = null;

	/// <summary>
	/// Amount of CPU usage.
	/// </summary>
	[JsonPropertyName("cpu_utilization")]
	public double? CpuUtilization { get; set; } = null;

	/// <summary>
	/// Impact point of highest impacting issue in the data protection health category.
	/// </summary>
	[JsonPropertyName("data_protection_impact")]
	public long? DataProtectionImpact { get; set; } = null;

	/// <summary>
	/// Total number of issues in the data protection health category.
	/// </summary>
	[JsonPropertyName("data_protection_issue_count")]
	public long? DataProtectionIssueCount { get; set; } = null;

	/// <summary>
	/// Unique identifier for the system.
	/// </summary>
	[JsonPropertyName("display_identifier")]
	public string? DisplayIdentifier { get; set; } = null;

	/// <summary>
	/// Number of FC ports with errors.
	/// </summary>
	[JsonPropertyName("error_fc_ports")]
	public long? ErrorFcPorts { get; set; } = null;

	/// <summary>
	/// Number of GE ports with errors.
	/// </summary>
	[JsonPropertyName("error_ge_ports")]
	public long? ErrorGePorts { get; set; } = null;

	/// <summary>
	/// Total number of ports with errors.
	/// </summary>
	[JsonPropertyName("error_ports")]
	public long? ErrorPorts { get; set; } = null;

	/// <summary>
	/// Health connectivity status.
	/// </summary>
	[JsonPropertyName("health_connectivity_status")]
	public string? HealthConnectivityStatus { get; set; } = null;

	/// <summary>
	/// Total amount of health issues.
	/// </summary>
	[JsonPropertyName("health_issue_count")]
	public long? HealthIssueCount { get; set; } = null;

	/// <summary>
	/// Health score of the system.
	/// </summary>
	[JsonPropertyName("health_score")]
	public long? HealthScore { get; set; } = null;

	/// <summary>
	/// Health state of the system.
	/// </summary>
	[JsonPropertyName("health_state")]
	public string? HealthState { get; set; } = null;

	/// <summary>
	/// Incrementing errors for the system.
	/// </summary>
	[JsonPropertyName("incrementing_bit_errors")]
	public long? IncrementingBitErrors { get; set; } = null;

	/// <summary>
	/// Incrementing link resets for the system.
	/// </summary>
	[JsonPropertyName("incrementing_link_resets")]
	public long? IncrementingLinkResets { get; set; } = null;

	/// <summary>
	/// IPv4 address of the system.
	/// </summary>
	[JsonPropertyName("ipv4_address")]
	public string? Ipv4Address { get; set; } = null;

	/// <summary>
	/// IPv6 address of the system.
	/// </summary>
	[JsonPropertyName("ipv6_address")]
	public string? Ipv6Address { get; set; } = null;

	/// <summary>
	/// Time of last contact with the system.
	/// </summary>
	[JsonPropertyName("last_contact_timestamp")]
	public long? LastContactTimestamp { get; set; } = null;

	/// <summary>
	/// Number of link resets across all ports on the system.
	/// </summary>
	[JsonPropertyName("link_resets")]
	public long? LinkResets { get; set; } = null;

	/// <summary>
	/// Location where the system can be found.
	/// </summary>
	[JsonPropertyName("location")]
	public string? Location { get; set; } = null;

	/// <summary>
	/// Model of the system.
	/// </summary>
	[JsonPropertyName("model")]
	public string? Model { get; set; } = null;

	/// <summary>
	/// Name of the system.
	/// </summary>
	[JsonPropertyName("object_name")]
	public string? ObjectName { get; set; } = null;

	/// <summary>
	/// Total number of FC ports that are offline.
	/// </summary>
	[JsonPropertyName("offline_fc_ports")]
	public long? OfflineFcPorts { get; set; } = null;

	/// <summary>
	/// Total number of GE ports that are offline.
	/// </summary>
	[JsonPropertyName("offline_ge_ports")]
	public long? OfflineGePorts { get; set; } = null;

	/// <summary>
	/// Total number of ports that are offline.
	/// </summary>
	[JsonPropertyName("offline_ports")]
	public long? OfflinePorts { get; set; } = null;

	/// <summary>
	/// Total number of FC ports that are online.
	/// </summary>
	[JsonPropertyName("online_fc_ports")]
	public long? OnlineFcPorts { get; set; } = null;

	/// <summary>
	/// Total number of GE ports that are online.
	/// </summary>
	[JsonPropertyName("online_ge_ports")]
	public long? OnlineGePorts { get; set; } = null;

	/// <summary>
	/// Total number of ports that are online.
	/// </summary>
	[JsonPropertyName("online_ports")]
	public long? OnlinePorts { get; set; } = null;

	/// <summary>
	/// Impact point of highest impacting issue in the performance health category.
	/// </summary>
	[JsonPropertyName("performance_impact")]
	public long? PerformanceImpact { get; set; } = null;

	/// <summary>
	/// Total number of issues in the performance health category.
	/// </summary>
	[JsonPropertyName("performance_issue_count")]
	public long? PerformanceIssueCount { get; set; } = null;

	/// <summary>
	/// Number of ports with over 80 percent utilization.
	/// </summary>
	[JsonPropertyName("ports_over_80_percent")]
	public long? PortsOver80Percent { get; set; } = null;

	/// <summary>
	/// Serial number of the system.
	/// </summary>
	[JsonPropertyName("serial_number")]
	public string? SerialNumber { get; set; } = null;

	/// <summary>
	/// Name of the site where the system is located.
	/// </summary>
	[JsonPropertyName("site_name")]
	public string? SiteName { get; set; } = null;

	/// <summary>
	/// Name of the state where the system is located.
	/// </summary>
	[JsonPropertyName("state")]
	public string? State { get; set; } = null;

	/// <summary>
	/// Street address 1 of where the system is located.
	/// </summary>
	[JsonPropertyName("street_address_1")]
	public string? StreetAddress1 { get; set; } = null;

	/// <summary>
	/// Street address 2 of where the system is located.
	/// </summary>
	[JsonPropertyName("street_address_2")]
	public string? StreetAddress2 { get; set; } = null;

	/// <summary>
	/// The switch MAC property.
	/// </summary>
	[JsonPropertyName("switch_mac")]
	public string? SwitchMac { get; set; } = null;

	/// <summary>
	/// Health impact for the system.
	/// </summary>
	[JsonPropertyName("system_health_impact")]
	public long? SystemHealthImpact { get; set; } = null;

	/// <summary>
	/// Total amount of health issues for the system.
	/// </summary>
	[JsonPropertyName("system_health_issue_count")]
	public long? SystemHealthIssueCount { get; set; } = null;

	/// <summary>
	/// User defined tags.
	/// </summary>
	[JsonPropertyName("system_tags")]
	public object? SystemTags { get; set; } = null;

	/// <summary>
	/// Total number of FC ports on the system.
	/// </summary>
	[JsonPropertyName("total_fc_ports")]
	public long? TotalFcPorts { get; set; } = null;

	/// <summary>
	/// Total number of GE ports on the system.
	/// </summary>
	[JsonPropertyName("total_ge_ports")]
	public long? TotalGePorts { get; set; } = null;

	/// <summary>
	/// Total number of ports on the system.
	/// </summary>
	[JsonPropertyName("total_ports")]
	public long? TotalPorts { get; set; } = null;

	/// <summary>
	/// Type of the system.
	/// </summary>
	[JsonPropertyName("type")]
	public string? Type { get; set; } = null;

	/// <summary>
	/// Time since last reboot of the system.
	/// </summary>
	[JsonPropertyName("uptime")]
	public long? Uptime { get; set; } = null;

	/// <summary>
	/// Overall bandwidth utilization of the system.
	/// </summary>
	[JsonPropertyName("utilization")]
	public double? Utilization { get; set; } = null;

	/// <summary>
	/// Name of the vendor who makes the system.
	/// </summary>
	[JsonPropertyName("vendor")]
	public string? Vendor { get; set; } = null;

	/// <summary>
	/// Current firmware version of the system.
	/// </summary>
	[JsonPropertyName("version")]
	public string? Version { get; set; } = null;

	/// <summary>
	/// World Wide Name (WWN) of the component.
	/// </summary>
	[JsonPropertyName("wwn")]
	public string? Wwn { get; set; } = null;

	/// <summary>
	/// State ZIP code of where the system is located.
	/// </summary>
	[JsonPropertyName("zip_code")]
	public string? ZipCode { get; set; } = null;

	private IDictionary<string, object>? _additionalProperties;

	[JsonExtensionData]
	public IDictionary<string, object> AdditionalProperties
	{
		get { return _additionalProperties ?? (_additionalProperties = new Dictionary<string, object>()); }
		set { _additionalProperties = value; }
	}

}
