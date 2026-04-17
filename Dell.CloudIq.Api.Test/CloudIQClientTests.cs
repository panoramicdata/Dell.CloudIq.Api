using FluentValidation;
using Microsoft.Extensions.Logging;

namespace Dell.CloudIq.Api.Test;

/// <summary>Tests for <see cref="CloudIqClient"/> construction and validation.</summary>
/// <param name="testOutputHelper">The xUnit test output helper.</param>
public class CloudIQClientTests(ITestOutputHelper testOutputHelper) : TestBase(testOutputHelper)
{
	private readonly Mock<ILogger> _mockLogger = new();

	/// <summary>Verifies that a valid client options object does not throw an exception on construction.</summary>
	[Fact]
	public void CloudIQClientConstructed_WithValidClientOptions_DoesNotThrowException()
	{
		var validClientOptions = new CloudIqClientOptions
		{
			ClientId = "valid-ClientId",
			ClientSecret = "valid-ClientSecret",
			BaseUri = "https://valid-BaseUri.com"
		};

		var cloudIQClient = () => new CloudIqClient(validClientOptions, _mockLogger.Object);

		cloudIQClient.Should().NotThrow();
	}

	/// <summary>Verifies that a missing ClientId throws a <see cref="ValidationException"/>.</summary>
	[Fact]
	public void CloudIQClientConstructed_WithInvalidClientId_ThrowsException()
	{
		var invalidClientOptions = new CloudIqClientOptions
		{
			ClientSecret = "valid-ClientSecret",
			BaseUri = "https://valid-BaseUri.com"
		};

		var cloudIQClient = () => new CloudIqClient(invalidClientOptions, _mockLogger.Object);

		cloudIQClient.Should().Throw<ValidationException>();
	}

	/// <summary>Verifies that a missing ClientSecret throws a <see cref="ValidationException"/>.</summary>
	[Fact]
	public void CloudIQClientConstructed_WithInvalidClientSecret_ThrowsException()
	{
		var invalidClientOptions = new CloudIqClientOptions
		{
			ClientId = "valid-ClientId",
			BaseUri = "https://valid-BaseUri.com"
		};

		var cloudIQClient = () => new CloudIqClient(invalidClientOptions, _mockLogger.Object);

		cloudIQClient.Should().Throw<ValidationException>();
	}

	/// <summary>Verifies that a missing BaseUri throws a <see cref="ValidationException"/>.</summary>
	[Fact]
	public void CloudIQClientConstructed_WithInvalidBaseUri_ThrowsException()
	{
		var invalidClientOptions = new CloudIqClientOptions
		{
			ClientId = "valid-ClientId",
			ClientSecret = "valid-ClientSecret"
		};

		var cloudIQClient = () => new CloudIqClient(invalidClientOptions, _mockLogger.Object);

		cloudIQClient.Should().Throw<ValidationException>();
	}
}
