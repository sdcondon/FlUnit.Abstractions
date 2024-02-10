using System;
using System.Threading.Tasks;

namespace FlUnit
{
    /// <summary>
    /// Interface for types representing a testable assertion for a test.
    /// </summary>
    public interface ITestAssertion : IFormattable
    {
        /// <summary>
        /// Tests the assertion. Failures should be indicated by thrown exceptions (ideally those implementing <see cref="ITestFailureDetails"/>).
        /// </summary>
#if NET6_0_OR_GREATER
        ValueTask AssertAsync();
#else
        Task AssertAsync();
#endif
    }
}
