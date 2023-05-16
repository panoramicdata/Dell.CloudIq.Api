using FluentAssertions;
using FluentValidation;
using Microsoft.Extensions.Logging;
using Moq;
using Xunit.Abstractions;

namespace Dell.CloudIq.Api.Test;

public class CloudIQClientTests : TestBase
{
	private readonly Mock<ILogger> _mockLogger;
	public CloudIQClientTests(ITestOutputHelper testOutputHelper) : base(testOutputHelper)
	{
		_mockLogger = new Mock<ILogger>();
	}

	[Fact]
	public void CloudIQClientConstructed_WithValidClientOptions_DoesNotThrowException()
	{
		var validClientOptions = new CloudIQClientOptions
		{
			ClientId = "valid-ClientId",
			ClientSecret = "valid-ClientSecret",
			BaseUri = "https://valid-BaseUri.com"
		};

		var cloudIQClient = () => new CloudIQClient(validClientOptions, _mockLogger.Object);

		cloudIQClient.Should().NotThrow();
	}

	[Fact]
	public void CloudIQClientConstructed_WithInvalidClientId_ThrowsException()
	{
		var invalidClientOptions = new CloudIQClientOptions
		{
			ClientSecret = "valid-ClientSecret",
			BaseUri = "https://valid-BaseUri.com"
		};

		var cloudIQClient = () => new CloudIQClient(invalidClientOptions, _mockLogger.Object);

		cloudIQClient.Should().Throw<ValidationException>();
	}

	[Fact]
	public void CloudIQClientConstructed_WithInvalidClientSecret_ThrowsException()
	{
		var invalidClientOptions = new CloudIQClientOptions
		{
			ClientId = "valid-ClientId",
			BaseUri = "https://valid-BaseUri.com"
		};

		var cloudIQClient = () => new CloudIQClient(invalidClientOptions, _mockLogger.Object);

		cloudIQClient.Should().Throw<ValidationException>();
	}

	[Fact]
	public void CloudIQClientConstructed_WithInvalidBaseUri_ThrowsException()
	{
		var invalidClientOptions = new CloudIQClientOptions
		{
			ClientId = "valid-ClientId",
			ClientSecret = "valid-ClientSecret"
		};

		var cloudIQClient = () => new CloudIQClient(invalidClientOptions, _mockLogger.Object);

		cloudIQClient.Should().Throw<ValidationException>();
	}
}
