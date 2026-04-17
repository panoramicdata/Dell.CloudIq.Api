namespace Dell.CloudIq.Api;

/// <summary>
/// These are the resource types that support metrics.
/// <br/>* datastore - Data store
/// <br/>* drive - Spinning or flash drives.
/// <br/>* filesystem - File system.
/// <br/>* host - Host
/// <br/>* network_system - Network System
/// <br/>* pool - Pool
/// <br/>* server_system - Server System
/// <br/>* storage_system - Storage System
/// <br/>* volume - Block volume (aka LUN).
/// <br/>
/// </summary>
[JsonConverter(typeof(JsonStringEnumMemberConverter))]
public enum MetricMetadataResourceType
{

	/// <summary>Data store.</summary>
	[JsonPropertyName("datastore")]
	Datastore = 0,


	/// <summary>Spinning or flash drives.</summary>
	[JsonPropertyName("drive")]
	Drive = 1,


	/// <summary>File system.</summary>
	[JsonPropertyName("filesystem")]
	Filesystem = 2,


	/// <summary>Host.</summary>
	[JsonPropertyName("host")]
	Host = 3,


	/// <summary>Network system.</summary>
	[JsonPropertyName("network_system")]
	NetworkSystem = 4,


	/// <summary>Pool.</summary>
	[JsonPropertyName("pool")]
	Pool = 5,


	/// <summary>Server system.</summary>
	[JsonPropertyName("server_system")]
	ServerSystem = 6,


	/// <summary>Storage group.</summary>
	[JsonPropertyName("storage_group")]
	StorageGroup = 7,


	/// <summary>Storage system.</summary>
	[JsonPropertyName("storage_system")]
	StorageSystem = 8,


	/// <summary>Block volume (aka LUN).</summary>
	[JsonPropertyName("volume")]
	Volume = 9,

}
