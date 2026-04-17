using Microsoft.Extensions.Logging;

namespace Dell.CloudIq.Api.Test.Extensions;

/// <summary>Extension methods for <see cref="ITestOutputHelper"/>.</summary>
public static class TestOutputHelperExtensions
{
	/// <summary>Builds an <see cref="ILogger"/> backed by the xUnit test output helper.</summary>
	/// <param name="testOutputHelper">The xUnit test output helper.</param>
	/// <returns>An <see cref="ILogger"/> that writes to the test output.</returns>
	public static ILogger BuildLogger(this ITestOutputHelper testOutputHelper)
		=> new XunitLogger(testOutputHelper);
}

/// <summary>An <see cref="ILogger"/> implementation that writes to xUnit test output.</summary>
/// <param name="testOutputHelper">The xUnit test output helper to write log messages to.</param>
public class XunitLogger(ITestOutputHelper testOutputHelper) : ILogger
{
	/// <summary>Begins a logical operation scope.</summary>
	/// <typeparam name="TState">The type of the state.</typeparam>
	/// <param name="state">The identifier for the scope.</param>
	/// <returns>An <see cref="IDisposable"/> that ends the scope on dispose.</returns>
	public IDisposable? BeginScope<TState>(TState state) where TState : notnull => null;

	/// <summary>Returns true; all log levels are enabled.</summary>
	/// <param name="logLevel">The log level to check.</param>
	/// <returns><see langword="true"/> always.</returns>
	public bool IsEnabled(LogLevel logLevel) => true;

	/// <summary>Writes a log entry to the test output.</summary>
	/// <typeparam name="TState">The type of the state object.</typeparam>
	/// <param name="logLevel">The log level.</param>
	/// <param name="eventId">The event identifier.</param>
	/// <param name="state">The state object to log.</param>
	/// <param name="exception">Optional exception to log.</param>
	/// <param name="formatter">A function that formats the state and exception into a message string.</param>
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
