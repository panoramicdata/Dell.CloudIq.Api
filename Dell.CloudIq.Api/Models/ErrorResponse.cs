using System.Net;

namespace Dell.CloudIq.Api;

/// <summary>
/// A standard response body used for all non-2xx REST responses.
/// </summary>
public class ErrorResponse
{
	[JsonPropertyName("http_status_code")]
	public HttpStatusCode HttpStatusCode { get; set; }

	[JsonPropertyName("messages")]
	public List<ErrorMessages> Messages { get; set; } = new();

	private IDictionary<string, object>? _additionalProperties;

	[JsonExtensionData]
	public IDictionary<string, object> AdditionalProperties
	{
		get { return _additionalProperties ??= new Dictionary<string, object>(); }
		set { _additionalProperties = value; }
	}
}
