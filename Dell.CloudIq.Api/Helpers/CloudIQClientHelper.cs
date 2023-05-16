namespace Dell.CloudIq.Api.Helpers;

internal static class CloudIQClientHelper
{
	internal static async Task<CollectionResponse<T>> GetAllAsync<T>(
		Func<int?, int, CancellationToken, Task<CollectionResponse<T>>> getPagedResponseAsync,
		CancellationToken cancellationToken = default)
	{
		var response = new CollectionResponse<T>();
		var pagingComplete = false;
		var limitPerPage = 1000;
		var pageOffset = 0;
		double maxPageOffset = 0;

		while (!pagingComplete)
		{
			var pageResponse = await getPagedResponseAsync(limitPerPage, pageOffset, cancellationToken).ConfigureAwait(false);
			response.Results.AddRange(pageResponse.Results);

			if (pageResponse?.Paging.TotalInstances is not null &&
				pageResponse.Paging.TotalInstances != 0)
			{
				maxPageOffset = Math.Ceiling((double)(pageResponse.Paging.TotalInstances / limitPerPage));
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