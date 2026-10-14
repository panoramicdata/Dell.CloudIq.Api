namespace Dell.CloudIq.Api.Test;

using System.Net;

/// <summary>Tests for the <see cref="ErrorResponse"/> model.</summary>
public class ErrorResponseTests
{
	/// <summary>Verifies that <c>ErrorResponse</c> reads back the values it was given.</summary>
	[Fact]
	public void Properties_ReadBackWhatWasWritten()
	{
		var response = new ErrorResponse
		{
			HttpStatusCode = HttpStatusCode.InternalServerError,
			Messages = [new ErrorMessages { Code = "E01", Message = "boom" }]
		};

		response.HttpStatusCode.Should().Be(HttpStatusCode.InternalServerError);
		response.Messages.Should().HaveCount(1);
		response.Messages[0].Code.Should().Be("E01");
	}

	/// <summary>Verifies that <c>ErrorResponse</c> deserialises from the JSON shape CloudIQ returns.</summary>
	[Fact]
	public void Deserialize_FromCloudIqShape_ReadsEveryField()
	{
		var json = """{"http_status_code":500,"messages":[{"code":"E01","message":"boom"}]}""";

		var response = JsonSerializer.Deserialize<ErrorResponse>(json);

		response.Should().NotBeNull();
		response!.HttpStatusCode.Should().Be(HttpStatusCode.InternalServerError);
		response.Messages.Should().HaveCount(1);
		response.Messages[0].Code.Should().Be("E01");
	}
}
