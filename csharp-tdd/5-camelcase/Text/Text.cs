using System;

namespace Text
{
    /// <summary>
    /// Contains text manipulation operations.
    /// </summary>
    public class Str
    {
        /// <summary>
        /// Determines the number of words in a camelCase string.
        /// </summary>
        /// <param name="s">The input string to analyze.</param>
        /// <returns>The number of words in the string.</returns>
        public static int CamelCase(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return 0; // No words in an empty string.
            }

            int wordCount = 1; // Initialize to 1 for the first word.

            foreach (char c in s)
            {
                if (char.IsUpper(c))
                {
                    wordCount++;
                }
            }

            return wordCount;
        }
    }
}
