/*
 * @lc app=leetcode id=98 lang=csharp
 *
 * [98] Validate Binary Search Tree
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
    // 1
    // public bool IsValidBST(TreeNode root) {
    //     var ss = new Queue<TreeNode>();
    //     ss.Enqueue(root);

    //     while (ss.Count > 0)
    //     {
    //         var cur = ss.Dequeue();
    //         if (cur.left != null)
    //         {
    //             if (!Check(cur.left, cur.val, true))
    //                 return false;
    //             ss.Enqueue(cur.left);
    //         }
    //         if (cur.right != null)
    //         {
    //             if (!Check(cur.right, cur.val, false))
    //                 return false;
    //             ss.Enqueue(cur.right);
    //         }
    //     }
    //     return true;
    // }

    // bool Check(TreeNode node, int val, bool isLeft)
    // {
    //     if (node == null)
    //         return true;
    //     if (isLeft && node.val >= val)
    //         return false;
    //     if (!isLeft && node.val <= val)
    //         return false;

    //     return Check(node.left, val, isLeft) && Check(node.right, val, isLeft);
    // }

    // 2
    // public bool IsValidBST(TreeNode root) {
    //     return Check(root, int.MinValue, int.MaxValue);
    // }
    // bool Check(TreeNode root, int lower, int upper)
    // {
    //     if (root == null)
    //         return true;
    //     if (root.val <= lower || root.val >= upper)
    //         return false;
    //     return Check(root.left, lower, root.val) && Check(root.right, root.val, upper);
    // }

    public bool IsValidBST(TreeNode root) {
        var ss = new Stack<TreeNode>();
        long inorder = (long)int.MinValue - 1;

        while (root != null || ss.Count != 0)
        {
            while (root != null)
            {
                ss.Push(root);
                root = root.left;
            }

            root = ss.Pop();
            if (root.val <= inorder)
                return false;

            inorder = root.val;
            root = root.right;
        }
        return true;
    }
}
// @lc code=end

