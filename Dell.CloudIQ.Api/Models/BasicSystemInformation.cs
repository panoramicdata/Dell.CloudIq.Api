namespace Dell.CloudIQ.Api;

/// <summary>
/// Basic information about the system.
/// </summary>
public partial class BasicSystemInformation
{
	/// <summary>
	/// Unique identifier of the basic-system-info. This is a singleton, so the id is always "0"
	/// </summary>
	[JsonProperty("id", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public string Id { get; set; }

	/// <summary>
	/// System name.
	/// </summary>
	[JsonProperty("name", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public string Name { get; set; }

	/// <summary>
	/// System model.
	/// </summary>
	[JsonProperty("model", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public string Model { get; set; }

	/// <summary>
	/// System service tag.
	/// </summary>
	[JsonProperty("service_tag", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public string ServiceTag { get; set; }

	/// <summary>
	/// Software release version.
	/// </summary>
	[JsonProperty("release_version", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public string ReleaseVersion { get; set; }

	/// <summary>
	/// List of supported API versions, in major.minor format (no leading "v" and no patch number).
	/// </summary>
	[JsonProperty("supported_api_versions", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public List<string> SupportedApiVersions { get; set; }

	private IDictionary<string, object> _additionalProperties;

	[JsonExtensionData]
	public IDictionary<string, object> AdditionalProperties
	{
		get { return _additionalProperties ?? (_additionalProperties = new Dictionary<string, object>()); }
		set { _additionalProperties = value; }
	}
}
