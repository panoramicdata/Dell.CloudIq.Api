namespace Dell.CloudIq.Api;

/// <summary>
/// These are the available intervals for collection and rollup metrics.
/// <br/>All collection and rollups should occur at the top of the minute/hour/day.
/// <br/>These enum values are chosen from the ISO 8601 interval pattern: -?P(\d+D)?(T(\d+H)?(\d+M)?(\d+(.\d+)?S)?)
/// <br/>The collection interval may vary by resource type, and only that and
/// <br/>higher intervals are available.
/// <br/>* PT5M - five minutes
/// <br/>* PT15M - fifteen minutes
/// <br/>* PT1H - one hour
/// <br/>* P1D - one day
/// <br/>
/// </summary>
[JsonConverter(typeof(JsonStringEnumMemberConverter))]
public enum MetricsInterval
{

	[JsonPropertyName("PT5M")]
	PT5M = 0,


	[JsonPropertyName("PT15M")]
	PT15M = 1,


	[JsonPropertyName("PT1H")]
	PT1H = 2,


	[JsonPropertyName("P1D")]
	P1D = 3,


}
