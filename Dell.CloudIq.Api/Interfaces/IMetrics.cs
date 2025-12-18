namespace Dell.CloudIq.Api.Interfaces;

public interface IMetrics
{
	/// <summary>
	/// Get a Metric Metadata
	/// </summary>
	/// <remarks>
	/// Get a metric metadata by its ID.
	/// </remarks>

	/// <param name="id">Unique identifier of the metric metadata instance.</param>
	/// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
	/// <returns>OK</returns>
	/// <exception cref="ApiException">A server side error occurred.</exception>
	[Get("/rest/v1/metric-metadata/{id}")]
	Task<MetricMetadataInstance> GetMetricMetadataInstanceAsync(
		string id,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Get Metric Metadata
	/// </summary>
	/// <remarks>
	/// Get a list of all the metric metadata.
	/// </remarks>

	/// <param name="filter">This filters rows in a query, by constraining the result to rows matching the property condition specified.</param>
	/// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
	/// <returns>OK</returns>
	/// <exception cref="ApiException">A server side error occurred.</exception>
	[Get("/rest/v1/metric-metadata")]
	Task<MetricMetadataInstances> GetMetricMetadataCollectionAsync(
		string? filter = null,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Get Metrics
	/// </summary>
	/// <remarks>
	/// Perform a metrics query to the system. Responses are always in timestamp granularity - either all requested data for a timestamp is returned, or none.
	/// </remarks>
	/// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
	/// <returns>OK</returns>
	/// <exception cref="ApiException">A server side error occurred.</exception>
	[Post("/rest/v1/metrics/query")]
	Task<MetricsResponseEntries> PostMetricsQueryAsync([Body] MetricsQuery body, CancellationToken cancellationToken = default);
}
