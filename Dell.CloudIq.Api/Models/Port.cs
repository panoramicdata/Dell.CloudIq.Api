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

	public string? Id { get; set; } = null;

	/// <summary>
	/// Unique identifier for the device or appliance.
	/// </summary>
	[JsonPropertyName("system_id")]
	public string? SystemId { get; set; } = null;

	/// <summary>
	/// Type of the system.
	/// </summary>
	[JsonPropertyName("system_type")]
	public string? SystemType { get; set; } = null;

	/// <summary>
	/// Type of connector.
	/// </summary>
	[JsonPropertyName("connector_type")]
	public string? ConnectorType { get; set; } = null;

	/// <summary>
	/// Health description for the port.
	/// </summary>
	[JsonPropertyName("health_description")]
	public string? HealthDescription { get; set; } = null;

	/// <summary>
	/// Health value for the port.
	/// </summary>
	[JsonPropertyName("health_value")]
	public string? HealthValue { get; set; } = null;

	/// <summary>
	/// Links multiple Ethernet ports to one logical port.
	/// </summary>
	[JsonPropertyName("link_aggregation")]
	public bool? LinkAggregation { get; set; } = null;

	/// <summary>
	/// Name of the port.
	/// </summary>
	[JsonPropertyName("object_name")]
	public string? ObjectName { get; set; } = null;

	/// <summary>
	/// Port needs to be replaced.
	/// </summary>
	[JsonPropertyName("needs_replacement")]
	public bool? NeedsReplacement { get; set; } = null;

	/// <summary>
	/// Type of the object.
	/// </summary>
	[JsonPropertyName("object_type")]
	public string? ObjectType { get; set; } = null;

	/// <summary>
	/// Number of the port.
	/// </summary>
	[JsonPropertyName("port_number")]
	public long? PortNumber { get; set; } = null;

	/// <summary>
	/// Status of the port.
	/// </summary>
	[JsonPropertyName("status")]
	public string? Status { get; set; } = null;

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
	/// Type of the system.
	/// </summary>
	[JsonPropertyName("type")]
	public string? Type { get; set; } = null;

	/// <summary>
	/// World Wide Name (WWN) or MAC address of the component.
	/// </summary>
	[JsonPropertyName("wwn_or_mac_address")]
	public string? WwnOrMacAddress { get; set; } = null;

	private IDictionary<string, object>? _additionalProperties;

	[JsonExtensionData]
	public IDictionary<string, object> AdditionalProperties
	{
		get { return _additionalProperties ??= new Dictionary<string, object>(); }
		set { _additionalProperties = value; }
	}
}
