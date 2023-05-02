namespace Dell.CloudIq.Api;

/// <summary>
/// Basic information about the system.
/// </summary>
public partial class BasicSystemInformationResponse
{
	[JsonProperty("results", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
	public List<BasicSystemInformation> Results { get; set; }

	private IDictionary<string, object> _additionalProperties;

	[JsonExtensionData]
	public IDictionary<string, object> AdditionalProperties
	{
		get { return _additionalProperties ?? (_additionalProperties = new Dictionary<string, object>()); }
		set { _additionalProperties = value; }
	}
}
