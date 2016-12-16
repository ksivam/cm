using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    /// <summary>
    /// Write a function that takes three integer inputs and returns a single output. 
    /// The inputs are the lengths of the sides of a triangle.The output is the area of that triangle.
    /// </summary>
    public class Req3
    {
        /// <summary>
        /// Calculates the area of triangle with its three sides.
        /// </summary>
        /// <param name="a">Side a length.</param>
        /// <param name="b">Side b length.</param>
        /// <param name="c">Side c length.</param>
        /// <returns>The area of the triable in <see cref="double"/></returns>
        public static double CalculateAreaOfTriange(int a, int b, int c)
        {
            if (!isValidTriangle(a, b, c))
            {
                string msg = string.Format("Impossible triangle with sides: {0}, {1}, {2}", a, b, c);
                throw new InvalidTriangleException(msg);
            }

            // Ref: https://en.wikipedia.org/wiki/Triangle#Using_Heron.27s_formula
            double s = (a + b + c) / 2.0;
            double area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
            return Math.Round(area, 4);
        }

        /// <summary>
        /// Checks whether a valid triangle can be formed with the give sides.
        /// </summary>
        /// <param name="a">Side a length.</param>
        /// <param name="b">Side b length.</param>
        /// <param name="c">Side c length.</param>
        /// <returns>A <see cref="bool"/></returns>
        private static bool isValidTriangle(int a, int b, int c)
        {
            if (a < 1 || b < 1 || c < 1)
            {
                return false;
            }

            // Ref: https://en.wikipedia.org/wiki/Triangle_inequality#Mathematical_expression_of_the_constraint_on_the_sides_of_a_triangle
            int diffOfTwoSides = Math.Abs(a - b);
            int sumOfTwoSides = a + b;

            return (diffOfTwoSides < c) && (c < sumOfTwoSides);
        }
    }

    /// <summary>
    /// Defines the invalid triange exception.
    /// </summary>
    public class InvalidTriangleException : Exception
    {
        /// <summary>
        /// The constructor.
        /// </summary>
        /// <param name="message">The exception message.</param>
        public InvalidTriangleException(string message)
            : base(message)
        {
        }
    }
}
