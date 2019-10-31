#region license

// <copyright company="ZAN LLC" file="重复数组.cs">
//   Copyright (c)2019 ZAN ALL RIGHTS RESERVED.
// </copyright>

#endregion

namespace LeetCode
{
    #region region

    using System.Collections.Generic;

    #endregion

    /// <summary>
    /// The 重复数组.
    /// </summary>
    public static class 重复数组
    {
        /// <summary>
        /// The contains duplicate.
        /// </summary>
        /// <param name="nums">
        /// The nums.
        /// </param>
        /// <returns>
        /// The <see cref="bool"/>.
        /// </returns>
        public static bool ContainsDuplicate(int[] nums)
        {
            /**
             * 给定一个整数数组，判断是否存在重复元素。
             * 如果任何值在数组中出现至少两次，函数返回 true。如果数组中每个元素都不相同，则返回 false。
             */
            var set = new HashSet<int>(nums);

            return set.Count != nums.Length;
        }
    }
}