using System.Collections;
using System.Collections.Generic;

namespace UnitTests.Shared
{
    /// <summary>
    /// XUnit abstraction to allow more flexibility when working with Theory
    /// (Inline) data: https://andrewlock.net/creating-strongly-typed-xunit-theory-test-data-with-theorydata/
    /// </summary>
    public abstract class TheoryData : IEnumerable<object[]>
    {
        /// <summary>
        /// Represents the behind the scenes Theory data.
        /// </summary>
        private readonly List<object[]> data = new List<object[]>();

        /// <summary>
        /// Allows data to be added.
        /// </summary>
        /// <param name="values">The values to be added.</param>
        protected void AddRow(params object[] values) => data.Add(values);

        /// <summary>
        /// Allows access to the data.
        /// </summary>
        /// <returns>The data behind this type.</returns>
        public IEnumerator<object[]> GetEnumerator() => data.GetEnumerator();

        /// <summary>
        /// Allows access to the enumerator.
        /// </summary>
        /// <returns>The <see cref="IEnumerator"/> behind this type.</returns>
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
