using System;
using System.Collections.Generic;

namespace FirstProject
{
    internal class Program
    {
        static void Main()
        {
            List<int> arr = new List<int>{2, 7, 11, 15 };
            List<int> result = TwoSum(arr, 17);

            Console.WriteLine($"[{string.Join(",", result)}]");
        }
        public static List<int> TwoSum(List<int> nums, int target)
        {
            for (int i = 0; i < nums.Count; i++) {
                for (int j = i+1; j < nums.Count; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        return new List<int> { i, j };
                    }
                }
            }
            return new List<int>();
        }
    }
}
