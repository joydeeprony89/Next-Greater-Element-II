using System;
using System.Collections.Generic;

namespace Next_Greater_Element_II
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = new int[] { 1, 2, 1 };
            var result = NextGreaterElements(nums);
            foreach (int num in result) Console.WriteLine(num);
        }

        static int[] NextGreaterElements(int[] nums)
        {
            int length = nums.Length;
            int[] result = new int[length];
            Stack<int> stack = new Stack<int>();
            for (int i = length * 2 - 1; i >= 0; i--)
            {
                while (stack.Count > 0 && nums[stack.Peek()] <= nums[i % length])
                    stack.Pop();
                result[i % length] = stack.Count == 0 ? -1 : nums[stack.Peek()];
                stack.Push(i % length);
            }
            return result;
        }
    }
}
