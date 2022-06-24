/*
 * @lc app=leetcode id=3 lang=csharp
 *
 * [3] Longest Substring Without Repeating Characters
 */

// @lc code=start
using System.Collections.Generic;

public partial class Solution {
    public int LengthOfLongestSubstring(string s) {
        if (s == null || s.Length == 0)
            return 0;

        Dictionary<char, int> kk = new Dictionary<char, int>();
        int maxLengh = 0;
        int length = 0;
        for (int i = 0; i < s.Length; ++i)
        {
            char c = s[i];
            if (kk.ContainsKey(c))
            {
                length = 0;
                i = kk[c];
                kk.Clear();
            }
            else
            {
                length += 1;
                kk[c] = i;
            }
            if (length > maxLengh)
            {
                maxLengh = length;
            }
        }
        return maxLengh;
    }
}
// @lc code=end

