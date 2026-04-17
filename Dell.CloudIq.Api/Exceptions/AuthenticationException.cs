namespace Dell.CloudIq.Api.Exceptions;

/// <summary>
/// Exception thrown when authentication with the Dell CloudIQ API fails.
/// </summary>
public class AuthenticationException : Exception
{
	/// <summary>Initializes a new instance of <see cref="AuthenticationException"/>.</summary>
	public AuthenticationException()
	{

	}

	/// <summary>Initializes a new instance of <see cref="AuthenticationException"/> with a message.</summary>
	/// <param name="message">The error message.</param>
	public AuthenticationException(string message) : base(message)
	{

	}
}
