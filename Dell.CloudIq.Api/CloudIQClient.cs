using Microsoft.Extensions.Logging;

namespace Dell.CloudIq.Api;

public class CloudIQClient
{
	private readonly CloudIQClientOptions _clientOptions;

	public CloudIQClient(
		CloudIQClientOptions clientOptions,
		ILogger logger)
	{
		_clientOptions = clientOptions;
		var handler = new AuthenticatedHttpClientHandler(clientOptions, logger);
		var httpClient = new HttpClient(handler)
		{
			BaseAddress = new($"{_clientOptions.BaseUri}/cloudiq")
		};

		var jsonSerializerOptions = new System.Text.Json.JsonSerializerOptions();
		jsonSerializerOptions.Converters.Add(new JsonStringEnumConverter());
		jsonSerializerOptions.Converters.Add(new JsonStringEnumMemberConverter());

		//TODO: Set the jsonSerializerOptions.UnmappedMemberHandling when .Net8 is released. https://learn.microsoft.com/en-us/dotnet/standard/serialization/system-text-json/missing-members?source=recommendations
		var refitSettings = new RefitSettings()
		{
			ContentSerializer = new SystemTextJsonContentSerializer(jsonSerializerOptions)
		};

		Hardware = RestService.For<IHardware>(httpClient, refitSettings);
		Metrics = RestService.For<IMetrics>(httpClient, refitSettings);
		Storage = RestService.For<IStorage>(httpClient, refitSettings);
		System = RestService.For<ISystem>(httpClient, refitSettings);
	}


	public IHardware Hardware { get; set; }

	public IMetrics Metrics { get; set; }

	public IStorage Storage { get; set; }

	public ISystem System { get; set; }
}
