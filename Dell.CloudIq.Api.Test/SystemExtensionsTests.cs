namespace Dell.CloudIq.Api.Test;

using Dell.CloudIq.Api.Interfaces;

/// <summary>Tests for the <see cref="SystemExtensions"/> all-pages paging helpers.</summary>
public class SystemExtensionsTests
{
	private static CollectionResponse<T> BuildPage<T>(int count, long total) where T : new()
	{
		var results = new List<T>();
		for (var i = 0; i < count; i++)
		{
			results.Add(new T());
		}

		return new CollectionResponse<T>
		{
			Results = results,
			Paging = new Paging { TotalInstances = total }
		};
	}

	/// <summary>Verifies that GetFirmwaresAllAsync returns every result across all pages.</summary>
	[Fact]
	public async Task GetFirmwaresAllAsync_ReturnsAllResults()
	{
		var mock = new Mock<ISystem>();
		mock.Setup(s => s.GetFirmwaresAsync(It.IsAny<string?>(), It.IsAny<List<string>>(), It.IsAny<string?>(),
				It.IsAny<int?>(), It.IsAny<int?>(), It.IsAny<CancellationToken?>()))
			.ReturnsAsync(() => BuildPage<Firmware>(2, 2));

		var systems = mock.Object;

		var result = await systems.GetFirmwaresAllAsync(cancellationToken: TestContext.Current.CancellationToken);

		result.Results.Should().HaveCount(2);
	}

	/// <summary>Verifies that GetHciSystemsAllAsync returns every result across all pages.</summary>
	[Fact]
	public async Task GetHciSystemsAllAsync_ReturnsAllResults()
	{
		var mock = new Mock<ISystem>();
		mock.Setup(s => s.GetHciSystemsAsync(It.IsAny<string?>(), It.IsAny<List<string>>(), It.IsAny<string?>(),
				It.IsAny<int?>(), It.IsAny<int?>(), It.IsAny<CancellationToken>()))
			.ReturnsAsync(() => BuildPage<HciSystem>(2, 2));

		var systems = mock.Object;

		var result = await systems.GetHciSystemsAllAsync(cancellationToken: TestContext.Current.CancellationToken);

		result.Results.Should().HaveCount(2);
	}

	/// <summary>Verifies that GetNetworkSystemsAllAsync returns every result across all pages.</summary>
	[Fact]
	public async Task GetNetworkSystemsAllAsync_ReturnsAllResults()
	{
		var mock = new Mock<ISystem>();
		mock.Setup(s => s.GetNetworkSystemsAsync(It.IsAny<string?>(), It.IsAny<List<string>>(), It.IsAny<string?>(),
				It.IsAny<int?>(), It.IsAny<int?>(), It.IsAny<CancellationToken>()))
			.ReturnsAsync(() => BuildPage<NetworkSystem>(2, 2));

		var systems = mock.Object;

		var result = await systems.GetNetworkSystemsAllAsync(cancellationToken: TestContext.Current.CancellationToken);

		result.Results.Should().HaveCount(2);
	}

	/// <summary>Verifies that GetServerSystemsAllAsync returns every result across all pages.</summary>
	[Fact]
	public async Task GetServerSystemsAllAsync_ReturnsAllResults()
	{
		var mock = new Mock<ISystem>();
		mock.Setup(s => s.GetServerSystemsAsync(It.IsAny<string?>(), It.IsAny<List<string>>(), It.IsAny<string?>(),
				It.IsAny<int?>(), It.IsAny<int?>(), It.IsAny<CancellationToken>()))
			.ReturnsAsync(() => BuildPage<ServerSystem>(2, 2));

		var systems = mock.Object;

		var result = await systems.GetServerSystemsAllAsync(cancellationToken: TestContext.Current.CancellationToken);

		result.Results.Should().HaveCount(2);
	}

	/// <summary>Verifies that GetStorageSystemsAllAsync returns every result across all pages.</summary>
	[Fact]
	public async Task GetStorageSystemsAllAsync_ReturnsAllResults()
	{
		var mock = new Mock<ISystem>();
		mock.Setup(s => s.GetStorageSystemsAsync(It.IsAny<string?>(), It.IsAny<List<string>>(), It.IsAny<string?>(),
				It.IsAny<int?>(), It.IsAny<int?>(), It.IsAny<CancellationToken>()))
			.ReturnsAsync(() => BuildPage<StorageSystem>(2, 2));

		var systems = mock.Object;

		var result = await systems.GetStorageSystemsAllAsync(cancellationToken: TestContext.Current.CancellationToken);

		result.Results.Should().HaveCount(2);
	}

	/// <summary>Verifies that GetSystemsAllAsync returns every result across all pages.</summary>
	[Fact]
	public async Task GetSystemsAllAsync_ReturnsAllResults()
	{
		var mock = new Mock<ISystem>();
		mock.Setup(s => s.GetSystemsAsync(It.IsAny<string?>(), It.IsAny<List<string>>(), It.IsAny<string?>(),
				It.IsAny<int?>(), It.IsAny<int?>(), It.IsAny<CancellationToken?>()))
			.ReturnsAsync(() => BuildPage<CloudIQSystem>(2, 2));

		var systems = mock.Object;

		var result = await systems.GetSystemsAllAsync(cancellationToken: TestContext.Current.CancellationToken);

		result.Results.Should().HaveCount(2);
	}
}
