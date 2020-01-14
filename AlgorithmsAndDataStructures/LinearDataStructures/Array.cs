using System;
using System.Collections.Generic;

namespace AlgorithmsAndDataStructures.LinearDataStructures
{
    /**
     * Get the smallest integer in an array of integers
     * Runtime: O(n)
     * @param {Array} input; array of integers
     * @returns int or null
     * @example GetMin([3, 4, 5, 1]) => 1
     */
    public class Arrays
    {
        public int? GetMin(int[] input)
        {
            int? min = null;
            foreach (var element in input)
            {
                if (min == null || element < min)
                {
                    min = element;
                }
            }
            
            return min;
        }

        public int FindIndex(int[] input, int val)
        {
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == val) return i;
            }

            return -1;
        }

        /**
         * Finds out if an array has duplicates
         * Runtime: O(n)
         * Space Complexity: O(n) from auxiliary data structure
         */
        public bool HasDuplicates(int[] input)
        {
            var dupes = new Dictionary<int, bool>();
            foreach (var val in input)
            {
                if (dupes.ContainsKey(val))
                {
                    return true;
                }

                dupes[val] = true;
            }

            return false;
        }
    }
}