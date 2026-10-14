namespace Dell.CloudIq.Api.Test;

/// <summary>Tests for the <see cref="MetricsResponseEntry"/> model.</summary>
public class MetricsResponseEntryTests
{
	/// <summary>Verifies that <c>MetricsResponseEntry</c> reads back the values it was given.</summary>
	[Fact]
	public void Properties_ReadBackWhatWasWritten()
	{
		var entry = new MetricsResponseEntry
		{
			Id = "res-1",
			Timestamps = [new MetricsValueEntry()]
		};

		entry.Id.Should().Be("res-1");
		entry.Timestamps.Should().HaveCount(1);
	}

	/// <summary>Verifies that <c>MetricsResponseEntry</c> deserialises from the JSON shape CloudIQ returns.</summary>
	[Fact]
	public void Deserialize_FromCloudIqShape_ReadsEveryField()
	{
		var json = """{"id":"res-1","timestamps":[{"timestamp":"2024-01-01T00:00:00Z","values":[1.0,2.0]}]}""";

		var entry = JsonSerializer.Deserialize<MetricsResponseEntry>(json);

		entry.Should().NotBeNull();
		entry!.Id.Should().Be("res-1");
		entry.Timestamps.Should().HaveCount(1);
	}
}
