namespace Dell.CloudIq.Api.Test;

/// <summary>Tests for the <see cref="BasicSystemInformation"/> model.</summary>
public class BasicSystemInformationTests
{
	/// <summary>Verifies that <c>BasicSystemInformation</c> reads back the values it was given.</summary>
	[Fact]
	public void Properties_ReadBackWhatWasWritten()
	{
		var info = new BasicSystemInformation
		{
			Id = "0",
			Name = "sys",
			Model = "PowerStore",
			ServiceTag = "TAG123",
			ReleaseVersion = "1.0",
			SupportedApiVersions = ["1.0", "1.1"]
		};

		AssertValues(info, ["1.0", "1.1"]);
	}

	/// <summary>Verifies that <c>BasicSystemInformation</c> deserialises from the JSON shape CloudIQ returns.</summary>
	[Fact]
	public void Deserialize_FromCloudIqShape_ReadsEveryField()
	{
		var json = """{"id":"0","name":"sys","model":"PowerStore","service_tag":"TAG123","release_version":"1.0","supported_api_versions":["1.0"]}""";

		var info = JsonSerializer.Deserialize<BasicSystemInformation>(json);

		info.Should().NotBeNull();
		AssertValues(info!, ["1.0"]);
	}

	private static void AssertValues(BasicSystemInformation info, string[] expectedApiVersions)
	{
		info.Id.Should().Be("0");
		info.Name.Should().Be("sys");
		info.Model.Should().Be("PowerStore");
		info.ServiceTag.Should().Be("TAG123");
		info.ReleaseVersion.Should().Be("1.0");
		info.SupportedApiVersions.Should().Equal(expectedApiVersions);
	}
}
