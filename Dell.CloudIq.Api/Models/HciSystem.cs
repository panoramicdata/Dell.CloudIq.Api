namespace Dell.CloudIq.Api;

/// <summary>
/// HCI Systems
/// </summary>
public partial class HciSystem
{
	/// <summary>
	/// Unique identifier for the system.
	/// </summary>
	[JsonPropertyName("id")]

	public string? Id { get; set; } = null;

	/// <summary>
	/// Unique identifier for the system.
	/// </summary>
	[JsonPropertyName("system_id")]
	public string? SystemId { get; set; } = null;

	/// <summary>
	/// Type of system.
	/// </summary>
	[JsonPropertyName("system_type")]
	public string? SystemType { get; set; } = null;

	/// <summary>
	/// Identifier of the site where the system is located.
	/// </summary>
	[JsonPropertyName("site_id")]
	public string? SiteId { get; set; } = null;

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
	/// The cluster connectivity status.
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
	/// The contract number.
	/// </summary>
	[JsonPropertyName("contract_number")]
	public string? ContractNumber { get; set; } = null;

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
	/// The cluster data center name.
	/// </summary>
	[JsonPropertyName("datacenter_name")]
	public string? DatacenterName { get; set; } = null;

	/// <summary>
	/// Unique identifier for the system.
	/// </summary>
	[JsonPropertyName("display_identifier")]
	public string? DisplayIdentifier { get; set; } = null;

	/// <summary>
	/// The HCI mesh role of cluster, including Server, Client, and both, it represents the vSAN Datastore Sharing in CloudIQ, the value should be one of: CLIENT_AND_SERVER/CLIENT_ONLY/SERVER_ONLY/NOT_SUPPORTED (the cluster has a VxRail version which does not support HCI Mesh)/NONE (neither client nor server)/UNAVAILABLE (HCI Mesh info is not collected by telemetry).
	/// </summary>
	[JsonPropertyName("hci_mesh_type")]
	public string? HciMeshType { get; set; } = null;

	/// <summary>
	/// The cluster health connectivity status.
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
	/// The install time of the current VxRail version.
	/// </summary>
	[JsonPropertyName("install_timestamp")]
	public long? InstallTimestamp { get; set; } = null;

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
	/// The predicted full date of cluster capacity forecast.
	/// </summary>
	[JsonPropertyName("predicted_full_date_timestamp")]
	public long? PredictedFullDateTimestamp { get; set; } = null;

	/// <summary>
	/// Serial number of the system.
	/// </summary>
	[JsonPropertyName("serial_number")]
	public string? SerialNumber { get; set; } = null;

	/// <summary>
	/// Name of the site where the system is located. For multi sites case, the value will be one site name of managing hosts.
	/// </summary>
	[JsonPropertyName("site_name")]
	public string? SiteName { get; set; } = null;

	/// <summary>
	/// The cluster deployment type property. It is a concatenated cluster type and solution type with underscore. the value should be one of: STANDARD/STANDARD_VVD/STANDARD_VCF/STRETCHED/STRETCHED_VVD/STRETCHED_VCF/TWO_NODE_ROBO/TWO_NODE_ROBO_VVD/TWO_NODE_ROBO_VCF/DIMENTION/DIMENTION_VVD/DIMENTION_VCF/COMPUTE/COMPUTE_VVD/COMPUTE_VCF/UNAVAILABLE.
	/// </summary>
	[JsonPropertyName("deployment_type")]
	public string? DeploymentType { get; set; } = null;

	/// <summary>
	/// Name of the state where the system is located.
	/// </summary>
	[JsonPropertyName("state")]
	public string? State { get; set; } = null;

	/// <summary>
	/// The storage free size of cluster - Unit: bytes
	/// </summary>
	[JsonPropertyName("storage_free_size")]
	public long? StorageFreeSize { get; set; } = null;

	/// <summary>
	/// The storage total size of cluster - Unit: bytes
	/// </summary>
	[JsonPropertyName("storage_total_size")]
	public long? StorageTotalSize { get; set; } = null;

	/// <summary>
	/// The storage used size of cluster - Unit: bytes
	/// </summary>
	[JsonPropertyName("storage_used_size")]
	public long? StorageUsedSize { get; set; } = null;

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
	/// Cluster total appliances number.
	/// </summary>
	[JsonPropertyName("total_appliances")]
	public long? TotalAppliances { get; set; } = null;

	/// <summary>
	/// Cluster total hosts number.
	/// </summary>
	[JsonPropertyName("total_hosts")]
	public long? TotalHosts { get; set; } = null;

	/// <summary>
	/// Type of system.
	/// </summary>
	[JsonPropertyName("type")]
	public string? Type { get; set; } = null;

	/// <summary>
	/// The FQDN of vCenter where the cluster is located.
	/// </summary>
	[JsonPropertyName("vcenter_fqdn")]
	public string? VcenterFqdn { get; set; } = null;

	/// <summary>
	/// License type of vCenter.
	/// </summary>
	[JsonPropertyName("vcenter_license_type")]
	public string? VcenterLicenseType { get; set; } = null;

	/// <summary>
	/// Version of vCenter where the cluster is located.
	/// </summary>
	[JsonPropertyName("vcenter_version")]
	public string? VcenterVersion { get; set; } = null;

	/// <summary>
	/// Name of the vendor who makes the system.
	/// </summary>
	[JsonPropertyName("vendor")]
	public string? Vendor { get; set; } = null;

	/// <summary>
	/// Version number of the system.
	/// </summary>
	[JsonPropertyName("version")]
	public string? Version { get; set; } = null;

	/// <summary>
	/// Virtual machine count in the cluster.
	/// </summary>
	[JsonPropertyName("vm_count")]
	public long? VmCount { get; set; } = null;

	/// <summary>
	/// License type of vSAN.
	/// </summary>
	[JsonPropertyName("vsan_license_type")]
	public string? VsanLicenseType { get; set; } = null;

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
