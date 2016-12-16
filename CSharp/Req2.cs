using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp
{
    /// <summary>
    /// Write a function that takes a single positive integer, and returns a collection / sequence of integers.
    /// The return value should contain those integers that are positive divisors of the input integer.
    /// </summary>
    public class Req2
    {
        /// <summary>
        /// Gets all positive divisora for the input positive integer
        /// </summary>
        /// <param name="input">The input.</param>
        /// <returns>An array of <see cref="UInt64"/> divisors</returns>
        public static UInt64[] getPositiveDivisors(UInt64 input)
        {
            if (input == 0)
            {
                throw new ArgumentException("Input value '0' is not positive integer. Please input a positive integer");
            }

            ICollection<UInt64> result = new List<UInt64>();

            /**
             * Below is the thought process of how this solution is arrived
             * 
             * 1. A simple brute force approach is to iterate from 1 to n and find all
             * divisor S.T (n % i) == 0. The complexity here is (-)n. Not ideal.
             * 
             * 2. On closer look, n cannot have any positive divisor greater than n/2 except itself.
             * So, a small inprovement to #1 solution is to iterate from 1 to n/2 to find all divisor 
             * S.T (n % i) == 0 and finally include n in the output divisor. 
             * The complexity remains (-)n/2 <==> (-)n. Not ideal.
             * 
             * 3. On probing further and referencing @https://en.wikipedia.org/wiki/Divisor, it can be conclude that
             * (i) m is a divisor of n, if n % m == 0
             * (ii) m is a divisor, if there exist another number k, such that m * k == n
             * From #(ii), we get k by n/m .. More over the divisor abd quotient appears in pair (divisor, quotient)
             * Also, instead of iterating from i to n/2, it is just enough to iterate till the square root of n.
             * Care should be take to exclude identical (divisor, quotient) pair incase of perfect square n.
             * The complexity of the solution is (-) Sqrt(n).
             * 
             * Solution #3 is not ideal when large positive number is given as input. 
             * For example, the boundary condition UInt64.MaxValue, could potentially take 584 years to complete
             * if one for loop iteration take 1 nano seconds.
             * 
             * 4. Another potential improvement to large positive number input is to have 
             * (i) A distributed backend jobs/services, which takes sharded positive numbers between 1 to UInt64.MaxValue 
             * as input and update the storage system (eg: redis) with a key/value pair result like 
             * {n: [all positive divisors of n]}. This is like a demon, which runs forever calculation/updating the storage 
             * with results.
             * (ii) Now the front end system which is responsible for getting all positive divisors for the inputs number
             * can simple query the storage system for the key and return the already computed postive divisor results.
             * (iii) The best case time complexity is (-) (1 + overhead of calling storage) and the worst case remains
             * (-) Sqrt(n).
             * 
             * In the below solution, option #3 is implemented and assumed that no large positive integers are given as input.
             */

            double sqrt = Math.Sqrt(input);
            for (UInt64 divisor = 1; divisor <= sqrt; ++divisor)
            {            
                if (input % divisor == 0)
                {
                    // divisor * quotient == input
                    UInt64 quotient = input / divisor;

                    result.Add(divisor);
                    if (quotient != divisor)
                    {
                        result.Add(quotient);
                    }
                }
            }

            return result.OrderBy(i => i).ToArray();
        }
    }
}
