/*
 * @lc app=leetcode id=34 lang=csharp
 *
 * [34] Find First and Last Position of Element in Sorted Array
 */

// @lc code=start
public partial class Solution {
    public int[] SearchRange(int[] nums, int target) {
        if (nums.Length == 0)
            return new int[]{-1, -1};
        
        int leftIdx = _BinaryFind(nums, target, 0, nums.Length - 1, true);
        int rightIdx = _BinaryFind(nums, target, 0, nums.Length - 1, false) - 1;
        if (leftIdx >= 0 && leftIdx < nums.Length && rightIdx >= 0 && rightIdx < nums.Length && 
            nums[leftIdx] == target && nums[rightIdx] == target)
            return new int[]{leftIdx, rightIdx};
        return new int[]{-1, -1};
    }

    private int _BinaryFind(int[] nums, int target, int left, int right, bool lower)
    {
        int ret = nums.Length;
        while (left <= right)
        {
            var kk = (left + right) / 2;
            if (nums[kk] > target || (lower && nums[kk] >= target))
            {
                right = kk - 1;
                ret = kk;
            }
            else
            {
                left = kk + 1;
            }
        }
        return ret;
    }
}
// @lc code=end

