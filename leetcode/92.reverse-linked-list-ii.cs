/*
 * @lc app=leetcode id=92 lang=csharp
 *
 * [92] Reverse Linked List II
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
    // public ListNode ReverseBetween(ListNode head, int left, int right) {
    //     var current = head;
    //     ListNode leftNode = null;
    //     var valStacks = new Stack<int>();

    //     var p = current;
    //     for (int pos = 1; pos <= right && p != null; ++pos)
    //     {
    //         if (pos == left)
    //             leftNode = p;

    //         if (pos >= left)
    //         {
    //             valStacks.Push(p.val);
    //         }

    //         p = p.next;
    //     }
        
    //     current = leftNode;
    //     while (valStacks.Count > 0 && current != null)
    //     {
    //         var vv = valStacks.Pop();
    //         current.val = vv;
    //         current = current.next;
    //     }

    //     return head;
    // }

    public ListNode ReverseBetween(ListNode head, int left, int right) {
        var dummyNode = new ListNode(-1);
        dummyNode.next = head;
        
        // current
        ListNode prev = dummyNode;
        for (int i = 0; i < left - 1; ++i)
            prev = prev.next;

        ListNode curr = prev.next;
        ListNode next = null;
        for (int i = 0; i < right - left; ++i)
        {
            next = curr.next;
            curr.next = next.next;
            next.next = prev.next;
            prev.next = next;
        }

        return dummyNode.next;
    }
}
// @lc code=end

