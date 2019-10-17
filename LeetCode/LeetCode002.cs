#region license

// <copyright company="ZAN LLC" file="LeetCode002.cs">
//   Copyright (c)2019 ZAN ALL RIGHTS RESERVED.
// </copyright>

#endregion

namespace LeetCode
{
    /// <summary>
    ///     第二题俩数相加
    /// </summary>
    public class LeetCode002
    {
        /*
         *给出两个 非空 的链表用来表示两个非负的整数。其中，它们各自的位数是按照 逆序 的方式存储的，并且它们的每个节点只能存储 一位 数字。
          如果，我们将这两个数相加起来，则会返回一个新的链表来表示它们的和。
          您可以假设除了数字 0 之外，这两个数都不会以 0 开头。
         */
        /**
          * Definition for singly-linked list.
          * public class ListNode {
          *     public int val;
          *     public ListNode next;
          *     public ListNode(int x) { val = x; }
          * }
          */

        /// <summary>
        /// The add two numbers.
        /// </summary>
        /// <param name="l1">
        /// The l 1.
        /// </param>
        /// <param name="l2">
        /// The l 2.
        /// </param>
        /// <returns>
        /// The <see cref="ListNode"/>.
        /// </returns>
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            var node1 = new ListNode(0);
            var num = 0;
            var i = true;
            while (l1 != null || l2 != null)
            {
                var n = l1?.val ?? 0;
                var d = l2?.val ?? 0;
                var sum = n + d + num;
                num = sum / 10;
                sum = sum % 10;
                node1 = i ? new ListNode(sum) : new ListNode(sum) { next = node1 };
                i = false;
                l1 = l1?.next;
                l2 = l2?.next;
            }

            return node1;
            //var pre = new ListNode(0);
            //var cur = pre;          // ？？？
            //var carry = 0;
            //while (l1 != null || l2 != null)
            //{
            //    var x = l1?.val ?? 0;
            //    var y = l2?.val ?? 0;
            //    var sum = x + y + carry;

            //    carry = sum / 10;
            //    sum = sum % 10;


            //    cur.next = new ListNode(sum); // 看不懂
            //    cur = cur.next;

            //    l1 = l1?.next;
            //    l2 = l2?.next;
            //}

            //if (carry == 1)
            //{
            //    cur.next = new ListNode(carry);
            //}

            //return pre.next;
            return null;
        }
    }

    /// <summary>
    /// The list node.
    /// </summary>
    public class ListNode
    {
        /// <summary>
        /// The next.
        /// </summary>
        public ListNode next;

        /// <summary>
        /// The val.
        /// </summary>
        public int val;

        /// <summary>
        /// Initializes a new instance of the <see cref="ListNode"/> class.
        /// </summary>
        /// <param name="x">
        /// The x.
        /// </param>
        public ListNode(int x)
        {
            this.val = x;
        }
    }
}