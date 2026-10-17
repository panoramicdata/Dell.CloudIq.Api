namespace Dell.CloudIq.Api.Test;

using Dell.CloudIq.Api.Interfaces;

/// <summary>Tests for the <see cref="StorageExtensions"/> all-pages paging helpers.</summary>
public class StorageExtensionsTests
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

	private static async Task VerifyAll<T>(
		System.Linq.Expressions.Expression<Func<IStorage, Task<CollectionResponse<T>>>> setup,
		System.Func<IStorage, Task<CollectionResponse<T>>> all) where T : new()
	{
		var mock = new Mock<IStorage>();
		mock.Setup(setup).ReturnsAsync(() => BuildPage<T>(2, 2));
		var result = await all(mock.Object);
		result.Results.Should().HaveCount(2);
	}

	/// <summary>Verifies that GetDatastoresAllAsync returns every result across all pages.</summary>
	[Fact]
	public async Task GetDatastoresAllAsync_ReturnsAllResults()
	{
		await VerifyAll<DataStore>(
			s => s.GetDatastoresAsync(It.IsAny<string?>(), It.IsAny<List<string>>(), It.IsAny<string?>(),
				It.IsAny<int?>(), It.IsAny<int?>(), It.IsAny<CancellationToken?>()),
			s => s.GetDatastoresAllAsync(cancellationToken: TestContext.Current.CancellationToken));
	}

	/// <summary>Verifies that GetDrivesAllAsync returns every result across all pages.</summary>
	[Fact]
	public async Task GetDrivesAllAsync_ReturnsAllResults()
	{
		await VerifyAll<Drive>(
			s => s.GetDrivesAsync(It.IsAny<string?>(), It.IsAny<List<string>>(), It.IsAny<string?>(),
				It.IsAny<int?>(), It.IsAny<int?>(), It.IsAny<CancellationToken?>()),
			s => s.GetDrivesAllAsync(cancellationToken: TestContext.Current.CancellationToken));
	}

	/// <summary>Verifies that GetFilesystemsAllAsync returns every result across all pages.</summary>
	[Fact]
	public async Task GetFilesystemsAllAsync_ReturnsAllResults()
	{
		await VerifyAll<Filesystem>(
			s => s.GetFilesystemsAsync(It.IsAny<string?>(), It.IsAny<List<string>>(), It.IsAny<string?>(),
				It.IsAny<int?>(), It.IsAny<int?>(), It.IsAny<CancellationToken?>()),
			s => s.GetFilesystemsAllAsync(cancellationToken: TestContext.Current.CancellationToken));
	}

	/// <summary>Verifies that GetHostsAllAsync returns every result across all pages.</summary>
	[Fact]
	public async Task GetHostsAllAsync_ReturnsAllResults()
	{
		await VerifyAll<Host>(
			s => s.GetHostsAsync(It.IsAny<string?>(), It.IsAny<List<string>>(), It.IsAny<string?>(),
				It.IsAny<int?>(), It.IsAny<int?>(), It.IsAny<CancellationToken?>()),
			s => s.GetHostsAllAsync(cancellationToken: TestContext.Current.CancellationToken));
	}

	/// <summary>Verifies that GetPoolsAllAsync returns every result across all pages.</summary>
	[Fact]
	public async Task GetPoolsAllAsync_ReturnsAllResults()
	{
		await VerifyAll<Pool>(
			s => s.GetPoolsAsync(It.IsAny<string?>(), It.IsAny<List<string>>(), It.IsAny<string?>(),
				It.IsAny<int?>(), It.IsAny<int?>(), It.IsAny<CancellationToken?>()),
			s => s.GetPoolsAllAsync(cancellationToken: TestContext.Current.CancellationToken));
	}

	/// <summary>Verifies that GetStorageGroupsAllAsync returns every result across all pages.</summary>
	[Fact]
	public async Task GetStorageGroupsAllAsync_ReturnsAllResults()
	{
		await VerifyAll<StorageGroup>(
			s => s.GetStorageGroupsAsync(It.IsAny<string?>(), It.IsAny<List<string>>(), It.IsAny<string?>(),
				It.IsAny<int?>(), It.IsAny<int?>(), It.IsAny<CancellationToken>()),
			s => s.GetStorageGroupsAllAsync(cancellationToken: TestContext.Current.CancellationToken));
	}

	/// <summary>Verifies that GetStorageResourcePoolsAllAsync returns every result across all pages.</summary>
	[Fact]
	public async Task GetStorageResourcePoolsAllAsync_ReturnsAllResults()
	{
		await VerifyAll<Srp>(
			s => s.GetStorageResourcePoolsAsync(It.IsAny<string?>(), It.IsAny<List<string>>(), It.IsAny<string?>(),
				It.IsAny<int?>(), It.IsAny<int?>(), It.IsAny<CancellationToken>()),
			s => s.GetStorageResourcePoolsAllAsync(cancellationToken: TestContext.Current.CancellationToken));
	}

	/// <summary>Verifies that GetVirtualMachinesAllAsync returns every result across all pages.</summary>
	[Fact]
	public async Task GetVirtualMachinesAllAsync_ReturnsAllResults()
	{
		await VerifyAll<VirtualMachine>(
			s => s.GetVirtualMachinesAsync(It.IsAny<string?>(), It.IsAny<List<string>>(), It.IsAny<string?>(),
				It.IsAny<int?>(), It.IsAny<int?>(), It.IsAny<CancellationToken>()),
			s => s.GetVirtualMachinesAllAsync(cancellationToken: TestContext.Current.CancellationToken));
	}

	/// <summary>Verifies that GetVolumesAllAsync returns every result across all pages.</summary>
	[Fact]
	public async Task GetVolumesAllAsync_ReturnsAllResults()
	{
		await VerifyAll<Volume>(
			s => s.GetVolumesAsync(It.IsAny<string?>(), It.IsAny<List<string>>(), It.IsAny<string?>(),
				It.IsAny<int?>(), It.IsAny<int?>(), It.IsAny<CancellationToken?>()),
			s => s.GetVolumesAllAsync(cancellationToken: TestContext.Current.CancellationToken));
	}
}
