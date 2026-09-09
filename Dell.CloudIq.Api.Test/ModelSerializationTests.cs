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

	/// <summary>
	/// Verifies that a model reads both the properties it declares itself and the ones it inherits
	/// from its base, which is what the shared system and storage bases rely on.
	/// </summary>
	[Fact]
	public void Deserialize_WithInheritedAndOwnProperties_ReadsBoth()
	{
		var storageSystem = JsonSerializer.Deserialize<StorageSystem>(
			"""{"id":"sys-1","object_name":"array-1","health_score":95,"bandwidth":1234}""");

		storageSystem.Should().NotBeNull();
		storageSystem!.Id.Should().Be("sys-1");
		storageSystem.ObjectName.Should().Be("array-1");
		storageSystem.HealthScore.Should().Be(95);
		storageSystem.Bandwidth.Should().Be(1234);
	}

	/// <summary>Verifies that inherited properties are written out under their own JSON names.</summary>
	[Fact]
	public void Serialize_WithInheritedAndOwnProperties_WritesBoth()
	{
		var volume = new Volume { Id = "vol-1", ObjectName = "volume-1", Bandwidth = 99 };

		var json = JsonSerializer.Serialize(volume);

		json.Should().Contain("""
			"id":"vol-1"
			""");
		json.Should().Contain("""
			"object_name":"volume-1"
			""");
		json.Should().Contain("""
			"bandwidth":99
			""");
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
