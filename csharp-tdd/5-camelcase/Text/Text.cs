using System;

namespace Text
{
    /// <summary>
    /// Provides string operations.
    /// </summary>
    public static class Str
    {
        /// <summary>
        /// Counts the number of words in a camelCase string.
        /// </summary>
        /// <param name="s">The camelCase string to analyze.</param>
        /// <returns>The number of words in the string.</returns>
        /// <remarks>
        /// Each word begins with a capital letter except the first word.
        /// An empty string contains 0 words.
        /// </remarks>
        public static int CamelCase(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return 0;
            }

            int wordCount = 1;
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
