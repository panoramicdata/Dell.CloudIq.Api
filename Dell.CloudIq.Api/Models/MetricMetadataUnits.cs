namespace Dell.CloudIq.Api;

/// <summary>
/// These are the various supported units for metrics.
/// <br/>Note that RATE type metrics add an implied "per second" to the units expressed 
/// <br/>using this, and that rates can be type:number(format:float) in addition to listed value types.
/// <br/>* COUNT - A value that increases over time (may wrap to zero). Always integer.
/// <br/>* PERCENT - A percentage value in the 0-100 range. May be integer or number(float).
/// <br/>* RPM - Revolutions per minute. May be integer or number(float).
/// <br/>* SECOND - Time duration in seconds. May be integer or number(float).
/// <br/>* MILLISECOND - Time duration in milliseconds. May be integer or number(float).
/// <br/>* MICROSECOND - Time duration in microseconds. May be integer or number(float).
/// <br/>* BYTE - A byte of data. Always integer. Always int64 format when referring to storage.
/// <br/>* IO - An I/O operation. Always integer.
/// <br/>* PACKET - A network packet. Always integer.
/// <br/>* VOLT - Voltage. Always number (float).
/// <br/>* AMP - Amperage. Always number (float).
/// <br/>* DEGREE_C - Celsius temperature. May be integer or number(float). Number is recommended.
/// <br/>* WATTS - Watt. Always integer.
/// <br/>* KILOWATT_P_HOUR - Kilowatt per hour. Always integer.
/// <br/>* CUBICFEET_P_MINUTE - Cubic feet per minute. May be integer or number(float). Number is recommended.
/// <br/>
/// </summary>
[JsonConverter(typeof(JsonStringEnumMemberConverter))]
public enum MetricMetadataUnits
{

	[JsonPropertyName("COUNT")]
	COUNT = 0,


	[JsonPropertyName("PERCENT")]
	PERCENT = 1,


	[JsonPropertyName("RPM")]
	RPM = 2,


	[JsonPropertyName("SECOND")]
	SECOND = 3,


	[JsonPropertyName("MILLISECOND")]
	MILLISECOND = 4,


	[JsonPropertyName("MICROSECOND")]
	MICROSECOND = 5,


	[JsonPropertyName("BYTE")]
	BYTE = 6,


	[JsonPropertyName("IO")]
	IO = 7,


	[JsonPropertyName("PACKET")]
	PACKET = 8,


	[JsonPropertyName("VOLT")]
	VOLT = 9,


	[JsonPropertyName("AMP")]
	AMP = 10,


	[JsonPropertyName("DEGREE_C")]
	DEGREEC = 11,


	[JsonPropertyName("WATTS")]
	WATTS = 12,


	[JsonPropertyName("KILOWATT_P_HOUR")]
	KILOWATTPHOUR = 13,


	[JsonPropertyName("CUBICFEET_P_MINUTE")]
	CUBICFEETPMINUTE = 14,

}
