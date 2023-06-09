namespace Dell.CloudIq.Api;

/// <summary>
/// The pool object.
/// </summary>
public class Pool
{
	/// <summary>
	/// Identifier of the pool.
	/// </summary>
	[JsonPropertyName("id")]

	public string Id { get; set; } = string.Empty;

	/// <summary>
	/// Unique identifier for the device or appliance.
	/// </summary>
	[JsonPropertyName("system_id")]
	public string? SystemId { get; set; }

	/// <summary>
	/// Type of the system.
	/// </summary>
	[JsonPropertyName("system_type")]
	public string? SystemType { get; set; }

	/// <summary>
	/// Available capacity - Unit: bytes
	/// </summary>
	[JsonPropertyName("free_size")]
	public long? FreeSize { get; set; }

	/// <summary>
	/// Number of health issues that are present on the pool.
	/// </summary>
	[JsonPropertyName("issue_count")]
	public long? IssueCount { get; set; }

	/// <summary>
	/// User defined tags.
	/// </summary>
	[JsonPropertyName("tags")]
	public object? Tags { get; set; }

	/// <summary>
	/// Name of the pool.
	/// </summary>
	[JsonPropertyName("object_name")]
	public string? ObjectName { get; set; }

	/// <summary>
	/// Identifier of the object, defined by the system.
	/// </summary>
	[JsonPropertyName("object_native_id")]
	public string? ObjectNativeId { get; set; }

	/// <summary>
	/// Type of the object, which is always POOL.
	/// </summary>
	[JsonPropertyName("object_type")]
	public string? ObjectType { get; set; }

	/// <summary>
	/// Percentage of pool capacity that is provisioned.
	/// </summary>
	[JsonPropertyName("subscribed_percent")]
	public double? SubscribedPercent { get; set; }

	/// <summary>
	/// Total subscribed capacity of the pool - Unit: bytes
	/// </summary>
	[JsonPropertyName("subscribed_size")]
	public long? SubscribedSize { get; set; }

	/// <summary>
	/// User defined tags.
	/// </summary>
	[JsonPropertyName("system_tags")]
	public object? SystemTags { get; set; }

	/// <summary>
	/// Model of the system.
	/// </summary>
	[JsonPropertyName("system_model")]
	public string? SystemModel { get; set; }

	/// <summary>
	/// Name of the system.
	/// </summary>
	[JsonPropertyName("system_name")]
	public string? SystemName { get; set; }

	/// <summary>
	/// Predicted time that the pool will become full.
	/// </summary>
	[JsonPropertyName("time_to_full_prediction")]
	public string? TimeToFullPrediction { get; set; }

	/// <summary>
	/// Total capacity of the pool - Unit: bytes
	/// </summary>
	[JsonPropertyName("total_size")]
	public long? TotalSize { get; set; }

	/// <summary>
	/// The type of pool.
	/// </summary>
	[JsonPropertyName("type")]
	public string? Type { get; set; }

	/// <summary>
	/// Percentage of pool capacity that is being used.
	/// </summary>
	[JsonPropertyName("used_percent")]
	public double? UsedPercent { get; set; }

	/// <summary>
	/// Capacity of the pool that is being used - Unit: bytes
	/// </summary>
	[JsonPropertyName("used_size")]
	public long? UsedSize { get; set; }

	private IDictionary<string, object>? _additionalProperties;

	[JsonExtensionData]
	public IDictionary<string, object> AdditionalProperties
	{
		get { return _additionalProperties ??= new Dictionary<string, object>(); }
		set { _additionalProperties = value; }
	}
}
