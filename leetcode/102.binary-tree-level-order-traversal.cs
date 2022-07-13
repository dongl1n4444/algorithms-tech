/*
 * @lc app=leetcode id=102 lang=csharp
 *
 * [102] Binary Tree Level Order Traversal
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
using System;
using System.Collections.Generic;

public partial class Solution {
    public IList<IList<int>> LevelOrder(TreeNode root) {
        var ret = new List<IList<int>>();
        if (root == null)
            return ret;

        var ff = new Queue<TreeNode>();
        ff.Enqueue(root);
        var ll = new Queue<int>();
        ll.Enqueue(0);

        while (ff.Count > 0)
        {
            var currrent = ff.Dequeue();
            var curLevel = ll.Dequeue();
            if (ret.Count <= curLevel)
                ret.Add(new List<int>());
            ret[curLevel].Add(currrent.val);

            if (currrent.left != null)
            {
                ff.Enqueue(currrent.left);
                ll.Enqueue(curLevel + 1);
            }
            if (currrent.right != null)
            {
                ff.Enqueue(currrent.right);
                ll.Enqueue(curLevel + 1);
            }
        }

        return ret;
    }
}
// @lc code=end

