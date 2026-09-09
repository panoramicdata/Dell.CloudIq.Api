namespace Dell.CloudIq.Api;

/// <summary>
/// The system object.
/// </summary>
public class CloudIQSystem : CloudIqSystemBase
{
	/// <summary>
	/// The contract number
	/// </summary>
	[JsonPropertyName("contract_number")]
	public string? ContractNumber { get; set; }
}
