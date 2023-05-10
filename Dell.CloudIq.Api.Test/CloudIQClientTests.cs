using AutoFixture;
using FluentValidation;
using Microsoft.Extensions.Logging;
using Moq;
using Xunit.Abstractions;

namespace Dell.CloudIq.Api.Test;

public class CloudIQClientTests : TestBase
{
	private readonly Fixture _fixture;
	private readonly Mock<ILogger> _mockLogger;
	public CloudIQClientTests(ITestOutputHelper testOutputHelper) : base(testOutputHelper)
	{
		_fixture = new Fixture();
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

		Assert.Null(Record.Exception(cloudIQClient));
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

		Assert.Throws<ValidationException>(cloudIQClient);
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

		Assert.Throws<ValidationException>(cloudIQClient);
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

		Assert.Throws<ValidationException>(cloudIQClient);
	}

	[Fact]
	public async Task GetAllAsync_ReturnsAllPages()
	{

		var clientOptions = GetClientOptions();
		clientOptions.LimitPerPage = 3;
		var client = new CloudIQClient(clientOptions, Logger);

		// Arrange
		var page1 = new CollectionResponse<CloudIQSystem>
		{
			Results = _fixture.Build<CloudIQSystem>().CreateMany(3).ToList(),
			Paging = new Paging
			{
				TotalInstances = 5
			}
		};

		var page2 = new CollectionResponse<CloudIQSystem>
		{
			Results = _fixture.Build<CloudIQSystem>().CreateMany(2).ToList(),
			Paging = new Paging
			{
				TotalInstances = 5
			}
		};

		var pageFactoryMock = new Mock<Func<int?, int, CancellationToken, Task<CollectionResponse<CloudIQSystem>>>>();
		pageFactoryMock.SetupSequence(x => x(It.IsAny<int?>(), It.IsAny<int>(), It.IsAny<CancellationToken>()))
			.ReturnsAsync(page1)
			.ReturnsAsync(page2);

		// Act
		var result = await CloudIQClient.GetAllAsync(pageFactoryMock.Object);

		// Assert
		Assert.Equal(5, result.Results.Count);
	}

	[Fact]
	public async Task GetAllAsync_WithoutLimitSet_ReturnsAll()
	{
		// Arrange
		var page = new CollectionResponse<CloudIQSystem>
		{
			Results = _fixture.Build<CloudIQSystem>().CreateMany(5).ToList(),
			Paging = new Paging
			{
				TotalInstances = 5
			}
		};

		var pageFactoryMock = new Mock<Func<int?, int, CancellationToken, Task<CollectionResponse<CloudIQSystem>>>>();
		pageFactoryMock.Setup(x => x(It.IsAny<int?>(), It.IsAny<int>(), It.IsAny<CancellationToken>()))
			.ReturnsAsync(page);

		// Act
		var result = await CloudIQClient.GetAllAsync(pageFactoryMock.Object);

		// Assert
		Assert.Equal(page.Results.Count, result.Results.Count);
	}

	[Fact]
	public async Task GetAllAsync_EmptyResult_NoPages()
	{
		// Arrange
		var emptyPage = new CollectionResponse<CloudIQSystem>
		{
			Results = new List<CloudIQSystem>(),
			Paging = new Paging
			{
				TotalInstances = 0
			}
		};

		var pageFactoryMock = new Mock<Func<int?, int, CancellationToken, Task<CollectionResponse<CloudIQSystem>>>>();
		pageFactoryMock.Setup(x => x(It.IsAny<int?>(), It.IsAny<int>(), It.IsAny<CancellationToken>()))
			.ReturnsAsync(emptyPage);

		// Act
		var result = await CloudIQClient.GetAllAsync(pageFactoryMock.Object);

		// Assert
		Assert.Empty(result.Results);
	}
}
