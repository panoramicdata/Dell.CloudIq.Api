namespace Dell.CloudIq.Api.Test;

/// <summary>Tests for the <see cref="Response"/> model.</summary>
public class ResponseTests
{
	/// <summary>Verifies that a default <c>Response</c> starts with an empty paging block and zero results.</summary>
	[Fact]
	public void Defaults_AreEmpty()
	{
		var response = new Response();

		response.Paging.Should().NotBeNull();
		response.Results.Should().BeEmpty();
	}

	/// <summary>Verifies that <c>Response</c> deserialises from the JSON shape CloudIQ returns.</summary>
	[Fact]
	public void Deserialize_FromCloudIqShape_ReadsEveryField()
	{
		var json = """{"paging":{"total_instances":1},"results":[{"id":"mm-1","name":"m"}]}""";

		var response = JsonSerializer.Deserialize<Response>(json);

		response.Should().NotBeNull();
		response!.Paging.TotalInstances.Should().Be(1);
		response.Results.Should().HaveCount(1);
		response.Results[0].Id.Should().Be("mm-1");
	}
}
