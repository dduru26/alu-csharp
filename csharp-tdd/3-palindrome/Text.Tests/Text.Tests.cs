using NUnit.Framework;

namespace Text.Tests
{
    // Test class for the Str.IsPalindrome method
    public class StrTests
    {
        // Test simple palindrome
        [Test]
        public void SimpleWordPalindrome()
        {
            Assert.IsTrue(Str.IsPalindrome("racecar"));
        }

        // Test case-insensitive palindrome
        [Test]
        public void CaseInsensitivePalindrome()
        {
            Assert.IsTrue(Str.IsPalindrome("Racecar"));
        }

        // Test palindrome with mixed case
        [Test]
        public void MixedCasePalindrome()
        {
            Assert.IsTrue(Str.IsPalindrome("RaceCar"));
        }

        // Test palindrome with spaces and punctuation
        [Test]
        public void PalindromeWithSpacesAndPunctuation()
        {
            Assert.IsTrue(Str.IsPalindrome("A man, a plan, a canal: Panama."));
        }

        // Test simple word palindrome
        [Test]
        public void LevelPalindrome()
        {
            Assert.IsTrue(Str.IsPalindrome("level"));
        }

        // Test empty string is palindrome
        [Test]
        public void EmptyStringIsPalindrome()
        {
            Assert.IsTrue(Str.IsPalindrome(""));
        }

        // Test single character is palindrome
        [Test]
        public void SingleCharacterIsPalindrome()
        {
            Assert.IsTrue(Str.IsPalindrome("a"));
        }

        // Test non-palindrome
        [Test]
        public void NonPalindrome()
        {
            Assert.IsFalse(Str.IsPalindrome("hello"));
        }

        // Test palindrome with numbers
        [Test]
        public void PalindromeWithNumbers()
        {
            Assert.IsTrue(Str.IsPalindrome("12321"));
        }

        // Test palindrome with mixed alphanumeric
        [Test]
        public void PalindromeWithAlphanumeric()
        {
            Assert.IsTrue(Str.IsPalindrome("a1b1a"));
        }

        // Test non-palindrome with mixed case
        [Test]
        public void NonPalindromeWithMixedCase()
        {
            Assert.IsFalse(Str.IsPalindrome("Hello"));
        }

        // Test palindrome with only spaces and punctuation
        [Test]
        public void OnlySpacesAndPunctuation()
        {
            Assert.IsTrue(Str.IsPalindrome("   !!!   "));
        }

        // Test two character palindrome
        [Test]
        public void TwoCharacterPalindrome()
        {
            Assert.IsTrue(Str.IsPalindrome("aa"));
        }

        // Test two character non-palindrome
        [Test]
        public void TwoCharacterNonPalindrome()
        {
            Assert.IsFalse(Str.IsPalindrome("ab"));
        }
    }
}
