using Microsoft.Extensions.Logging;

namespace Dell.CloudIq.Api.Test.Extensions;

public static class TestOutputHelperExtensions
{
	public static ILogger BuildLogger(this ITestOutputHelper testOutputHelper)
		=> new XunitLogger(testOutputHelper);
}

public class XunitLogger(ITestOutputHelper testOutputHelper) : ILogger
{
	public IDisposable? BeginScope<TState>(TState state) where TState : notnull => null;

	public bool IsEnabled(LogLevel logLevel) => true;

	public void Log<TState>(
		LogLevel logLevel,
		EventId eventId,
		TState state,
		Exception? exception,
		Func<TState, Exception?, string> formatter)
	{
		testOutputHelper.WriteLine($"[{logLevel}] {formatter(state, exception)}");

		if (exception is not null)
		{
			testOutputHelper.WriteLine(exception.ToString());
		}
	}
}
