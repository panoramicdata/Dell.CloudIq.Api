namespace Dell.CloudIq.Api;

/// <summary>
/// The storage system.
/// </summary>
public partial class StorageSystem
{
	/// <summary>
	/// Identifier for the storage system.
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
	/// The system bandwidth. Aggregated for a rolling average over the last 24 hours - Unit: bytes/s
	/// </summary>
	[JsonProperty("bandwidth")]
	public long Bandwidth { get; set; }

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
	/// Name of the city where the system is located.
	/// </summary>
	[JsonProperty("city")]
	public string City { get; set; }

	/// <summary>
	/// Storage efficiency ratio of data which has compression applied to it on the system.
	/// </summary>
	[JsonProperty("compression_savings")]
	public double CompressionSavings { get; set; }

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
	/// The configured size for this system - Unit: bytes
	/// </summary>
	[JsonProperty("configured_size")]
	public long ConfiguredSize { get; set; }

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
	/// The %free capacity.
	/// </summary>
	[JsonProperty("free_percent")]
	public double FreePercent { get; set; }

	/// <summary>
	/// The free size value - Unit: bytes
	/// </summary>
	[JsonProperty("free_size")]
	public long FreeSize { get; set; }

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
	/// The overall health score of the system.
	/// </summary>
	[JsonProperty("health_score")]
	public long HealthScore { get; set; }

	/// <summary>
	/// Health state of the system.
	/// </summary>
	[JsonProperty("health_state")]
	public string HealthState { get; set; }

	/// <summary>
	/// The IOPS for the system. Aggregated for a rolling average over the last 24 hours - Unit: IO/s
	/// </summary>
	[JsonProperty("iops")]
	public long Iops { get; set; }

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
	/// Last time that CloudIQ received data from the system.
	/// </summary>
	[JsonProperty("last_contact_timestamp")]
	public System.DateTimeOffset LastContactTimestamp { get; set; }

	/// <summary>
	/// The latency for the system. Aggregated for a rolling average over the last 24 hours - Unit: microseconds
	/// </summary>
	[JsonProperty("latency")]
	public long Latency { get; set; }

	/// <summary>
	/// Location where the system is located.
	/// </summary>
	[JsonProperty("location")]
	public string Location { get; set; }

	/// <summary>
	/// The logical size written - Unit: bytes
	/// </summary>
	[JsonProperty("logical_size")]
	public long LogicalSize { get; set; }

	/// <summary>
	/// The model of the system.
	/// </summary>
	[JsonProperty("model")]
	public string Model { get; set; }

	/// <summary>
	/// The user-defined name of the system.
	/// </summary>
	[JsonProperty("object_name")]
	public string ObjectName { get; set; }

	/// <summary>
	/// The overall system-level storage efficiency ratio based on Thin, Snapshots, Deduplication, and Data Reduction.
	/// </summary>
	[JsonProperty("overall_efficiency")]
	public double OverallEfficiency { get; set; }

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
	/// The serial number for this system.
	/// </summary>
	[JsonProperty("serial_number")]
	public string SerialNumber { get; set; }

	/// <summary>
	/// Name of the site where the system is located.
	/// </summary>
	[JsonProperty("site_name")]
	public string SiteName { get; set; }

	/// <summary>
	/// The snaps savings for this system.
	/// </summary>
	[JsonProperty("snaps_savings")]
	public double SnapsSavings { get; set; }

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
	/// The savings due to thin provisioning.
	/// </summary>
	[JsonProperty("thin_savings")]
	public double ThinSavings { get; set; }

	/// <summary>
	/// The total size of the system - Unit: bytes
	/// </summary>
	[JsonProperty("total_size")]
	public long TotalSize { get; set; }

	/// <summary>
	/// Type of the system.
	/// </summary>
	[JsonProperty("type")]
	public string Type { get; set; }

	/// <summary>
	/// The unconfigured capacity for this system - Unit: bytes
	/// </summary>
	[JsonProperty("unconfigured_size")]
	public long UnconfiguredSize { get; set; }

	/// <summary>
	/// Percentage of capacity used for this system.
	/// </summary>
	[JsonProperty("used_percent")]
	public double UsedPercent { get; set; }

	/// <summary>
	/// The value of used capacity for this system - Unit: bytes
	/// </summary>
	[JsonProperty("used_size")]
	public long UsedSize { get; set; }

	/// <summary>
	/// Name of the vendor who makes the system.
	/// </summary>
	[JsonProperty("vendor")]
	public string Vendor { get; set; }

	/// <summary>
	/// Version identifier.
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
