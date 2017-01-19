using static System.Console;
using System.Collections.Generic;
using System.Linq;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Sorting.Tests
{
    [TestClass]
    public class NumberSortingTests
    {
        private readonly IntSorting sorter;

        public NumberSortingTests()
        {
            sorter = new IntSorting();
        }

        [TestMethod]
        public void BubbleSort_IntSmall()
        {
            IEnumerable<int> unsortedNumbers = new[] {5, 10, 32, 1, 16, 34, 56};
            
            var result = sorter.BubbleSort(unsortedNumbers).ToArray();

            WriteLine($"Result: {string.Join(", ", result)}");

            //1, 5, 10, 16, 32, 34, 56
            result.Should().BeInAscendingOrder();
        }
    }
}
