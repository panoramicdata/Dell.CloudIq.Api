using System.Runtime.Serialization;

namespace Dell.CloudIq.Api;
[DataContract]
internal class ApiToken
{
	[DataMember (Name = "access_token")]
	public string AccessToken { get; set; } = string.Empty;

	[DataMember(Name = "token_type")]
	public string TokenType { get; set; } = string.Empty;

	[DataMember(Name = "expires_in")]
	public int ExpiresIn { get; set; } = 0;

	[DataMember(Name = "scope")]
	public string Scope { get; set; } = string.Empty;
}
