namespace Dell.CloudIq.Api;

/// <summary>
/// The port object.
/// </summary>
public partial class Port
{
	/// <summary>
	/// The port ID.
	/// </summary>
	[JsonPropertyName("id")]
	
	public string Id { get; set; }

	/// <summary>
	/// Unique identifier for the device or appliance.
	/// </summary>
	[JsonPropertyName("system_id")]
	public string SystemId { get; set; }

	/// <summary>
	/// Type of the system.
	/// </summary>
	[JsonPropertyName("system_type")]
	public string SystemType { get; set; }

	/// <summary>
	/// Type of connector.
	/// </summary>
	[JsonPropertyName("connector_type")]
	public string ConnectorType { get; set; }

	/// <summary>
	/// Health description for the port.
	/// </summary>
	[JsonPropertyName("health_description")]
	public string HealthDescription { get; set; }

	/// <summary>
	/// Health value for the port.
	/// </summary>
	[JsonPropertyName("health_value")]
	public string HealthValue { get; set; }

	/// <summary>
	/// Links multiple Ethernet ports to one logical port.
	/// </summary>
	[JsonPropertyName("link_aggregation")]
	public bool LinkAggregation { get; set; }

	/// <summary>
	/// Name of the port.
	/// </summary>
	[JsonPropertyName("object_name")]
	public string ObjectName { get; set; }

	/// <summary>
	/// Port needs to be replaced.
	/// </summary>
	[JsonPropertyName("needs_replacement")]
	public bool NeedsReplacement { get; set; }

	/// <summary>
	/// Type of the object.
	/// </summary>
	[JsonPropertyName("object_type")]
	public string ObjectType { get; set; }

	/// <summary>
	/// Number of the port.
	/// </summary>
	[JsonPropertyName("port_number")]
	public long PortNumber { get; set; }

	/// <summary>
	/// Status of the port.
	/// </summary>
	[JsonPropertyName("status")]
	public string Status { get; set; }

	/// <summary>
	/// Model of the system.
	/// </summary>
	[JsonPropertyName("system_model")]
	public string SystemModel { get; set; }

	/// <summary>
	/// Name of the system.
	/// </summary>
	[JsonPropertyName("system_name")]
	public string SystemName { get; set; }

	/// <summary>
	/// Type of the system.
	/// </summary>
	[JsonPropertyName("type")]
	public string Type { get; set; }

	/// <summary>
	/// World Wide Name (WWN) or MAC address of the component.
	/// </summary>
	[JsonPropertyName("wwn_or_mac_address")]
	public string WwnOrMacAddress { get; set; }

	private IDictionary<string, object> _additionalProperties;

	[JsonExtensionData]
	public IDictionary<string, object> AdditionalProperties
	{
		get { return _additionalProperties ?? (_additionalProperties = new Dictionary<string, object>()); }
		set { _additionalProperties = value; }
	}
}
