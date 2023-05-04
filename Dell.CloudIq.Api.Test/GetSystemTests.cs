using FluentAssertions;
using Microsoft.Extensions.Logging;
using Refit;
using System.Text.Json;
using Xunit.Abstractions;

namespace Dell.CloudIq.Api.Test;
public class GetSystemTests : TestBase
{
	public GetSystemTests(ITestOutputHelper testOutputHelper) : base(testOutputHelper)
	{
	}

	[Fact]
	public async Task GetHciSystems_ReturnsList()
	{
		var clientOptions = GetClientOptions();
		var client = new CloudIQClient(clientOptions, Logger);

		var hciSystems = await client.System.GetHciSystemsAsync();

		hciSystems.Should().NotBeNull();
	}

	[Fact]
	public async Task GetHciSystem_ReturnsSystem()
	{
		var clientOptions = GetClientOptions();
		var client = new CloudIQClient(clientOptions, Logger);

		var hciSystems = await client.System.GetHciSystemsAsync();

		hciSystems.Should().NotBeNull();
		hciSystems.Results.Should().NotBeEmpty();
		var firstSystem = hciSystems.Results.First();

		var system = await client.System.GetHciSystemAsync(firstSystem.Id);
		system.Should().NotBeNull();
		system.Id.Should().Be(firstSystem.Id);
	}

	[Fact]
	public async Task GetSystems_ReturnsList()
	{
		var clientOptions = GetClientOptions();
		var client = new CloudIQClient(clientOptions, Logger);

		var systems = await client.System.GetSystemsAsync();

		systems.Should().NotBeNull();
	}

	[Fact]
	public async Task GetSystems_WithFilter_ReturnsList()
	{
		var clientOptions = GetClientOptions();
		var client = new CloudIQClient(clientOptions, Logger);

		var systems = await client.System.GetSystemsAsync(filter: "type eq 'POWEREDGE'");

		systems.Should().NotBeNull();
	}

	[Fact]
	public async Task GetSystems_WithSelect_ReturnsList()
	{
		var clientOptions = GetClientOptions();
		var client = new CloudIQClient(clientOptions, Logger);

		var systems = await client.System.GetSystemsAsync(select: new() { "id", "model" });

		systems.Should().NotBeNull();
	}

	[Fact]
	public async Task GetSystems_WithInvalidFilter_ReturnsError()
	{
		var clientOptions = GetClientOptions();
		var client = new CloudIQClient(clientOptions, Logger);

		var exception = await Assert.ThrowsAsync<ApiException>(() => client.System.GetSystemsAsync(filter: "<string>"));
		exception.StatusCode.Should().Be(System.Net.HttpStatusCode.InternalServerError);

		var errorResponse = JsonSerializer.Deserialize<ErrorResponse>(exception.Content!);

		if (errorResponse is not null)
		{
			errorResponse.Messages.First().Message.Should().Contain("Invalid Filter");
		}
	}
}
