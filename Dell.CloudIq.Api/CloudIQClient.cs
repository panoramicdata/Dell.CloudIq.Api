using Microsoft.Extensions.Logging;

namespace Dell.CloudIq.Api;

public class CloudIQClient
{
	private readonly CloudIQClientOptions _clientOptions;
	private readonly ILogger _logger;

	public CloudIQClient(
		CloudIQClientOptions clientOptions,
		ILogger logger)
	{
		_clientOptions = clientOptions;
		_logger = logger;
		var handler = new AuthenticatedHttpClientHandler(clientOptions, logger);
		var httpClient = new HttpClient(handler)
		{
			BaseAddress = new($"{_clientOptions.BaseUri}/cloudiq")
		};

		var jsonSerializerOptions = new System.Text.Json.JsonSerializerOptions();
		jsonSerializerOptions.Converters.Add(new JsonStringEnumConverter());

		//TODO: Set the jsonSerializerOptions.UnmappedMemberHandling when .Net8 is released. https://learn.microsoft.com/en-us/dotnet/standard/serialization/system-text-json/missing-members?source=recommendations
		var refitSettings = new RefitSettings()
		{
			ContentSerializer = new SystemTextJsonContentSerializer(jsonSerializerOptions)
		};

		Compute = RestService.For<ICompute>(httpClient, refitSettings);
		Hci = RestService.For<IHci>(httpClient, refitSettings);
		Network = RestService.For<INetwork>(httpClient, refitSettings);
		Resource = RestService.For<IResource>(httpClient, refitSettings);
		Server = RestService.For<IServer>(httpClient, refitSettings);
		Storage = RestService.For<IStorage>(httpClient, refitSettings);
		System = RestService.For<ISystem>(httpClient, refitSettings);
	}

	// TODO: Add the client

	public ICompute Compute { get; set; }

	public IHci Hci { get; set; }

	public INetwork Network { get; set; }

	public IResource Resource { get; set; }

	public IServer Server { get; set; }

	public IStorage Storage { get; set; }

	public ISystem System { get; set; }
}
