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

	[JsonPropertyName("datastore")]
	Datastore = 0,


	[JsonPropertyName("drive")]
	Drive = 1,


	[JsonPropertyName("filesystem")]
	Filesystem = 2,


	[JsonPropertyName("host")]
	Host = 3,


	[JsonPropertyName("network_system")]
	NetworkSystem = 4,


	[JsonPropertyName("pool")]
	Pool = 5,


	[JsonPropertyName("server_system")]
	ServerSystem = 6,


	[JsonPropertyName("storage_group")]
	StorageGroup = 7,


	[JsonPropertyName("storage_system")]
	StorageSystem = 8,


	[JsonPropertyName("volume")]
	Volume = 9,

}
