namespace Dell.CloudIq.Api;

/// <summary>
/// These are the various kinds of metrics.
/// <br/>* FACT - A value that can vary up and down such as a temperature. Integer or number type.
/// <br/>* RATE - A calculated rate, normally as (counter change)/(time interval in seconds). Integer or number type.
/// <br/>* COUNTER - An increasing value, not reset between reads, such as a read IO counter. Always integer type.
/// <br/>
/// </summary>
[JsonConverter(typeof(JsonStringEnumMemberConverter))]
public enum MetricMetadataType
{

	/// <summary>A value that can vary up and down such as a temperature. Integer or number type.</summary>
	[JsonPropertyName("FACT")]
	FACT = 0,

	/// <summary>A calculated rate, normally as (counter change)/(time interval in seconds). Integer or number type.</summary>
	[JsonPropertyName("RATE")]
	RATE = 1,

	/// <summary>An increasing value, not reset between reads, such as a read IO counter. Always integer type.</summary>
	[JsonPropertyName("COUNTER")]
	COUNTER = 2,
}