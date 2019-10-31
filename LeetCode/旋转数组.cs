#region license

// <copyright company="ZAN LLC" file="旋转数组.cs">
//   Copyright (c)2019 ZAN ALL RIGHTS RESERVED.
// </copyright>

#endregion

namespace LeetCode
{
    /// <summary>
    /// The 旋转数组.
    /// </summary>
    public static class 旋转数组
    {
        /// <summary>
        /// The rotate.
        /// </summary>
        /// <param name="nums">
        /// The nums.
        /// </param>
        /// <param name="k">
        /// The k.
        /// </param>
        public static void Rotate(int[] nums, int k)
        {
            /**
             * 给定一个数组，将数组中的元素向右移动 k 个位置，其中 k 是非负数。
             */


            for (var i = 0; i < k; i++)
            {
                var len = 0;
                for (var j = 0; j < nums.Length; j++)
                {
                    if (j == nums.Length - 1)
                    {
                        nums[0] = len;
                    }
                    else if (j == 0)
                    {
                        len = nums[j + 1];
                        nums[j + 1] = nums[j];
                    }
                    else
                    {
                        len = nums[j + 1];
                        nums[j + 1] = nums[j];
                    }
                }
            }
        }
    }
}