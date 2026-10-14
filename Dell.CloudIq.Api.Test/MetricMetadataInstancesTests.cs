namespace Dell.CloudIq.Api.Test;

/// <summary>Tests for the <see cref="MetricMetadataInstances"/> model.</summary>
public class MetricMetadataInstancesTests
{
	/// <summary>Verifies that a default <c>MetricMetadataInstances</c> starts with zero results.</summary>
	[Fact]
	public void Defaults_AreEmpty()
	{
		var instances = new MetricMetadataInstances();

		instances.Results.Should().BeEmpty();
	}

	/// <summary>Verifies that <c>MetricMetadataInstances</c> deserialises from the JSON shape CloudIQ returns.</summary>
	[Fact]
	public void Deserialize_FromCloudIqShape_ReadsEveryField()
	{
		var json = """{"results":[{"id":"mm-1","name":"m"}]}""";

		var instances = JsonSerializer.Deserialize<MetricMetadataInstances>(json);

		instances.Should().NotBeNull();
		instances!.Results.Should().HaveCount(1);
		instances.Results[0].Id.Should().Be("mm-1");
	}
}
