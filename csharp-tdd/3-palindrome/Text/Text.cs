using System;
using System.Text.RegularExpressions;

namespace Text
{
    /// <summary>
    /// Provides string operations.
    /// </summary>
    public static class Str
    {
        /// <summary>
        /// Determines whether a string is a palindrome.
        /// </summary>
        /// <param name="s">The string to check.</param>
        /// <returns>True if the string is a palindrome, False otherwise.</returns>
        /// <remarks>
        /// Palindrome check is case-insensitive and ignores spaces and punctuation.
        /// An empty string is considered a palindrome.
        /// </remarks>
        public static bool IsPalindrome(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return true;
            }

            // Remove non-alphanumeric characters and convert to lowercase
            string cleaned = Regex.Replace(s.ToLower(), "[^a-z0-9]", "");

            // Check if the cleaned string is a palindrome
            int left = 0;
            int right = cleaned.Length - 1;

            while (left < right)
            {
                if (cleaned[left] != cleaned[right])
                {
                    return false;
                }
                left++;
                right--;
            }

            return true;
        }
    }
}
