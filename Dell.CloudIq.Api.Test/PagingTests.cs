using AutoFixture;
using Moq;
using Xunit.Abstractions;

namespace Dell.CloudIq.Api.Test;

public class PagingTests : TestBase
{
	private readonly Fixture _fixture;
	public PagingTests(ITestOutputHelper testOutputHelper) : base(testOutputHelper)
	{
		_fixture = new Fixture();
	}

	[Fact]
	public async Task GetAllAsync_ReturnsAllPages()
	{

		var clientOptions = GetClientOptions();
		clientOptions.Limit = 3;
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

		var pageFactoryMock = new Mock<Func<int, int, CancellationToken, Task<CollectionResponse<CloudIQSystem>>>>();
		pageFactoryMock.SetupSequence(x => x(It.IsAny<int>(), It.IsAny<int>(), It.IsAny<CancellationToken>()))
			.ReturnsAsync(page1)
			.ReturnsAsync(page2);

		// Act
		var result = await CloudIQClient.GetAllAsync(pageFactoryMock.Object);

		// Assert
		Assert.Equal(5, result.Results.Count);
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

		var pageFactoryMock = new Mock<Func<int, int, CancellationToken, Task<CollectionResponse<CloudIQSystem>>>>();
		pageFactoryMock.Setup(x => x(It.IsAny<int>(), It.IsAny<int>(), It.IsAny<CancellationToken>()))
			.ReturnsAsync(emptyPage);

		// Act
		var result = await CloudIQClient.GetAllAsync(pageFactoryMock.Object);

		// Assert
		Assert.Empty(result.Results);
	}
}
