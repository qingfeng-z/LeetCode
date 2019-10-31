
namespace LeetCode
{
    using System;

    /**
     *  判断一个整数是否是回文数。回文数是指正序（从左向右）和倒序（从右向左）读都是一样的整数。
     */

    public static class LeetCode009
    {
        public static bool IsPalindrome(int x)
        {
            string str = x.ToString();
            for (var i = 0; i < str.Length / 2; i++)
            {
                if (str[i] != str[str.Length-1-i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
