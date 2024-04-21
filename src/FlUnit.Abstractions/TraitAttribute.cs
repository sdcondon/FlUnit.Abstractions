using System;

namespace FlUnit
{
    /// <summary>
    /// Attribute used to decorate a test, test class, or assembly with arbitrary name/value pairs ("traits").
    /// </summary>
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Class | AttributeTargets.Assembly, AllowMultiple = true)]
	public sealed class TraitAttribute : Attribute
	{
        /// <summary>
        /// Creates a new instance of the <see cref="TraitAttribute"/> class.
        /// </summary>
        /// <param name="name">The name of the trait.</param>
        /// <param name="value">The value of the trait.</param>
        public TraitAttribute(string name, string value) => (Name, Value) = (name, value);

        /// <summary>
        /// Gets the name of the trait.
        /// </summary>
		public string Name { get; }

        /// <summary>
        /// Gets the value of the trait.
        /// </summary>
        public string Value { get; }
	}
}
