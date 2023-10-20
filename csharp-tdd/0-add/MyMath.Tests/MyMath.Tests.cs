using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyMath;

namespace MyMath.Tests
{
    [TestClass]
    public class OperationsTests
    {
        [TestMethod]
        public void TestAdd()
        {
            // Arrange
            int a = 2;
            int b = 3;

            // Act
            int result = Operations.Add(a, b);

            // Assert
            Assert.AreEqual(5, result);
        }
    }
}
