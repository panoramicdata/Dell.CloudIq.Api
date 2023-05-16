using AutoFixture;
using Dell.CloudIq.Api.Helpers;
using FluentAssertions;
using Moq;
using Xunit.Abstractions;

namespace Dell.CloudIq.Api.Test;

public class CloudIQClientHelperTests : TestBase
{
	private readonly Fixture _fixture;
	public CloudIQClientHelperTests(ITestOutputHelper testOutputHelper) : base(testOutputHelper)
	{
		_fixture = new Fixture();
	}

	[Fact]
	public async Task GetAllAsync_ReturnsAllPages()
	{
		// Arrange
		var page1 = new CollectionResponse<CloudIQSystem>
		{
			Results = _fixture.Build<CloudIQSystem>().CreateMany(1000).ToList(),
			Paging = new Paging
			{
				TotalInstances = 1010
			}
		};

		var page2 = new CollectionResponse<CloudIQSystem>
		{
			Results = _fixture.Build<CloudIQSystem>().CreateMany(10).ToList(),
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
		var result = await CloudIQClientHelper.GetAllAsync(pageFactoryMock.Object);

		// Assert
		result.Results.Count.Should().Be(1010);
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
		var result = await CloudIQClientHelper.GetAllAsync(pageFactoryMock.Object);

		// Assert
		result.Results.Should().BeEmpty();
	}
}
