using Microsoft.Extensions.Configuration;

namespace Dell.CloudIq.Api.Test;

/// <summary>Base class for all Dell CloudIQ API integration tests.</summary>
/// <param name="testOutputHelper">The xUnit test output helper for logging.</param>
abstract public class TestBase(ITestOutputHelper testOutputHelper)
{
	/// <summary>
	/// User secrets supply the credentials for a local run; CLOUDIQ_-prefixed environment variables
	/// let CI supply the same values from repository secrets.
	/// </summary>
	private static readonly IConfiguration Configuration = new ConfigurationBuilder()
		.AddUserSecrets<TestBase>()
		.AddEnvironmentVariables("CLOUDIQ_")
		.Build();

	/// <summary>Gets the logger for the current test.</summary>
	public ILogger Logger { get; } = testOutputHelper.BuildLogger();

	/// <summary>Gets the cancellation token for the current test.</summary>
	protected static CancellationToken CancellationToken => TestContext.Current.CancellationToken;

	/// <summary>
	/// Gets a value indicating whether CloudIQ credentials are configured. Without them the tests
	/// that talk to CloudIQ cannot run, so they are skipped rather than failed — a runner with no
	/// credentials must not break the build, or a tag never reaches nuget.org.
	/// </summary>
	public static bool HasCredentials =>
		!string.IsNullOrWhiteSpace(Configuration["ClientId"])
		&& !string.IsNullOrWhiteSpace(Configuration["ClientSecret"])
		&& !string.IsNullOrWhiteSpace(Configuration["BaseUri"]);

	/// <summary>
	/// Creates a client for talking to CloudIQ, skipping the calling test when no credentials are
	/// configured.
	/// </summary>
	/// <returns>A <see cref="CloudIqClient"/> configured from user secrets or the environment.</returns>
	protected CloudIqClient CreateClient() => new(GetClientOptions(), Logger);

	/// <summary>
	/// Fetches a collection from CloudIQ and asserts that it came back. Every collection endpoint is
	/// tested the same way, so the assertions live here rather than in each test.
	/// </summary>
	/// <typeparam name="T">The type of instance the collection holds.</typeparam>
	/// <param name="getCollection">Fetches the collection under test.</param>
	protected async Task AssertCollectionAsync<T>(Func<CloudIqClient, Task<CollectionResponse<T>>> getCollection)
	{
		var client = CreateClient();

		var collection = await getCollection(client);

		collection.Should().BeOfType<CollectionResponse<T>>();
		collection.Should().NotBeNull();
	}

	/// <summary>
	/// Fetches a collection and, when it holds anything, asserts that fetching its first instance by
	/// id returns that same instance. An empty collection is not a failure: what CloudIQ returns
	/// depends on the account the credentials belong to.
	/// </summary>
	/// <typeparam name="T">The type of instance the collection holds.</typeparam>
	/// <param name="getCollection">Fetches the collection under test.</param>
	/// <param name="getById">Fetches a single instance by its id.</param>
	/// <param name="getId">Reads the id of an instance.</param>
	protected Task AssertFirstItemFetchableByIdAsync<T>(
		Func<CloudIqClient, Task<CollectionResponse<T>>> getCollection,
		Func<CloudIqClient, string, Task<T>> getById,
		Func<T, string> getId)
		=> AssertFirstItemFetchableByIdAsync(getCollection, getById, getId, getId);

	/// <summary>
	/// The same as <see cref="AssertFirstItemFetchableByIdAsync{T}(Func{CloudIqClient, Task{CollectionResponse{T}}}, Func{CloudIqClient, string, Task{T}}, Func{T, string})"/>,
	/// for the endpoints where fetching by id returns a different type to the one the collection holds.
	/// </summary>
	/// <typeparam name="TItem">The type of instance the collection holds.</typeparam>
	/// <typeparam name="TFetched">The type returned when fetching by id.</typeparam>
	/// <param name="getCollection">Fetches the collection under test.</param>
	/// <param name="getById">Fetches a single instance by its id.</param>
	/// <param name="getItemId">Reads the id of an instance in the collection.</param>
	/// <param name="getFetchedId">Reads the id of the instance fetched by id.</param>
	protected async Task AssertFirstItemFetchableByIdAsync<TItem, TFetched>(
		Func<CloudIqClient, Task<CollectionResponse<TItem>>> getCollection,
		Func<CloudIqClient, string, Task<TFetched>> getById,
		Func<TItem, string> getItemId,
		Func<TFetched, string> getFetchedId)
	{
		var client = CreateClient();

		var collection = await getCollection(client);

		collection.Should().BeOfType<CollectionResponse<TItem>>();
		collection.Should().NotBeNull();

		if (collection.Results.Count == 0)
		{
			return;
		}

		var expectedId = getItemId(collection.Results.First());

		var fetched = await getById(client, expectedId);

		fetched.Should().NotBeNull();
		getFetchedId(fetched).Should().Be(expectedId);
	}

	/// <summary>Builds <see cref="CloudIqClientOptions"/> from the test configuration.</summary>
	/// <returns>A configured <see cref="CloudIqClientOptions"/> instance.</returns>
	private static CloudIqClientOptions GetClientOptions()
	{
		Assert.SkipUnless(
			HasCredentials,
			"CloudIQ credentials are not configured. Set ClientId, ClientSecret and BaseUri in user secrets (see userSecrets.example.json), or as CLOUDIQ_ClientId, CLOUDIQ_ClientSecret and CLOUDIQ_BaseUri environment variables.");

		return new CloudIqClientOptions
		{
			ClientId = Configuration["ClientId"]!,
			ClientSecret = Configuration["ClientSecret"]!,
			BaseUri = Configuration["BaseUri"]!
		};
	}
}
