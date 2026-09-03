namespace Dell.CloudIq.Api;

/// <summary>
/// Base class for the CloudIQ models. CloudIQ adds fields to its responses without warning, so
/// every model keeps the properties it does not declare instead of dropping them.
/// </summary>
public abstract class CloudIqModel
{
	private IDictionary<string, object>? _additionalProperties;

	/// <summary>Gets or sets additional properties not explicitly defined in the schema.</summary>
	[JsonExtensionData]
	public IDictionary<string, object> AdditionalProperties
	{
		get { return _additionalProperties ??= new Dictionary<string, object>(); }
		set { _additionalProperties = value; }
	}
}
