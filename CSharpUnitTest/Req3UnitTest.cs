using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSharp;

namespace CSharpUnitTest
{
    [TestClass]
    public class Req3UnitTest
    {
        [TestMethod]
        [ExpectedException(typeof(InvalidTriangleException))]
        public void GIVEN_SidesOfZeroLength_WHEN_CalculateAreaOfTriangle_THEN_ThrowInvalidTriangleException()
        {
            double area = Req3.CalculateAreaOfTriange(0, 2, 0);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidTriangleException))]
        public void GIVEN_SideOfNegativeLength_WHEN_CalculateAreaOfTriangle_THEN_ThrowInvalidTriangleException()
        {
            double area = Req3.CalculateAreaOfTriange(-10, 2, 4);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidTriangleException))]
        public void GIVEN_SidesOfImpossibleLength_WHEN_CalculateAreaOfTriangle_THEN_ThrowInvalidTriangleException()
        {
            double area = Req3.CalculateAreaOfTriange(1, 2, 3);
        }

        [TestMethod]
        public void GIVEN_SidesOfValidLength_WHEN_CalculateAreaOfTriangle_THEN_ReturnArea()
        {
            double actualArea1 = Req3.CalculateAreaOfTriange(3, 4, 5);
            double expectedArea1 = 6;
            Assert.AreEqual(expectedArea1, actualArea1,
                "Incorrect triangle area for sides 3, 4, 5.");

            double actualArea2 = Req3.CalculateAreaOfTriange(3, 7, 5);
            double expectedArea2 = 6.4952;
            Assert.AreEqual(expectedArea2, actualArea2, "Incorrect triangle area for sides 3, 7, 5.");
        }
    }
}
