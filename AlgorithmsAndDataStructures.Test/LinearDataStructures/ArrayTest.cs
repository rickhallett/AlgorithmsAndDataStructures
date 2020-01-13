using System.Drawing;
using Xunit;
using AlgorithmsAndDataStructures.LinearDataStructures;

namespace AlgorithmsAndDataStructures.Test.LinearDataStructures
{
    public class ArrayTest
    {
        private readonly Arrays _arrays;
        
        public ArrayTest()
        {
            _arrays = new Arrays();
        }
        
        [Theory]
        [InlineData(new []{1, 2, 3}, 1)]
        [InlineData(new []{1, 2, 3, 4, 5}, 1)]
        [InlineData(new []{10, 100, 3, 1}, 1)]
        [InlineData(new []{2, 6, 4, 1, 100}, 1)]
        public void FindMinArrayTest(int[] testValue, int expectedValue)
        {
            Assert.Equal(expectedValue, _arrays.GetMin(testValue));
        }

        [Theory]
        [InlineData(new []{1, 2, 3, 4, 5}, false)]
        [InlineData(new []{1, 2, 2, 4, 5}, true)]
        [InlineData(new []{5, 5, 5, 5, 5}, true)]
        public void HasDuplicatesTest(int[] testValues, bool expectedValue)
        {
            Assert.Equal(expectedValue, _arrays.HasDuplicates(testValues));
        }
    }
}