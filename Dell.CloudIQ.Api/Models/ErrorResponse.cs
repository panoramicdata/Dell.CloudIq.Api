namespace Dell.CloudIQ.Api;

/// <summary>
/// A standard response body used for all non-2xx REST responses.
/// </summary>  
public partial class ErrorResponse
{
	[JsonProperty("http_status_code", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public HTTPStatusEnum HttpStatusCode { get; set; }

	[JsonProperty("messages", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public List<ErrorMessages> Messages { get; set; }

	private IDictionary<string, object> _additionalProperties;

	[JsonExtensionData]
	public IDictionary<string, object> AdditionalProperties
	{
		get { return _additionalProperties ?? (_additionalProperties = new Dictionary<string, object>()); }
		set { _additionalProperties = value; }
	}
}
