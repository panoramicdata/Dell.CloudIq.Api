namespace Dell.CloudIq.Api;

/// <summary>
/// These are the available metric categories. Not all resource types have
/// <br/>metrics in every category.
/// <br/>* PERF - Performance metrics such as latency and throughput measures.
/// <br/>* SPACE - Capacity metrics, primarily for storage. All values in bytes.
/// <br/>type: string
/// <br/>
/// </summary>
public enum MetricMetadataCategoryEnum
{
	[System.Runtime.Serialization.EnumMember(Value = @"PERF")]
	PERF = 0,

	[System.Runtime.Serialization.EnumMember(Value = @"SPACE")]
	SPACE = 1,
}
