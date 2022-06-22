/*
 * @lc app=leetcode id=1 lang=csharp
 *
 * [1] Two Sum
 */

// @lc code=start
using System;
using System.Collections.Generic;
public partial class Solution {
    public int[] TwoSum(int[] nums, int target) {
        // Time: O(n^2) Space: O(1)
        // int[] ret = new int[2];
        // for (int i = 0; i < nums.Length - 1; i++)
        // {
        //     for (int j = i + 1; j < nums.Length; j++) 
        //     {
        //         if (nums[i] + nums[j] == target)
        //         {
        //             ret[0] = i;
        //             ret[1] = j;
        //             break;
        //         }
        //     }
        // }

        // Time: O(n) Space: O(n)
        Dictionary<int, int> idxs = new Dictionary<int, int>(); 
        for (int i = 0; i < nums.Length; i++)
        {
            int ext = target - nums[i];
            if (idxs.ContainsKey(ext))
                return new int[2]{idxs[ext], i};
            idxs[nums[i]] = i;
        }
        return null;
    }
}
// @lc code=end

