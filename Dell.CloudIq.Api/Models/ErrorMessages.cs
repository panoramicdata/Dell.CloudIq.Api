namespace Dell.CloudIq.Api;

/// <summary>
/// A message describing the failure, a contributing factor to the \nfailure, or possibly the aftermath of the failure.
/// </summary>
public partial class ErrorMessages
{
	/// <summary>
	/// Identifier for this kind of message. This is a string that can be used to look up additional information on the support website. \n(Note - specific format can be determined by platform - hex value codes are common in Midrange.)
	/// </summary>
	[JsonProperty("code")]
	public string Code { get; set; }

	/// <summary>
	/// The time at which the error occurred.
	/// </summary>
	[JsonProperty("timestamp")]
	public System.DateTimeOffset Timestamp { get; set; }

	[JsonProperty("severity")]
	[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
	public SeverityEnum Severity { get; set; }

	/// <summary>
	/// Message string.
	/// </summary>
	[JsonProperty("message")]
	public string Message { get; set; }

	/// <summary>
	/// Localized message string.
	/// </summary>
	[JsonProperty("message_l10n")]
	public string MessageL10n { get; set; }

	/// <summary>
	/// Ordered list of substitution args for the error message. Must match up with the {0}, {1}, etc... actually in the message referenced by the message code above, if any.
	/// </summary>
	[JsonProperty("arguments")]
	public List<object> Arguments { get; set; }

	private IDictionary<string, object> _additionalProperties;

	[JsonExtensionData]
	public IDictionary<string, object> AdditionalProperties
	{
		get { return _additionalProperties ?? (_additionalProperties = new Dictionary<string, object>()); }
		set { _additionalProperties = value; }
	}
}
