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

	/// <summary>Runs one all-pages test: configures the mock, invokes the target and asserts the result count.</summary>
	private static async Task RunAllPagesTest<T>(
		Action<Mock<ISystem>> setup,
		Func<ISystem, Task<CollectionResponse<T>>> invoke) where T : new()
	{
		var mock = new Mock<ISystem>();
		setup(mock);

		var result = await invoke(mock.Object);

		result.Results.Should().HaveCount(2);
	}

	/// <summary>Verifies that GetFirmwaresAllAsync returns every result across all pages.</summary>
	[Fact]
	public async Task GetFirmwaresAllAsync_ReturnsAllResults()
	{
		await RunAllPagesTest<Firmware>(
			mock => mock.Setup(s => s.GetFirmwaresAsync(It.IsAny<string?>(), It.IsAny<List<string>>(), It.IsAny<string?>(),
					It.IsAny<int?>(), It.IsAny<int?>(), It.IsAny<CancellationToken?>()))
				.ReturnsAsync(() => BuildPage<Firmware>(2, 2)),
			s => s.GetFirmwaresAllAsync(cancellationToken: TestContext.Current.CancellationToken));
	}

	/// <summary>Verifies that GetHciSystemsAllAsync returns every result across all pages.</summary>
	[Fact]
	public async Task GetHciSystemsAllAsync_ReturnsAllResults()
	{
		await RunAllPagesTest<HciSystem>(
			mock => mock.Setup(s => s.GetHciSystemsAsync(It.IsAny<string?>(), It.IsAny<List<string>>(), It.IsAny<string?>(),
					It.IsAny<int?>(), It.IsAny<int?>(), It.IsAny<CancellationToken>()))
				.ReturnsAsync(() => BuildPage<HciSystem>(2, 2)),
			s => s.GetHciSystemsAllAsync(cancellationToken: TestContext.Current.CancellationToken));
	}

	/// <summary>Verifies that GetNetworkSystemsAllAsync returns every result across all pages.</summary>
	[Fact]
	public async Task GetNetworkSystemsAllAsync_ReturnsAllResults()
	{
		await RunAllPagesTest<NetworkSystem>(
			mock => mock.Setup(s => s.GetNetworkSystemsAsync(It.IsAny<string?>(), It.IsAny<List<string>>(), It.IsAny<string?>(),
					It.IsAny<int?>(), It.IsAny<int?>(), It.IsAny<CancellationToken>()))
				.ReturnsAsync(() => BuildPage<NetworkSystem>(2, 2)),
			s => s.GetNetworkSystemsAllAsync(cancellationToken: TestContext.Current.CancellationToken));
	}

	/// <summary>Verifies that GetServerSystemsAllAsync returns every result across all pages.</summary>
	[Fact]
	public async Task GetServerSystemsAllAsync_ReturnsAllResults()
	{
		await RunAllPagesTest<ServerSystem>(
			mock => mock.Setup(s => s.GetServerSystemsAsync(It.IsAny<string?>(), It.IsAny<List<string>>(), It.IsAny<string?>(),
					It.IsAny<int?>(), It.IsAny<int?>(), It.IsAny<CancellationToken>()))
				.ReturnsAsync(() => BuildPage<ServerSystem>(2, 2)),
			s => s.GetServerSystemsAllAsync(cancellationToken: TestContext.Current.CancellationToken));
	}

	/// <summary>Verifies that GetStorageSystemsAllAsync returns every result across all pages.</summary>
	[Fact]
	public async Task GetStorageSystemsAllAsync_ReturnsAllResults()
	{
		await RunAllPagesTest<StorageSystem>(
			mock => mock.Setup(s => s.GetStorageSystemsAsync(It.IsAny<string?>(), It.IsAny<List<string>>(), It.IsAny<string?>(),
					It.IsAny<int?>(), It.IsAny<int?>(), It.IsAny<CancellationToken>()))
				.ReturnsAsync(() => BuildPage<StorageSystem>(2, 2)),
			s => s.GetStorageSystemsAllAsync(cancellationToken: TestContext.Current.CancellationToken));
	}

	/// <summary>Verifies that GetSystemsAllAsync returns every result across all pages.</summary>
	[Fact]
	public async Task GetSystemsAllAsync_ReturnsAllResults()
	{
		await RunAllPagesTest<CloudIQSystem>(
			mock => mock.Setup(s => s.GetSystemsAsync(It.IsAny<string?>(), It.IsAny<List<string>>(), It.IsAny<string?>(),
					It.IsAny<int?>(), It.IsAny<int?>(), It.IsAny<CancellationToken?>()))
				.ReturnsAsync(() => BuildPage<CloudIQSystem>(2, 2)),
			s => s.GetSystemsAllAsync(cancellationToken: TestContext.Current.CancellationToken));
	}
}
