namespace Dell.CloudIq.Api.Test;

public class CloudIQClientHelperTests(ITestOutputHelper testOutputHelper) : TestBase(testOutputHelper)
{
	private readonly Fixture _fixture = new();

	[Fact]
	public async Task GetAllAsync_ReturnsAllPages()
	{
		// Arrange
		var page1 = new CollectionResponse<CloudIQSystem>
		{
			Results = [.. _fixture.Build<CloudIQSystem>().CreateMany(1000)],
			Paging = new Paging
			{
				TotalInstances = 1010
			}
		};

		var page2 = new CollectionResponse<CloudIQSystem>
		{
			Results = [.. _fixture.Build<CloudIQSystem>().CreateMany(10)],
			Paging = new Paging
			{
				TotalInstances = 1010
			}
		};

		var pageFactoryMock = new Mock<Func<int?, int, CancellationToken, Task<CollectionResponse<CloudIQSystem>>>>();
		pageFactoryMock.SetupSequence(x => x(It.IsAny<int?>(), It.IsAny<int>(), It.IsAny<CancellationToken>()))
			.ReturnsAsync(page1)
			.ReturnsAsync(page2);

		// Act
		var result = await CloudIQClientHelper.GetAllAsync(pageFactoryMock.Object, CancellationToken);

		// Assert
		result.Results.Should().HaveCount(1010);
	}

	[Fact]
	public async Task GetAllAsync_EmptyResult_NoPages()
	{
		// Arrange
		var emptyPage = new CollectionResponse<CloudIQSystem>
		{
			Results = [],
			Paging = new Paging
			{
				TotalInstances = 0
			}
		};

		var pageFactoryMock = new Mock<Func<int?, int, CancellationToken, Task<CollectionResponse<CloudIQSystem>>>>();
		pageFactoryMock.Setup(x => x(It.IsAny<int?>(), It.IsAny<int>(), It.IsAny<CancellationToken>()))
			.ReturnsAsync(emptyPage);

		// Act
		var result = await CloudIQClientHelper.GetAllAsync(pageFactoryMock.Object);

		// Assert
		result.Results.Should().BeEmpty();
	}
}
