namespace Dell.CloudIq.Api;

/// <summary>
/// The host object.
/// </summary>
public partial class Host
{
	/// <summary>
	/// Host identifier.
	/// </summary>
	[JsonProperty("id", Required = Newtonsoft.Json.Required.Always)]
	[Required(AllowEmptyStrings = true)]
	public string Id { get; set; }

	/// <summary>
	/// Unique identifier for the device or appliance.
	/// </summary>
	[JsonProperty("system_id", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public string SystemId { get; set; }

	/// <summary>
	/// Product type of the system.
	/// </summary>
	[JsonProperty("system_type", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public string SystemType { get; set; }

	/// <summary>
	/// Description of the host.
	/// </summary>
	[JsonProperty("description", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public string Description { get; set; }

	/// <summary>
	/// Number of initiators that are connected between the host or server and the monitored system.
	/// </summary>
	[JsonProperty("initiator_count", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public long InitiatorCount { get; set; }

	/// <summary>
	/// Type of initiator (FC or iSCSI) that the host or server uses to connect to a monitored system.
	/// </summary>
	[JsonProperty("initiator_protocol", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public string InitiatorProtocol { get; set; }

	/// <summary>
	/// Number of health issues that are present on the host or server.
	/// </summary>
	[JsonProperty("issue_count", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public long IssueCount { get; set; }

	/// <summary>
	/// User defined tags.
	/// </summary>
	[JsonProperty("tags", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public object Tags { get; set; }

	/// <summary>
	/// Name of the host or server.
	/// </summary>
	[JsonProperty("object_name", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public string ObjectName { get; set; }

	/// <summary>
	/// Identifier of the object, defined by the system.
	/// </summary>
	[JsonProperty("object_native_id", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public string ObjectNativeId { get; set; }

	/// <summary>
	/// IPv4 or IPv6 IP addresses, domain names, or netgroup name associated with the host or server.
	/// </summary>
	[JsonProperty("network_addresses", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public string NetworkAddresses { get; set; }

	/// <summary>
	/// Type of the object.
	/// </summary>
	[JsonProperty("object_type", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public string ObjectType { get; set; }

	/// <summary>
	/// Operating system of the host or server.
	/// </summary>
	[JsonProperty("operating_system", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public string OperatingSystem { get; set; }

	/// <summary>
	/// User defined tags.
	/// </summary>
	[JsonProperty("system_tags", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public object SystemTags { get; set; }

	/// <summary>
	/// Model of the system.
	/// </summary>
	[JsonProperty("system_model", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public string SystemModel { get; set; }

	/// <summary>
	/// Name of the system.
	/// </summary>
	[JsonProperty("system_name", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public string SystemName { get; set; }

	/// <summary>
	/// Total size of all LUNs or Volumes that are provisioned to the host or server from the system - Unit: bytes
	/// </summary>
	[JsonProperty("total_size", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public long TotalSize { get; set; }

	private IDictionary<string, object> _additionalProperties;

	[JsonExtensionData]
	public IDictionary<string, object> AdditionalProperties
	{
		get { return _additionalProperties ?? (_additionalProperties = new Dictionary<string, object>()); }
		set { _additionalProperties = value; }
	}
}
