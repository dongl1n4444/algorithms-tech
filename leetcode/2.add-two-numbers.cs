/*
 * @lc app=leetcode id=2 lang=csharp
 *
 * [2] Add Two Numbers
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

 using System.Text;

 public class ListNode {
    public int val;
    public ListNode next;
    public ListNode(int val=0, ListNode next=null) {
        this.val = val;
        this.next = next;
    }
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        ListNode current = this;
        sb.Append("[");
        while (current != null)
        {
            sb.Append(current.val.ToString());
            if (current.next != null)
                sb.Append(",");
            current = current.next;
        }
        sb.Append("]");
        return sb.ToString();
    }
    public static ListNode Create(int[] values)
    {
        ListNode next = null;
        for (int i = values.Length - 1; i >= 0; --i)
        {
            var node = new ListNode(values[i], next);
            next = node;
        }
        return next;
    }
}

public partial class Solution {
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        return _AddTwoNumbers(l1, l2, 0);
    }

    private ListNode _AddTwoNumbers(ListNode l1, ListNode l2, int exVal)
    {
        ListNode ret = new ListNode(exVal);
        if (l1 != null)
        { 
            ret.val += l1.val;
            l1 = l1.next;
        }
        if (l2 != null)
        {
            ret.val += l2.val;
            l2 = l2.next;
        }
        int exVal2 = 0;
        if (ret.val >= 10)
        {
            exVal2 = ret.val / 10;
            ret.val = ret.val % 10;
        }
        if (l1 != null || l2 != null || exVal2 > 0)
            ret.next = _AddTwoNumbers(l1, l2, exVal2);
        else
            ret.next = null;
        return ret;
    }
}
// @lc code=end

