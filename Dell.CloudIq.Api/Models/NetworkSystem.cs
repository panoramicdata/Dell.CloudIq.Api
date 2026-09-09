namespace Dell.CloudIq.Api;

/// <summary>
/// The network system object.
/// </summary>
public class NetworkSystem : CloudIqSystemBase
{
	/// <summary>
	/// Number of bit errors across all ports on the system.
	/// </summary>
	[JsonPropertyName("bit_errors")]
	public long? BitErrors { get; set; }

	/// <summary>
	/// Chassis World Wide Name (WWN) of the switch.
	/// </summary>
	[JsonPropertyName("chassis_wwn")]
	public string? ChassisWwn { get; set; }

	/// <summary>
	/// CloudIQ Collector GDS identifier.
	/// </summary>
	[JsonPropertyName("ciqc")]
	public string? Ciqc { get; set; }

	/// <summary>
	/// Name of the CloudIQ Collector.
	/// </summary>
	[JsonPropertyName("ciqc_name")]
	public string? CiqcName { get; set; }

	/// <summary>
	/// Total number of congested ports on the switch.
	/// </summary>
	[JsonPropertyName("congested_ports")]
	public long? CongestedPorts { get; set; }

	/// <summary>
	/// Amount of CPU usage.
	/// </summary>
	[JsonPropertyName("cpu_utilization")]
	public double? CpuUtilization { get; set; }

	/// <summary>
	/// Number of FC ports with errors.
	/// </summary>
	[JsonPropertyName("error_fc_ports")]
	public long? ErrorFcPorts { get; set; }

	/// <summary>
	/// Number of GE ports with errors.
	/// </summary>
	[JsonPropertyName("error_ge_ports")]
	public long? ErrorGePorts { get; set; }

	/// <summary>
	/// Total number of ports with errors.
	/// </summary>
	[JsonPropertyName("error_ports")]
	public long? ErrorPorts { get; set; }

	/// <summary>
	/// Incrementing errors for the system.
	/// </summary>
	[JsonPropertyName("incrementing_bit_errors")]
	public long? IncrementingBitErrors { get; set; }

	/// <summary>
	/// Incrementing link resets for the system.
	/// </summary>
	[JsonPropertyName("incrementing_link_resets")]
	public long? IncrementingLinkResets { get; set; }

	/// <summary>
	/// Number of link resets across all ports on the system.
	/// </summary>
	[JsonPropertyName("link_resets")]
	public long? LinkResets { get; set; }

	/// <summary>
	/// Total number of FC ports that are offline.
	/// </summary>
	[JsonPropertyName("offline_fc_ports")]
	public long? OfflineFcPorts { get; set; }

	/// <summary>
	/// Total number of GE ports that are offline.
	/// </summary>
	[JsonPropertyName("offline_ge_ports")]
	public long? OfflineGePorts { get; set; }

	/// <summary>
	/// Total number of ports that are offline.
	/// </summary>
	[JsonPropertyName("offline_ports")]
	public long? OfflinePorts { get; set; }

	/// <summary>
	/// Total number of FC ports that are online.
	/// </summary>
	[JsonPropertyName("online_fc_ports")]
	public long? OnlineFcPorts { get; set; }

	/// <summary>
	/// Total number of GE ports that are online.
	/// </summary>
	[JsonPropertyName("online_ge_ports")]
	public long? OnlineGePorts { get; set; }

	/// <summary>
	/// Total number of ports that are online.
	/// </summary>
	[JsonPropertyName("online_ports")]
	public long? OnlinePorts { get; set; }

	/// <summary>
	/// Number of ports with over 80 percent utilization.
	/// </summary>
	[JsonPropertyName("ports_over_80_percent")]
	public long? PortsOver80Percent { get; set; }

	/// <summary>
	/// The switch MAC property.
	/// </summary>
	[JsonPropertyName("switch_mac")]
	public string? SwitchMac { get; set; }

	/// <summary>
	/// Total number of FC ports on the system.
	/// </summary>
	[JsonPropertyName("total_fc_ports")]
	public long? TotalFcPorts { get; set; }

	/// <summary>
	/// Total number of GE ports on the system.
	/// </summary>
	[JsonPropertyName("total_ge_ports")]
	public long? TotalGePorts { get; set; }

	/// <summary>
	/// Total number of ports on the system.
	/// </summary>
	[JsonPropertyName("total_ports")]
	public long? TotalPorts { get; set; }

	/// <summary>
	/// Time since last reboot of the system.
	/// </summary>
	[JsonPropertyName("uptime")]
	public long? Uptime { get; set; }

	/// <summary>
	/// Overall bandwidth utilization of the system.
	/// </summary>
	[JsonPropertyName("utilization")]
	public double? Utilization { get; set; }

	/// <summary>
	/// World Wide Name (WWN) of the component.
	/// </summary>
	[JsonPropertyName("wwn")]
	public string? Wwn { get; set; }
}
