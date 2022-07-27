/*
 * @lc app=leetcode id=114 lang=csharp
 *
 * [114] Flatten Binary Tree to Linked List
 */

// @lc code=start
/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
using System.Collections.Generic;

public partial class Solution {
    public void Flatten(TreeNode root) {
        if (root == null)
            return;
        
        var ss = new Stack<TreeNode>();
        ss.Push(root);
        var tmp = new TreeNode(-1);
        var pp = tmp;

        while (ss.Count > 0)
        {
            var cur = ss.Pop();
            pp.left = null;
            pp.right = cur;
            pp = cur;

            if (cur.right != null)
            {
                ss.Push(cur.right);
            }
            if (cur.left != null)
            {
                ss.Push(cur.left);
            }
        }
    }
}
// @lc code=end

