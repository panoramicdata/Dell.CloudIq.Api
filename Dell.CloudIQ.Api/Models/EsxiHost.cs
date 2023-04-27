namespace Dell.CloudIQ.Api;

/// <summary>
/// Esxi Host
/// </summary>
public partial class EsxiHost
{
	/// <summary>
	/// Unique identifier of the host.
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
	/// Type of the system, the value should be one of: VXRAIL/VMWARE.
	/// </summary>
	[JsonProperty("system_type", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public string SystemType { get; set; }

	/// <summary>
	/// The appliance serial number of the host, this only applies to VxRail hosts now.
	/// </summary>
	[JsonProperty("appliance_serial_number", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public string ApplianceSerialNumber { get; set; }

	/// <summary>
	/// Model name of the host.
	/// </summary>
	[JsonProperty("model", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public string Model { get; set; }

	/// <summary>
	/// Name of the host or server.
	/// </summary>
	[JsonProperty("object_name", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public string ObjectName { get; set; }

	/// <summary>
	/// Type of the object, the value should be one of: HOST (for VxRail product)/HOST_SYSTEM (for VMWare product type).
	/// </summary>
	[JsonProperty("object_type", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public string ObjectType { get; set; }

	/// <summary>
	/// Seral Number of the host.
	/// </summary>
	[JsonProperty("serial_number", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public string SerialNumber { get; set; }

	/// <summary>
	/// Service Tag of the host.
	/// </summary>
	[JsonProperty("service_tag", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public string ServiceTag { get; set; }

	/// <summary>
	/// OS version of the host.
	/// </summary>
	[JsonProperty("version", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public string Version { get; set; }

	private IDictionary<string, object> _additionalProperties;

	[JsonExtensionData]
	public IDictionary<string, object> AdditionalProperties
	{
		get { return _additionalProperties ?? (_additionalProperties = new Dictionary<string, object>()); }
		set { _additionalProperties = value; }
	}
}
