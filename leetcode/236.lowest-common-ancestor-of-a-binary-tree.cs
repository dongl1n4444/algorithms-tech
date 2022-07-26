/*
 * @lc app=leetcode id=236 lang=csharp
 *
 * [236] Lowest Common Ancestor of a Binary Tree
 */

// @lc code=start
/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
using System.Collections.Generic;

public partial class Solution {
    public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q) {
        var p1 = DFSParents(root, p);
        var p2 = DFSParents(root, q);
        for (int i = 0; i < p1.Count; ++i)
        {
            for (int j = 0; j < p2.Count; ++j)
            {
                if (p1[i] == p2[j])
                {
                    return p1[i];
                }
            }
        }
        return null;
    }

    private List<TreeNode> DFSParents(TreeNode root, TreeNode target)
    {
        var st = new Stack<TreeNode>();
        st.Push(root);
        Dictionary<TreeNode, TreeNode> kp = new Dictionary<TreeNode, TreeNode>();
        kp[root] = null;

        while (st.Count > 0)
        {
            var cur = st.Pop();
            if (cur == target)
            {
                break;
            }

            if (cur.left != null && kp.ContainsKey(cur.left) == false)
            {
                st.Push(cur.left);
                kp[cur.left] = cur;
            }
            if (cur.right != null && kp.ContainsKey(cur.right) == false)
            {
                st.Push(cur.right);
                kp[cur.right] = cur;
            }
        }

        var parents = new List<TreeNode>();
        parents.Add(target);
        var p = kp[target];
        while (p != null)
        {
            parents.Add(p);
            p = kp[p];
        }
        return parents;
    }
}
// @lc code=end

