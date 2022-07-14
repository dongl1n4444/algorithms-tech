/*
 * @lc app=leetcode id=105 lang=csharp
 *
 * [105] Construct Binary Tree from Preorder and Inorder Traversal
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
    public TreeNode BuildTree(int[] preorder, int[] inorder) {
        if (preorder.Length == 0 || inorder.Length == 0)
            return null;
        

        Dictionary<int, int> pIdxs = new Dictionary<int, int>();
        Dictionary<int, int> iIdxs = new Dictionary<int, int>();
        for (int i = 0; i < preorder.Length; ++i)
            pIdxs[preorder[i]] = i;
        for (int i = 0; i < inorder.Length; ++i)
            iIdxs[inorder[i]] = i;

        int rootVal = preorder[0];
        var root = new TreeNode();
        root.val = rootVal;
        KK(preorder, inorder, rootVal, pIdxs, iIdxs, root, 0, inorder.Length);

        return root;
    }

    private void KK(int[] preorder, int[] inorder, int curVal, 
        Dictionary<int, int> pIdxs, Dictionary<int, int> iIdxs, TreeNode curNode, int iLEdgeIdx, int iREdgeIdx)
    {
        int iCurIdx = iIdxs[curVal];
        int pCurIdx = pIdxs[curVal];

        if (pCurIdx + 1 < preorder.Length)
        {
            int nextVal = preorder[pCurIdx + 1];
            // left root
            if (iIdxs[nextVal] < iCurIdx)
            {
                var leftNode = new TreeNode(nextVal);
                curNode.left = leftNode;
                KK(preorder, inorder, nextVal, pIdxs, iIdxs, leftNode, iLEdgeIdx, iCurIdx + 1);
            }
        }

        // right root
        int leftLength = iCurIdx - iLEdgeIdx;
        if (pCurIdx + leftLength + 1 < preorder.Length)
        {
            int rightVal = preorder[pCurIdx + leftLength + 1];
            if (iIdxs[rightVal] > iCurIdx && iIdxs[rightVal] < iREdgeIdx)
            {
                var rightNode = new TreeNode(rightVal);
                curNode.right = rightNode;
                KK(preorder, inorder, rightVal, pIdxs, iIdxs, rightNode, iCurIdx + 1, iREdgeIdx);
            }
        }
    }
}
// @lc code=end

