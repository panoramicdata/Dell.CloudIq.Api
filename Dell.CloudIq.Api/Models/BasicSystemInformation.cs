namespace Dell.CloudIq.Api;

/// <summary>
/// Basic information about the system.
/// </summary>
public partial class BasicSystemInformation
{
	/// <summary>
	/// Unique identifier of the basic-system-info. This is a singleton, so the id is always "0"
	/// </summary>
	[JsonPropertyName("id")]
	public string Id { get; set; }

	/// <summary>
	/// System name.
	/// </summary>
	[JsonPropertyName("name")]
	public string Name { get; set; }

	/// <summary>
	/// System model.
	/// </summary>
	[JsonPropertyName("model")]
	public string Model { get; set; }

	/// <summary>
	/// System service tag.
	/// </summary>
	[JsonPropertyName("service_tag")]
	public string ServiceTag { get; set; }

	/// <summary>
	/// Software release version.
	/// </summary>
	[JsonPropertyName("release_version")]
	public string ReleaseVersion { get; set; }

	/// <summary>
	/// List of supported API versions, in major.minor format (no leading "v" and no patch number).
	/// </summary>
	[JsonPropertyName("supported_api_versions")]
	public List<string> SupportedApiVersions { get; set; }

	private IDictionary<string, object> _additionalProperties;

	[JsonExtensionData]
	public IDictionary<string, object> AdditionalProperties
	{
		get { return _additionalProperties ?? (_additionalProperties = new Dictionary<string, object>()); }
		set { _additionalProperties = value; }
	}
}
