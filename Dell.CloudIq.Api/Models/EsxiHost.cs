namespace Dell.CloudIq.Api;

/// <summary>
/// Esxi Host
/// </summary>
public class EsxiHost
{
	/// <summary>
	/// Unique identifier of the host.
	/// </summary>
	[JsonPropertyName("id")]

	public string Id { get; set; } = string.Empty;

	/// <summary>
	/// Unique identifier for the system.
	/// </summary>
	[JsonPropertyName("system_id")]
	public string? SystemId { get; set; }

	/// <summary>
	/// Type of the system, the value should be one of: VXRAIL/VMWARE.
	/// </summary>
	[JsonPropertyName("system_type")]
	public string? SystemType { get; set; }

	/// <summary>
	/// The appliance serial number of the host, this only applies to VxRail hosts now.
	/// </summary>
	[JsonPropertyName("appliance_serial_number")]
	public string? ApplianceSerialNumber { get; set; }

	/// <summary>
	/// Model name of the host.
	/// </summary>
	[JsonPropertyName("model")]
	public string? Model { get; set; }

	/// <summary>
	/// Name of the host or server.
	/// </summary>
	[JsonPropertyName("object_name")]
	public string? ObjectName { get; set; }

	/// <summary>
	/// Type of the object, the value should be one of: HOST (for VxRail product)/HOST_SYSTEM (for VMWare product type).
	/// </summary>
	[JsonPropertyName("object_type")]
	public string? ObjectType { get; set; }

	/// <summary>
	/// Seral Number of the host.
	/// </summary>
	[JsonPropertyName("serial_number")]
	public string? SerialNumber { get; set; }

	/// <summary>
	/// Service Tag of the host.
	/// </summary>
	[JsonPropertyName("service_tag")]
	public string? ServiceTag { get; set; }

	/// <summary>
	/// OS version of the host.
	/// </summary>
	[JsonPropertyName("version")]
	public string? Version { get; set; }

	private IDictionary<string, object>? _additionalProperties;

	[JsonExtensionData]
	public IDictionary<string, object> AdditionalProperties
	{
		get { return _additionalProperties ??= new Dictionary<string, object>(); }
		set { _additionalProperties = value; }
	}
}
