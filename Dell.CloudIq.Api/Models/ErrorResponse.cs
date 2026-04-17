using System.Net;

namespace Dell.CloudIq.Api;

/// <summary>
/// A standard response body used for all non-2xx REST responses.
/// </summary>
public class ErrorResponse
{
	/// <summary>Gets or sets the HTTP status code of the error response.</summary>
	[JsonPropertyName("http_status_code")]
	public HttpStatusCode HttpStatusCode { get; set; }

	/// <summary>Gets or sets the list of error messages describing the failure.</summary>
	[JsonPropertyName("messages")]
	public List<ErrorMessages> Messages { get; set; } = [];

	private IDictionary<string, object>? _additionalProperties;

	/// <summary>Gets or sets additional properties not explicitly defined in the schema.</summary>
	[JsonExtensionData]
	public IDictionary<string, object> AdditionalProperties
	{
		get { return _additionalProperties ??= new Dictionary<string, object>(); }
		set { _additionalProperties = value; }
	}
}
