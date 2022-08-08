/*
 * @lc app=leetcode id=300 lang=csharp
 *
 * [300] Longest Increasing Subsequence
 */

// @lc code=start
using System.Collections.Generic;

public partial class Solution {
    public int LengthOfLIS(int[] nums) {
        var dp = new int[nums.Length + 1];

        int tmax = 0;
        for (int i = nums.Length - 1; i >= 0; --i)
        {
            int max = 0;
            for (int j = i + 1; j < nums.Length; ++j)
            {
                if (nums[i] < nums[j] && dp[j] > max)
                {
                    max = dp[j];
                }
            }
            dp[i] = max + 1;

            if (dp[i] > tmax)
                tmax = dp[i];
        }

        return tmax;
    }
}
// @lc code=end

