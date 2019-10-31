
#region license

// <copyright company="ZAN LLC" file="只出现一次的数字.cs">
//   Copyright (c)2019 ZAN ALL RIGHTS RESERVED.
// </copyright>

#endregion

namespace LeetCode
{
    /// <summary>
    /// The 只出现一次的数字.
    /// </summary>
    public static class 只出现一次的数字
    {
        public static int SingleNumber(int[] nums)
        {
            var n = 0;
            foreach (var num in nums)
            {
                n ^= num;
            }

            return n;
        }
    }
}