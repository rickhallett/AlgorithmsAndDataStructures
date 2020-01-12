using System;
using System.Linq;

namespace AlgorithmsAndDataStructures
{
    public class BinarySearch
    {
        public int ExecuteRecursive(int[] inputArray, int searchVal, int offset = 0)
        {
            int fulcrum = inputArray.Length / 2;
            int currentVal = inputArray[fulcrum];

            if (currentVal == searchVal)
            {
                return offset + fulcrum;
            }

            if (inputArray.Length == 1)
            {
                return -1;
            }

            if (searchVal > currentVal)
            {
                int[] right = new int[inputArray.Length / 2];
                Array.Copy(inputArray, fulcrum, right, 0, inputArray.Length / 2);
                return ExecuteRecursive(right, searchVal, offset + fulcrum);
            }
            
            int[] left = new int[inputArray.Length / 2];
            Array.Copy(inputArray, 0, left, 0, inputArray.Length / 2);
            return ExecuteRecursive(left, searchVal, offset);
        }

        public int ExecuteIterative(int[] inputArray, int searchVal, int offset = 0)
        {
            while (true)
            {
                int fulcrum = inputArray.Length / 2;
                int currentVal = inputArray[fulcrum];

                if (currentVal == searchVal)
                {
                    return offset + fulcrum;
                }

                if (inputArray.Length == 1)
                {
                    return -1;
                }

                if (searchVal > currentVal)
                {
                    int[] right = new int[inputArray.Length / 2];
                    Array.Copy(inputArray, fulcrum, right, 0, inputArray.Length / 2);
                    inputArray = right;
                    offset = offset + fulcrum;
                    continue;
                }

                int[] left = new int[inputArray.Length / 2];
                Array.Copy(inputArray, 0, left, 0, inputArray.Length / 2);
                inputArray = left;
            }
        }
    }
}