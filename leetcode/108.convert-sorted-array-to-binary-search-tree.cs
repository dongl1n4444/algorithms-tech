/*
 * @lc app=leetcode id=108 lang=csharp
 *
 * [108] Convert Sorted Array to Binary Search Tree
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
public partial class Solution {
    public TreeNode SortedArrayToBST(int[] nums) {
        var halfIdx = nums.Length / 2;
        var k = nums[halfIdx];
        var root = new TreeNode(k);

        KKK(root, nums, 0, halfIdx - 1, true);
        KKK(root, nums, halfIdx + 1, nums.Length - 1, false);

        return root;
    }

    void KKK(TreeNode root, int[] nums, int startIdx, int endIdx, bool left)
    {
        if (startIdx > endIdx || endIdx < startIdx || endIdx < 0 ||
            startIdx >= nums.Length)
            return;

        var cidx = (startIdx + endIdx) / 2;
        var val = nums[cidx];
        TreeNode node = new TreeNode(val);
        if (left)
        {
            root.left = node;
        }
        else
        {
            root.right = node;
        }

        KKK(node, nums, startIdx, cidx - 1, true);
        KKK(node, nums, cidx + 1, endIdx, false);
    }
}
// @lc code=end

