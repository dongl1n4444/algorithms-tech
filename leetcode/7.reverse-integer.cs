/*
 * @lc app=leetcode id=7 lang=csharp
 *
 * [7] Reverse Integer
 */

// @lc code=start
using System;

public partial class Solution {
    public int ReverseInteger(int x) {

        int ret = 0;
        while (x != 0)
        {
            int k1 = x % 10;
            x = x / 10;
            if (ret > int.MaxValue / 10 ||
                (ret == int.MaxValue / 10 && k1 > 7))
                return 0;
            if (ret < int.MinValue / 10 ||
                (ret == int.MinValue / 10 && k1 < -8))
                return 0;

            ret = ret * 10 + k1;
        }
        return ret;
    }
}
// @lc code=end

