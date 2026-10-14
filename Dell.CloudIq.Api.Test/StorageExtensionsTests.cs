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

	/// <summary>Verifies that GetDatastoresAllAsync returns every result across all pages.</summary>
	[Fact]
	public async Task GetDatastoresAllAsync_ReturnsAllResults()
	{
		var mock = new Mock<IStorage>();
		mock.Setup(s => s.GetDatastoresAsync(It.IsAny<string?>(), It.IsAny<List<string>>(), It.IsAny<string?>(),
				It.IsAny<int?>(), It.IsAny<int?>(), It.IsAny<CancellationToken?>()))
			.ReturnsAsync(() => BuildPage<DataStore>(2, 2));

		var storage = mock.Object;

		var result = await storage.GetDatastoresAllAsync(cancellationToken: TestContext.Current.CancellationToken);

		result.Results.Should().HaveCount(2);
	}

	/// <summary>Verifies that GetDrivesAllAsync returns every result across all pages.</summary>
	[Fact]
	public async Task GetDrivesAllAsync_ReturnsAllResults()
	{
		var mock = new Mock<IStorage>();
		mock.Setup(s => s.GetDrivesAsync(It.IsAny<string?>(), It.IsAny<List<string>>(), It.IsAny<string?>(),
				It.IsAny<int?>(), It.IsAny<int?>(), It.IsAny<CancellationToken?>()))
			.ReturnsAsync(() => BuildPage<Drive>(2, 2));

		var storage = mock.Object;

		var result = await storage.GetDrivesAllAsync(cancellationToken: TestContext.Current.CancellationToken);

		result.Results.Should().HaveCount(2);
	}

	/// <summary>Verifies that GetFilesystemsAllAsync returns every result across all pages.</summary>
	[Fact]
	public async Task GetFilesystemsAllAsync_ReturnsAllResults()
	{
		var mock = new Mock<IStorage>();
		mock.Setup(s => s.GetFilesystemsAsync(It.IsAny<string?>(), It.IsAny<List<string>>(), It.IsAny<string?>(),
				It.IsAny<int?>(), It.IsAny<int?>(), It.IsAny<CancellationToken?>()))
			.ReturnsAsync(() => BuildPage<Filesystem>(2, 2));

		var storage = mock.Object;

		var result = await storage.GetFilesystemsAllAsync(cancellationToken: TestContext.Current.CancellationToken);

		result.Results.Should().HaveCount(2);
	}

	/// <summary>Verifies that GetHostsAllAsync returns every result across all pages.</summary>
	[Fact]
	public async Task GetHostsAllAsync_ReturnsAllResults()
	{
		var mock = new Mock<IStorage>();
		mock.Setup(s => s.GetHostsAsync(It.IsAny<string?>(), It.IsAny<List<string>>(), It.IsAny<string?>(),
				It.IsAny<int?>(), It.IsAny<int?>(), It.IsAny<CancellationToken?>()))
			.ReturnsAsync(() => BuildPage<Host>(2, 2));

		var storage = mock.Object;

		var result = await storage.GetHostsAllAsync(cancellationToken: TestContext.Current.CancellationToken);

		result.Results.Should().HaveCount(2);
	}

	/// <summary>Verifies that GetPoolsAllAsync returns every result across all pages.</summary>
	[Fact]
	public async Task GetPoolsAllAsync_ReturnsAllResults()
	{
		var mock = new Mock<IStorage>();
		mock.Setup(s => s.GetPoolsAsync(It.IsAny<string?>(), It.IsAny<List<string>>(), It.IsAny<string?>(),
				It.IsAny<int?>(), It.IsAny<int?>(), It.IsAny<CancellationToken?>()))
			.ReturnsAsync(() => BuildPage<Pool>(2, 2));

		var storage = mock.Object;

		var result = await storage.GetPoolsAllAsync(cancellationToken: TestContext.Current.CancellationToken);

		result.Results.Should().HaveCount(2);
	}

	/// <summary>Verifies that GetStorageGroupsAllAsync returns every result across all pages.</summary>
	[Fact]
	public async Task GetStorageGroupsAllAsync_ReturnsAllResults()
	{
		var mock = new Mock<IStorage>();
		mock.Setup(s => s.GetStorageGroupsAsync(It.IsAny<string?>(), It.IsAny<List<string>>(), It.IsAny<string?>(),
				It.IsAny<int?>(), It.IsAny<int?>(), It.IsAny<CancellationToken>()))
			.ReturnsAsync(() => BuildPage<StorageGroup>(2, 2));

		var storage = mock.Object;

		var result = await storage.GetStorageGroupsAllAsync(cancellationToken: TestContext.Current.CancellationToken);

		result.Results.Should().HaveCount(2);
	}

	/// <summary>Verifies that GetStorageResourcePoolsAllAsync returns every result across all pages.</summary>
	[Fact]
	public async Task GetStorageResourcePoolsAllAsync_ReturnsAllResults()
	{
		var mock = new Mock<IStorage>();
		mock.Setup(s => s.GetStorageResourcePoolsAsync(It.IsAny<string?>(), It.IsAny<List<string>>(), It.IsAny<string?>(),
				It.IsAny<int?>(), It.IsAny<int?>(), It.IsAny<CancellationToken>()))
			.ReturnsAsync(() => BuildPage<Srp>(2, 2));

		var storage = mock.Object;

		var result = await storage.GetStorageResourcePoolsAllAsync(cancellationToken: TestContext.Current.CancellationToken);

		result.Results.Should().HaveCount(2);
	}

	/// <summary>Verifies that GetVirtualMachinesAllAsync returns every result across all pages.</summary>
	[Fact]
	public async Task GetVirtualMachinesAllAsync_ReturnsAllResults()
	{
		var mock = new Mock<IStorage>();
		mock.Setup(s => s.GetVirtualMachinesAsync(It.IsAny<string?>(), It.IsAny<List<string>>(), It.IsAny<string?>(),
				It.IsAny<int?>(), It.IsAny<int?>(), It.IsAny<CancellationToken>()))
			.ReturnsAsync(() => BuildPage<VirtualMachine>(2, 2));

		var storage = mock.Object;

		var result = await storage.GetVirtualMachinesAllAsync(cancellationToken: TestContext.Current.CancellationToken);

		result.Results.Should().HaveCount(2);
	}

	/// <summary>Verifies that GetVolumesAllAsync returns every result across all pages.</summary>
	[Fact]
	public async Task GetVolumesAllAsync_ReturnsAllResults()
	{
		var mock = new Mock<IStorage>();
		mock.Setup(s => s.GetVolumesAsync(It.IsAny<string?>(), It.IsAny<List<string>>(), It.IsAny<string?>(),
				It.IsAny<int?>(), It.IsAny<int?>(), It.IsAny<CancellationToken?>()))
			.ReturnsAsync(() => BuildPage<Volume>(2, 2));

		var storage = mock.Object;

		var result = await storage.GetVolumesAllAsync(cancellationToken: TestContext.Current.CancellationToken);

		result.Results.Should().HaveCount(2);
	}
}
