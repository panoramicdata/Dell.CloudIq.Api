using FluentAssertions;
using Microsoft.Extensions.Logging;
using Xunit.Abstractions;

namespace Dell.CloudIq.Api.Test;
public class GetVirtualMachinesTests : TestBase
{
	private readonly ITestOutputHelper _testOutputHelper;
	private readonly ILogger _logger;

	public GetVirtualMachinesTests(ITestOutputHelper testOutputHelper)
	{
		_testOutputHelper = testOutputHelper;
		_logger = testOutputHelper.BuildLogger();
	}

	[Fact]
	public async Task GetMachines_ReturnsList()
	{
		var clientOptions = GetClientOptions();
		var client = new CloudIQClient(clientOptions, _logger);

		var machines = await client.Virtual.GetMachinesAsync();

		machines.Should().NotBeNull();
	}

	[Fact]
	public async Task GetMachine_ReturnsMachine()
	{
		var clientOptions = GetClientOptions();
		var client = new CloudIQClient(clientOptions, _logger);

		var virtualMachines = await client.Virtual.GetMachinesAsync();

		virtualMachines.Should().NotBeNull();
		var firstMachine = virtualMachines.Results.FirstOrDefault();

		if (firstMachine?.Id != null)
		{
			var machine = await client.Virtual.GetMachineAsync(firstMachine.Id);
			machine.Should().NotBeNull();
			machine.Id.Should().Be(firstMachine.Id);
		}
	}

}