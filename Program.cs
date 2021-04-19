using System;
using System.Collections.Generic;

namespace TwoSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 2, 3, 4 };
            int target = 6;
            int[] ans = new int[2];
            for(int i = 0; i < nums.Length; i++)
            {
                for(int j = i+1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        ans[0] = i;
                        ans[1] = j;
                    }
                }
            }
            Console.Write("[{0},{1}]",ans[0], ans[1]);
        }
    }
}
