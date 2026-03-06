using NUnit.Framework;

namespace Text.Tests
{
    // Test class for the Str.CamelCase method
    public class StrTests
    {
        // Test single word (no capital letters)
        [Test]
        public void SingleWord()
        {
            Assert.AreEqual(1, Str.CamelCase("hello"));
        }

        // Test two words
        [Test]
        public void TwoWords()
        {
            Assert.AreEqual(2, Str.CamelCase("helloWorld"));
        }

        // Test three words
        [Test]
        public void ThreeWords()
        {
            Assert.AreEqual(3, Str.CamelCase("helloWorldFoo"));
        }

        // Test empty string
        [Test]
        public void EmptyString()
        {
            Assert.AreEqual(0, Str.CamelCase(""));
        }

        // Test single capital letter
        [Test]
        public void SingleCapitalLetter()
        {
            Assert.AreEqual(2, Str.CamelCase("A"));
        }

        // Test multiple consecutive capital letters
        [Test]
        public void MultipleCapitalLetters()
        {
            Assert.AreEqual(4, Str.CamelCase("aAbBcC"));
        }

        // Test camelCase example
        [Test]
        public void CamelCaseExample()
        {
            Assert.AreEqual(2, Str.CamelCase("myVariable"));
        }

        // Test longer camelCase
        [Test]
        public void LongerCamelCase()
        {
            Assert.AreEqual(7, Str.CamelCase("thisIsALongCamelCaseString"));
        }

        // Test single lowercase letter
        [Test]
        public void SingleLowercaseLetter()
        {
            Assert.AreEqual(1, Str.CamelCase("a"));
        }

        // Test all lowercase
        [Test]
        public void AllLowercase()
        {
            Assert.AreEqual(1, Str.CamelCase("lowercase"));
        }
    }
}
