namespace Dell.CloudIq.Api;

/// <summary>
/// HCI Systems
/// </summary>
public class HciSystem
{
	/// <summary>
	/// Unique identifier for the system.
	/// </summary>
	[JsonPropertyName("id")]

	public string Id { get; set; } = string.Empty;

	/// <summary>
	/// Unique identifier for the system.
	/// </summary>
	[JsonPropertyName("system_id")]
	public string? SystemId { get; set; }

	/// <summary>
	/// Type of system.
	/// </summary>
	[JsonPropertyName("system_type")]
	public string? SystemType { get; set; }

	/// <summary>
	/// Identifier of the site where the system is located.
	/// </summary>
	[JsonPropertyName("site_id")]
	public string? SiteId { get; set; }

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
	/// The cluster connectivity status.
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
	/// The contract number.
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
	/// The cluster data center name.
	/// </summary>
	[JsonPropertyName("datacenter_name")]
	public string? DatacenterName { get; set; }

	/// <summary>
	/// Unique identifier for the system.
	/// </summary>
	[JsonPropertyName("display_identifier")]
	public string? DisplayIdentifier { get; set; }

	/// <summary>
	/// The HCI mesh role of cluster, including Server, Client, and both, it represents the vSAN Datastore Sharing in CloudIQ, the value should be one of: CLIENT_AND_SERVER/CLIENT_ONLY/SERVER_ONLY/NOT_SUPPORTED (the cluster has a VxRail version which does not support HCI Mesh)/NONE (neither client nor server)/UNAVAILABLE (HCI Mesh info is not collected by telemetry).
	/// </summary>
	[JsonPropertyName("hci_mesh_type")]
	public string? HciMeshType { get; set; }

	/// <summary>
	/// The cluster health connectivity status.
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
	/// The install time of the current VxRail version.
	/// </summary>
	[JsonPropertyName("install_timestamp")]
	public long? InstallTimestamp { get; set; }

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
	/// The predicted full date of cluster capacity forecast.
	/// </summary>
	[JsonPropertyName("predicted_full_date_timestamp")]
	public long? PredictedFullDateTimestamp { get; set; }

	/// <summary>
	/// Serial number of the system.
	/// </summary>
	[JsonPropertyName("serial_number")]
	public string? SerialNumber { get; set; }

	/// <summary>
	/// Name of the site where the system is located. For multi sites case, the value will be one site name of managing hosts.
	/// </summary>
	[JsonPropertyName("site_name")]
	public string? SiteName { get; set; }

	/// <summary>
	/// The cluster deployment type property. It is a concatenated cluster type and solution type with underscore. the value should be one of: STANDARD/STANDARD_VVD/STANDARD_VCF/STRETCHED/STRETCHED_VVD/STRETCHED_VCF/TWO_NODE_ROBO/TWO_NODE_ROBO_VVD/TWO_NODE_ROBO_VCF/DIMENTION/DIMENTION_VVD/DIMENTION_VCF/COMPUTE/COMPUTE_VVD/COMPUTE_VCF/UNAVAILABLE.
	/// </summary>
	[JsonPropertyName("deployment_type")]
	public string? DeploymentType { get; set; }

	/// <summary>
	/// Name of the state where the system is located.
	/// </summary>
	[JsonPropertyName("state")]
	public string? State { get; set; }

	/// <summary>
	/// The storage free size of cluster - Unit: bytes
	/// </summary>
	[JsonPropertyName("storage_free_size")]
	public long? StorageFreeSize { get; set; }

	/// <summary>
	/// The storage total size of cluster - Unit: bytes
	/// </summary>
	[JsonPropertyName("storage_total_size")]
	public long? StorageTotalSize { get; set; }

	/// <summary>
	/// The storage used size of cluster - Unit: bytes
	/// </summary>
	[JsonPropertyName("storage_used_size")]
	public long? StorageUsedSize { get; set; }

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
	/// Cluster total appliances number.
	/// </summary>
	[JsonPropertyName("total_appliances")]
	public long? TotalAppliances { get; set; }

	/// <summary>
	/// Cluster total hosts number.
	/// </summary>
	[JsonPropertyName("total_hosts")]
	public long? TotalHosts { get; set; }

	/// <summary>
	/// Type of system.
	/// </summary>
	[JsonPropertyName("type")]
	public string? Type { get; set; }

	/// <summary>
	/// The FQDN of vCenter where the cluster is located.
	/// </summary>
	[JsonPropertyName("vcenter_fqdn")]
	public string? VcenterFqdn { get; set; }

	/// <summary>
	/// License type of vCenter.
	/// </summary>
	[JsonPropertyName("vcenter_license_type")]
	public string? VcenterLicenseType { get; set; }

	/// <summary>
	/// Version of vCenter where the cluster is located.
	/// </summary>
	[JsonPropertyName("vcenter_version")]
	public string? VcenterVersion { get; set; }

	/// <summary>
	/// Name of the vendor who makes the system.
	/// </summary>
	[JsonPropertyName("vendor")]
	public string? Vendor { get; set; }

	/// <summary>
	/// Version number of the system.
	/// </summary>
	[JsonPropertyName("version")]
	public string? Version { get; set; }

	/// <summary>
	/// Virtual machine count in the cluster.
	/// </summary>
	[JsonPropertyName("vm_count")]
	public long? VmCount { get; set; }

	/// <summary>
	/// License type of vSAN.
	/// </summary>
	[JsonPropertyName("vsan_license_type")]
	public string? VsanLicenseType { get; set; }

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
