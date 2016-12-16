using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using CSharp;
using System.Text;

namespace CSharpUnitTest
{
    [TestClass]
    public class Req1UnitTest
    {
        [TestMethod]
        public void GIVEN_ValidStringTestCase_WHEN_IsNullOrEmpty_THEN_Pass()
        {
            IDictionary<String, bool> testcases = new Dictionary<String, bool>()
            {
                {"a", false },
                {"", true },
                {"null", false }
            };

            RunStringTests(testcases);
        }

        [TestMethod]
        public void GIVEN_Null_WHEN_IsNullOrEmpty_THEN_Pass()
        {
            String nullString = null;
            Assert.IsTrue(nullString.isNullOrEmpty(), "Null string check failed.");
        }

        [TestMethod]
        public void GIVEN_ValidUnicodeStringTestCase_WHEN_IsNullOrEmpty_THEN_Pass()
        {
            // Ref: http://www.ltg.ed.ac.uk/~richard/unicode-sample.html
            IDictionary<String, bool> testcases = new Dictionary<String, bool>()
            {
                {"Ϋ ά έ ή ί ΰ α β γ δ ", false },
                {"அ ஆ இ ஈ உ ஊ எ ஏ ஐ", false },
                {"Τ Υ Φ Χ Ψ Ω Ϊ Ϋ ά έ ", false }
            };

            RunStringTests(testcases);
        }

        private static void RunStringTests(IDictionary<string, bool> testcases)
        {
            StringBuilder result = new StringBuilder();
            foreach (KeyValuePair<String, bool> testcase in testcases)
            {
                bool actual = testcase.Key.isNullOrEmpty();
                bool expected = testcase.Value;

                if (actual != expected)
                {
                    string msg = string.Format("Test case failed for '{0}'. Actual: {1}. Expected: {2}",
                        testcase.Key,
                        actual,
                        expected);

                    result.Append(msg);
                }

                Assert.IsTrue(result.Length == 0, result.ToString());
            }
        }
    }
}
