using System.Threading;

namespace FlUnit
{
    /// <summary>
    /// Interface for types representing the context in which a test is running.
    /// Can be used by tests to interact with that context - to record test attachments, write output, and so on.
    /// </summary>
    public interface ITestContext
    {
        /// <summary>
        /// Gets the cancellation token for the test. Potentially long-running test clauses should respect this.
        /// </summary>
        CancellationToken TestCancellation { get; }

        /// <summary>
        /// Appends some text to the output stream for the testt.
        /// </summary>
        /// <param name="output">The text to append.</param>
        void WriteOutput(string output);

        /// <summary>
        /// Appends a line of text to the output stream of the test context.
        /// </summary>
        /// <param name="output">The text to append.</param>
        void WriteOutputLine(string output);

        /// <summary>
        /// Appends some text to the error stream of the test context.
        /// </summary>
        /// <param name="error">The text to append.</param>
        void WriteError(string error);

        /// <summary>
        /// Appends a line of text to the error stream of the test context.
        /// </summary>
        /// <param name="error">The text to append.</param>
        void WriteErrorLine(string error);
    }
}
