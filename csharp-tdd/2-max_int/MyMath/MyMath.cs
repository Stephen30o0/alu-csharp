﻿using System;
using System.Collections.Generic;

namespace MyMath
{
    public class Operations
    {
        /// <summary>
        /// Returns the maximum integer in a list of integers.
        /// </summary>
        /// <param name="nums">The list of integers to find the maximum from.</param>
        /// <returns>The maximum integer in the list, or 0 if the list is empty.</returns>
        public static int Max(List<int> nums)
        {
            if (nums == null || nums.Count == 0)
            {
                return 0;
            }

            int max = nums[0];

            foreach (int num in nums)
            {
                if (num > max)
                {
                    max = num;
                }
            }

            return max;
        }
    }
}
