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
	[JsonProperty("system_id", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public string SystemId { get; set; }

	/// <summary>
	/// DEPRECATED - Unique identifier for the system.
	/// </summary>
	[JsonProperty("system", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	[System.Obsolete]
	public string System { get; set; }

	/// <summary>
	/// Type of system.
	/// </summary>
	[JsonProperty("system_type", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public string SystemType { get; set; }

	/// <summary>
	/// Identifier of the site where the system is located.
	/// </summary>
	[JsonProperty("site_id", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public string SiteId { get; set; }

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
	/// Name of the city where the system is located.
	/// </summary>
	[JsonProperty("city", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public string City { get; set; }

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
	/// The cluster connectivity status.
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
	/// The contract number.
	/// </summary>
	[JsonProperty("contract_number", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public string ContractNumber { get; set; }

	/// <summary>
	/// Name of the country where the system is located.
	/// </summary>
	[JsonProperty("country", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public string Country { get; set; }

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
	/// The cluster data center name.
	/// </summary>
	[JsonProperty("datacenter_name", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public string DatacenterName { get; set; }

	/// <summary>
	/// Unique identifier for the system.
	/// </summary>
	[JsonProperty("display_identifier", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public string DisplayIdentifier { get; set; }

	/// <summary>
	/// The HCI mesh role of cluster, including Server, Client, and both, it represents the vSAN Datastore Sharing in CloudIQ, the value should be one of: CLIENT_AND_SERVER/CLIENT_ONLY/SERVER_ONLY/NOT_SUPPORTED (the cluster has a VxRail version which does not support HCI Mesh)/NONE (neither client nor server)/UNAVAILABLE (HCI Mesh info is not collected by telemetry).
	/// </summary>
	[JsonProperty("hci_mesh_type", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public string HciMeshType { get; set; }

	/// <summary>
	/// The cluster health connectivity status.
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
	/// The install time of the current VxRail version.
	/// </summary>
	[JsonProperty("install_timestamp", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public System.DateTimeOffset InstallTimestamp { get; set; }

	/// <summary>
	/// IPv4 address of the system.
	/// </summary>
	[JsonProperty("ipv4_address", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public string Ipv4Address { get; set; }

	/// <summary>
	/// IPv6 address of the system.
	/// </summary>
	[JsonProperty("ipv6_address", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public string Ipv6Address { get; set; }

	/// <summary>
	/// Last time that CloudIQ received data from the system.
	/// </summary>
	[JsonProperty("last_contact_timestamp", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public System.DateTimeOffset LastContactTimestamp { get; set; }

	/// <summary>
	/// Location where the system can be found.
	/// </summary>
	[JsonProperty("location", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public string Location { get; set; }

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
	/// The predicted full date of cluster capacity forecast.
	/// </summary>
	[JsonProperty("predicted_full_date_timestamp", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public System.DateTimeOffset PredictedFullDateTimestamp { get; set; }

	/// <summary>
	/// Serial number of the system.
	/// </summary>
	[JsonProperty("serial_number", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public string SerialNumber { get; set; }

	/// <summary>
	/// Name of the site where the system is located. For multi sites case, the value will be one site name of managing hosts.
	/// </summary>
	[JsonProperty("site_name", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public string SiteName { get; set; }

	/// <summary>
	/// The cluster deployment type property. It is a concatenated cluster type and solution type with underscore. the value should be one of: STANDARD/STANDARD_VVD/STANDARD_VCF/STRETCHED/STRETCHED_VVD/STRETCHED_VCF/TWO_NODE_ROBO/TWO_NODE_ROBO_VVD/TWO_NODE_ROBO_VCF/DIMENTION/DIMENTION_VVD/DIMENTION_VCF/COMPUTE/COMPUTE_VVD/COMPUTE_VCF/UNAVAILABLE.
	/// </summary>
	[JsonProperty("deployment_type", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public string DeploymentType { get; set; }

	/// <summary>
	/// Name of the state where the system is located.
	/// </summary>
	[JsonProperty("state", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public string State { get; set; }

	/// <summary>
	/// The storage free size of cluster - Unit: bytes
	/// </summary>
	[JsonProperty("storage_free_size", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public long StorageFreeSize { get; set; }

	/// <summary>
	/// The storage total size of cluster - Unit: bytes
	/// </summary>
	[JsonProperty("storage_total_size", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public long StorageTotalSize { get; set; }

	/// <summary>
	/// The storage used size of cluster - Unit: bytes
	/// </summary>
	[JsonProperty("storage_used_size", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public long StorageUsedSize { get; set; }

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
	/// Cluster total appliances number.
	/// </summary>
	[JsonProperty("total_appliances", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public long TotalAppliances { get; set; }

	/// <summary>
	/// Cluster total hosts number.
	/// </summary>
	[JsonProperty("total_hosts", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public long TotalHosts { get; set; }

	/// <summary>
	/// Type of system.
	/// </summary>
	[JsonProperty("type", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public string Type { get; set; }

	/// <summary>
	/// The FQDN of vCenter where the cluster is located.
	/// </summary>
	[JsonProperty("vcenter_fqdn", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public string VcenterFqdn { get; set; }

	/// <summary>
	/// License type of vCenter.
	/// </summary>
	[JsonProperty("vcenter_license_type", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public string VcenterLicenseType { get; set; }

	/// <summary>
	/// Version of vCenter where the cluster is located.
	/// </summary>
	[JsonProperty("vcenter_version", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public string VcenterVersion { get; set; }

	/// <summary>
	/// Name of the vendor who makes the system.
	/// </summary>
	[JsonProperty("vendor", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public string Vendor { get; set; }

	/// <summary>
	/// Version number of the system.
	/// </summary>
	[JsonProperty("version", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public string Version { get; set; }

	/// <summary>
	/// Virtual machine count in the cluster.
	/// </summary>
	[JsonProperty("vm_count", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public long VmCount { get; set; }

	/// <summary>
	/// License type of vSAN.
	/// </summary>
	[JsonProperty("vsan_license_type", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public string VsanLicenseType { get; set; }

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
