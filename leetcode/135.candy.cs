/*
 * @lc app=leetcode id=135 lang=csharp
 *
 * [135] Candy
 */

// @lc code=start
using System;

public partial class Solution {
    public int Candy(int[] ratings) {
        int[] vals = new int[ratings.Length];
        for (int i = 0; i < vals.Length; ++i)
        {
            if (vals[i] == 0)
                _Candy(ratings, ref vals, i, 1);
        }
        
        int total = 0;
        for (int i = 0; i < vals.Length; ++i)
            total += vals[i];
        return total;
    }

    public void _Candy(int[] ratings, ref int[] vals, int idx, int val)
    {
        if (idx < 0 || idx >= ratings.Length)
            return;

        vals[idx] = val;
        if (idx > 0 && ratings[idx - 1] > ratings[idx] && vals[idx - 1] <= vals[idx])
            _Candy(ratings, ref vals, idx - 1, val + 1);
        if (idx < ratings.Length - 1 && ratings[idx + 1] > ratings[idx] && vals[idx + 1] <= vals[idx])
            _Candy(ratings, ref vals, idx + 1, val + 1);
    }
}
// @lc code=end

