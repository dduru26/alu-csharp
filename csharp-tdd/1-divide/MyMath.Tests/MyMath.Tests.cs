using NUnit.Framework;

namespace MyMath.Tests
{
    // Test class for the Matrix.Divide method
    public class MatrixTests
    {
        // Test dividing a simple matrix by a positive number
        [Test]
        public void DivideMatrixByPositiveNumber()
        {
            int[,] matrix = { { 10, 20 }, { 30, 40 } };
            int[,] result = Matrix.Divide(matrix, 2);
            
            Assert.AreEqual(5, result[0, 0]);
            Assert.AreEqual(10, result[0, 1]);
            Assert.AreEqual(15, result[1, 0]);
            Assert.AreEqual(20, result[1, 1]);
        }

        // Test dividing a matrix by 1
        [Test]
        public void DivideMatrixByOne()
        {
            int[,] matrix = { { 5, 10 }, { 15, 20 } };
            int[,] result = Matrix.Divide(matrix, 1);
            
            Assert.AreEqual(5, result[0, 0]);
            Assert.AreEqual(10, result[0, 1]);
            Assert.AreEqual(15, result[1, 0]);
            Assert.AreEqual(20, result[1, 1]);
        }

        // Test dividing a matrix by zero returns null
        [Test]
        public void DivideMatrixByZeroReturnsNull()
        {
            int[,] matrix = { { 10, 20 }, { 30, 40 } };
            int[,] result = Matrix.Divide(matrix, 0);
            
            Assert.IsNull(result);
        }

        // Test dividing a null matrix returns null
        [Test]
        public void DivideNullMatrixReturnsNull()
        {
            int[,] result = Matrix.Divide(null, 5);
            
            Assert.IsNull(result);
        }

        // Test dividing a matrix with negative numbers
        [Test]
        public void DivideMatrixWithNegativeNumbers()
        {
            int[,] matrix = { { -10, 20 }, { -30, 40 } };
            int[,] result = Matrix.Divide(matrix, 2);
            
            Assert.AreEqual(-5, result[0, 0]);
            Assert.AreEqual(10, result[0, 1]);
            Assert.AreEqual(-15, result[1, 0]);
            Assert.AreEqual(20, result[1, 1]);
        }

        // Test dividing a matrix by a negative number
        [Test]
        public void DivideMatrixByNegativeNumber()
        {
            int[,] matrix = { { 10, 20 }, { 30, 40 } };
            int[,] result = Matrix.Divide(matrix, -2);
            
            Assert.AreEqual(-5, result[0, 0]);
            Assert.AreEqual(-10, result[0, 1]);
            Assert.AreEqual(-15, result[1, 0]);
            Assert.AreEqual(-20, result[1, 1]);
        }

        // Test dividing a single element matrix
        [Test]
        public void DivideSingleElementMatrix()
        {
            int[,] matrix = { { 100 } };
            int[,] result = Matrix.Divide(matrix, 10);
            
            Assert.AreEqual(10, result[0, 0]);
        }

        // Test dividing a matrix with zeros
        [Test]
        public void DivideMatrixWithZeros()
        {
            int[,] matrix = { { 0, 20 }, { 30, 0 } };
            int[,] result = Matrix.Divide(matrix, 5);
            
            Assert.AreEqual(0, result[0, 0]);
            Assert.AreEqual(4, result[0, 1]);
            Assert.AreEqual(6, result[1, 0]);
            Assert.AreEqual(0, result[1, 1]);
        }

        // Test dividing a 3x3 matrix
        [Test]
        public void Divide3x3Matrix()
        {
            int[,] matrix = { { 2, 4, 6 }, { 8, 10, 12 }, { 14, 16, 18 } };
            int[,] result = Matrix.Divide(matrix, 2);
            
            Assert.AreEqual(1, result[0, 0]);
            Assert.AreEqual(2, result[0, 1]);
            Assert.AreEqual(3, result[0, 2]);
            Assert.AreEqual(4, result[1, 0]);
            Assert.AreEqual(5, result[1, 1]);
            Assert.AreEqual(6, result[1, 2]);
            Assert.AreEqual(7, result[2, 0]);
            Assert.AreEqual(8, result[2, 1]);
            Assert.AreEqual(9, result[2, 2]);
        }
    }
}
