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
		System.Linq.Expressions.Expression<Func<ISystem, Task<CollectionResponse<T>>>> setup,
		System.Func<ISystem, Task<CollectionResponse<T>>> invoke) where T : new()
	{
		var mock = new Mock<ISystem>();
		mock.Setup(setup).ReturnsAsync(() => BuildPage<T>(2, 2));

		var result = await invoke(mock.Object);

		result.Results.Should().HaveCount(2);
	}

	/// <summary>Verifies that GetFirmwaresAllAsync returns every result across all pages.</summary>
	[Fact]
	public async Task GetFirmwaresAllAsync_ReturnsAllResults()
	{
		await RunAllPagesTest<Firmware>(
			s => s.GetFirmwaresAsync(It.IsAny<string?>(), It.IsAny<List<string>>(), It.IsAny<string?>(),
				It.IsAny<int?>(), It.IsAny<int?>(), It.IsAny<CancellationToken?>()),
			s => s.GetFirmwaresAllAsync(cancellationToken: TestContext.Current.CancellationToken));
	}

	/// <summary>Verifies that GetHciSystemsAllAsync returns every result across all pages.</summary>
	[Fact]
	public async Task GetHciSystemsAllAsync_ReturnsAllResults()
	{
		await RunAllPagesTest<HciSystem>(
			s => s.GetHciSystemsAsync(It.IsAny<string?>(), It.IsAny<List<string>>(), It.IsAny<string?>(),
				It.IsAny<int?>(), It.IsAny<int?>(), It.IsAny<CancellationToken>()),
			s => s.GetHciSystemsAllAsync(cancellationToken: TestContext.Current.CancellationToken));
	}

	/// <summary>Verifies that GetNetworkSystemsAllAsync returns every result across all pages.</summary>
	[Fact]
	public async Task GetNetworkSystemsAllAsync_ReturnsAllResults()
	{
		await RunAllPagesTest<NetworkSystem>(
			s => s.GetNetworkSystemsAsync(It.IsAny<string?>(), It.IsAny<List<string>>(), It.IsAny<string?>(),
				It.IsAny<int?>(), It.IsAny<int?>(), It.IsAny<CancellationToken>()),
			s => s.GetNetworkSystemsAllAsync(cancellationToken: TestContext.Current.CancellationToken));
	}

	/// <summary>Verifies that GetServerSystemsAllAsync returns every result across all pages.</summary>
	[Fact]
	public async Task GetServerSystemsAllAsync_ReturnsAllResults()
	{
		await RunAllPagesTest<ServerSystem>(
			s => s.GetServerSystemsAsync(It.IsAny<string?>(), It.IsAny<List<string>>(), It.IsAny<string?>(),
				It.IsAny<int?>(), It.IsAny<int?>(), It.IsAny<CancellationToken>()),
			s => s.GetServerSystemsAllAsync(cancellationToken: TestContext.Current.CancellationToken));
	}

	/// <summary>Verifies that GetStorageSystemsAllAsync returns every result across all pages.</summary>
	[Fact]
	public async Task GetStorageSystemsAllAsync_ReturnsAllResults()
	{
		await RunAllPagesTest<StorageSystem>(
			s => s.GetStorageSystemsAsync(It.IsAny<string?>(), It.IsAny<List<string>>(), It.IsAny<string?>(),
				It.IsAny<int?>(), It.IsAny<int?>(), It.IsAny<CancellationToken>()),
			s => s.GetStorageSystemsAllAsync(cancellationToken: TestContext.Current.CancellationToken));
	}

	/// <summary>Verifies that GetSystemsAllAsync returns every result across all pages.</summary>
	[Fact]
	public async Task GetSystemsAllAsync_ReturnsAllResults()
	{
		await RunAllPagesTest<CloudIQSystem>(
			s => s.GetSystemsAsync(It.IsAny<string?>(), It.IsAny<List<string>>(), It.IsAny<string?>(),
				It.IsAny<int?>(), It.IsAny<int?>(), It.IsAny<CancellationToken?>()),
			s => s.GetSystemsAllAsync(cancellationToken: TestContext.Current.CancellationToken));
	}
}
