namespace Dell.CloudIq.Api;

public class CloudIQClientOptions
{
	public string ClientId { get; set; } = string.Empty;

	public string ClientSecret { get; set; } = string.Empty;

	public string BaseUri { get; set; } = string.Empty;

	public int? Limit { get; set; } = 1000;
}
