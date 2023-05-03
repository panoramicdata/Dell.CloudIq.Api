namespace Dell.CloudIq.Api;

public interface ICompute
{
	/// <summary>
	/// Get a EsxiHost
	/// </summary>
	/// <remarks>
	/// Get a esxi host by its ID.
	/// </remarks>
	/// <param name="id">The esxi host ID to retrieve</param>
	/// <param name="select">By default, all properties are returned in resource instances. This can be very expensive - large and slow for large collection responses in particular. This allows the client to select the specific properties that they need, which in addition to the performance benefits for the client and server, also documents the dependencies of the client code, and makes it more resilient to changes on the server side. If the select query contains a tag key that has special characters (such as a dot, dash, or underscore), then the user needs to enclose such keys within parentheses (). Examples are tags(dot.key.0), tags(dash-key-0), or tags(underscore_0). If the key does not contain any special characters, then examples of what the user can use are tags.BusinessUnit or tags(BusinessUnit).</param>
	/// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
	/// <returns>OK</returns>
	/// <exception cref="ApiException">A server side error occurred.</exception>
	[Get("/rest/v1/compute_hosts/{id}")]
	Task<EsxiHost> GetHostAsync(
		string id,
		List<string>? select = null,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Get EsxiHosts
	/// </summary>
	/// <remarks>
	/// Get a list of all the esxi host objects.
	/// </remarks>
	/// <param name="filter">This filters rows in a query, by constraining the result to rows matching the property condition(s) specified. Multiple filters are valid and are "and"ed together. If the filter query contains a tag key that has special characters (such as a dot, dash, or underscore), then the user needs to enclose such keys within parentheses (). Examples are tags(dot.key.0), tags(dash-key-0), or tags(underscore_0). If the key does not contain any special characters, then examples of what the user can use are tags.BusinessUnit or tags(BusinessUnit).</param>
	/// <param name="select">By default, all properties are returned in resource instances. This can be very expensive - large and slow for large collection responses in particular. This allows the client to select the specific properties that they need, which in addition to the performance benefits for the client and server, also documents the dependencies of the client code, and makes it more resilient to changes on the server side. If the select query contains a tag key that has special characters (such as a dot, dash, or underscore), then the user needs to enclose such keys within parentheses (). Examples are tags(dot.key.0), tags(dash-key-0), or tags(underscore_0). If the key does not contain any special characters, then examples of what the user can use are tags.BusinessUnit or tags(BusinessUnit).</param>
	/// <param name="order">Sorts the result set by the properties specified. Ascending order is default if not specified. If the order query contains a tag key that has special characters (such as a dot, dash, or underscore), then the user needs to enclose such keys within parentheses (). Examples are tags(dot.key.0), tags(dash-key-0), or tags(underscore_0). If the key does not contain any special characters, then examples of what the user can use are tags.BusinessUnit or tags(BusinessUnit).</param>
	/// <param name="limit">Optional page size desired for the response. Default value may be platform specified, either globally or per resource type. If paging is supported, the max size should be limited also, whether or not the client specifies a limit. A reasonable max page size in on the order of 1000 items but can vary. Smaller could be better for large instance representations.</param>
	/// <param name="offset">Optional page size desired for the response. Default value may be platform specified, either globally or per resource type. If paging is supported, the max size should be limited also, whether or not the client specifies a limit. A reasonable max page size in on the order of 1000 items but can vary. Smaller could be better for large instance representations.</param>
	/// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
	/// <returns>OK</returns>
	/// <exception cref="ApiException">A server side error occurred.</exception>
	[Get("/rest/v1/compute_hosts")]
	Task<CollectionResponse<EsxiHost>> GetHostsAsync(
		string? filter = null,
		List<string>? select = null,
		string? order = null,
		int? limit = null,
		int? offset = null,
		CancellationToken cancellationToken = default);

}
