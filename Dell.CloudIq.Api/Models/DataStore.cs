namespace Dell.CloudIq.Api;

/// <summary>
/// The datastore object.
/// </summary>
public partial class DataStore
{
	/// <summary>
	/// Unique identifier of the datastore object.
	/// </summary>
	[JsonProperty("id", Required = Newtonsoft.Json.Required.Always)]
	[Required(AllowEmptyStrings = true)]
	public string Id { get; set; }

	/// <summary>
	/// Unique identifier of the system managing this datastore.
	/// </summary>
	[JsonProperty("system_id")]
	public string SystemId { get; set; }

	/// <summary>
	/// System type for the datastore, the value should be one of: VXRAIL/VMWARE.
	/// </summary>
	[JsonProperty("system_type")]
	public string SystemType { get; set; }

	/// <summary>
	/// Path used to connect to the datastore.
	/// </summary>
	[JsonProperty("export_path")]
	public string ExportPath { get; set; }

	/// <summary>
	/// Free size of the datastore - Unit: bytes
	/// </summary>
	[JsonProperty("free_size")]
	public long FreeSize { get; set; }

	/// <summary>
	/// Name of the datastore.
	/// </summary>
	[JsonProperty("object_name")]
	public string ObjectName { get; set; }

	/// <summary>
	/// Type of the object, which is always DATASTORE.
	/// </summary>
	[JsonProperty("object_type")]
	public string ObjectType { get; set; }

	/// <summary>
	/// Total size of the datastore - Unit: bytes
	/// </summary>
	[JsonProperty("total_size")]
	public long TotalSize { get; set; }

	/// <summary>
	/// Type of datastore in vSphere.
	/// </summary>
	[JsonProperty("type")]
	public string Type { get; set; }

	/// <summary>
	/// Percentage of datastore capacity that is being used.
	/// </summary>
	[JsonProperty("used_percent")]
	public double UsedPercent { get; set; }

	/// <summary>
	/// Used size of the datastore - Unit: bytes
	/// </summary>
	[JsonProperty("used_size")]
	public long UsedSize { get; set; }

	private IDictionary<string, object> _additionalProperties;

	[JsonExtensionData]
	public IDictionary<string, object> AdditionalProperties
	{
		get { return _additionalProperties ?? (_additionalProperties = new Dictionary<string, object>()); }
		set { _additionalProperties = value; }
	}

}
