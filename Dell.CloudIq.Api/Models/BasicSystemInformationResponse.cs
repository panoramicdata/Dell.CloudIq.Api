namespace Dell.CloudIq.Api;

/// <summary>
/// Basic information about the system.
/// </summary>
public class BasicSystemInformationResponse : CloudIqModel
{
	/// <summary>Gets or sets the list of basic system information results.</summary>
	[DataMember(Name = "results")]
	public List<BasicSystemInformation>? Results { get; set; }
}
