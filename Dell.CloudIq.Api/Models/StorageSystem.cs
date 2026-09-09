namespace Dell.CloudIq.Api;

/// <summary>
/// The storage system.
/// </summary>
public class StorageSystem : CloudIqSystemBase
{
	/// <summary>
	/// The system bandwidth. Aggregated for a rolling average over the last 24 hours - Unit: bytes/s
	/// </summary>
	[JsonPropertyName("bandwidth")]
	public long? Bandwidth { get; set; }

	/// <summary>
	/// Storage efficiency ratio of data which has compression applied to it on the system.
	/// </summary>
	[JsonPropertyName("compression_savings")]
	public double? CompressionSavings { get; set; }

	/// <summary>
	/// The configured size for this system - Unit: bytes
	/// </summary>
	[JsonPropertyName("configured_size")]
	public long? ConfiguredSize { get; set; }

	/// <summary>
	/// The %free capacity.
	/// </summary>
	[JsonPropertyName("free_percent")]
	public double? FreePercent { get; set; }

	/// <summary>
	/// The free size value - Unit: bytes
	/// </summary>
	[JsonPropertyName("free_size")]
	public long? FreeSize { get; set; }

	/// <summary>
	/// The IOPS for the system. Aggregated for a rolling average over the last 24 hours - Unit: IO/s
	/// </summary>
	[JsonPropertyName("iops")]
	public long? Iops { get; set; }

	/// <summary>
	/// The latency for the system. Aggregated for a rolling average over the last 24 hours - Unit: microseconds
	/// </summary>
	[JsonPropertyName("latency")]
	public long? Latency { get; set; }

	/// <summary>
	/// The logical size written - Unit: bytes
	/// </summary>
	[JsonPropertyName("logical_size")]
	public long? LogicalSize { get; set; }

	/// <summary>
	/// The overall system-level storage efficiency ratio based on Thin, Snapshots, Deduplication, and Data Reduction.
	/// </summary>
	[JsonPropertyName("overall_efficiency")]
	public double? OverallEfficiency { get; set; }

	/// <summary>
	/// The snaps savings for this system.
	/// </summary>
	[JsonPropertyName("snaps_savings")]
	public double? SnapsSavings { get; set; }

	/// <summary>
	/// The savings due to thin provisioning.
	/// </summary>
	[JsonPropertyName("thin_savings")]
	public double? ThinSavings { get; set; }

	/// <summary>
	/// The total size of the system - Unit: bytes
	/// </summary>
	[JsonPropertyName("total_size")]
	public long? TotalSize { get; set; }

	/// <summary>
	/// The unconfigured capacity for this system - Unit: bytes
	/// </summary>
	[JsonPropertyName("unconfigured_size")]
	public long? UnconfiguredSize { get; set; }

	/// <summary>
	/// Percentage of capacity used for this system.
	/// </summary>
	[JsonPropertyName("used_percent")]
	public double? UsedPercent { get; set; }

	/// <summary>
	/// The value of used capacity for this system - Unit: bytes
	/// </summary>
	[JsonPropertyName("used_size")]
	public long? UsedSize { get; set; }
}
