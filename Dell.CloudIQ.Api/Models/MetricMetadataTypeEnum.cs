namespace Dell.CloudIq.Api;

/// <summary>
/// These are the various kinds of metrics.
/// <br/>* FACT - A value that can vary up and down such as a temperature. Integer or number type.
/// <br/>* RATE - A calculated rate, normally as (counter change)/(time interval in seconds). Integer or number type.
/// <br/>* COUNTER - An increasing value, not reset between reads, such as a read IO counter. Always integer type.
/// <br/>
/// </summary>
public enum MetricMetadataTypeEnum
{

	[System.Runtime.Serialization.EnumMember(Value = @"FACT")]
	FACT = 0,

	[System.Runtime.Serialization.EnumMember(Value = @"RATE")]
	RATE = 1,

	[System.Runtime.Serialization.EnumMember(Value = @"COUNTER")]
	COUNTER = 2,
}