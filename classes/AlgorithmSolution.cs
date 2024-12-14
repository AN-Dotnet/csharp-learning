using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace csharp.classes
{
    public class AlgorithmSolution
    {
        public int[] TwoSum(int[] nums, int target)  // sum of two numbers = Target
        {
            // bad efficiency with the time complexity of O(N^2)
            // for (int i = 0; i < nums.Length; i++) {
            //     for (int j = i + 1;  j < nums.Length; j++) {
            //         if (nums[i] + nums[j] == target)
            //         {
            //             return new int[] { i, j };
            //         }
            //     }
            // }
            // throw new ArgumentException("No Solution");

            // this is a much better solution with time complexity of O(N)
            Dictionary<int, int> dict = new();
            for (int i = 0; i < nums.Length; i++) {
                int complement = target - nums[i];
                if (dict.ContainsKey(complement))
                {
                    return new int[] { dict[complement], i};
                }
                if (!dict.ContainsKey(nums[i]))
                {
                    dict.Add(nums[i], i);
                }
            }
            throw new ArgumentException("No Solution");
        }
    }
}