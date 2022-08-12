/*
 * @lc app=leetcode id=235 lang=csharp
 *
 * [235] Lowest Common Ancestor of a Binary Search Tree
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

public partial class Solution {
    public TreeNode LowestCommonAncestor2(TreeNode root, TreeNode p, TreeNode q) {
        var cur = root;
        while (cur != null)
        {
            if (p.val <= cur.val && q.val >= cur.val)
                return cur;
            if (p.val >= cur.val && q.val <= cur.val)
                return cur;
            if (p.val < cur.val && q.val < cur.val)
            {
                cur = cur.left;
            }
            if (p.val > cur.val && q.val > cur.val)
            {
                cur = cur.right;
            }
        }
        return root;
    }
}
// @lc code=end

