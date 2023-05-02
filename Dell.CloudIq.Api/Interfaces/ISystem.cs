namespace Dell.CloudIq.Api;

public interface ISystem
{
	/// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
	/// <summary>
	/// Get Basic System Information
	/// </summary>
	/// <remarks>
	/// Get basic system information. Since this is a single resource type, the id will be "0".
	/// </remarks>
	/// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
	/// <returns>OK</returns>
	/// <exception cref="ApiException">A server side error occurred.</exception>
	[Get("/basic-system-information")]
	Task<CollectionResponse> GetBasicSystemInfosAsync(CancellationToken cancellationToken);

	/// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
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
	Task<DataStore> GetDatastoreAsync(string id, string select, CancellationToken cancellationToken);

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
	Task<CollectionResponse> GetDatastoresAsync(string filter, string select, string order, int? limit, int? offset, CancellationToken cancellationToken);

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
	Task<Drive> GetDriveAsync(string id, string select, CancellationToken cancellationToken);

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
	Task<CollectionResponse> GetDrivesAsync(string filter, string select, string order, int? limit, int? offset, CancellationToken cancellationToken);

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
	Task<Filesystem> GetFilesystemAsync(string id, string select, CancellationToken cancellationToken);

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
	Task<CollectionResponse> GetFilesystemsAsync(string filter, string select, string order, int? limit, int? offset, CancellationToken cancellationToken);

	/// <summary>
	/// Get a Firmware
	/// </summary>
	/// <remarks>
	/// Get a server firmware by its ID.
	/// </remarks>
	/// <param name="id">The server firmware ID to retrieve</param>
	/// <param name="select">By default, all properties are returned in resource instances. This can be very expensive - large and slow for large collection responses in particular. This allows the client to select the specific properties that they need, which in addition to the performance benefits for the client and server, also documents the dependencies of the client code, and makes it more resilient to changes on the server side. If the select query contains a tag key that has special characters (such as a dot, dash, or underscore), then the user needs to enclose such keys within parentheses (). Examples are tags(dot.key.0), tags(dash-key-0), or tags(underscore_0). If the key does not contain any special characters, then examples of what the user can use are tags.BusinessUnit or tags(BusinessUnit).</param>
	/// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
	/// <returns>OK</returns>
	/// <exception cref="ApiException">A server side error occurred.</exception>
	[Get("/rest/v1/firmwares/{id}")]
	Task<Firmware> GetFirmwareAsync(string id, string select, CancellationToken cancellationToken);

	/// <summary>
	/// Get Firmwares
	/// </summary>
	/// <remarks>
	/// Get a list of all the server firmware objects.
	/// </remarks>
	/// <param name="filter">This filters rows in a query, by constraining the result to rows matching the property condition(s) specified. Multiple filters are valid and are "and"ed together. If the filter query contains a tag key that has special characters (such as a dot, dash, or underscore), then the user needs to enclose such keys within parentheses (). Examples are tags(dot.key.0), tags(dash-key-0), or tags(underscore_0). If the key does not contain any special characters, then examples of what the user can use are tags.BusinessUnit or tags(BusinessUnit).</param>
	/// <param name="select">By default, all properties are returned in resource instances. This can be very expensive - large and slow for large collection responses in particular. This allows the client to select the specific properties that they need, which in addition to the performance benefits for the client and server, also documents the dependencies of the client code, and makes it more resilient to changes on the server side. If the select query contains a tag key that has special characters (such as a dot, dash, or underscore), then the user needs to enclose such keys within parentheses (). Examples are tags(dot.key.0), tags(dash-key-0), or tags(underscore_0). If the key does not contain any special characters, then examples of what the user can use are tags.BusinessUnit or tags(BusinessUnit).</param>
	/// <param name="order">Sorts the result set by the properties specified. Ascending order is default if not specified. If the order query contains a tag key that has special characters (such as a dot, dash, or underscore), then the user needs to enclose such keys within parentheses (). Examples are tags(dot.key.0), tags(dash-key-0), or tags(underscore_0). If the key does not contain any special characters, then examples of what the user can use are tags.BusinessUnit or tags(BusinessUnit).</param>
	/// <param name="limit">Optional page size desired for the response. Default value may be platform specified, either globally or per resource type. If paging is supported, the max size should be limited also, whether or not the client specifies a limit. A reasonable max page size in on the order of 1000 items but can vary. Smaller could be better for large instance representations.</param>
	/// <param name="offset">Optional page size desired for the response. Default value may be platform specified, either globally or per resource type. If paging is supported, the max size should be limited also, whether or not the client specifies a limit. A reasonable max page size in on the order of 1000 items but can vary. Smaller could be better for large instance representations.</param>
	/// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
	/// <returns>OK</returns>
	/// <exception cref="ApiException">A server side error occurred.</exception>
	[Get("/rest/v1/firmwares")]
	Task<CollectionResponse> GetFirmwaresAsync(string filter, string select, string order, int? limit, int? offset, CancellationToken cancellationToken);

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
	Task<Host> GetHostAsync(string id, string select, CancellationToken cancellationToken);

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
	Task<CollectionResponse> GetHostsAsync(string filter, string select, string order, int? limit, int? offset, CancellationToken cancellationToken);

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
	Task<Pool> GetPoolAsync(string id, string select, CancellationToken cancellationToken);

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
	Task<CollectionResponse> GetPoolsAsync(string filter, string select, string order, int? limit, int? offset, CancellationToken cancellationToken);

	/// <summary>
	/// Get a Port
	/// </summary>
	/// <remarks>
	/// Get a port by its ID.
	/// </remarks>
	/// <param name="id">The port ID to retrieve</param>
	/// <param name="select">By default, all properties are returned in resource instances. This can be very expensive - large and slow for large collection responses in particular. This allows the client to select the specific properties that they need, which in addition to the performance benefits for the client and server, also documents the dependencies of the client code, and makes it more resilient to changes on the server side. If the select query contains a tag key that has special characters (such as a dot, dash, or underscore), then the user needs to enclose such keys within parentheses (). Examples are tags(dot.key.0), tags(dash-key-0), or tags(underscore_0). If the key does not contain any special characters, then examples of what the user can use are tags.BusinessUnit or tags(BusinessUnit).</param>
	/// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
	/// <returns>OK</returns>
	/// <exception cref="ApiException">A server side error occurred.</exception>
	[Get("/rest/v1/ports/{id}")]
	Task<Port> GetPortAsync(string id, string select, CancellationToken cancellationToken);

	/// <summary>
	/// Get Ports
	/// </summary>
	/// <remarks>
	/// Get a list of all the port objects.
	/// </remarks>
	/// <param name="filter">This filters rows in a query, by constraining the result to rows matching the property condition(s) specified. Multiple filters are valid and are "and"ed together. If the filter query contains a tag key that has special characters (such as a dot, dash, or underscore), then the user needs to enclose such keys within parentheses (). Examples are tags(dot.key.0), tags(dash-key-0), or tags(underscore_0). If the key does not contain any special characters, then examples of what the user can use are tags.BusinessUnit or tags(BusinessUnit).</param>
	/// <param name="select">By default, all properties are returned in resource instances. This can be very expensive - large and slow for large collection responses in particular. This allows the client to select the specific properties that they need, which in addition to the performance benefits for the client and server, also documents the dependencies of the client code, and makes it more resilient to changes on the server side. If the select query contains a tag key that has special characters (such as a dot, dash, or underscore), then the user needs to enclose such keys within parentheses (). Examples are tags(dot.key.0), tags(dash-key-0), or tags(underscore_0). If the key does not contain any special characters, then examples of what the user can use are tags.BusinessUnit or tags(BusinessUnit).</param>
	/// <param name="order">Sorts the result set by the properties specified. Ascending order is default if not specified. If the order query contains a tag key that has special characters (such as a dot, dash, or underscore), then the user needs to enclose such keys within parentheses (). Examples are tags(dot.key.0), tags(dash-key-0), or tags(underscore_0). If the key does not contain any special characters, then examples of what the user can use are tags.BusinessUnit or tags(BusinessUnit).</param>
	/// <param name="limit">Optional page size desired for the response. Default value may be platform specified, either globally or per resource type. If paging is supported, the max size should be limited also, whether or not the client specifies a limit. A reasonable max page size in on the order of 1000 items but can vary. Smaller could be better for large instance representations.</param>
	/// <param name="offset">Optional page size desired for the response. Default value may be platform specified, either globally or per resource type. If paging is supported, the max size should be limited also, whether or not the client specifies a limit. A reasonable max page size in on the order of 1000 items but can vary. Smaller could be better for large instance representations.</param>
	/// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
	/// <returns>OK</returns>
	/// <exception cref="ApiException">A server side error occurred.</exception>
	[Get("/rest/v1/ports")]
	Task<CollectionResponse> GetPortsAsync(string filter, string select, string order, int? limit, int? offset, CancellationToken cancellationToken);

	/// <summary>
	/// Get a System
	/// </summary>
	/// <remarks>
	/// Get a system by its ID.
	/// </remarks>
	/// <param name="id">The system ID to retrieve</param>
	/// <param name="select">By default, all properties are returned in resource instances. This can be very expensive - large and slow for large collection responses in particular. This allows the client to select the specific properties that they need, which in addition to the performance benefits for the client and server, also documents the dependencies of the client code, and makes it more resilient to changes on the server side. If the select query contains a tag key that has special characters (such as a dot, dash, or underscore), then the user needs to enclose such keys within parentheses (). Examples are tags(dot.key.0), tags(dash-key-0), or tags(underscore_0). If the key does not contain any special characters, then examples of what the user can use are tags.BusinessUnit or tags(BusinessUnit).</param>
	/// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
	/// <returns>OK</returns>
	/// <exception cref="ApiException">A server side error occurred.</exception>
	[Get("/rest/v1/systems/{id}")]
	Task<CloudIQSystem> GetSystemAsync(string id, string select, CancellationToken cancellationToken);

	/// <summary>
	/// Get Systems
	/// </summary>
	/// <remarks>
	/// Get a list of all the system objects.
	/// </remarks>
	/// <param name="filter">This filters rows in a query, by constraining the result to rows matching the property condition(s) specified. Multiple filters are valid and are "and"ed together. If the filter query contains a tag key that has special characters (such as a dot, dash, or underscore), then the user needs to enclose such keys within parentheses (). Examples are tags(dot.key.0), tags(dash-key-0), or tags(underscore_0). If the key does not contain any special characters, then examples of what the user can use are tags.BusinessUnit or tags(BusinessUnit).</param>
	/// <param name="select">By default, all properties are returned in resource instances. This can be very expensive - large and slow for large collection responses in particular. This allows the client to select the specific properties that they need, which in addition to the performance benefits for the client and server, also documents the dependencies of the client code, and makes it more resilient to changes on the server side. If the select query contains a tag key that has special characters (such as a dot, dash, or underscore), then the user needs to enclose such keys within parentheses (). Examples are tags(dot.key.0), tags(dash-key-0), or tags(underscore_0). If the key does not contain any special characters, then examples of what the user can use are tags.BusinessUnit or tags(BusinessUnit).</param>
	/// <param name="order">Sorts the result set by the properties specified. Ascending order is default if not specified. If the order query contains a tag key that has special characters (such as a dot, dash, or underscore), then the user needs to enclose such keys within parentheses (). Examples are tags(dot.key.0), tags(dash-key-0), or tags(underscore_0). If the key does not contain any special characters, then examples of what the user can use are tags.BusinessUnit or tags(BusinessUnit).</param>
	/// <param name="limit">Optional page size desired for the response. Default value may be platform specified, either globally or per resource type. If paging is supported, the max size should be limited also, whether or not the client specifies a limit. A reasonable max page size in on the order of 1000 items but can vary. Smaller could be better for large instance representations.</param>
	/// <param name="offset">Optional page size desired for the response. Default value may be platform specified, either globally or per resource type. If paging is supported, the max size should be limited also, whether or not the client specifies a limit. A reasonable max page size in on the order of 1000 items but can vary. Smaller could be better for large instance representations.</param>
	/// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
	/// <returns>OK</returns>
	/// <exception cref="ApiException">A server side error occurred.</exception>
	[Get("/rest/v1/systems")]
	Task<CollectionResponse> GetSystemsAsync(
		string? filter = null,
		List<string>? select = null,
		string? order = null,
		int? limit = null,
		int? offset = null,
		CancellationToken? cancellationToken = default);

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
	Task<Volume> GetVolumeAsync(string id, string select, CancellationToken cancellationToken);

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
	Task<CollectionResponse> GetVolumesAsync(string filter, string select, string order, int? limit, int? offset, CancellationToken cancellationToken);

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
	Task<MetricsResponseEntries> PostMetricsQueryAsync([Body] MetricsQuery body, CancellationToken cancellationToken);

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
	Task<MetricMetadataInstance> GetMetricMetadataInstanceAsync(string id, CancellationToken cancellationToken);

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
	Task<MetricMetadataInstances> GetMetricMetadataCollectionAsync(string filter, CancellationToken cancellationToken);

}
