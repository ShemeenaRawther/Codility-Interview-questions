using System.Collections.Generic;
using System.Linq;

namespace Programming
{
    internal class OddAccuracyInArray
    {
        public static int FindOddOccurancy(int[] numbers)
        {
            var uniqueNumbers = new HashSet<int>();

            for (int i = 0; i < numbers.Length; i++)
            {
                if (uniqueNumbers.Contains(numbers[i]))
                {
                    uniqueNumbers.Remove(numbers[i]);
                }
                else
                {
                    uniqueNumbers.Add(numbers[i]);
                }
            }

            return uniqueNumbers.First();

        }
    }
}
