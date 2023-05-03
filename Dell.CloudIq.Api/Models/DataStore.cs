namespace Dell.CloudIq.Api;

/// <summary>
/// The datastore object.
/// </summary>
public partial class DataStore
{
	/// <summary>
	/// Unique identifier of the datastore object.
	/// </summary>
	[JsonPropertyName("id")]
	public string? Id { get; set; } = null;

	/// <summary>
	/// Unique identifier of the system managing this datastore.
	/// </summary>
	[JsonPropertyName("system_id")]
	public string? SystemId { get; set; } = null;

	/// <summary>
	/// System type for the datastore, the value should be one of: VXRAIL/VMWARE.
	/// </summary>
	[JsonPropertyName("system_type")]
	public string? SystemType { get; set; } = null;

	/// <summary>
	/// Path used to connect to the datastore.
	/// </summary>
	[JsonPropertyName("export_path")]
	public string? ExportPath { get; set; } = null;

	/// <summary>
	/// Free size of the datastore - Unit: bytes
	/// </summary>
	[JsonPropertyName("free_size")]
	public long? FreeSize { get; set; } = null;

	/// <summary>
	/// Name of the datastore.
	/// </summary>
	[JsonPropertyName("object_name")]
	public string? ObjectName { get; set; } = null;

	/// <summary>
	/// Type of the object, which is always DATASTORE.
	/// </summary>
	[JsonPropertyName("object_type")]
	public string? ObjectType { get; set; } = null;

	/// <summary>
	/// Total size of the datastore - Unit: bytes
	/// </summary>
	[JsonPropertyName("total_size")]
	public long? TotalSize { get; set; } = null;

	/// <summary>
	/// Type of datastore in vSphere.
	/// </summary>
	[JsonPropertyName("type")]
	public string? Type { get; set; } = null;

	/// <summary>
	/// Percentage of datastore capacity that is being used.
	/// </summary>
	[JsonPropertyName("used_percent")]
	public double? UsedPercent { get; set; } = null;

	/// <summary>
	/// Used size of the datastore - Unit: bytes
	/// </summary>
	[JsonPropertyName("used_size")]
	public long? UsedSize { get; set; } = null;

	private IDictionary<string, object>? _additionalProperties;

	[JsonExtensionData]
	public IDictionary<string, object> AdditionalProperties
	{
		get { return _additionalProperties ?? (_additionalProperties = new Dictionary<string, object>()); }
		set { _additionalProperties = value; }
	}

}
