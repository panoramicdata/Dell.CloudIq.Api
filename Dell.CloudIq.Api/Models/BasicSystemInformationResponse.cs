namespace Dell.CloudIq.Api;

/// <summary>
/// Basic information about the system.
/// </summary>
public class BasicSystemInformationResponse
{
	[DataMember(Name = "results")]
	public List<BasicSystemInformation>? Results { get; set; }

	private IDictionary<string, object>? _additionalProperties;

	[JsonExtensionData]
	public IDictionary<string, object> AdditionalProperties
	{
		get { return _additionalProperties ??= new Dictionary<string, object>(); }
		set { _additionalProperties = value; }
	}
}
