using System;

namespace Text
{
    /// <summary>
    /// Contains text manipulation operations.
    /// </summary>
    public class Str
    {
        /// <summary>
        /// Checks if a string is a palindrome.
        /// </summary>
        /// <param name="s">The input string to check.</param>
        /// <returns>True if the string is a palindrome, False if it's not.</returns>
        public static bool IsPalindrome(string s)
        {
            if (string.IsNullOrWhiteSpace(s))
            {
                return true; // An empty string is considered a palindrome.
            }

            s = CleanString(s);

            int left = 0;
            int right = s.Length - 1;

            while (left < right)
            {
                if (s[left] != s[right])
                {
                    return false;
                }

                left++;
                right--;
            }

            return true;
        }

        private static string CleanString(string s)
        {
            s = s.ToLower();
            s = RemovePunctuationAndSpaces(s);
            return s;
        }

        private static string RemovePunctuationAndSpaces(string s)
        {
            var result = new char[s.Length];
            int resultIndex = 0;

            foreach (var c in s)
            {
                if (char.IsLetterOrDigit(c))
                {
                    result[resultIndex] = c;
                    resultIndex++;
                }
            }

            return new string(result, 0, resultIndex);
        }
    }
}
