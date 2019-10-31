using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    /**
     *  给出一个 32 位的有符号整数，你需要将这个整数中每位上的数字进行反转。
     */
    public static class LeetCode007
    {

        public static int Reverse(int x)
        {
            /**
             * 题解
             * 1.循环 输入值，
             * 2.获取整数x 的最后一位数字
             * 3.判断边界值   不能超出int 值的最大范围 最新范围
             * 4.将自定义的变量 * 10 + 获取出的最后一个数字。
             *
             */

            int rev = 0;
            while (x!=0)
            {
                int pop = x % 10; // 末尾数字
                x /= 10; // 去掉末尾的数字
                if (rev > int.MaxValue / 10 || (rev == int.MaxValue && pop > 7)) return 0;
                if (rev < int.MinValue / 10 || (rev == int.MinValue && pop < -8)) return 0;
                rev = rev * 10 + pop;
            }

            return rev;
        }
    }
}
