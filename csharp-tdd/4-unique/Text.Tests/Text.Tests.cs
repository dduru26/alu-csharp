using NUnit.Framework;

namespace Text.Tests
{
    // Test class for the Str.UniqueChar method
    public class StrTests
    {
        // Test string with unique character at the beginning
        [Test]
        public void UniqueCharAtBeginning()
        {
            Assert.AreEqual(-1, Str.UniqueChar("abcabc"));
        }

        // Test string with unique character in the middle
        [Test]
        public void UniqueCharInMiddle()
        {
            Assert.AreEqual(3, Str.UniqueChar("aabcbb"));
        }

        // Test string with unique character at the end
        [Test]
        public void UniqueCharAtEnd()
        {
            Assert.AreEqual(-1, Str.UniqueChar("aabba"));
        }

        // Test string with no unique characters
        [Test]
        public void NoUniqueCharacters()
        {
            Assert.AreEqual(-1, Str.UniqueChar("aabbcc"));
        }

        // Test single character string
        [Test]
        public void SingleCharacter()
        {
            Assert.AreEqual(0, Str.UniqueChar("a"));
        }

        // Test empty string
        [Test]
        public void EmptyString()
        {
            Assert.AreEqual(-1, Str.UniqueChar(""));
        }

        // Test string with all same characters
        [Test]
        public void AllSameCharacters()
        {
            Assert.AreEqual(-1, Str.UniqueChar("aaaa"));
        }

        // Test string with two characters
        [Test]
        public void TwoCharactersSame()
        {
            Assert.AreEqual(-1, Str.UniqueChar("aa"));
        }

        // Test string with two different characters
        [Test]
        public void TwoDifferentCharacters()
        {
            Assert.AreEqual(0, Str.UniqueChar("ab"));
        }

        // Test long string with unique character
        [Test]
        public void LongStringWithUniqueChar()
        {
            Assert.AreEqual(-1, Str.UniqueChar("aabbccddee"));
        }

        // Test string with first unique character
        [Test]
        public void FirstUniqueCharacter()
        {
            Assert.AreEqual(0, Str.UniqueChar("leetcode"));
        }

        // Test another example
        [Test]
        public void AnotherExample()
        {
            Assert.AreEqual(2, Str.UniqueChar("loveleetcode"));
        }
    }
}
