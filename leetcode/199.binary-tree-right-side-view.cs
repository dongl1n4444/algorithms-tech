/*
 * @lc app=leetcode id=199 lang=csharp
 *
 * [199] Binary Tree Right Side View
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

 public class TreeNode {
      public int val;
      public TreeNode left;
      public TreeNode right;
      public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
          this.val = val;
          this.left = left;
          this.right = right;
      }
  }

public partial class Solution {
    // bfs
    // public IList<int> RightSideView(TreeNode root) {

    //     var ff = new Queue<TreeNode>();
    //     ff.Enqueue(root);
    //     var depthQueue = new Queue<int>();
    //     depthQueue.Enqueue(0);
    //     Dictionary<int, int> depthRightVals = new Dictionary<int, int>();

    //     int maxLevel = -1;

    //     while (ff.Count > 0)
    //     {
    //         TreeNode current = ff.Dequeue();
    //         int d = depthQueue.Dequeue();

    //         if (current != null)
    //         {
    //             maxLevel = Math.Max(maxLevel, d);
    //             depthRightVals[d] = current.val;

    //             if (current.left != null)
    //             {
    //                 ff.Enqueue(current.left);
    //                 depthQueue.Enqueue(d + 1);
    //             }

    //             if (current.right != null)
    //             {
    //                 ff.Enqueue(current.right);
    //                 depthQueue.Enqueue(d + 1);
    //             }
    //         }

    //     }

    //     // find every level right node
    //     List<int> vals = new List<int>();
    //     for (int i = 0; i <= maxLevel; ++i)
    //     {
    //         vals.Add(depthRightVals[i]);
    //     }

    //     return vals;
    // }

    // dfs
    public IList<int> RightSideView(TreeNode root) {

        var ff = new Stack<TreeNode>();
        ff.Push(root);
        var depthStack = new Stack<int>();
        depthStack.Push(0);
        Dictionary<int, int> depthRightVals = new Dictionary<int, int>();

        int maxLevel = -1;

        while (ff.Count > 0)
        {
            TreeNode current = ff.Pop();
            int d = depthStack.Pop();

            if (current != null)
            {
                maxLevel = Math.Max(maxLevel, d);
                if (depthRightVals.ContainsKey(d) == false)
                    depthRightVals[d] = current.val;

                if (current.left != null)
                {
                    ff.Push(current.left);
                    depthStack.Push(d + 1);
                }

                if (current.right != null)
                {
                    ff.Push(current.right);
                    depthStack.Push(d + 1);
                }
            }

        }

        // find every level right node
        List<int> vals = new List<int>();
        for (int i = 0; i <= maxLevel; ++i)
        {
            vals.Add(depthRightVals[i]);
        }

        return vals;
    }
}
// @lc code=end

