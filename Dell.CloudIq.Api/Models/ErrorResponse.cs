using System.Net;

namespace Dell.CloudIq.Api;

/// <summary>
/// A standard response body used for all non-2xx REST responses.
/// </summary>
public class ErrorResponse : CloudIqModel
{
	/// <summary>Gets or sets the HTTP status code of the error response.</summary>
	[JsonPropertyName("http_status_code")]
	public HttpStatusCode HttpStatusCode { get; set; }

	/// <summary>Gets or sets the list of error messages describing the failure.</summary>
	[JsonPropertyName("messages")]
	public List<ErrorMessages> Messages { get; set; } = [];
}
