namespace Dell.CloudIq.Api.Test;

/// <summary>Tests for <see cref="CloudIQClientHelper"/>.</summary>
/// <param name="testOutputHelper">The xUnit test output helper.</param>
public class CloudIQClientHelperTests(ITestOutputHelper testOutputHelper) : TestBase(testOutputHelper)
{
	private readonly Fixture _fixture = new();

	/// <summary>Verifies that GetAllAsync retrieves all pages and returns the full result set.</summary>
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

	/// <summary>Verifies that GetAllAsync returns an empty result when there are no pages.</summary>
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
		var result = await CloudIQClientHelper.GetAllAsync(pageFactoryMock.Object, cancellationToken: CancellationToken);

		// Assert
		result.Results.Should().BeEmpty();
	}
}
