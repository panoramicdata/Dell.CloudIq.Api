namespace Dell.CloudIq.Api.Interfaces.Extensions;

public static class IStorageExtensions
{
	public static Task<CollectionResponse<DataStore>> GetDatastoresAllAsync(
		this IStorage storage,
		string? filter = null,
		List<string>? select = null,
		string? order = null,
		CancellationToken cancellationToken = default)
		=> CloudIQClient.GetAllAsync(
			(limit, pageOffset, cancellationToken)
			=> storage.GetDatastoresAsync(
				filter,
				select,
				order,
				limit,
				pageOffset,
				cancellationToken
				),
			cancellationToken);

	public static Task<CollectionResponse<Drive>> GetDrivesAllAsync(
		this IStorage storage,
		string? filter = null,
		List<string>? select = null,
		string? order = null,
		CancellationToken cancellationToken = default)
		=> CloudIQClient.GetAllAsync(
			(limit, pageOffset, cancellationToken)
			=> storage.GetDrivesAsync(
				filter,
				select,
				order,
				limit,
				pageOffset,
				cancellationToken
				),
			cancellationToken);

	public static Task<CollectionResponse<Filesystem>> GetFilesystemsAllAsync(
		this IStorage storage,
		string? filter = null,
		List<string>? select = null,
		string? order = null,
		CancellationToken cancellationToken = default)
		=> CloudIQClient.GetAllAsync(
			(limit, pageOffset, cancellationToken)
			=> storage.GetFilesystemsAsync(
				filter,
				select,
				order,
				limit,
				pageOffset,
				cancellationToken
				),
			cancellationToken);

	public static Task<CollectionResponse<Host>> GetHostsAllAsync(
		this IStorage storage,
		string? filter = null,
		List<string>? select = null,
		string? order = null,
		CancellationToken cancellationToken = default)
		=> CloudIQClient.GetAllAsync(
			(limit, pageOffset, cancellationToken)
			=> storage.GetHostsAsync(
				filter,
				select,
				order,
				limit,
				pageOffset,
				cancellationToken
				),
			cancellationToken);

	public static Task<CollectionResponse<Pool>> GetPoolsAllAsync(
		this IStorage storage,
		string? filter = null,
		List<string>? select = null,
		string? order = null,
		CancellationToken cancellationToken = default)
		=> CloudIQClient.GetAllAsync(
			(limit, pageOffset, cancellationToken)
			=> storage.GetPoolsAsync(
				filter,
				select,
				order,
				limit,
				pageOffset,
				cancellationToken
				),
			cancellationToken);

	public static Task<CollectionResponse<StorageGroup>> GetStorageGroupsAllAsync(
		this IStorage storage,
		string? filter = null,
		List<string>? select = null,
		string? order = null,
		CancellationToken cancellationToken = default)
		=> CloudIQClient.GetAllAsync(
			(limit, pageOffset, cancellationToken)
			=> storage.GetStorageGroupsAsync(
				filter,
				select,
				order,
				limit,
				pageOffset,
				cancellationToken
				),
			cancellationToken);

	public static Task<CollectionResponse<Srp>> GetStorageResourcePoolsAllAsync(
		this IStorage storage,
		string? filter = null,
		List<string>? select = null,
		string? order = null,
		CancellationToken cancellationToken = default)
		=> CloudIQClient.GetAllAsync(
			(limit, pageOffset, cancellationToken)
			=> storage.GetStorageResourcePoolsAsync(
				filter,
				select,
				order,
				limit,
				pageOffset,
				cancellationToken
				),
			cancellationToken);

	public static Task<CollectionResponse<VirtualMachine>> GetVirtualMachinesAllAsync(
		this IStorage storage,
		string? filter = null,
		List<string>? select = null,
		string? order = null,
		CancellationToken cancellationToken = default)
		=> CloudIQClient.GetAllAsync(
			(limit, pageOffset, cancellationToken)
			=> storage.GetVirtualMachinesAsync(
				filter,
				select,
				order,
				limit,
				pageOffset,
				cancellationToken
				),
			cancellationToken);

	public static Task<CollectionResponse<Volume>> GetVolumesAllAsync(
		this IStorage storage,
		string? filter = null,
		List<string>? select = null,
		string? order = null,
		CancellationToken cancellationToken = default)
		=> CloudIQClient.GetAllAsync(
			(limit, pageOffset, cancellationToken)
			=> storage.GetVolumesAsync(
				filter,
				select,
				order,
				limit,
				pageOffset,
				cancellationToken
				),
			cancellationToken);
}
