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

        /// <summary>
        /// The leet code test 7.
        /// </summary>
        [Test]
        [TestCase(123)]
        public void LeetCodeTest7(int x)
        {
           var rev = LeetCode007.Reverse(x);
           Assert.IsTrue(rev == 321);
        }

        /// <summary>
        /// The leet code test 9.
        /// </summary>
        [Test]
        [TestCase(123321)]
        public void LeetCodeTest9(int x)
        {
            var rev = LeetCode009.IsPalindrome(x);
            Assert.IsTrue(rev);
        }

        [Test]
        public void ��ת����Test()
        {
            var arr = new[] { 1, 5, 8, 3 };
            var k = 2;
            ��ת����.Rotate(arr, k);
            Assert.Pass();
        }

        [Test]
        public void �ظ�����Test()
        {
            var arr = new[] { 1, 5, 8, 3 };
            var duplicate = �ظ�����.ContainsDuplicate(arr);
            Assert.IsFalse(duplicate);
            arr = new[] { 1, 1, 2, 3 };
            duplicate = �ظ�����.ContainsDuplicate(arr);
            Assert.IsTrue(duplicate);
        }

        [Test]
        public void ֻ����һ�ε�����Test()
        {
            var arr = new[] { 1, 1, 2, 8, 8 };
            var duplicate = ֻ����һ�ε�����.SingleNumber(arr);
            Assert.IsTrue(duplicate==2);
        }

        [Test]
        public void test()
        {
            var s = 1 ^ 1;
            var e = 2 ^ 1;
            var ss = 10 ^ 2;
            var w = 3 ^ 6;
            var ee = 1;
        }
    }
}