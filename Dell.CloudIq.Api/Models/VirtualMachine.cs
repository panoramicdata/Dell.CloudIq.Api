namespace Dell.CloudIq.Api;

/// <summary>
/// The virtual machine object.
/// </summary>
public partial class VirtualMachine
{
	/// <summary>
	/// Identifier of the virtual machine.
	/// </summary>
	[JsonProperty("id", Required = Newtonsoft.Json.Required.Always)]
	[Required(AllowEmptyStrings = true)]
	public string Id { get; set; }

	/// <summary>
	/// Unique identifier for the system managing this virtual machine.
	/// </summary>
	[JsonProperty("system_id")]
	public string SystemId { get; set; }

	/// <summary>
	/// Type of the system for the virtual machine, the value should be one of: VXRAIL/VMWARE.
	/// </summary>
	[JsonProperty("system_type")]
	public string SystemType { get; set; }

	/// <summary>
	/// The CPU utilization averaged past 24 hours.
	/// </summary>
	[JsonProperty("cpu_usage_percent")]
	public double CpuUsagePercent { get; set; }

	/// <summary>
	/// User defined tags.
	/// </summary>
	[JsonProperty("tags")]
	public object Tags { get; set; }

	/// <summary>
	/// The memory utilization averaged past 24 hours.
	/// </summary>
	[JsonProperty("memory_usage_percent")]
	public double MemoryUsagePercent { get; set; }

	/// <summary>
	/// Name of the virtual machine.
	/// </summary>
	[JsonProperty("object_name")]
	public string ObjectName { get; set; }

	/// <summary>
	/// Type of the object, which is always VIRTUAL_MACHINE.
	/// </summary>
	[JsonProperty("object_type")]
	public string ObjectType { get; set; }

	/// <summary>
	/// Identifies whether the virtual machine is powered on or off, the value should be one of: POWERED_ON/POWERED_OFF.
	/// </summary>
	[JsonProperty("power_state")]
	public string PowerState { get; set; }

	/// <summary>
	/// User defined tags.
	/// </summary>
	[JsonProperty("system_tags")]
	public object SystemTags { get; set; }

	private IDictionary<string, object> _additionalProperties;

	[JsonExtensionData]
	public IDictionary<string, object> AdditionalProperties
	{
		get { return _additionalProperties ?? (_additionalProperties = new Dictionary<string, object>()); }
		set { _additionalProperties = value; }
	}
}
