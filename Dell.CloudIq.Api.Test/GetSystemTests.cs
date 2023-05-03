using FluentAssertions;
using Microsoft.Extensions.Logging;
using Refit;
using System.Text.Json;
using Xunit.Abstractions;

namespace Dell.CloudIq.Api.Test;
public class GetSystemTests : TestBase
{
	private readonly ITestOutputHelper _testOutputHelper;
	private readonly ILogger _logger;

	public GetSystemTests(ITestOutputHelper testOutputHelper)
	{
		_testOutputHelper = testOutputHelper;
		_logger = testOutputHelper.BuildLogger();
	}

	[Fact]
	public async Task GetSystems_ReturnsList()
	{
		var clientOptions = GetClientOptions();
		var client = new CloudIQClient(clientOptions, _logger);

		var systems = await client.System.GetSystemsAsync();

		systems.Should().NotBeNull();
	}

	[Fact]
	public async Task GetSystems_WithFilter_ReturnsList()
	{
		var clientOptions = GetClientOptions();
		var client = new CloudIQClient(clientOptions, _logger);

		var systems = await client.System.GetSystemsAsync(filter: "type eq 'POWEREDGE'");

		systems.Should().NotBeNull();
	}

	[Fact]
	public async Task GetSystems_WithSelect_ReturnsList()
	{
		var clientOptions = GetClientOptions();
		var client = new CloudIQClient(clientOptions, _logger);

		var systems = await client.System.GetSystemsAsync(select: new() { "id", "model" });

		systems.Should().NotBeNull();
	}

	[Fact]
	public async Task GetSystems_WithInvalidFilter_ReturnsError()
	{
		var clientOptions = GetClientOptions();
		var client = new CloudIQClient(clientOptions, _logger);

		var exception = await Assert.ThrowsAsync<ApiException>(() => client.System.GetSystemsAsync(filter: "<string>"));
		exception.StatusCode.Should().Be(System.Net.HttpStatusCode.InternalServerError);

		var errorResponse = JsonSerializer.Deserialize<ErrorResponse>(exception.Content!);
		errorResponse.Messages[0].Message.Should().Contain("Invalid Filter");
	}
}
