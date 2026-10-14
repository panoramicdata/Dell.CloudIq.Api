namespace Dell.CloudIq.Api.Test;

using Dell.CloudIq.Api.Interfaces;

/// <summary>Tests for the <see cref="HardwareExtensions"/> all-pages paging helpers.</summary>
public class HardwareExtensionsTests
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

	/// <summary>Verifies that GetEsxiHostsAllAsync returns every result across all pages.</summary>
	[Fact]
	public async Task GetEsxiHostsAllAsync_ReturnsAllResults()
	{
		var mock = new Mock<IHardware>();
		mock.Setup(s => s.GetEsxiHostsAsync(It.IsAny<string?>(), It.IsAny<List<string>>(), It.IsAny<string?>(),
				It.IsAny<int?>(), It.IsAny<int?>(), It.IsAny<CancellationToken>()))
			.ReturnsAsync(() => BuildPage<EsxiHost>(2, 2));

		var hardware = mock.Object;

		var result = await hardware.GetEsxiHostsAllAsync(cancellationToken: TestContext.Current.CancellationToken);

		result.Results.Should().HaveCount(2);
	}

	/// <summary>Verifies that GetPortsAllAsync returns every result across all pages.</summary>
	[Fact]
	public async Task GetPortsAllAsync_ReturnsAllResults()
	{
		var mock = new Mock<IHardware>();
		mock.Setup(s => s.GetPortsAsync(It.IsAny<string?>(), It.IsAny<List<string>>(), It.IsAny<string?>(),
				It.IsAny<int?>(), It.IsAny<int?>(), It.IsAny<CancellationToken>()))
			.ReturnsAsync(() => BuildPage<Port>(2, 2));

		var hardware = mock.Object;

		var result = await hardware.GetPortsAllAsync(cancellationToken: TestContext.Current.CancellationToken);

		result.Results.Should().HaveCount(2);
	}
}
