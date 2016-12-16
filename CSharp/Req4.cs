using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    /// <summary>
    /// Write a function that takes an array of integers, and returns an array of integers. 
    /// The return value should contain those integers which are most common in the input array.
    /// </summary>
    public class Req4
    {
        /// <summary>
        /// Gets the most common items from the input array.
        /// </summary>
        /// <param name="input">The input array.</param>
        /// <returns>An array of common items.</returns>
        public static int[] getMostCommonItems(int[] input)
        {
            if (input == null || input.Length == 0)
            {
                // garbage in; garbage out
                return input;
            }

            IDictionary<int, int> frequencyDictionary = new Dictionary<int, int>();
            ICollection<int> result = new List<int>();

            // Calcualate the number of occurance of each item in the input array.
            // Time complexity: (-) n
            foreach (int item in input)
            {
                int count = 1;
                if (frequencyDictionary.ContainsKey(item))
                {
                    count = ++frequencyDictionary[item];
                }

                frequencyDictionary[item] = count;
            }

            // Sort the values and get the max occurance value.
            // Time complexity: (-) n log(n)
            int topFrequency = frequencyDictionary.Values.OrderByDescending(i => i).First();

            // Get the items which has the max occurance value.
            // Time complexity: (-)n
            foreach (KeyValuePair<int, int> freqencies in frequencyDictionary)
            {
                if (freqencies.Value == topFrequency)
                {
                    result.Add(freqencies.Key);
                }
            }

            // total time complexity: (-) n + (-) n log(n) + (-) n
            /// <=> (-) n + (-) n log(n)
            return result.ToArray();
        }
    }
}
