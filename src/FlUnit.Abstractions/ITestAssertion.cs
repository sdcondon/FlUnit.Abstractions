using System;
using System.Threading.Tasks;

namespace FlUnit
{
    /// <summary>
    /// Interface for types representing a testable assertion for a test.
    /// </summary>
    public interface ITestAssertion : IFormattable
    {
#if NET6_0_OR_GREATER
        /// <summary>
        /// Tests the assertion. Failures should be indicated by thrown exceptions (ideally those implementing <see cref="ITestFailureDetails"/>).
        /// </summary>
        /// <returns>A <see cref="ValueTask"/> representing the completion of the operation.</returns>
        ValueTask AssertAsync();
#else
        /// <summary>
        /// Tests the assertion. Failures should be indicated by thrown exceptions (ideally those implementing <see cref="ITestFailureDetails"/>).
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the completion of the operation.</returns>
        Task AssertAsync();
#endif
    }
}
