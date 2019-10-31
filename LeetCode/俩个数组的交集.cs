
#region license

// <copyright company="ZAN LLC" file="俩个数组的交集.cs">
//   Copyright (c)2019 ZAN ALL RIGHTS RESERVED.
// </copyright>

#endregion

namespace LeetCode
{
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The 俩个数组的交集.
    /// </summary>
    public static class 俩个数组的交集
    {
        public static int[] Intersect(int[] nums1, int[] nums2)
        {
            var arr = new HashSet<int>();
            var dict = nums2.ToDictionary(s => s, s => s);
            foreach (var i in nums1)
            {
                if (dict.ContainsKey(i))
                {
                    //if (arr)
                    //{

                    //}
                    //arr.Add(dict[i]);
                }
            }

            return new int[] { };
        }
    }
}