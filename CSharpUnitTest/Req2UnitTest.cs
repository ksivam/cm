using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSharp;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CSharpUnitTest
{
    [TestClass]
    public class Req2UnitTest
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void GIVEN_Zero_WHEN_GetPositiveDivisors_THEN_ThrowArgumentException()
        {
            UInt64[] result = Req2.getPositiveDivisors(0);
        }

        [TestMethod]
        public void GIVEN_PositiveInteger_WHEN_GetPositiveDivisors_THEN_ReturnPositiveDivisors()
        {
            IDictionary<UInt64, UInt64[]> testcases = new Dictionary<UInt64, UInt64[]>()
            {
                {60, new UInt64[] {1, 2, 3, 4, 5, 6, 10, 12, 15, 20, 30, 60} },
                {42, new UInt64[] {1, 2, 3, 6, 7, 14, 21, 42} },
                {25, new UInt64[] {1, 5, 25} },
                {3, new UInt64[] {1,3} },
                {2, new UInt64[] {1,2} },
                {1, new UInt64[] {1} }
            };

            StringBuilder result = new StringBuilder();
            foreach (KeyValuePair<UInt64, UInt64[]> testcase in testcases)
            {
                UInt64[] actual = Req2.getPositiveDivisors(testcase.Key);
                UInt64[] expected = testcase.Value;

                // Ref: https://msdn.microsoft.com/en-us/library/bb348567.aspx
                if (!actual.SequenceEqual(expected))
                {
                    string msg = string.Format("Test case failed for '{0}'. Actual: [{1}]. Expected: [{2}]",
                        testcase.Key,
                        String.Join(",", actual),
                        String.Join(",", expected));

                    result.Append(msg);
                }

                Assert.IsTrue(result.Length == 0, result.ToString());
            }
        }
    }
}
