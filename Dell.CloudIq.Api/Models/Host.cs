namespace Dell.CloudIq.Api;

/// <summary>
/// The host object.
/// </summary>
public partial class Host
{
	/// <summary>
	/// Host identifier.
	/// </summary>
	[JsonPropertyName("id")]
	
	public string? Id { get; set; } = null;

	/// <summary>
	/// Unique identifier for the device or appliance.
	/// </summary>
	[JsonPropertyName("system_id")]
	public string? SystemId { get; set; } = null;

	/// <summary>
	/// Product type of the system.
	/// </summary>
	[JsonPropertyName("system_type")]
	public string? SystemType { get; set; } = null;

	/// <summary>
	/// Description of the host.
	/// </summary>
	[JsonPropertyName("description")]
	public string? Description { get; set; } = null;

	/// <summary>
	/// Number of initiators that are connected between the host or server and the monitored system.
	/// </summary>
	[JsonPropertyName("initiator_count")]
	public long? InitiatorCount { get; set; } = null;

	/// <summary>
	/// Type of initiator (FC or iSCSI) that the host or server uses to connect to a monitored system.
	/// </summary>
	[JsonPropertyName("initiator_protocol")]
	public string? InitiatorProtocol { get; set; } = null;

	/// <summary>
	/// Number of health issues that are present on the host or server.
	/// </summary>
	[JsonPropertyName("issue_count")]
	public long? IssueCount { get; set; } = null;

	/// <summary>
	/// User defined tags.
	/// </summary>
	[JsonPropertyName("tags")]
	public object? Tags { get; set; } = null;

	/// <summary>
	/// Name of the host or server.
	/// </summary>
	[JsonPropertyName("object_name")]
	public string? ObjectName { get; set; } = null;

	/// <summary>
	/// Identifier of the object, defined by the system.
	/// </summary>
	[JsonPropertyName("object_native_id")]
	public string? ObjectNativeId { get; set; } = null;

	/// <summary>
	/// IPv4 or IPv6 IP addresses, domain names, or netgroup name associated with the host or server.
	/// </summary>
	[JsonPropertyName("network_addresses")]
	public string? NetworkAddresses { get; set; } = null;

	/// <summary>
	/// Type of the object.
	/// </summary>
	[JsonPropertyName("object_type")]
	public string? ObjectType { get; set; } = null;

	/// <summary>
	/// Operating system of the host or server.
	/// </summary>
	[JsonPropertyName("operating_system")]
	public string? OperatingSystem { get; set; } = null;

	/// <summary>
	/// User defined tags.
	/// </summary>
	[JsonPropertyName("system_tags")]
	public object? SystemTags { get; set; } = null;

	/// <summary>
	/// Model of the system.
	/// </summary>
	[JsonPropertyName("system_model")]
	public string? SystemModel { get; set; } = null;

	/// <summary>
	/// Name of the system.
	/// </summary>
	[JsonPropertyName("system_name")]
	public string? SystemName { get; set; } = null;

	/// <summary>
	/// Total size of all LUNs or Volumes that are provisioned to the host or server from the system - Unit: bytes
	/// </summary>
	[JsonPropertyName("total_size")]
	public long? TotalSize { get; set; } = null;

	private IDictionary<string, object>? _additionalProperties;

	[JsonExtensionData]
	public IDictionary<string, object> AdditionalProperties
	{
		get { return _additionalProperties ??= new Dictionary<string, object>(); }
		set { _additionalProperties = value; }
	}
}
