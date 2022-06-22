/*
 * @lc app=leetcode id=13 lang=csharp
 *
 * [13] Roman to Integer
 */

// @lc code=start
using System;
using System.Collections.Generic;

public partial class Solution {

    private static Dictionary<char, int> RomanToIntIdxs = new Dictionary<char, int>()
    {
        {'I', 1},
        {'V', 5},
        {'X', 10},
        {'L', 50},
        {'C', 100},
        {'D', 500},
        {'M', 1000}
    };

    public int RomanToInt(string s) {
        int ret = 0;
        for (int i = 0; i < s.Length; ++i)
        {
            var k = RomanToIntIdxs[s[i]];
            if (i < s.Length - 1)
            {
                var k2 = RomanToIntIdxs[s[i + 1]];
                if (k < k2)
                {
                    ret += k2 - k;
                    i += 1;
                    continue;
                }
            }

            ret += k;
        }

        return ret;
    }
}
// @lc code=end

