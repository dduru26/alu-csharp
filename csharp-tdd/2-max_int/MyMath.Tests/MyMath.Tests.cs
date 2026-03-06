using NUnit.Framework;
using System.Collections.Generic;

namespace MyMath.Tests
{
    // Test class for the Operations.Max method
    public class OperationsTests
    {
        // Test max of a list with positive numbers
        [Test]
        public void MaxOfPositiveNumbers()
        {
            List<int> nums = new List<int> { 1, 5, 3, 9, 2 };
            Assert.AreEqual(9, Operations.Max(nums));
        }

        // Test max of a list with negative numbers
        [Test]
        public void MaxOfNegativeNumbers()
        {
            List<int> nums = new List<int> { -5, -1, -10, -3 };
            Assert.AreEqual(-1, Operations.Max(nums));
        }

        // Test max of a list with mixed positive and negative numbers
        [Test]
        public void MaxOfMixedNumbers()
        {
            List<int> nums = new List<int> { -5, 10, -3, 8, 0 };
            Assert.AreEqual(10, Operations.Max(nums));
        }

        // Test max of an empty list returns 0
        [Test]
        public void MaxOfEmptyListReturnsZero()
        {
            List<int> nums = new List<int>();
            Assert.AreEqual(0, Operations.Max(nums));
        }

        // Test max of a list with one element
        [Test]
        public void MaxOfSingleElement()
        {
            List<int> nums = new List<int> { 42 };
            Assert.AreEqual(42, Operations.Max(nums));
        }

        // Test max of a null list returns 0
        [Test]
        public void MaxOfNullListReturnsZero()
        {
            Assert.AreEqual(0, Operations.Max(null));
        }

        // Test max of a list with all same elements
        [Test]
        public void MaxOfAllSameElements()
        {
            List<int> nums = new List<int> { 5, 5, 5, 5 };
            Assert.AreEqual(5, Operations.Max(nums));
        }

        // Test max of a list with zeros
        [Test]
        public void MaxOfListWithZeros()
        {
            List<int> nums = new List<int> { 0, 0, 0 };
            Assert.AreEqual(0, Operations.Max(nums));
        }

        // Test max of a large list
        [Test]
        public void MaxOfLargeList()
        {
            List<int> nums = new List<int> { 100, 50, 75, 200, 25, 150 };
            Assert.AreEqual(200, Operations.Max(nums));
        }

        // Test max of a list with max at the beginning
        [Test]
        public void MaxAtBeginning()
        {
            List<int> nums = new List<int> { 100, 50, 25, 10 };
            Assert.AreEqual(100, Operations.Max(nums));
        }

        // Test max of a list with max at the end
        [Test]
        public void MaxAtEnd()
        {
            List<int> nums = new List<int> { 10, 25, 50, 100 };
            Assert.AreEqual(100, Operations.Max(nums));
        }
    }
}
