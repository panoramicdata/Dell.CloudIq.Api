namespace Dell.CloudIq.Api.Test;

using Dell.CloudIq.Api.Exceptions;

/// <summary>Tests for <see cref="AuthenticationException"/>.</summary>
public class AuthenticationExceptionTests
{
	/// <summary>Verifies that the default constructor produces an instance of the type.</summary>
	[Fact]
	public void DefaultConstructor_ProducesAnException()
	{
		var exception = new AuthenticationException();

		exception.Should().BeOfType<AuthenticationException>();
		exception.Message.Should().NotBeNullOrEmpty();
	}

	/// <summary>Verifies that the message constructor propagates the supplied message.</summary>
	[Fact]
	public void MessageConstructor_KeepsTheMessage()
	{
		var exception = new AuthenticationException("Auth failed.");

		exception.Message.Should().Be("Auth failed.");
	}
}
