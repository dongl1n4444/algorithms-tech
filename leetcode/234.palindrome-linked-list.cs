/*
 * @lc app=leetcode id=234 lang=csharp
 *
 * [234] Palindrome Linked List
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
using System.Collections.Generic;

public partial class Solution {
    // t: n + n/2 = n
    // s: n
    // 双指针
    public bool IsPalindrome(ListNode head) {
        var ll = new List<int>();
        var p = head;
        while (p != null)
        {
            ll.Add(p.val);
            p = p.next;
        }

        for (int i = 0; i < ll.Count / 2; ++i)
        {
            if (ll[i] != ll[ll.Count - i - 1])
                return false;
        }
        return true;
    }
}
// @lc code=end

