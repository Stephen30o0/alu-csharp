using System;
using MyMath;
using NUnit.Framework;

namespace MyMath.Tests
{
    [TestFixture]
    public class MatrixTests
    {
        [Test]
        public void Divide_ValidMatrixAndNonZeroNum_ReturnsDividedMatrix()
        {
            // Arrange
            int[,] matrix = { { 4, 8 }, { 12, 24 } };
            int num = 2;
            int[,] expected = { { 2, 4 }, { 6, 12 } };

            // Act
            int[,] result = Matrix.Divide(matrix, num);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Divide_NumIsZero_PrintsMessageAndReturnsNull()
        {
            // Arrange
            int[,] matrix = { { 4, 8 }, { 12, 24 } };
            int num = 0;

            // Act
            int[,] result = Matrix.Divide(matrix, num);

            // Assert
            Assert.IsNull(result);
        }

        [Test]
        public void Divide_NullMatrix_ReturnsNull()
        {
            // Arrange
            int[,] matrix = null;
            int num = 2;

            // Act
            int[,] result = Matrix.Divide(matrix, num);

            // Assert
            Assert.IsNull(result);
        }
    }
}
