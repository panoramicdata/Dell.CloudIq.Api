namespace Dell.CloudIq.Api;

/// <summary>
/// These are the available metric categories. Not all resource types have
/// <br/>metrics in every category.
/// <br/>* PERF - Performance metrics such as latency and throughput measures.
/// <br/>* SPACE - Capacity metrics, primarily for storage. All values in bytes.
/// <br/>type: string
/// <br/>
/// </summary>

[JsonConverter(typeof(JsonStringEnumMemberConverter))]
public enum MetricMetadataCategory
{
	[JsonPropertyName("PERF")]
	PERF = 0,

	[JsonPropertyName("SPACE")]
	SPACE = 1,
}
