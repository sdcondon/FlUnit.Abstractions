using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FlUnit
{
    /// <summary>
    /// Interface for types representing an individual test case.
    /// </summary>
    public interface ITestCase : IFormattable
    {
        /// <summary>
        /// Assertions that should all succeed (that is, not throw) once the <see cref="ActAsync"/> method has been invoked.
        /// </summary>
        IReadOnlyCollection<ITestAssertion> Assertions { get; }

        /// <summary>
        /// Invokes the test action.
        /// </summary>
        /// <returns>A <see cref="ValueTask"/> representing the completion of the operation.</returns>
        ValueTask ActAsync();
    }
}
