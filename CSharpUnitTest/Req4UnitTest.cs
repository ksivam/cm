using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CSharp;

namespace CSharpUnitTest
{
    public class MostCommonItemsTestSample
    {
        public int[] Input;
        public ICollection<int> ExpectedOutput;
    }

    [TestClass]
    public class Req4UnitTest
    {
        [TestMethod]
        public void GIVEN_ValidInputArray_WHEN_GetMostCommonItems_THEN_ReturnMostCommonItems()
        {
            ICollection<MostCommonItemsTestSample> testcases = getTestInputs();

            StringBuilder result = new StringBuilder();
            foreach (MostCommonItemsTestSample sample in testcases)
            {
                int[] commonItems = Req4.getMostCommonItems(sample.Input);
                IEnumerable<int> actual = new List<int>(commonItems).OrderBy(i => i);
                IEnumerable<int> expected = sample.ExpectedOutput.OrderBy(i => i);


                if (!actual.SequenceEqual(expected))
                {
                    string msg = string.Format("Test case failed for '{0}'. Actual: [{1}]. Expected: [{2}]",
                        String.Join(",", sample.Input),
                        String.Join(",", actual),
                        String.Join(",", expected));

                    result.Append(msg);
                }

                Assert.IsTrue(result.Length == 0, result.ToString());
            }
        }

        private ICollection<MostCommonItemsTestSample> getTestInputs()
        {
            return new List<MostCommonItemsTestSample>()
            {
                new MostCommonItemsTestSample()
                {
                    Input = new int[] {5, 4, 3, 2, 4, 5, 1, 6, 1, 2, 5, 4},
                    ExpectedOutput = new int[] {5, 4}
                },
                new MostCommonItemsTestSample()
                {
                    Input = new int[] {1, 2, 3, 4, 5, 1, 6, 7},
                    ExpectedOutput = new int[] {1}
                },
                new MostCommonItemsTestSample()
                {
                    Input = new int[] {1, 2, 3, 4, 5, 6, 7},
                    ExpectedOutput = new int[] {1, 2, 3, 4, 5, 6, 7}
                }
            };
        }
    }
}
