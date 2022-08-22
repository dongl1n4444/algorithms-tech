/*
 * @lc app=leetcode id=342 lang=csharp
 *
 * [342] Power of Four
 */

// @lc code=start
using System;

public partial class Solution {
    public bool IsPowerOfFour(int n) {
        // if (n <= 0)
        //     return false;

        // while (n > 1)
        // {
        //     if ((n & 3) != 0 )
        //         return false;
        //     n = n >> 2;
        // }
        // return true;
        return n > 0 && (n & (n - 1)) == 0 && (n & 0xaaaaaaaa) == 0;
    }
}
// @lc code=end

