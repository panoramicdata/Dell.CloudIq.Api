namespace Dell.CloudIq.Api.Test;

using Dell.CloudIq.Api;

/// <summary>Tests for the <see cref="ApiToken"/> model.</summary>
public class ApiTokenTests
{
	/// <summary>Verifies that an <c>ApiToken</c> reads back the values it was given.</summary>
	[Fact]
	public void Properties_ReadBackWhatWasWritten()
	{
		var token = new ApiToken
		{
			AccessToken = "abc",
			TokenType = "Bearer",
			ExpiresIn = 3600,
			Scope = "all"
		};

		token.AccessToken.Should().Be("abc");
		token.TokenType.Should().Be("Bearer");
		token.ExpiresIn.Should().Be(3600);
		token.Scope.Should().Be("all");
	}

	/// <summary>Verifies that <c>ApiToken</c> deserialises from the JSON shape CloudIQ returns.</summary>
	[Fact]
	public void Deserialize_FromCloudIqShape_ReadsEveryField()
	{
		var json = """{"access_token":"tok-1","token_type":"Bearer","expires_in":42,"scope":"s"}""";

		var token = JsonSerializer.Deserialize<ApiToken>(json);

		token.Should().NotBeNull();
		token!.AccessToken.Should().Be("tok-1");
		token.TokenType.Should().Be("Bearer");
		token.ExpiresIn.Should().Be(42);
		token.Scope.Should().Be("s");
	}
}
