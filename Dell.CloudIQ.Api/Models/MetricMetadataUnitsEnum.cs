namespace Dell.CloudIQ.Api;

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
public enum MetricMetadataUnitsEnum
{

	[System.Runtime.Serialization.EnumMember(Value = @"COUNT")]
	COUNT = 0,


	[System.Runtime.Serialization.EnumMember(Value = @"PERCENT")]
	PERCENT = 1,


	[System.Runtime.Serialization.EnumMember(Value = @"RPM")]
	RPM = 2,


	[System.Runtime.Serialization.EnumMember(Value = @"SECOND")]
	SECOND = 3,


	[System.Runtime.Serialization.EnumMember(Value = @"MILLISECOND")]
	MILLISECOND = 4,


	[System.Runtime.Serialization.EnumMember(Value = @"MICROSECOND")]
	MICROSECOND = 5,


	[System.Runtime.Serialization.EnumMember(Value = @"BYTE")]
	BYTE = 6,


	[System.Runtime.Serialization.EnumMember(Value = @"IO")]
	IO = 7,


	[System.Runtime.Serialization.EnumMember(Value = @"PACKET")]
	PACKET = 8,


	[System.Runtime.Serialization.EnumMember(Value = @"VOLT")]
	VOLT = 9,


	[System.Runtime.Serialization.EnumMember(Value = @"AMP")]
	AMP = 10,


	[System.Runtime.Serialization.EnumMember(Value = @"DEGREE_C")]
	DEGREEC = 11,


	[System.Runtime.Serialization.EnumMember(Value = @"WATTS")]
	WATTS = 12,


	[System.Runtime.Serialization.EnumMember(Value = @"KILOWATT_P_HOUR")]
	KILOWATTPHOUR = 13,


	[System.Runtime.Serialization.EnumMember(Value = @"CUBICFEET_P_MINUTE")]
	CUBICFEETPMINUTE = 14,

}
