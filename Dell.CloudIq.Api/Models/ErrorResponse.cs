using System.Net;

namespace Dell.CloudIq.Api;

/// <summary>
/// A standard response body used for all non-2xx REST responses.
/// </summary>  
public partial class ErrorResponse
{
	[JsonProperty("http_status_code")]
	public HttpStatusCode HttpStatusCode { get; set; }

	[JsonProperty("messages")]
	public List<ErrorMessages> Messages { get; set; }

	private IDictionary<string, object> _additionalProperties;

	[JsonExtensionData]
	public IDictionary<string, object> AdditionalProperties
	{
		get { return _additionalProperties ?? (_additionalProperties = new Dictionary<string, object>()); }
		set { _additionalProperties = value; }
	}
}
