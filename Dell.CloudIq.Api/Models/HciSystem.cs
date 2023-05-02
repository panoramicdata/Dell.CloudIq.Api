namespace Dell.CloudIq.Api;

/// <summary>
/// HCI Systems
/// </summary>
public partial class HciSystem
{
	/// <summary>
	/// Unique identifier for the system.
	/// </summary>
	[JsonProperty("id", Required = Newtonsoft.Json.Required.Always)]
	[Required(AllowEmptyStrings = true)]
	public string Id { get; set; }

	/// <summary>
	/// Unique identifier for the system.
	/// </summary>
	[JsonProperty("system_id")]
	public string SystemId { get; set; }

	/// <summary>
	/// Type of system.
	/// </summary>
	[JsonProperty("system_type")]
	public string SystemType { get; set; }

	/// <summary>
	/// Identifier of the site where the system is located.
	/// </summary>
	[JsonProperty("site_id")]
	public string SiteId { get; set; }

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
	/// The cluster connectivity status.
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
	/// The contract number.
	/// </summary>
	[JsonProperty("contract_number")]
	public string ContractNumber { get; set; }

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
	/// The cluster data center name.
	/// </summary>
	[JsonProperty("datacenter_name")]
	public string DatacenterName { get; set; }

	/// <summary>
	/// Unique identifier for the system.
	/// </summary>
	[JsonProperty("display_identifier")]
	public string DisplayIdentifier { get; set; }

	/// <summary>
	/// The HCI mesh role of cluster, including Server, Client, and both, it represents the vSAN Datastore Sharing in CloudIQ, the value should be one of: CLIENT_AND_SERVER/CLIENT_ONLY/SERVER_ONLY/NOT_SUPPORTED (the cluster has a VxRail version which does not support HCI Mesh)/NONE (neither client nor server)/UNAVAILABLE (HCI Mesh info is not collected by telemetry).
	/// </summary>
	[JsonProperty("hci_mesh_type")]
	public string HciMeshType { get; set; }

	/// <summary>
	/// The cluster health connectivity status.
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
	/// The install time of the current VxRail version.
	/// </summary>
	[JsonProperty("install_timestamp")]
	public System.DateTimeOffset InstallTimestamp { get; set; }

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
	/// The predicted full date of cluster capacity forecast.
	/// </summary>
	[JsonProperty("predicted_full_date_timestamp")]
	public System.DateTimeOffset PredictedFullDateTimestamp { get; set; }

	/// <summary>
	/// Serial number of the system.
	/// </summary>
	[JsonProperty("serial_number")]
	public string SerialNumber { get; set; }

	/// <summary>
	/// Name of the site where the system is located. For multi sites case, the value will be one site name of managing hosts.
	/// </summary>
	[JsonProperty("site_name")]
	public string SiteName { get; set; }

	/// <summary>
	/// The cluster deployment type property. It is a concatenated cluster type and solution type with underscore. the value should be one of: STANDARD/STANDARD_VVD/STANDARD_VCF/STRETCHED/STRETCHED_VVD/STRETCHED_VCF/TWO_NODE_ROBO/TWO_NODE_ROBO_VVD/TWO_NODE_ROBO_VCF/DIMENTION/DIMENTION_VVD/DIMENTION_VCF/COMPUTE/COMPUTE_VVD/COMPUTE_VCF/UNAVAILABLE.
	/// </summary>
	[JsonProperty("deployment_type")]
	public string DeploymentType { get; set; }

	/// <summary>
	/// Name of the state where the system is located.
	/// </summary>
	[JsonProperty("state")]
	public string State { get; set; }

	/// <summary>
	/// The storage free size of cluster - Unit: bytes
	/// </summary>
	[JsonProperty("storage_free_size")]
	public long StorageFreeSize { get; set; }

	/// <summary>
	/// The storage total size of cluster - Unit: bytes
	/// </summary>
	[JsonProperty("storage_total_size")]
	public long StorageTotalSize { get; set; }

	/// <summary>
	/// The storage used size of cluster - Unit: bytes
	/// </summary>
	[JsonProperty("storage_used_size")]
	public long StorageUsedSize { get; set; }

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
	/// Cluster total appliances number.
	/// </summary>
	[JsonProperty("total_appliances")]
	public long TotalAppliances { get; set; }

	/// <summary>
	/// Cluster total hosts number.
	/// </summary>
	[JsonProperty("total_hosts")]
	public long TotalHosts { get; set; }

	/// <summary>
	/// Type of system.
	/// </summary>
	[JsonProperty("type")]
	public string Type { get; set; }

	/// <summary>
	/// The FQDN of vCenter where the cluster is located.
	/// </summary>
	[JsonProperty("vcenter_fqdn")]
	public string VcenterFqdn { get; set; }

	/// <summary>
	/// License type of vCenter.
	/// </summary>
	[JsonProperty("vcenter_license_type")]
	public string VcenterLicenseType { get; set; }

	/// <summary>
	/// Version of vCenter where the cluster is located.
	/// </summary>
	[JsonProperty("vcenter_version")]
	public string VcenterVersion { get; set; }

	/// <summary>
	/// Name of the vendor who makes the system.
	/// </summary>
	[JsonProperty("vendor")]
	public string Vendor { get; set; }

	/// <summary>
	/// Version number of the system.
	/// </summary>
	[JsonProperty("version")]
	public string Version { get; set; }

	/// <summary>
	/// Virtual machine count in the cluster.
	/// </summary>
	[JsonProperty("vm_count")]
	public long VmCount { get; set; }

	/// <summary>
	/// License type of vSAN.
	/// </summary>
	[JsonProperty("vsan_license_type")]
	public string VsanLicenseType { get; set; }

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
