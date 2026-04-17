namespace Dell.CloudIq.Api;

/// <summary>
/// Basic information about the system.
/// </summary>
public class BasicSystemInformationResponse
{
	/// <summary>Gets or sets the list of basic system information results.</summary>
	[DataMember(Name = "results")]
	public List<BasicSystemInformation>? Results { get; set; }

	private IDictionary<string, object>? _additionalProperties;

	/// <summary>Gets or sets additional properties not explicitly defined in the schema.</summary>
	[JsonExtensionData]
	public IDictionary<string, object> AdditionalProperties
	{
		get { return _additionalProperties ??= new Dictionary<string, object>(); }
		set { _additionalProperties = value; }
	}
}
