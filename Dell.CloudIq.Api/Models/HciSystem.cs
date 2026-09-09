namespace Dell.CloudIq.Api;

/// <summary>
/// HCI Systems
/// </summary>
public class HciSystem : CloudIqSystemBase
{
	/// <summary>
	/// Identifier of the site where the system is located.
	/// </summary>
	[JsonPropertyName("site_id")]
	public string? SiteId { get; set; }

	/// <summary>
	/// The contract number.
	/// </summary>
	[JsonPropertyName("contract_number")]
	public string? ContractNumber { get; set; }

	/// <summary>
	/// The cluster data center name.
	/// </summary>
	[JsonPropertyName("datacenter_name")]
	public string? DatacenterName { get; set; }

	/// <summary>
	/// The HCI mesh role of cluster, including Server, Client, and both, it represents the vSAN Datastore Sharing in CloudIQ, the value should be one of: CLIENT_AND_SERVER/CLIENT_ONLY/SERVER_ONLY/NOT_SUPPORTED (the cluster has a VxRail version which does not support HCI Mesh)/NONE (neither client nor server)/UNAVAILABLE (HCI Mesh info is not collected by telemetry).
	/// </summary>
	[JsonPropertyName("hci_mesh_type")]
	public string? HciMeshType { get; set; }

	/// <summary>
	/// The install time of the current VxRail version.
	/// </summary>
	[JsonPropertyName("install_timestamp")]
	public long? InstallTimestamp { get; set; }

	/// <summary>
	/// The predicted full date of cluster capacity forecast.
	/// </summary>
	[JsonPropertyName("predicted_full_date_timestamp")]
	public long? PredictedFullDateTimestamp { get; set; }

	/// <summary>
	/// The cluster deployment type property. It is a concatenated cluster type and solution type with underscore. the value should be one of: STANDARD/STANDARD_VVD/STANDARD_VCF/STRETCHED/STRETCHED_VVD/STRETCHED_VCF/TWO_NODE_ROBO/TWO_NODE_ROBO_VVD/TWO_NODE_ROBO_VCF/DIMENTION/DIMENTION_VVD/DIMENTION_VCF/COMPUTE/COMPUTE_VVD/COMPUTE_VCF/UNAVAILABLE.
	/// </summary>
	[JsonPropertyName("deployment_type")]
	public string? DeploymentType { get; set; }

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
	/// Virtual machine count in the cluster.
	/// </summary>
	[JsonPropertyName("vm_count")]
	public long? VmCount { get; set; }

	/// <summary>
	/// License type of vSAN.
	/// </summary>
	[JsonPropertyName("vsan_license_type")]
	public string? VsanLicenseType { get; set; }
}
