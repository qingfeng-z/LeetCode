using LeetCode;
using NUnit.Framework;

namespace Tests
{
    using System.Text;

    public class LeetCodeTests
    {
        /// <summary>
        /// The leet code test 1.
        /// </summary>
        [Test]
        public void LeetCodeTest1()
        {
            var l1 = new LeetCode001();
            l1.test();
        }

        /// <summary>
        /// The leet code test 2.
        /// </summary>
        [Test]
        public void LeetCodeTest2()
        {
            var l2 = new LeetCode002();
            var node1 = new ListNode(8) { next = new ListNode(9) { next = new ListNode(2) } };
            var node2 = new ListNode(3) { next = new ListNode(2) { next = new ListNode(1) } };
            var node = l2.AddTwoNumbers(node1, node2);
            
            // 421
            var sb = new StringBuilder();
            while (true)
            {
                if (node == null)
                {
                    break;
                }

                sb.Append(node.val.ToString());
                node = node.next;
            }

            var ee = sb.ToString();
            Assert.IsTrue(node != null);
        }
    }
}