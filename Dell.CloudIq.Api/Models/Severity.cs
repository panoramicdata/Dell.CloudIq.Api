namespace Dell.CloudIq.Api;

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

[JsonConverter(typeof(JsonStringEnumMemberConverter))]
public enum Severity
{

	/// <summary>Information that may be of use in understanding the failure. It is not a problem to fix.</summary>
	[JsonPropertyName("INFO")]
	INFO = 0,


	/// <summary>A condition that is not a failure, but may be unexpected or a contributing factor.</summary>
	[JsonPropertyName("WARNING")]
	WARNING = 1,


	/// <summary>An actual failure condition through which the request could not continue.</summary>
	[JsonPropertyName("ERROR")]
	ERROR = 2,


	/// <summary>A failure with significant impact to the system.</summary>
	[JsonPropertyName("CRITICAL")]
	CRITICAL = 3,


}
