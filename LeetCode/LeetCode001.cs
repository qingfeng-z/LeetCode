#region license

// <copyright company="ZAN LLC" file="LeetCode001.cs">
//   Copyright (c)2019 ZAN ALL RIGHTS RESERVED.
// </copyright>

#endregion

namespace LeetCode
{
    #region region

    using System.Collections.Generic;

    #endregion

    /// <summary>
    ///     第一题俩数之和
    /// </summary>
    public class LeetCode001
    {
        /// <summary>
        ///     The test.
        /// </summary>
        public void test()
        {
            var nums = new int[] {9,8,7,6,5,8,2 };
            var target = 13;
            this.TwoSumSolveOne(nums, target);
            this.TwoSumSolveTwo(nums, target);
        }
        /*
         *给定一个整数数组 nums 和一个目标值 target，请你在该数组中找出和为目标值的那 两个 整数，并返回他们的数组下标。
         *你可以假设每种输入只会对应一个答案。但是，你不能重复利用这个数组中同样的元素。
         */

        /// <summary>
        ///     暴力解决方法
        /// </summary>
        /// <param name="nums">
        ///     The nums.
        /// </param>
        /// <param name="target">
        ///     The target.
        /// </param>
        /// <returns>
        ///     The <see cref="int[]" />.
        /// </returns>
        public int[] TwoSumSolveOne(int[] nums, int target)
        {
            for (var i = 0; i < nums.Length; i++)
            {
                var num = target - nums[i];
                for (var j = 1; j < nums.Length; j++)
                {
                    if (nums[j] == num && i != j)
                    {
                        return new[] { i, j };
                    }
                }
            }

            return null;
        }

        /// <summary>
        ///     一遍哈希表
        /// </summary>
        /// <param name="nums">
        ///     The nums.
        /// </param>
        /// <param name="target">
        ///     The target.
        /// </param>
        /// <returns>
        ///     The <see cref="int[]" />.
        /// </returns>
        public int[] TwoSumSolveTwo(int[] nums, int target)
        {
            var dict = new Dictionary<int, int>();
            for (var i = 0; i < nums.Length; i++)
            {
                if (dict.ContainsKey(target - nums[i]))
                    return new[] { dict[target - nums[i]], i };

                if (!dict.ContainsKey(nums[i]))
                    dict.Add(nums[i], i);
            }

            return null;
        }
    }
}