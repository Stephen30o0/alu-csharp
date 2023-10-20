using System;
using System.Collections.Generic;
using MyMath;
using Xunit;

namespace MyMath.Tests
{
    public class MyMathTests
    {
        [Fact]
        public void Max_WithEmptyList_ReturnsZero()
        {
            List<int> emptyList = new List<int>();
            int max = Operations.Max(emptyList);
            Assert.Equal(0, max);
        }

        [Fact]
        public void Max_WithListOfIntegers_ReturnsMaxValue()
        {
            List<int> integers = new List<int> { 1, 3, 5, 2, 4 };
            int max = Operations.Max(integers);
            Assert.Equal(5, max);
        }

        [Fact]
        public void Max_WithNullList_ReturnsZero()
        {
            List<int> nullList = null;
            int max = Operations.Max(nullList);
            Assert.Equal(0, max);
        }
    }
}
