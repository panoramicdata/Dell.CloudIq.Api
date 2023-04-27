namespace Dell.CloudIQ.Api;

/// <summary>
/// The severity of the condition.
/// <br/>* INFO - Information that may be of use in understanding the 
/// <br/>  failure. It is not a problem to fix.
/// <br/>* WARNING - A condition that isn't a failure, but may be 
/// <br/>  unexpected or a contributing factor. It may be necessary to 
/// <br/>  fix the condition to successfully retry the request.
/// <br/>* ERROR - An actual failure condition through which the 
/// <br/>  request could not continue.
/// <br/>* CRITICAL - A failure with significant impact to the system. 
/// <br/>  Normally failed commands roll back and are just ERROR, 
/// <br/>  but may be used for exceptional cases.
/// </summary>
public enum SeverityEnum
{

	[System.Runtime.Serialization.EnumMember(Value = @"INFO")]
	INFO = 0,


	[System.Runtime.Serialization.EnumMember(Value = @"WARNING")]
	WARNING = 1,


	[System.Runtime.Serialization.EnumMember(Value = @"ERROR")]
	ERROR = 2,


	[System.Runtime.Serialization.EnumMember(Value = @"CRITICAL")]
	CRITICAL = 3,


}
