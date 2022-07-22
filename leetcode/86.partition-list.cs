/*
 * @lc app=leetcode id=86 lang=csharp
 *
 * [86] Partition List
 */

// @lc code=start
/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public partial class Solution {
    public ListNode Partition(ListNode head, int x) {
        var small = new ListNode(0);
        var big = new ListNode(0);

        var smallP = small;
        var bigP = big;

        var cur = head;
        while (cur != null)
        {
            var curNext = cur.next;

            if (cur.val < x)
            {
                smallP.next = cur;
                smallP = cur;
                cur.next = null;
            }
            else
            {
                bigP.next = cur;
                bigP = cur;
                cur.next = null;
            }

            cur = curNext;
        }

        smallP.next = big.next;
        return small.next;
    }
}
// @lc code=end

