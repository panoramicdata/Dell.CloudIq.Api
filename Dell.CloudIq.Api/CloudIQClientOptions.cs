namespace Dell.CloudIq.Api;

/// <summary>
/// CloudIQClient options
/// </summary>
public class CloudIQClientOptions
{
	/// <summary>
	/// The ClientId
	/// </summary>
	public string ClientId { get; set; } = string.Empty;

	/// <summary>
	/// The ClientSecret
	/// </summary>
	public string ClientSecret { get; set; } = string.Empty;

	/// <summary>
	/// The BaseUri
	/// </summary>
	public string BaseUri { get; set; } = string.Empty;
}
