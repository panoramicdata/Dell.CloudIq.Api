namespace Dell.CloudIq.Api;

/// <summary>
/// The properties every storage resource reports: what it is, which system it belongs to, and how
/// much of it is used.
/// </summary>
public abstract class StorageResourceBase : CloudIqModel
{
	/// <summary>
	/// Identifier of the file system.
	/// </summary>
	[JsonPropertyName("id")]
	public string Id { get; set; } = string.Empty;

	/// <summary>
	/// Unique identifier for the device or appliance.
	/// </summary>
	[JsonPropertyName("system_id")]
	public string? SystemId { get; set; }

	/// <summary>
	/// The system type for the file system.
	/// </summary>
	[JsonPropertyName("system_type")]
	public string? SystemType { get; set; }

	/// <summary>
	/// Number of health issues that are present on the file system.
	/// </summary>
	[JsonPropertyName("issue_count")]
	public long? IssueCount { get; set; }

	/// <summary>
	/// User defined tags.
	/// </summary>
	[JsonPropertyName("tags")]
	public object? Tags { get; set; }

	/// <summary>
	/// Name of the file system.
	/// </summary>
	[JsonPropertyName("object_name")]
	public string? ObjectName { get; set; }

	/// <summary>
	/// Identifier of the object, defined by the system.
	/// </summary>
	[JsonPropertyName("object_native_id")]
	public string? ObjectNativeId { get; set; }

	/// <summary>
	/// Type of the object.
	/// </summary>
	[JsonPropertyName("object_type")]
	public string? ObjectType { get; set; }

	/// <summary>
	/// User defined tags.
	/// </summary>
	[JsonPropertyName("system_tags")]
	public object? SystemTags { get; set; }

	/// <summary>
	/// The model of the system for the file system.
	/// </summary>
	[JsonPropertyName("system_model")]
	public string? SystemModel { get; set; }

	/// <summary>
	/// The name of the system.
	/// </summary>
	[JsonPropertyName("system_name")]
	public string? SystemName { get; set; }

	/// <summary>
	/// The total size of the file system - Unit: bytes
	/// </summary>
	[JsonPropertyName("total_size")]
	public long? TotalSize { get; set; }

	/// <summary>
	/// The type of the file system.
	/// </summary>
	[JsonPropertyName("type")]
	public string? Type { get; set; }

	/// <summary>
	/// Size used for the file system - Unit: bytes
	/// </summary>
	[JsonPropertyName("used_size")]
	public long? UsedSize { get; set; }
}
