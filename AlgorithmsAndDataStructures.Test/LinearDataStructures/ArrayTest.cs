using System.Drawing;
using Xunit;
using AlgorithmsAndDataStructures.LinearDataStructures;

namespace AlgorithmsAndDataStructures.Test.LinearDataStructures
{
    public class ArrayTest
    {
        public Arrays arrays;
        public ArrayTest()
        {
            arrays = new Arrays();
        }
        
        [Fact]
        public void FindMinArrayTest()
        {
            Assert.Equal(1, arrays.FindMinArray(new []{1, 2, 3}));
            Assert.Equal(1, arrays.FindMinArray(new []{4, 6, 8, 1, 9, 2}));
        }

        [Theory]
        [InlineData(new []{1, 2, 3}, 1)]
        [InlineData(new []{1, 2, 3, 4, 5}, 1)]
        [InlineData(new []{10, 100, 3, 1}, 1)]
        [InlineData(new []{2, 6, 4, 1, 100}, 1)]
        public void FindMinArray2Test(int[] testValue, int expectedValue)
        {
            Assert.Equal(expectedValue, arrays.FindMinArray(testValue));
        }
    }
}