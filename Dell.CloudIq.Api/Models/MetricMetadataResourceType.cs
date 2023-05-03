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
public enum MetricMetadataResourceType
{

	[System.Runtime.Serialization.EnumMember(Value = @"datastore")]
	Datastore = 0,


	[System.Runtime.Serialization.EnumMember(Value = @"drive")]
	Drive = 1,


	[System.Runtime.Serialization.EnumMember(Value = @"filesystem")]
	Filesystem = 2,


	[System.Runtime.Serialization.EnumMember(Value = @"host")]
	Host = 3,


	[System.Runtime.Serialization.EnumMember(Value = @"network_system")]
	NetworkSystem = 4,


	[System.Runtime.Serialization.EnumMember(Value = @"pool")]
	Pool = 5,


	[System.Runtime.Serialization.EnumMember(Value = @"server_system")]
	ServerSystem = 6,


	[System.Runtime.Serialization.EnumMember(Value = @"storage_group")]
	StorageGroup = 7,


	[System.Runtime.Serialization.EnumMember(Value = @"storage_system")]
	StorageSystem = 8,


	[System.Runtime.Serialization.EnumMember(Value = @"volume")]
	Volume = 9,

}
