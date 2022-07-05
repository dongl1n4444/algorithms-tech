/*
 * @lc app=leetcode id=128 lang=csharp
 *
 * [128] Longest Consecutive Sequence
 */

// @lc code=start
using System.Collections.Generic;

public partial class Solution {
    public int LongestConsecutive(int[] nums) {
        HashSet<int> vals = new HashSet<int>();
        for (int i = 0; i < nums.Length; ++i)
        {
            vals.Add(nums[i]);
        }

        int maxCount = 0;
        foreach (var val in vals)
        {
            if (vals.Contains(val - 1))
                continue;

            int count = 0;
            int nval = val;
            while (vals.Contains(nval))
            {
                count += 1;
                nval += 1;
                if (count > maxCount)
                {
                    maxCount = count;
                }
            }
        }
        return maxCount;
    }
}
// @lc code=end

