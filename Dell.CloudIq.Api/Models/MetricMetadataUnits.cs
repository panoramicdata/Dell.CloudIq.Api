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

	/// <summary>A value that increases over time (may wrap to zero). Always integer.</summary>
	[JsonPropertyName("COUNT")]
	COUNT = 0,


	/// <summary>A percentage value in the 0-100 range. May be integer or number (float).</summary>
	[JsonPropertyName("PERCENT")]
	PERCENT = 1,


	/// <summary>Revolutions per minute. May be integer or number (float).</summary>
	[JsonPropertyName("RPM")]
	RPM = 2,


	/// <summary>Time duration in seconds. May be integer or number (float).</summary>
	[JsonPropertyName("SECOND")]
	SECOND = 3,


	/// <summary>Time duration in milliseconds. May be integer or number (float).</summary>
	[JsonPropertyName("MILLISECOND")]
	MILLISECOND = 4,


	/// <summary>Time duration in microseconds. May be integer or number (float).</summary>
	[JsonPropertyName("MICROSECOND")]
	MICROSECOND = 5,


	/// <summary>A byte of data. Always integer. Always int64 format when referring to storage.</summary>
	[JsonPropertyName("BYTE")]
	BYTE = 6,


	/// <summary>An I/O operation. Always integer.</summary>
	[JsonPropertyName("IO")]
	IO = 7,


	/// <summary>A network packet. Always integer.</summary>
	[JsonPropertyName("PACKET")]
	PACKET = 8,


	/// <summary>Voltage. Always number (float).</summary>
	[JsonPropertyName("VOLT")]
	VOLT = 9,


	/// <summary>Amperage. Always number (float).</summary>
	[JsonPropertyName("AMP")]
	AMP = 10,


	/// <summary>Celsius temperature. May be integer or number (float).</summary>
	[JsonPropertyName("DEGREE_C")]
	DEGREEC = 11,


	/// <summary>Watt. Always integer.</summary>
	[JsonPropertyName("WATTS")]
	WATTS = 12,


	/// <summary>Kilowatt per hour. Always integer.</summary>
	[JsonPropertyName("KILOWATT_P_HOUR")]
	KILOWATTPHOUR = 13,


	/// <summary>Cubic feet per minute. May be integer or number (float).</summary>
	[JsonPropertyName("CUBICFEET_P_MINUTE")]
	CUBICFEETPMINUTE = 14,

}
