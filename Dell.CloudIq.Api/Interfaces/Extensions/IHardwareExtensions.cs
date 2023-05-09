namespace Dell.CloudIq.Api.Interfaces.Extensions;

public static class IHardwareExtensions
{
	public static Task<CollectionResponse<EsxiHost>> GetEsxiHostsAllAsync(
		this IHardware hardware,
		string? filter = null,
		List<string>? select = null,
		string? order = null,
		CancellationToken cancellationToken = default)
		=> CloudIQClient.GetAllAsync(
			(limit, pageOffset, cancellationToken)
			=> hardware.GetEsxiHostsAsync(
				filter,
				select,
				order,
				limit,
				pageOffset,
				cancellationToken
				),
			cancellationToken);

	public static Task<CollectionResponse<Port>> GetPortsAllAsync(
		this IHardware hardware,
		string? filter = null,
		List<string>? select = null,
		string? order = null,
		CancellationToken cancellationToken = default)
		=> CloudIQClient.GetAllAsync(
			(limit, pageOffset, cancellationToken)
			=> hardware.GetPortsAsync(
				filter,
				select,
				order,
				limit,
				pageOffset,
				cancellationToken
				),
			cancellationToken);
}
