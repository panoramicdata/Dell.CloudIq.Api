namespace Dell.CloudIq.Api.Test;

/// <summary>
/// Tests that the models keep hold of JSON properties CloudIQ sends but the models do not declare.
/// Every model carries the same extension-data property, so these cover the shared behaviour.
/// </summary>
/// <param name="testOutputHelper">The xUnit test output helper.</param>
public class ModelSerializationTests(ITestOutputHelper testOutputHelper) : TestBase(testOutputHelper)
{
	/// <summary>Verifies that an undeclared JSON property is kept in <c>AdditionalProperties</c>.</summary>
	[Fact]
	public void Deserialize_WithUndeclaredProperty_KeepsItInAdditionalProperties()
	{
		var system = JsonSerializer.Deserialize<CloudIQSystem>("""{"id":"sys-1","undeclared":"kept"}""");

		system.Should().NotBeNull();
		system!.Id.Should().Be("sys-1");
		system.AdditionalProperties.Should().ContainKey("undeclared");
		system.AdditionalProperties["undeclared"].ToString().Should().Be("kept");
	}

	/// <summary>Verifies that an added property is written back out at the top level.</summary>
	[Fact]
	public void Serialize_WithAdditionalProperty_WritesItAtTheTopLevel()
	{
		var system = new CloudIQSystem { Id = "sys-1" };
		system.AdditionalProperties["undeclared"] = "kept";

		var json = JsonSerializer.Serialize(system);

		json.Should().Contain("""
			"undeclared":"kept"
			""");
	}

	/// <summary>Verifies that <c>AdditionalProperties</c> is usable without being assigned first.</summary>
	[Fact]
	public void AdditionalProperties_WhenNotSet_IsEmptyRatherThanNull()
	{
		new Paging().AdditionalProperties.Should().BeEmpty();
	}

	/// <summary>Verifies that a generic collection wrapper also keeps undeclared properties.</summary>
	[Fact]
	public void Deserialize_Collection_KeepsUndeclaredPropertyOnTheWrapper()
	{
		var response = JsonSerializer.Deserialize<CollectionResponse<CloudIQSystem>>(
			"""{"results":[{"id":"a"}],"undeclared":1}""");

		response.Should().NotBeNull();
		response!.Results.Should().HaveCount(1);
		response.AdditionalProperties.Should().ContainKey("undeclared");
	}
}
