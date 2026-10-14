namespace Dell.CloudIq.Api.Test;

/// <summary>Tests for the <see cref="MetricsQuery"/> model.</summary>
public class MetricsQueryTests
{
	/// <summary>Verifies that <c>MetricsQuery</c> reads back the values it was given.</summary>
	[Fact]
	public void Properties_ReadBackWhatWasWritten()
	{
		var query = new MetricsQuery
		{
			ResourceType = MetricMetadataResourceType.Volume,
			Ids = ["id-1"],
			Metrics = ["cpu"],
			Interval = MetricsInterval.PT5M,
			From = 10,
			To = 20
		};

		AssertExpectedValues(query);
	}

	/// <summary>Verifies that <c>MetricsQuery</c> deserialises from the JSON shape CloudIQ uses.</summary>
	[Fact]
	public void Deserialize_FromCloudIqShape_ReadsEveryField()
	{
		var json = """{"resource_type":"volume","ids":["id-1"],"metrics":["cpu"],"interval":"PT5M","from":10,"to":20}""";

		var query = JsonSerializer.Deserialize<MetricsQuery>(json);
		query.Should().NotBeNull();

		AssertExpectedValues(query);
	}

	/// <summary>Asserts every <see cref="MetricsQuery"/> field holds the value both tests use.</summary>
	private static void AssertExpectedValues(MetricsQuery query)
	{
		query.ResourceType.Should().Be(MetricMetadataResourceType.Volume);
		query.Ids.Should().Equal(["id-1"]);
		query.Metrics.Should().Equal(["cpu"]);
		query.Interval.Should().Be(MetricsInterval.PT5M);
		query.From.Should().Be(10);
		query.To.Should().Be(20);
	}
}
