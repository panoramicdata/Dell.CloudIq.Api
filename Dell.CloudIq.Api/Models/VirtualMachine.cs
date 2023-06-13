namespace Dell.CloudIq.Api;

/// <summary>
/// The virtual machine object.
/// </summary>
public class VirtualMachine
{
	/// <summary>
	/// Identifier of the virtual machine.
	/// </summary>
	[JsonPropertyName("id")]

	public string Id { get; set; } = string.Empty;

	/// <summary>
	/// Unique identifier for the system managing this virtual machine.
	/// </summary>
	[JsonPropertyName("system_id")]
	public string? SystemId { get; set; }

	/// <summary>
	/// Type of the system for the virtual machine, the value should be one of: VXRAIL/VMWARE.
	/// </summary>
	[JsonPropertyName("system_type")]
	public string? SystemType { get; set; }

	/// <summary>
	/// The CPU utilization averaged past 24 hours.
	/// </summary>
	[JsonPropertyName("cpu_usage_percent")]
	public double? CpuUsagePercent { get; set; }

	/// <summary>
	/// User defined tags.
	/// </summary>
	[JsonPropertyName("tags")]
	public object? Tags { get; set; }

	/// <summary>
	/// The memory utilization averaged past 24 hours.
	/// </summary>
	[JsonPropertyName("memory_usage_percent")]
	public double? MemoryUsagePercent { get; set; }

	/// <summary>
	/// Name of the virtual machine.
	/// </summary>
	[JsonPropertyName("object_name")]
	public string? ObjectName { get; set; }

	/// <summary>
	/// Type of the object, which is always VIRTUAL_MACHINE.
	/// </summary>
	[JsonPropertyName("object_type")]
	public string? ObjectType { get; set; }

	/// <summary>
	/// Identifies whether the virtual machine is powered on or off, the value should be one of: POWERED_ON/POWERED_OFF.
	/// </summary>
	[JsonPropertyName("power_state")]
	public string? PowerState { get; set; }

	/// <summary>
	/// User defined tags.
	/// </summary>
	[JsonPropertyName("system_tags")]
	public object? SystemTags { get; set; }

	private IDictionary<string, object>? _additionalProperties;

	[JsonExtensionData]
	public IDictionary<string, object> AdditionalProperties
	{
		get { return _additionalProperties ??= new Dictionary<string, object>(); }
		set { _additionalProperties = value; }
	}
}
