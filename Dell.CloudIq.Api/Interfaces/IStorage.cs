﻿namespace Dell.CloudIq.Api;
public interface IStorage
{
	/// <summary>
	/// Get a DataStore
	/// </summary>
	/// <remarks>
	/// Get a datastore by its ID.
	/// </remarks>
	/// <param name="id">The datastore ID to retrieve</param>
	/// <param name="select">By default, all properties are returned in resource instances. This can be very expensive - large and slow for large collection responses in particular. This allows the client to select the specific properties that they need, which in addition to the performance benefits for the client and server, also documents the dependencies of the client code, and makes it more resilient to changes on the server side. If the select query contains a tag key that has special characters (such as a dot, dash, or underscore), then the user needs to enclose such keys within parentheses (). Examples are tags(dot.key.0), tags(dash-key-0), or tags(underscore_0). If the key does not contain any special characters, then examples of what the user can use are tags.BusinessUnit or tags(BusinessUnit).</param>
	/// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
	/// <returns>OK</returns>
	/// <exception cref="ApiException">A server side error occurred.</exception>
	[Get("/rest/v1/datastores/{id}")]
	Task<DataStore> GetDatastoreAsync(
		string id,
		List<string>? select = null,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Get DataStores
	/// </summary>
	/// <remarks>
	/// Get a list of all the datastore objects.
	/// </remarks>
	/// <param name="filter">This filters rows in a query, by constraining the result to rows matching the property condition(s) specified. Multiple filters are valid and are "and"ed together. If the filter query contains a tag key that has special characters (such as a dot, dash, or underscore), then the user needs to enclose such keys within parentheses (). Examples are tags(dot.key.0), tags(dash-key-0), or tags(underscore_0). If the key does not contain any special characters, then examples of what the user can use are tags.BusinessUnit or tags(BusinessUnit).</param>
	/// <param name="select">By default, all properties are returned in resource instances. This can be very expensive - large and slow for large collection responses in particular. This allows the client to select the specific properties that they need, which in addition to the performance benefits for the client and server, also documents the dependencies of the client code, and makes it more resilient to changes on the server side. If the select query contains a tag key that has special characters (such as a dot, dash, or underscore), then the user needs to enclose such keys within parentheses (). Examples are tags(dot.key.0), tags(dash-key-0), or tags(underscore_0). If the key does not contain any special characters, then examples of what the user can use are tags.BusinessUnit or tags(BusinessUnit).</param>
	/// <param name="order">Sorts the result set by the properties specified. Ascending order is default if not specified. If the order query contains a tag key that has special characters (such as a dot, dash, or underscore), then the user needs to enclose such keys within parentheses (). Examples are tags(dot.key.0), tags(dash-key-0), or tags(underscore_0). If the key does not contain any special characters, then examples of what the user can use are tags.BusinessUnit or tags(BusinessUnit).</param>
	/// <param name="limit">Optional page size desired for the response. Default value may be platform specified, either globally or per resource type. If paging is supported, the max size should be limited also, whether or not the client specifies a limit. A reasonable max page size in on the order of 1000 items but can vary. Smaller could be better for large instance representations.</param>
	/// <param name="offset">Optional page size desired for the response. Default value may be platform specified, either globally or per resource type. If paging is supported, the max size should be limited also, whether or not the client specifies a limit. A reasonable max page size in on the order of 1000 items but can vary. Smaller could be better for large instance representations.</param>
	/// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
	/// <returns>OK</returns>
	/// <exception cref="ApiException">A server side error occurred.</exception>
	[Get("/rest/v1/datastores")]
	Task<CollectionResponse<DataStore>> GetDatastoresAsync(
		string? filter = null,
		List<string>? select = null,
		string? order = null,
		int? limit = null,
		int? offset = null,
		CancellationToken? cancellationToken = default);

	/// <summary>
	/// Get a Drive
	/// </summary>
	/// <remarks>
	/// Get a drive by its ID.
	/// </remarks>
	/// <param name="id">The drive ID to retrieve</param>
	/// <param name="select">By default, all properties are returned in resource instances. This can be very expensive - large and slow for large collection responses in particular. This allows the client to select the specific properties that they need, which in addition to the performance benefits for the client and server, also documents the dependencies of the client code, and makes it more resilient to changes on the server side. If the select query contains a tag key that has special characters (such as a dot, dash, or underscore), then the user needs to enclose such keys within parentheses (). Examples are tags(dot.key.0), tags(dash-key-0), or tags(underscore_0). If the key does not contain any special characters, then examples of what the user can use are tags.BusinessUnit or tags(BusinessUnit).</param>
	/// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
	/// <returns>OK</returns>
	/// <exception cref="ApiException">A server side error occurred.</exception>
	[Get("/rest/v1/drives/{id}")]
	Task<Drive> GetDriveAsync(
		string id,
		List<string>? select = null,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Get Drives
	/// </summary>
	/// <remarks>
	/// Get a list of all the drive objects.
	/// </remarks>
	/// <param name="filter">This filters rows in a query, by constraining the result to rows matching the property condition(s) specified. Multiple filters are valid and are "and"ed together. If the filter query contains a tag key that has special characters (such as a dot, dash, or underscore), then the user needs to enclose such keys within parentheses (). Examples are tags(dot.key.0), tags(dash-key-0), or tags(underscore_0). If the key does not contain any special characters, then examples of what the user can use are tags.BusinessUnit or tags(BusinessUnit).</param>
	/// <param name="select">By default, all properties are returned in resource instances. This can be very expensive - large and slow for large collection responses in particular. This allows the client to select the specific properties that they need, which in addition to the performance benefits for the client and server, also documents the dependencies of the client code, and makes it more resilient to changes on the server side. If the select query contains a tag key that has special characters (such as a dot, dash, or underscore), then the user needs to enclose such keys within parentheses (). Examples are tags(dot.key.0), tags(dash-key-0), or tags(underscore_0). If the key does not contain any special characters, then examples of what the user can use are tags.BusinessUnit or tags(BusinessUnit).</param>
	/// <param name="order">Sorts the result set by the properties specified. Ascending order is default if not specified. If the order query contains a tag key that has special characters (such as a dot, dash, or underscore), then the user needs to enclose such keys within parentheses (). Examples are tags(dot.key.0), tags(dash-key-0), or tags(underscore_0). If the key does not contain any special characters, then examples of what the user can use are tags.BusinessUnit or tags(BusinessUnit).</param>
	/// <param name="limit">Optional page size desired for the response. Default value may be platform specified, either globally or per resource type. If paging is supported, the max size should be limited also, whether or not the client specifies a limit. A reasonable max page size in on the order of 1000 items but can vary. Smaller could be better for large instance representations.</param>
	/// <param name="offset">Optional page size desired for the response. Default value may be platform specified, either globally or per resource type. If paging is supported, the max size should be limited also, whether or not the client specifies a limit. A reasonable max page size in on the order of 1000 items but can vary. Smaller could be better for large instance representations.</param>
	/// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
	/// <returns>OK</returns>
	/// <exception cref="ApiException">A server side error occurred.</exception>
	[Get("/rest/v1/drives")]
	Task<CollectionResponse<Drive>> GetDrivesAsync(
		string? filter = null,
		List<string>? select = null,
		string? order = null,
		int? limit = null,
		int? offset = null,
		CancellationToken? cancellationToken = default);

	/// <summary>
	/// Get a Filesystem
	/// </summary>
	/// <remarks>
	/// Get a filesystem by its ID.
	/// </remarks>
	/// <param name="id">The filesystem ID to retrieve</param>
	/// <param name="select">By default, all properties are returned in resource instances. This can be very expensive - large and slow for large collection responses in particular. This allows the client to select the specific properties that they need, which in addition to the performance benefits for the client and server, also documents the dependencies of the client code, and makes it more resilient to changes on the server side. If the select query contains a tag key that has special characters (such as a dot, dash, or underscore), then the user needs to enclose such keys within parentheses (). Examples are tags(dot.key.0), tags(dash-key-0), or tags(underscore_0). If the key does not contain any special characters, then examples of what the user can use are tags.BusinessUnit or tags(BusinessUnit).</param>
	/// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
	/// <returns>OK</returns>
	/// <exception cref="ApiException">A server side error occurred.</exception>
	[Get("/rest/v1/filesystems/{id}")]
	Task<Filesystem> GetFilesystemAsync(
		string id,
		List<string>? select = null,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Get Filesystems
	/// </summary>
	/// <remarks>
	/// Get a list of all the filesystem objects.
	/// </remarks>
	/// <param name="filter">This filters rows in a query, by constraining the result to rows matching the property condition(s) specified. Multiple filters are valid and are "and"ed together. If the filter query contains a tag key that has special characters (such as a dot, dash, or underscore), then the user needs to enclose such keys within parentheses (). Examples are tags(dot.key.0), tags(dash-key-0), or tags(underscore_0). If the key does not contain any special characters, then examples of what the user can use are tags.BusinessUnit or tags(BusinessUnit).</param>
	/// <param name="select">By default, all properties are returned in resource instances. This can be very expensive - large and slow for large collection responses in particular. This allows the client to select the specific properties that they need, which in addition to the performance benefits for the client and server, also documents the dependencies of the client code, and makes it more resilient to changes on the server side. If the select query contains a tag key that has special characters (such as a dot, dash, or underscore), then the user needs to enclose such keys within parentheses (). Examples are tags(dot.key.0), tags(dash-key-0), or tags(underscore_0). If the key does not contain any special characters, then examples of what the user can use are tags.BusinessUnit or tags(BusinessUnit).</param>
	/// <param name="order">Sorts the result set by the properties specified. Ascending order is default if not specified. If the order query contains a tag key that has special characters (such as a dot, dash, or underscore), then the user needs to enclose such keys within parentheses (). Examples are tags(dot.key.0), tags(dash-key-0), or tags(underscore_0). If the key does not contain any special characters, then examples of what the user can use are tags.BusinessUnit or tags(BusinessUnit).</param>
	/// <param name="limit">Optional page size desired for the response. Default value may be platform specified, either globally or per resource type. If paging is supported, the max size should be limited also, whether or not the client specifies a limit. A reasonable max page size in on the order of 1000 items but can vary. Smaller could be better for large instance representations.</param>
	/// <param name="offset">Optional page size desired for the response. Default value may be platform specified, either globally or per resource type. If paging is supported, the max size should be limited also, whether or not the client specifies a limit. A reasonable max page size in on the order of 1000 items but can vary. Smaller could be better for large instance representations.</param>
	/// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
	/// <returns>OK</returns>
	/// <exception cref="ApiException">A server side error occurred.</exception>
	[Get("/rest/v1/filesystems")]
	Task<CollectionResponse<Filesystem>> GetFilesystemsAsync(
		string? filter = null,
		List<string>? select = null,
		string? order = null,
		int? limit = null,
		int? offset = null,
		CancellationToken? cancellationToken = default);

	/// <summary>
	/// Get a Host
	/// </summary>
	/// <remarks>
	/// Get a host by its ID.
	/// </remarks>
	/// <param name="id">The host ID to retrieve</param>
	/// <param name="select">By default, all properties are returned in resource instances. This can be very expensive - large and slow for large collection responses in particular. This allows the client to select the specific properties that they need, which in addition to the performance benefits for the client and server, also documents the dependencies of the client code, and makes it more resilient to changes on the server side. If the select query contains a tag key that has special characters (such as a dot, dash, or underscore), then the user needs to enclose such keys within parentheses (). Examples are tags(dot.key.0), tags(dash-key-0), or tags(underscore_0). If the key does not contain any special characters, then examples of what the user can use are tags.BusinessUnit or tags(BusinessUnit).</param>
	/// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
	/// <returns>OK</returns>
	/// <exception cref="ApiException">A server side error occurred.</exception>
	[Get("/rest/v1/hosts/{id}")]
	Task<Host> GetHostAsync(
		string id,
		List<string>? select = null,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Get Hosts
	/// </summary>
	/// <remarks>
	/// Get a list of all the host objects.
	/// </remarks>
	/// <param name="filter">This filters rows in a query, by constraining the result to rows matching the property condition(s) specified. Multiple filters are valid and are "and"ed together. If the filter query contains a tag key that has special characters (such as a dot, dash, or underscore), then the user needs to enclose such keys within parentheses (). Examples are tags(dot.key.0), tags(dash-key-0), or tags(underscore_0). If the key does not contain any special characters, then examples of what the user can use are tags.BusinessUnit or tags(BusinessUnit).</param>
	/// <param name="select">By default, all properties are returned in resource instances. This can be very expensive - large and slow for large collection responses in particular. This allows the client to select the specific properties that they need, which in addition to the performance benefits for the client and server, also documents the dependencies of the client code, and makes it more resilient to changes on the server side. If the select query contains a tag key that has special characters (such as a dot, dash, or underscore), then the user needs to enclose such keys within parentheses (). Examples are tags(dot.key.0), tags(dash-key-0), or tags(underscore_0). If the key does not contain any special characters, then examples of what the user can use are tags.BusinessUnit or tags(BusinessUnit).</param>
	/// <param name="order">Sorts the result set by the properties specified. Ascending order is default if not specified. If the order query contains a tag key that has special characters (such as a dot, dash, or underscore), then the user needs to enclose such keys within parentheses (). Examples are tags(dot.key.0), tags(dash-key-0), or tags(underscore_0). If the key does not contain any special characters, then examples of what the user can use are tags.BusinessUnit or tags(BusinessUnit).</param>
	/// <param name="limit">Optional page size desired for the response. Default value may be platform specified, either globally or per resource type. If paging is supported, the max size should be limited also, whether or not the client specifies a limit. A reasonable max page size in on the order of 1000 items but can vary. Smaller could be better for large instance representations.</param>
	/// <param name="offset">Optional page size desired for the response. Default value may be platform specified, either globally or per resource type. If paging is supported, the max size should be limited also, whether or not the client specifies a limit. A reasonable max page size in on the order of 1000 items but can vary. Smaller could be better for large instance representations.</param>
	/// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
	/// <returns>OK</returns>
	/// <exception cref="ApiException">A server side error occurred.</exception>
	[Get("/rest/v1/hosts")]
	Task<CollectionResponse<Host>> GetHostsAsync(
		string? filter = null,
		List<string>? select = null,
		string? order = null,
		int? limit = null,
		int? offset = null,
		CancellationToken? cancellationToken = default);

	/// <summary>
	/// Get a Pool
	/// </summary>
	/// <remarks>
	/// Get a pool by its ID.
	/// </remarks>
	/// <param name="id">The pool ID to retrieve</param>
	/// <param name="select">By default, all properties are returned in resource instances. This can be very expensive - large and slow for large collection responses in particular. This allows the client to select the specific properties that they need, which in addition to the performance benefits for the client and server, also documents the dependencies of the client code, and makes it more resilient to changes on the server side. If the select query contains a tag key that has special characters (such as a dot, dash, or underscore), then the user needs to enclose such keys within parentheses (). Examples are tags(dot.key.0), tags(dash-key-0), or tags(underscore_0). If the key does not contain any special characters, then examples of what the user can use are tags.BusinessUnit or tags(BusinessUnit).</param>
	/// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
	/// <returns>OK</returns>
	/// <exception cref="ApiException">A server side error occurred.</exception>
	[Get("/rest/v1/pools/{id}")]
	Task<Pool> GetPoolAsync(
		string id,
		List<string>? select = null,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Get Pools
	/// </summary>
	/// <remarks>
	/// Get a list of all the pool objects.
	/// </remarks>
	/// <param name="filter">This filters rows in a query, by constraining the result to rows matching the property condition(s) specified. Multiple filters are valid and are "and"ed together. If the filter query contains a tag key that has special characters (such as a dot, dash, or underscore), then the user needs to enclose such keys within parentheses (). Examples are tags(dot.key.0), tags(dash-key-0), or tags(underscore_0). If the key does not contain any special characters, then examples of what the user can use are tags.BusinessUnit or tags(BusinessUnit).</param>
	/// <param name="select">By default, all properties are returned in resource instances. This can be very expensive - large and slow for large collection responses in particular. This allows the client to select the specific properties that they need, which in addition to the performance benefits for the client and server, also documents the dependencies of the client code, and makes it more resilient to changes on the server side. If the select query contains a tag key that has special characters (such as a dot, dash, or underscore), then the user needs to enclose such keys within parentheses (). Examples are tags(dot.key.0), tags(dash-key-0), or tags(underscore_0). If the key does not contain any special characters, then examples of what the user can use are tags.BusinessUnit or tags(BusinessUnit).</param>
	/// <param name="order">Sorts the result set by the properties specified. Ascending order is default if not specified. If the order query contains a tag key that has special characters (such as a dot, dash, or underscore), then the user needs to enclose such keys within parentheses (). Examples are tags(dot.key.0), tags(dash-key-0), or tags(underscore_0). If the key does not contain any special characters, then examples of what the user can use are tags.BusinessUnit or tags(BusinessUnit).</param>
	/// <param name="limit">Optional page size desired for the response. Default value may be platform specified, either globally or per resource type. If paging is supported, the max size should be limited also, whether or not the client specifies a limit. A reasonable max page size in on the order of 1000 items but can vary. Smaller could be better for large instance representations.</param>
	/// <param name="offset">Optional page size desired for the response. Default value may be platform specified, either globally or per resource type. If paging is supported, the max size should be limited also, whether or not the client specifies a limit. A reasonable max page size in on the order of 1000 items but can vary. Smaller could be better for large instance representations.</param>
	/// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
	/// <returns>OK</returns>
	/// <exception cref="ApiException">A server side error occurred.</exception>
	[Get("/rest/v1/pools")]
	Task<CollectionResponse<Pool>> GetPoolsAsync(
		string? filter = null,
		List<string>? select = null,
		string? order = null,
		int? limit = null,
		int? offset = null,
		CancellationToken? cancellationToken = default);

	/// <summary>
	/// Get a StorageGroup
	/// </summary>
	/// <remarks>
	/// Get a storage group by its ID.
	/// </remarks>
	/// <param name="id">The storage group ID to retrieve</param>
	/// <param name="select">By default, all properties are returned in resource instances. This can be very expensive - large and slow for large collection responses in particular. This allows the client to select the specific properties that they need, which in addition to the performance benefits for the client and server, also documents the dependencies of the client code, and makes it more resilient to changes on the server side. If the select query contains a tag key that has special characters (such as a dot, dash, or underscore), then the user needs to enclose such keys within parentheses (). Examples are tags(dot.key.0), tags(dash-key-0), or tags(underscore_0). If the key does not contain any special characters, then examples of what the user can use are tags.BusinessUnit or tags(BusinessUnit).</param>
	/// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
	/// <returns>OK</returns>
	/// <exception cref="ApiException">A server side error occurred.</exception>
	[Get("/rest/v1/storage_groups/{id}")]
	Task<StorageGroup> GetStorageGroupAsync(
		string id,
		List<string>? select = null,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Get StorageGroups
	/// </summary>
	/// <remarks>
	/// Get a list of all the storage group objects.
	/// </remarks>
	/// <param name="filter">This filters rows in a query, by constraining the result to rows matching the property condition(s) specified. Multiple filters are valid and are "and"ed together. If the filter query contains a tag key that has special characters (such as a dot, dash, or underscore), then the user needs to enclose such keys within parentheses (). Examples are tags(dot.key.0), tags(dash-key-0), or tags(underscore_0). If the key does not contain any special characters, then examples of what the user can use are tags.BusinessUnit or tags(BusinessUnit).</param>
	/// <param name="select">By default, all properties are returned in resource instances. This can be very expensive - large and slow for large collection responses in particular. This allows the client to select the specific properties that they need, which in addition to the performance benefits for the client and server, also documents the dependencies of the client code, and makes it more resilient to changes on the server side. If the select query contains a tag key that has special characters (such as a dot, dash, or underscore), then the user needs to enclose such keys within parentheses (). Examples are tags(dot.key.0), tags(dash-key-0), or tags(underscore_0). If the key does not contain any special characters, then examples of what the user can use are tags.BusinessUnit or tags(BusinessUnit).</param>
	/// <param name="order">Sorts the result set by the properties specified. Ascending order is default if not specified. If the order query contains a tag key that has special characters (such as a dot, dash, or underscore), then the user needs to enclose such keys within parentheses (). Examples are tags(dot.key.0), tags(dash-key-0), or tags(underscore_0). If the key does not contain any special characters, then examples of what the user can use are tags.BusinessUnit or tags(BusinessUnit).</param>
	/// <param name="limit">Optional page size desired for the response. Default value may be platform specified, either globally or per resource type. If paging is supported, the max size should be limited also, whether or not the client specifies a limit. A reasonable max page size in on the order of 1000 items but can vary. Smaller could be better for large instance representations.</param>
	/// <param name="offset">Optional page size desired for the response. Default value may be platform specified, either globally or per resource type. If paging is supported, the max size should be limited also, whether or not the client specifies a limit. A reasonable max page size in on the order of 1000 items but can vary. Smaller could be better for large instance representations.</param>
	/// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
	/// <returns>OK</returns>
	/// <exception cref="ApiException">A server side error occurred.</exception>
	[Get("/rest/v1/storage_groups")]
	Task<CollectionResponse<StorageGroup>> GetStorageGroupsAsync(
		string? filter = null,
		List<string>? select = null,
		string? order = null,
		int? limit = null,
		int? offset = null,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Get a Srp
	/// </summary>
	/// <remarks>
	/// Get a srp by its ID.
	/// </remarks>
	/// <param name="id">The srp ID to retrieve</param>
	/// <param name="select">By default, all properties are returned in resource instances. This can be very expensive - large and slow for large collection responses in particular. This allows the client to select the specific properties that they need, which in addition to the performance benefits for the client and server, also documents the dependencies of the client code, and makes it more resilient to changes on the server side. If the select query contains a tag key that has special characters (such as a dot, dash, or underscore), then the user needs to enclose such keys within parentheses (). Examples are tags(dot.key.0), tags(dash-key-0), or tags(underscore_0). If the key does not contain any special characters, then examples of what the user can use are tags.BusinessUnit or tags(BusinessUnit).</param>
	/// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
	/// <returns>OK</returns>
	/// <exception cref="ApiException">A server side error occurred.</exception>
	[Get("/rest/v1/storage_resource_pools/{id}")]
	Task<Srp> GetStorageResourcePoolAsync(
		string id,
		List<string>? select = null,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Get Srps
	/// </summary>
	/// <remarks>
	/// Get a list of all the srp objects.
	/// </remarks>
	/// <param name="filter">This filters rows in a query, by constraining the result to rows matching the property condition(s) specified. Multiple filters are valid and are "and"ed together. If the filter query contains a tag key that has special characters (such as a dot, dash, or underscore), then the user needs to enclose such keys within parentheses (). Examples are tags(dot.key.0), tags(dash-key-0), or tags(underscore_0). If the key does not contain any special characters, then examples of what the user can use are tags.BusinessUnit or tags(BusinessUnit).</param>
	/// <param name="select">By default, all properties are returned in resource instances. This can be very expensive - large and slow for large collection responses in particular. This allows the client to select the specific properties that they need, which in addition to the performance benefits for the client and server, also documents the dependencies of the client code, and makes it more resilient to changes on the server side. If the select query contains a tag key that has special characters (such as a dot, dash, or underscore), then the user needs to enclose such keys within parentheses (). Examples are tags(dot.key.0), tags(dash-key-0), or tags(underscore_0). If the key does not contain any special characters, then examples of what the user can use are tags.BusinessUnit or tags(BusinessUnit).</param>
	/// <param name="order">Sorts the result set by the properties specified. Ascending order is default if not specified. If the order query contains a tag key that has special characters (such as a dot, dash, or underscore), then the user needs to enclose such keys within parentheses (). Examples are tags(dot.key.0), tags(dash-key-0), or tags(underscore_0). If the key does not contain any special characters, then examples of what the user can use are tags.BusinessUnit or tags(BusinessUnit).</param>
	/// <param name="limit">Optional page size desired for the response. Default value may be platform specified, either globally or per resource type. If paging is supported, the max size should be limited also, whether or not the client specifies a limit. A reasonable max page size in on the order of 1000 items but can vary. Smaller could be better for large instance representations.</param>
	/// <param name="offset">Optional page size desired for the response. Default value may be platform specified, either globally or per resource type. If paging is supported, the max size should be limited also, whether or not the client specifies a limit. A reasonable max page size in on the order of 1000 items but can vary. Smaller could be better for large instance representations.</param>
	/// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
	/// <returns>OK</returns>
	/// <exception cref="ApiException">A server side error occurred.</exception>
	[Get("/rest/v1/storage_resource_pools")]
	Task<CollectionResponse<Srp>> GetStorageResourcePoolsAsync(
		string? filter = null,
		List<string>? select = null,
		string? order = null,
		int? limit = null,
		int? offset = null,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Get a VirtualMachine
	/// </summary>
	/// <remarks>
	/// Get a virtual machine by its ID.
	/// </remarks>
	/// <param name="select">By default, all properties are returned in resource instances. This can be very expensive - large and slow for large collection responses in particular. This allows the client to select the specific properties that they need, which in addition to the performance benefits for the client and server, also documents the dependencies of the client code, and makes it more resilient to changes on the server side. If the select query contains a tag key that has special characters (such as a dot, dash, or underscore), then the user needs to enclose such keys within parentheses (). Examples are tags(dot.key.0), tags(dash-key-0), or tags(underscore_0). If the key does not contain any special characters, then examples of what the user can use are tags.BusinessUnit or tags(BusinessUnit).</param>
	/// <param name="id">The virtual machine ID to retrieve</param>
	/// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
	/// <returns>OK</returns>
	/// <exception cref="ApiException">A server side error occurred.</exception>
	[Get("/rest/v1/virtual_machines/{id}")]
	Task<VirtualMachine> GetVirtualMachineAsync(
		string id,
		List<string>? select = null,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Get VirtualMachines
	/// </summary>
	/// <remarks>
	/// Get a list of all the virtual machine objects.
	/// </remarks>
	/// <param name="filter">This filters rows in a query, by constraining the result to rows matching the property condition(s) specified. Multiple filters are valid and are "and"ed together. If the filter query contains a tag key that has special characters (such as a dot, dash, or underscore), then the user needs to enclose such keys within parentheses (). Examples are tags(dot.key.0), tags(dash-key-0), or tags(underscore_0). If the key does not contain any special characters, then examples of what the user can use are tags.BusinessUnit or tags(BusinessUnit).</param>
	/// <param name="select">By default, all properties are returned in resource instances. This can be very expensive - large and slow for large collection responses in particular. This allows the client to select the specific properties that they need, which in addition to the performance benefits for the client and server, also documents the dependencies of the client code, and makes it more resilient to changes on the server side. If the select query contains a tag key that has special characters (such as a dot, dash, or underscore), then the user needs to enclose such keys within parentheses (). Examples are tags(dot.key.0), tags(dash-key-0), or tags(underscore_0). If the key does not contain any special characters, then examples of what the user can use are tags.BusinessUnit or tags(BusinessUnit).</param>
	/// <param name="order">Sorts the result set by the properties specified. Ascending order is default if not specified. If the order query contains a tag key that has special characters (such as a dot, dash, or underscore), then the user needs to enclose such keys within parentheses (). Examples are tags(dot.key.0), tags(dash-key-0), or tags(underscore_0). If the key does not contain any special characters, then examples of what the user can use are tags.BusinessUnit or tags(BusinessUnit).</param>
	/// <param name="limit">Optional page size desired for the response. Default value may be platform specified, either globally or per resource type. If paging is supported, the max size should be limited also, whether or not the client specifies a limit. A reasonable max page size in on the order of 1000 items but can vary. Smaller could be better for large instance representations.</param>
	/// <param name="offset">Optional page size desired for the response. Default value may be platform specified, either globally or per resource type. If paging is supported, the max size should be limited also, whether or not the client specifies a limit. A reasonable max page size in on the order of 1000 items but can vary. Smaller could be better for large instance representations.</param>
	/// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
	/// <returns>OK</returns>
	/// <exception cref="ApiException">A server side error occurred.</exception>
	[Get("/rest/v1/virtual_machines")]
	Task<CollectionResponse<VirtualMachine>> GetVirtualMachinesAsync(
		string? filter = null,
		List<string>? select = null,
		string? order = null,
		int? limit = null,
		int? offset = null,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Get a Volume
	/// </summary>
	/// <remarks>
	/// Get a volume by its ID.
	/// </remarks>
	/// <param name="id">The volume ID to retrieve</param>
	/// <param name="select">By default, all properties are returned in resource instances. This can be very expensive - large and slow for large collection responses in particular. This allows the client to select the specific properties that they need, which in addition to the performance benefits for the client and server, also documents the dependencies of the client code, and makes it more resilient to changes on the server side. If the select query contains a tag key that has special characters (such as a dot, dash, or underscore), then the user needs to enclose such keys within parentheses (). Examples are tags(dot.key.0), tags(dash-key-0), or tags(underscore_0). If the key does not contain any special characters, then examples of what the user can use are tags.BusinessUnit or tags(BusinessUnit).</param>
	/// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
	/// <returns>OK</returns>
	/// <exception cref="ApiException">A server side error occurred.</exception>
	[Get("/rest/v1/volumes/{id}")]
	Task<Volume> GetVolumeAsync(
		string id,
		List<string>? select = null,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Get Volumes
	/// </summary>
	/// <remarks>
	/// Get a list of all the volume objects.
	/// </remarks>
	/// <param name="filter">This filters rows in a query, by constraining the result to rows matching the property condition(s) specified. Multiple filters are valid and are "and"ed together. If the filter query contains a tag key that has special characters (such as a dot, dash, or underscore), then the user needs to enclose such keys within parentheses (). Examples are tags(dot.key.0), tags(dash-key-0), or tags(underscore_0). If the key does not contain any special characters, then examples of what the user can use are tags.BusinessUnit or tags(BusinessUnit).</param>
	/// <param name="select">By default, all properties are returned in resource instances. This can be very expensive - large and slow for large collection responses in particular. This allows the client to select the specific properties that they need, which in addition to the performance benefits for the client and server, also documents the dependencies of the client code, and makes it more resilient to changes on the server side. If the select query contains a tag key that has special characters (such as a dot, dash, or underscore), then the user needs to enclose such keys within parentheses (). Examples are tags(dot.key.0), tags(dash-key-0), or tags(underscore_0). If the key does not contain any special characters, then examples of what the user can use are tags.BusinessUnit or tags(BusinessUnit).</param>
	/// <param name="order">Sorts the result set by the properties specified. Ascending order is default if not specified. If the order query contains a tag key that has special characters (such as a dot, dash, or underscore), then the user needs to enclose such keys within parentheses (). Examples are tags(dot.key.0), tags(dash-key-0), or tags(underscore_0). If the key does not contain any special characters, then examples of what the user can use are tags.BusinessUnit or tags(BusinessUnit).</param>
	/// <param name="limit">Optional page size desired for the response. Default value may be platform specified, either globally or per resource type. If paging is supported, the max size should be limited also, whether or not the client specifies a limit. A reasonable max page size in on the order of 1000 items but can vary. Smaller could be better for large instance representations.</param>
	/// <param name="offset">Optional page size desired for the response. Default value may be platform specified, either globally or per resource type. If paging is supported, the max size should be limited also, whether or not the client specifies a limit. A reasonable max page size in on the order of 1000 items but can vary. Smaller could be better for large instance representations.</param>
	/// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
	/// <returns>OK</returns>
	/// <exception cref="ApiException">A server side error occurred.</exception>
	[Get("/rest/v1/volumes")]
	Task<CollectionResponse<Volume>> GetVolumesAsync(
		string? filter = null,
		List<string>? select = null,
		string? order = null,
		int? limit = null,
		int? offset = null,
		CancellationToken? cancellationToken = default);
}
