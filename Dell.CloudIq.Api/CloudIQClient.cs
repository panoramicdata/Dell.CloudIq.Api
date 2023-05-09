using Microsoft.Extensions.Logging;

namespace Dell.CloudIq.Api;

public class CloudIQClient
{
	private readonly CloudIQClientOptions _clientOptions;
	private static int _limit; //TODO: Check to see if we want limit configurable - make unit testing better if we do

	public CloudIQClient(
		CloudIQClientOptions clientOptions,
		ILogger logger)
	{
		_clientOptions = clientOptions;
		_limit = clientOptions.Limit ?? 1000;

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

	public static async Task<CollectionResponse<T>> GetAllAsync<T>(
		Func<int, int, CancellationToken, Task<CollectionResponse<T>>> getPagedResponseAsync,
		CancellationToken cancellationToken = default)
	{
		var response = new CollectionResponse<T>();
		var pagingComplete = false;
		var pageOffset = 0;
		var limit = _limit;
		double maxPageOffset = 0;

		while (!pagingComplete)
		{
			var pageResponse = await getPagedResponseAsync(limit, pageOffset, cancellationToken).ConfigureAwait(false);
			response.Results.AddRange(pageResponse.Results);

			if (pageResponse?.Paging.TotalInstances is not null && pageResponse.Paging.TotalInstances != 0)
			{
				maxPageOffset = Math.Ceiling((double)(pageResponse.Paging.TotalInstances / limit));
			}

			if (pageOffset < maxPageOffset)
			{
				pageOffset++;
				continue;
			}

			pagingComplete = true;
		}

		return response;
	}
}
