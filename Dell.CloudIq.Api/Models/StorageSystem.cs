namespace Dell.CloudIq.Api;

/// <summary>
/// The storage system.
/// </summary>
public partial class StorageSystem
{
	/// <summary>
	/// Identifier for the storage system.
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
	/// The system bandwidth. Aggregated for a rolling average over the last 24 hours - Unit: bytes/s
	/// </summary>
	[JsonPropertyName("bandwidth")]
	public long? Bandwidth { get; set; } = null;

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
	/// Name of the city where the system is located.
	/// </summary>
	[JsonPropertyName("city")]
	public string? City { get; set; } = null;

	/// <summary>
	/// Storage efficiency ratio of data which has compression applied to it on the system.
	/// </summary>
	[JsonPropertyName("compression_savings")]
	public double? CompressionSavings { get; set; } = null;

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
	/// The configured size for this system - Unit: bytes
	/// </summary>
	[JsonPropertyName("configured_size")]
	public long? ConfiguredSize { get; set; } = null;

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
	/// The %free capacity.
	/// </summary>
	[JsonPropertyName("free_percent")]
	public double? FreePercent { get; set; } = null;

	/// <summary>
	/// The free size value - Unit: bytes
	/// </summary>
	[JsonPropertyName("free_size")]
	public long? FreeSize { get; set; } = null;

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
	/// The overall health score of the system.
	/// </summary>
	[JsonPropertyName("health_score")]
	public long? HealthScore { get; set; } = null;

	/// <summary>
	/// Health state of the system.
	/// </summary>
	[JsonPropertyName("health_state")]
	public string? HealthState { get; set; } = null;

	/// <summary>
	/// The IOPS for the system. Aggregated for a rolling average over the last 24 hours - Unit: IO/s
	/// </summary>
	[JsonPropertyName("iops")]
	public long? Iops { get; set; } = null;

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
	/// Last time that CloudIQ received data from the system.
	/// </summary>
	[JsonPropertyName("last_contact_timestamp")]
	public long? LastContactTimestamp { get; set; } = null;

	/// <summary>
	/// The latency for the system. Aggregated for a rolling average over the last 24 hours - Unit: microseconds
	/// </summary>
	[JsonPropertyName("latency")]
	public long? Latency { get; set; } = null;

	/// <summary>
	/// Location where the system is located.
	/// </summary>
	[JsonPropertyName("location")]
	public string? Location { get; set; } = null;

	/// <summary>
	/// The logical size written - Unit: bytes
	/// </summary>
	[JsonPropertyName("logical_size")]
	public long? LogicalSize { get; set; } = null;

	/// <summary>
	/// The model of the system.
	/// </summary>
	[JsonPropertyName("model")]
	public string? Model { get; set; } = null;

	/// <summary>
	/// The user-defined name of the system.
	/// </summary>
	[JsonPropertyName("object_name")]
	public string? ObjectName { get; set; } = null;

	/// <summary>
	/// The overall system-level storage efficiency ratio based on Thin, Snapshots, Deduplication, and Data Reduction.
	/// </summary>
	[JsonPropertyName("overall_efficiency")]
	public double? OverallEfficiency { get; set; } = null;

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
	/// The serial number for this system.
	/// </summary>
	[JsonPropertyName("serial_number")]
	public string? SerialNumber { get; set; } = null;

	/// <summary>
	/// Name of the site where the system is located.
	/// </summary>
	[JsonPropertyName("site_name")]
	public string? SiteName { get; set; } = null;

	/// <summary>
	/// The snaps savings for this system.
	/// </summary>
	[JsonPropertyName("snaps_savings")]
	public double? SnapsSavings { get; set; } = null;

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
	/// The savings due to thin provisioning.
	/// </summary>
	[JsonPropertyName("thin_savings")]
	public double? ThinSavings { get; set; } = null;

	/// <summary>
	/// The total size of the system - Unit: bytes
	/// </summary>
	[JsonPropertyName("total_size")]
	public long? TotalSize { get; set; } = null;

	/// <summary>
	/// Type of the system.
	/// </summary>
	[JsonPropertyName("type")]
	public string? Type { get; set; } = null;

	/// <summary>
	/// The unconfigured capacity for this system - Unit: bytes
	/// </summary>
	[JsonPropertyName("unconfigured_size")]
	public long? UnconfiguredSize { get; set; } = null;

	/// <summary>
	/// Percentage of capacity used for this system.
	/// </summary>
	[JsonPropertyName("used_percent")]
	public double? UsedPercent { get; set; } = null;

	/// <summary>
	/// The value of used capacity for this system - Unit: bytes
	/// </summary>
	[JsonPropertyName("used_size")]
	public long? UsedSize { get; set; } = null;

	/// <summary>
	/// Name of the vendor who makes the system.
	/// </summary>
	[JsonPropertyName("vendor")]
	public string? Vendor { get; set; } = null;

	/// <summary>
	/// Version identifier.
	/// </summary>
	[JsonPropertyName("version")]
	public string? Version { get; set; } = null;

	/// <summary>
	/// State ZIP code of where the system is located.
	/// </summary>
	[JsonPropertyName("zip_code")]
	public string? ZipCode { get; set; } = null;

	private IDictionary<string, object> _additionalProperties;

	[JsonExtensionData]
	public IDictionary<string, object> AdditionalProperties
	{
		get { return _additionalProperties ?? (_additionalProperties = new Dictionary<string, object>()); }
		set { _additionalProperties = value; }
	}
}
