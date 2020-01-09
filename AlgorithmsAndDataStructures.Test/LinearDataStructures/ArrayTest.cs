using Xunit;
using AlgorithmsAndDataStructures.LinearDataStructures;

namespace AlgorithmsAndDataStructures.Test.LinearDataStructures
{
    public class ArrayTest
    {
        [Fact]
        public void ReturnNumReturnsNum()
        {
            var arrays = new Arrays();

            Assert.Equal(3, arrays.ReturnNum(3));
        }
    }
}