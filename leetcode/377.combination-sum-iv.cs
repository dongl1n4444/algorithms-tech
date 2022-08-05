/*
 * @lc app=leetcode id=377 lang=csharp
 *
 * [377] Combination Sum IV
 */

// @lc code=start
using System.Collections.Generic;

public partial class Solution {

    // public int CombinationSum4(int[] nums, int target) {
    //     Dictionary<int, int> rr = new Dictionary<int, int>();
    //     int count = KK(nums, target, 0, rr);
    //     return count;
    // }

    // int KK(int[] nums, int t, int n, Dictionary<int, int> rr)
    // {
    //     t -= n;
    //     if (t < 0)
    //         return 0;
    //     if (t == 0)
    //         return 1;

    //     if (rr.ContainsKey(t))
    //         return rr[t];

    //     int c = 0;
    //     for (int i = 0; i < nums.Length; ++i)
    //     {
    //         var k = nums[i];
    //         c += KK(nums, t, k, rr);
    //     }
    //     rr[t] = c;
    //     return c;
    // }

    // dp
    public int CombinationSum4(int[] nums, int target) {
        int[] dp = new int[target + 1];
        dp[0] = 1;
        for (int i = 1; i <= target; ++i)
        {
            for (int j = 0; j < nums.Length; ++j)
            {
                int num = nums[j];
                if (num <= i)
                    dp[i] += dp[i - num];
            }
        }
        return dp[target];
    }
}
// @lc code=end

