namespace Dell.CloudIQ.Api;

/// <summary>
/// The port object.
/// </summary>
public partial class Port
{
	/// <summary>
	/// The port ID.
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
	/// DEPRECATED - Unique identifier for the device or appliance.
	/// </summary>
	[JsonProperty("system", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	[System.Obsolete]
	public string System { get; set; }

	/// <summary>
	/// Type of the system.
	/// </summary>
	[JsonProperty("system_type", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public string SystemType { get; set; }

	/// <summary>
	/// Type of connector.
	/// </summary>
	[JsonProperty("connector_type", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public string ConnectorType { get; set; }

	/// <summary>
	/// Health description for the port.
	/// </summary>
	[JsonProperty("health_description", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public string HealthDescription { get; set; }

	/// <summary>
	/// Health value for the port.
	/// </summary>
	[JsonProperty("health_value", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public string HealthValue { get; set; }

	/// <summary>
	/// Links multiple Ethernet ports to one logical port.
	/// </summary>
	[JsonProperty("link_aggregation", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public bool LinkAggregation { get; set; }

	/// <summary>
	/// Name of the port.
	/// </summary>
	[JsonProperty("object_name", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public string ObjectName { get; set; }

	/// <summary>
	/// Port needs to be replaced.
	/// </summary>
	[JsonProperty("needs_replacement", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public bool NeedsReplacement { get; set; }

	/// <summary>
	/// Type of the object.
	/// </summary>
	[JsonProperty("object_type", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public string ObjectType { get; set; }

	/// <summary>
	/// Number of the port.
	/// </summary>
	[JsonProperty("port_number", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public long PortNumber { get; set; }

	/// <summary>
	/// Status of the port.
	/// </summary>
	[JsonProperty("status", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public string Status { get; set; }

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
	/// Type of the system.
	/// </summary>
	[JsonProperty("type", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public string Type { get; set; }

	/// <summary>
	/// World Wide Name (WWN) or MAC address of the component.
	/// </summary>
	[JsonProperty("wwn_or_mac_address", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public string WwnOrMacAddress { get; set; }

	private IDictionary<string, object> _additionalProperties;

	[JsonExtensionData]
	public IDictionary<string, object> AdditionalProperties
	{
		get { return _additionalProperties ?? (_additionalProperties = new Dictionary<string, object>()); }
		set { _additionalProperties = value; }
	}
}
