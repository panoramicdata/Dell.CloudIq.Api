namespace Dell.CloudIq.Api.Test;

/// <summary>Tests for the <see cref="ErrorMessages"/> model.</summary>
public class ErrorMessagesTests
{
	/// <summary>Verifies that <c>ErrorMessages</c> reads back the values it was given.</summary>
	[Fact]
	public void Properties_ReadBackWhatWasWritten()
	{
		VerifyFields(new ErrorMessages
		{
			Code = "E01",
			Timestamp = 123,
			Severity = Severity.CRITICAL,
			Message = "boom",
			MessageL10n = "explosion",
			Arguments = ["a", "b"]
		});
	}

	/// <summary>Verifies that <c>ErrorMessages</c> deserialises from the JSON shape CloudIQ returns.</summary>
	[Fact]
	public void Deserialize_FromCloudIqShape_ReadsEveryField()
	{
		var json = """{"code":"E01","timestamp":123,"severity":"CRITICAL","message":"boom","message_l10n":"explosion","arguments":["a","b"]}""";

		var message = JsonSerializer.Deserialize<ErrorMessages>(json);

		message.Should().NotBeNull();
		VerifyFields(message!);
	}

	private static void VerifyFields(ErrorMessages message)
	{
		message.Code.Should().Be("E01");
		message.Timestamp.Should().Be(123);
		message.Severity.Should().Be(Severity.CRITICAL);
		message.Message.Should().Be("boom");
		message.MessageL10n.Should().Be("explosion");
		message.Arguments.Should().HaveCount(2);
	}
}