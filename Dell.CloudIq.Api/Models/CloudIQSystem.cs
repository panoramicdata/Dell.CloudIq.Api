namespace Dell.CloudIq.Api;

/// <summary>
/// The system object.
/// </summary>
public class CloudIQSystem
{
	/// <summary>
	/// Identifier of the system.
	/// </summary>
	[JsonPropertyName("id")]
	public string Id { get; set; } = string.Empty;

	/// <summary>
	/// Unique identifier for the device or appliance.
	/// </summary>
	[JsonPropertyName("system_id")]
	public string? SystemId { get; set; }

	/// <summary>
	/// Type of component.
	/// </summary>
	[JsonPropertyName("system_type")]
	public string? SystemType { get; set; }

	/// <summary>
	/// Impact point of highest impacting issue in the capacity health category.
	/// </summary>
	[JsonPropertyName("capacity_impact")]
	public long? CapacityImpact { get; set; }

	/// <summary>
	/// Total number of issues in the capacity health category.
	/// </summary>
	[JsonPropertyName("capacity_issue_count")]
	public long? CapacityIssueCount { get; set; }

	/// <summary>
	/// Name of the city where the system is located.
	/// </summary>
	[JsonPropertyName("city")]
	public string? City { get; set; }

	/// <summary>
	/// Impact point of highest impacting issue in the configuration health category.
	/// </summary>
	[JsonPropertyName("configuration_impact")]
	public long? ConfigurationImpact { get; set; }

	/// <summary>
	/// Total number of issues in the configuration health category.
	/// </summary>
	[JsonPropertyName("configuration_issue_count")]
	public long? ConfigurationIssueCount { get; set; }

	/// <summary>
	/// Connectivity status.
	/// </summary>
	[JsonPropertyName("connectivity_status")]
	public string? ConnectivityStatus { get; set; }

	/// <summary>
	/// Type of the service contract of the system.
	/// </summary>
	[JsonPropertyName("contract_coverage_type")]
	public string? ContractCoverageType { get; set; }

	/// <summary>
	/// Expiration date for the service contract of the system.
	/// </summary>
	[JsonPropertyName("contract_expiration_date_timestamp")]
	public long? ContractExpirationDateTimestamp { get; set; }

	/// <summary>
	/// The contract number
	/// </summary>
	[JsonPropertyName("contract_number")]
	public string? ContractNumber { get; set; }

	/// <summary>
	/// Name of the country where the system is located.
	/// </summary>
	[JsonPropertyName("country")]
	public string? Country { get; set; }

	/// <summary>
	/// Impact point of highest impacting issue in the data protection health category.
	/// </summary>
	[JsonPropertyName("data_protection_impact")]
	public long? DataProtectionImpact { get; set; }

	/// <summary>
	/// Total number of issues in the data protection health category.
	/// </summary>
	[JsonPropertyName("data_protection_issue_count")]
	public long? DataProtectionIssueCount { get; set; }

	/// <summary>
	/// Unique identifier for the system.
	/// </summary>
	[JsonPropertyName("display_identifier")]
	public string? DisplayIdentifier { get; set; }

	/// <summary>
	/// Health connectivity status.
	/// </summary>
	[JsonPropertyName("health_connectivity_status")]
	public string? HealthConnectivityStatus { get; set; }

	/// <summary>
	/// Total amount of health issues.
	/// </summary>
	[JsonPropertyName("health_issue_count")]
	public long? HealthIssueCount { get; set; }

	/// <summary>
	/// Health score of the system.
	/// </summary>
	[JsonPropertyName("health_score")]
	public long? HealthScore { get; set; }

	/// <summary>
	/// Health state of the system.
	/// </summary>
	[JsonPropertyName("health_state")]
	public string? HealthState { get; set; }

	/// <summary>
	/// IPv4 address of the system.
	/// </summary>
	[JsonPropertyName("ipv4_address")]
	public string? Ipv4Address { get; set; }

	/// <summary>
	/// IPv6 address of the system.
	/// </summary>
	[JsonPropertyName("ipv6_address")]
	public string? Ipv6Address { get; set; }

	/// <summary>
	/// Last time that CloudIQ received data from the system.
	/// </summary>
	[JsonPropertyName("last_contact_timestamp")]
	public long? LastContactTimestamp { get; set; }

	/// <summary>
	/// Location where the system can be found.
	/// </summary>
	[JsonPropertyName("location")]
	public string? Location { get; set; }

	/// <summary>
	/// Model of the system.
	/// </summary>
	[JsonPropertyName("model")]
	public string? Model { get; set; }

	/// <summary>
	/// Name of the system.
	/// </summary>
	[JsonPropertyName("object_name")]
	public string? ObjectName { get; set; }

	/// <summary>
	/// Impact point of highest impacting issue in the performance health category.
	/// </summary>
	[JsonPropertyName("performance_impact")]
	public long? PerformanceImpact { get; set; }

	/// <summary>
	/// Total number of issues in the performance health category.
	/// </summary>
	[JsonPropertyName("performance_issue_count")]
	public long? PerformanceIssueCount { get; set; }

	/// <summary>
	/// Serial number of the component.
	/// </summary>
	[JsonPropertyName("serial_number")]
	public string? SerialNumber { get; set; }

	/// <summary>
	/// Name of the site where the system is located.
	/// </summary>
	[JsonPropertyName("site_name")]
	public string? SiteName { get; set; }

	/// <summary>
	/// Name of the state where the system is located.
	/// </summary>
	[JsonPropertyName("state")]
	public string? State { get; set; }

	/// <summary>
	/// Street address 1 of where the system is located.
	/// </summary>
	[JsonPropertyName("street_address_1")]
	public string? StreetAddress1 { get; set; }

	/// <summary>
	/// Street address 2 of where the system is located.
	/// </summary>
	[JsonPropertyName("street_address_2")]
	public string? StreetAddress2 { get; set; }

	/// <summary>
	/// Health impact for the system.
	/// </summary>
	[JsonPropertyName("system_health_impact")]
	public long? SystemHealthImpact { get; set; }

	/// <summary>
	/// Total amount of health issues for the system.
	/// </summary>
	[JsonPropertyName("system_health_issue_count")]
	public long? SystemHealthIssueCount { get; set; }

	/// <summary>
	/// User defined tags.
	/// </summary>
	[JsonPropertyName("system_tags")]
	public object? SystemTags { get; set; }

	/// <summary>
	/// Type of component.
	/// </summary>
	[JsonPropertyName("type")]
	public string? Type { get; set; }

	/// <summary>
	/// Name of the vendor who makes the component.
	/// </summary>
	[JsonPropertyName("vendor")]
	public string? Vendor { get; set; }

	/// <summary>
	/// Version number of the component.
	/// </summary>
	[JsonPropertyName("version")]
	public string? Version { get; set; }

	/// <summary>
	/// State ZIP code of where the system is located.
	/// </summary>
	[JsonPropertyName("zip_code")]
	public string? ZipCode { get; set; }

	private IDictionary<string, object>? _additionalProperties;

	[JsonExtensionData]
	public IDictionary<string, object> AdditionalProperties
	{
		get { return _additionalProperties ??= new Dictionary<string, object>(); }
		set { _additionalProperties = value; }
	}
}
