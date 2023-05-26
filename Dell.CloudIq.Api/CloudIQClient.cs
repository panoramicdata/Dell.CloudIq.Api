using Dell.CloudIq.Api.Validators;
using FluentValidation;
using Microsoft.Extensions.Logging;

namespace Dell.CloudIq.Api;

/// <summary>
/// A Dell Cloud IQ API client
/// </summary>
public class CloudIqClient
{
	/// <summary>
	/// A Dell Cloud IQ client
	/// </summary>
	/// <param name="clientOptions">The CloudIQClientOptions used for contacting the API</param>
	/// <param name="logger"></param>
	public CloudIqClient(
		CloudIqClientOptions clientOptions,
		ILogger logger)
	{
		ValidateClientOptions(clientOptions);

		var handler = new AuthenticatedHttpClientHandler(clientOptions, logger);
		var httpClient = new HttpClient(handler)
		{
			BaseAddress = new($"{clientOptions.BaseUri}/cloudiq")
		};

		var jsonSerializerOptions = new System.Text.Json.JsonSerializerOptions();
		jsonSerializerOptions.Converters.Add(new JsonStringEnumConverter());
		jsonSerializerOptions.Converters.Add(new JsonStringEnumMemberConverter());

		//TODO: Set the jsonSerializerOptions.UnmappedMemberHandling when .Net8 is released. https://learn.microsoft.com/en-us/dotnet/standard/serialization/system-text-json/missing-members?source=recommendations
		var refitSettings = new RefitSettings
		{
			ContentSerializer = new SystemTextJsonContentSerializer(jsonSerializerOptions)
		};

		Hardware = RestService.For<IHardware>(httpClient, refitSettings);
		Metrics = RestService.For<IMetrics>(httpClient, refitSettings);
		Storage = RestService.For<IStorage>(httpClient, refitSettings);
		System = RestService.For<ISystem>(httpClient, refitSettings);
	}

	private static void ValidateClientOptions(CloudIqClientOptions clientOptions)
	{
		var validator = new CloudIQClientOptionsValidator();
		validator.ValidateAndThrow(clientOptions);
	}

	public IHardware Hardware { get; set; }

	public IMetrics Metrics { get; set; }

	public IStorage Storage { get; set; }

	public ISystem System { get; set; }
}
