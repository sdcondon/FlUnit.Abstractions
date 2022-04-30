namespace FlUnit
{
    /// <summary>
    /// Interface for types representing the context in which a test is running.
    /// Can be used by tests to interact with that context - to record test attachments, write output, and so on.
    /// </summary>
    public interface ITestContext
    {
        /// <summary>
        /// Appends some text to the standard output stream of the test context.
        /// </summary>
        /// <param name="output">The text to append.</param>
        void WriteOutput(string output);

        /// <summary>
        /// Appends a line of text to the standard output stream of the test context.
        /// </summary>
        /// <param name="output">The text to append.</param>
        void WriteOutputLine(string output);
    }
}
