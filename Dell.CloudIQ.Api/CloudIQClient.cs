namespace Dell.CloudIq.Api;

public class CloudIQClient
{
	private readonly CloudIQClientOptions _clientOptions;

	public CloudIQClient(CloudIQClientOptions clientOptions)
	{
		_clientOptions = clientOptions;

		var httpClient = new HttpClient();
		var refitSettings = new RefitSettings();

		Compute = RestService.For<ICompute>(httpClient, refitSettings);
		Hci = RestService.For<IHci>(httpClient, refitSettings);
		Network = RestService.For<INetwork>(httpClient, refitSettings);
		Resource = RestService.For<IResource>(httpClient, refitSettings);
		Server = RestService.For<IServer>(httpClient, refitSettings);
		Storage = RestService.For<IStorage>(httpClient, refitSettings);
		System = RestService.For<ISystem>(httpClient, refitSettings);
	}

	// TODO: Add the client

	public ICompute Compute { get; set; }

	public IHci Hci { get; set; }

	public INetwork Network { get; set; }

	public IResource Resource { get; set; }

	public IServer Server { get; set; }

	public IStorage Storage { get; set; }

	public ISystem System { get; set; }
}
