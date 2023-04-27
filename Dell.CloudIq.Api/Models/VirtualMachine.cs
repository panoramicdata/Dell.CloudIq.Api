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
	[JsonProperty("system_id", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public string SystemId { get; set; }

	/// <summary>
	/// DEPRECATED - Unique identifier for the system managing this virtual machine.
	/// </summary>
	[JsonProperty("system", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	[System.Obsolete]
	public string System { get; set; }

	/// <summary>
	/// Type of the system for the virtual machine, the value should be one of: VXRAIL/VMWARE.
	/// </summary>
	[JsonProperty("system_type", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public string SystemType { get; set; }

	/// <summary>
	/// The CPU utilization averaged past 24 hours.
	/// </summary>
	[JsonProperty("cpu_usage_percent", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public double CpuUsagePercent { get; set; }

	/// <summary>
	/// User defined tags.
	/// </summary>
	[JsonProperty("tags", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public object Tags { get; set; }

	/// <summary>
	/// The memory utilization averaged past 24 hours.
	/// </summary>
	[JsonProperty("memory_usage_percent", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public double MemoryUsagePercent { get; set; }

	/// <summary>
	/// Name of the virtual machine.
	/// </summary>
	[JsonProperty("object_name", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public string ObjectName { get; set; }

	/// <summary>
	/// Type of the object, which is always VIRTUAL_MACHINE.
	/// </summary>
	[JsonProperty("object_type", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public string ObjectType { get; set; }

	/// <summary>
	/// Identifies whether the virtual machine is powered on or off, the value should be one of: POWERED_ON/POWERED_OFF.
	/// </summary>
	[JsonProperty("power_state", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public string PowerState { get; set; }

	/// <summary>
	/// User defined tags.
	/// </summary>
	[JsonProperty("system_tags", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public object SystemTags { get; set; }

	private IDictionary<string, object> _additionalProperties;

	[JsonExtensionData]
	public IDictionary<string, object> AdditionalProperties
	{
		get { return _additionalProperties ?? (_additionalProperties = new Dictionary<string, object>()); }
		set { _additionalProperties = value; }
	}
}
