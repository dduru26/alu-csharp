using NUnit.Framework;

namespace MyMath.Tests
{
    // Test class for the Operations.Add method
    public class OperationsTests
    {
        // Test adding two positive numbers
        [Test]
        public void AddTwoPositiveNumbers()
        {
            Assert.AreEqual(5, Operations.Add(2, 3));
        }

        // Test adding two negative numbers
        [Test]
        public void AddTwoNegativeNumbers()
        {
            Assert.AreEqual(-5, Operations.Add(-2, -3));
        }

        // Test adding positive and negative numbers
        [Test]
        public void AddPositiveAndNegativeNumbers()
        {
            Assert.AreEqual(1, Operations.Add(5, -4));
        }

        // Test adding zero to a number
        [Test]
        public void AddZeroToNumber()
        {
            Assert.AreEqual(5, Operations.Add(5, 0));
        }

        // Test adding two zeros
        [Test]
        public void AddTwoZeros()
        {
            Assert.AreEqual(0, Operations.Add(0, 0));
        }

        // Test adding large numbers
        [Test]
        public void AddLargeNumbers()
        {
            Assert.AreEqual(2000000000, Operations.Add(1000000000, 1000000000));
        }

        // Test adding negative zero
        [Test]
        public void AddNegativeZero()
        {
            Assert.AreEqual(5, Operations.Add(5, -0));
        }

        // Test commutative property (a + b = b + a)
        [Test]
        public void AddCommutativeProperty()
        {
            Assert.AreEqual(Operations.Add(3, 7), Operations.Add(7, 3));
        }
    }
}
