namespace Dell.CloudIq.Api;

/// <summary>
/// A collection is a list of instances along with metadata about that query.
/// A successful collection query returns a '200' with a list of instances in the response body.
/// An empty collection response (whether due to no instances at all, or due to filtering out all the existing instances) is not an error.
/// It still returns a '200', but the "results": [] list is empty.
/// </summary>
public partial class CollectionResponse<T>
{
	[JsonPropertyName("paging")]
	public Paging Paging { get; set; } = new();

	[JsonPropertyName("results")]
	public List<T> Results { get; set; } = new();

	private IDictionary<string, object>? _additionalProperties;

	[JsonExtensionData]
	public IDictionary<string, object> AdditionalProperties
	{
		get { return _additionalProperties ??= new Dictionary<string, object>(); }
		set { _additionalProperties = value; }
	}
}
