namespace Dell.CloudIq.Api;

/// <summary>
/// The pool object.
/// </summary>
public class Pool : StorageResourceBase
{
	/// <summary>
	/// Available capacity - Unit: bytes
	/// </summary>
	[JsonPropertyName("free_size")]
	public long? FreeSize { get; set; }

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
	/// Predicted time that the pool will become full.
	/// </summary>
	[JsonPropertyName("time_to_full_prediction")]
	public string? TimeToFullPrediction { get; set; }

	/// <summary>
	/// Percentage of pool capacity that is being used.
	/// </summary>
	[JsonPropertyName("used_percent")]
	public double? UsedPercent { get; set; }
}
