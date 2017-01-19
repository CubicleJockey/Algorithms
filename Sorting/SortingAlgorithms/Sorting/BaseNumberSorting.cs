using System;
using System.Collections.Generic;
using System.Linq;

namespace Sorting
{
    public abstract class BaseNumberSorting<TNumber> where TNumber : IComparable<TNumber>
    {
        /// <summary>
        /// Bubble Sort (aka - Sinking Sort)
        /// <br/>
        /// <remarks>
        /// Performance: <br/>
        /// *Worst-Case: O(n^2) <br/>
        /// *Best-Case:  O(n^2) <br/>
        /// *Average:    O(n^2) <br/>
        /// </remarks>
        /// </summary>
        /// <returns>A collection of numbers sorted in Ascending Order.</returns>
        public virtual IEnumerable<TNumber> BubbleSort(IEnumerable<TNumber> unsortedNumbers)
        {
            IList<TNumber> numbers = unsortedNumbers.ToArray();

            //Make sure to run through each number 
            for (var i = 0; i < numbers.Count; i++)
            {
                //Pass number through entire array
                for(var current = 0; current < (numbers.Count - 1); current++)
                {
                    var next = (current + 1);
                    if(numbers[current].CompareTo(numbers[next]) > 0)
                    {
                        Swap(numbers, current, next);
                    }
                }
            }
            return numbers;
        }


        #region Helper Methods

        private static void Swap(IList<TNumber> numbers, int current, int next)
        {
            var temp = numbers[next];
            numbers[next] = numbers[current];
            numbers[current] = temp;
        }

        #endregion  Helper Methods

    }
}
