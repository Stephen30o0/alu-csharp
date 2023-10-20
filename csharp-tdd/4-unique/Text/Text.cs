using System;

namespace Text
{
    /// <summary>
    /// Contains text manipulation operations.
    /// </summary>
    public class Str
    {
        /// <summary>
        /// Finds the index of the first non-repeating character in a string.
        /// </summary>
        /// <param name="s">The input string to check.</param>
        /// <returns>The index of the first non-repeating character, or -1 if none exists.</returns>
        public static int UniqueChar(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return -1; // No non-repeating character in an empty string.
            }

            int[] charCount = new int[26]; // Assuming only lowercase letters are in the string.

            for (int i = 0; i < s.Length; i++)
            {
                charCount[s[i] - 'a']++;
            }

            for (int i = 0; i < s.Length; i++)
            {
                if (charCount[s[i] - 'a'] == 1)
                {
                    return i;
                }
            }

            return -1; // No non-repeating character found.
        }
    }
}
