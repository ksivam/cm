using System;

namespace CSharp
{
    /// <summary>
    /// Write an extension method on string called IsNullOrEmpty. The extension method should return the
    /// same value as the standard.NET framework string.IsNullOrEmpty, without actually calling that function.
    /// </summary>
    public static class Req1
    {
        /// <summary>
        /// Checks whether the input string is null or empty.
        /// </summary>
        /// <param name="input">The input string.</param>
        /// <returns>A <see cref="bool"/></returns>
        public static bool isNullOrEmpty(this String input)
        {
            if (input == null || input.Length == 0)
            {
                return true;
            }

            return false;
        }
    }
}
