using Dell.CloudIq.Api.Helpers;

namespace Dell.CloudIq.Api;

public static class HardwareExtensions
{
	public static Task<CollectionResponse<EsxiHost>> GetEsxiHostsAllAsync(
		this IHardware hardware,
		string? filter = null,
		List<string>? select = null,
		string? order = null,
		CancellationToken cancellationToken = default)
		=> CloudIQClientHelper.GetAllAsync(
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
		=> CloudIQClientHelper.GetAllAsync(
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
