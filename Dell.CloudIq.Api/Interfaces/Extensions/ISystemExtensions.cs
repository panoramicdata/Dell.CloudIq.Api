namespace Dell.CloudIq.Api.Interfaces.Extensions;

public static class ISystemExtensions
{
	public static Task<CollectionResponse<Firmware>> GetFirmwaresAllAsync(
		this ISystem systems,
		string? filter = null,
		List<string>? select = null,
		string? order = null,
		CancellationToken cancellationToken = default)
		=> CloudIQClient.GetAllAsync(
			(limit, pageOffset, cancellationToken)
			=> systems.GetFirmwaresAsync(
				filter,
				select,
				order,
				limit,
				pageOffset,
				cancellationToken
				),
			cancellationToken);

	public static Task<CollectionResponse<HciSystem>> GetHciSystemsAllAsync(
		this ISystem systems,
		string? filter = null,
		List<string>? select = null,
		string? order = null,
		CancellationToken cancellationToken = default)
		=> CloudIQClient.GetAllAsync(
			(limit, pageOffset, cancellationToken)
			=> systems.GetHciSystemsAsync(
				filter,
				select,
				order,
				limit,
				pageOffset,
				cancellationToken
				),
			cancellationToken);

	public static Task<CollectionResponse<NetworkSystem>> GetNetworkSystemsAllAsync(
		this ISystem systems,
		string? filter = null,
		List<string>? select = null,
		string? order = null,
		CancellationToken cancellationToken = default)
		=> CloudIQClient.GetAllAsync(
			(limit, pageOffset, cancellationToken)
			=> systems.GetNetworkSystemsAsync(
				filter,
				select,
				order,
				limit,
				pageOffset,
				cancellationToken
				),
			cancellationToken);

	public static Task<CollectionResponse<ServerSystem>> GetServerSystemsAllAsync(
		this ISystem systems,
		string? filter = null,
		List<string>? select = null,
		string? order = null,
		CancellationToken cancellationToken = default)
		=> CloudIQClient.GetAllAsync(
			(limit, pageOffset, cancellationToken)
			=> systems.GetServerSystemsAsync(
				filter,
				select,
				order,
				limit,
				pageOffset,
				cancellationToken
				),
			cancellationToken);

	public static Task<CollectionResponse<StorageSystem>> GetStorageSystemsAllAsync(
		this ISystem systems,
		string? filter = null,
		List<string>? select = null,
		string? order = null,
		CancellationToken cancellationToken = default)
		=> CloudIQClient.GetAllAsync(
			(limit, pageOffset, cancellationToken)
			=> systems.GetStorageSystemsAsync(
				filter,
				select,
				order,
				limit,
				pageOffset,
				cancellationToken
				),
			cancellationToken);

	public static Task<CollectionResponse<CloudIQSystem>> GetSystemsAllAsync(
		this ISystem systems,
		string? filter = null,
		List<string>? select = null,
		string? order = null,
		CancellationToken cancellationToken = default)
		=> CloudIQClient.GetAllAsync(
			(limit, pageOffset, cancellationToken)
			=> systems.GetSystemsAsync(
				filter,
				select,
				order,
				limit,
				pageOffset,
				cancellationToken
				),
			cancellationToken);
}
