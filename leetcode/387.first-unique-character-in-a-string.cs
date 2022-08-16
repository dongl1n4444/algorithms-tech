/*
 * @lc app=leetcode id=387 lang=csharp
 *
 * [387] First Unique Character in a String
 */

// @lc code=start
using System.Collections.Generic;

public partial class Solution {
    public int FirstUniqChar(string s) {
        Dictionary<char, int> kk = new Dictionary<char, int>();
        int len = s.Length;
        for (int i = 0; i < len; ++i)
        {
            var c = s[i];
            if (kk.ContainsKey(c) == false)
            {
                kk[c] = 0;
            }
            kk[c] += 1;
        }

        var ret = -1;
        for (int i = 0; i < len; ++i)
        {
            if (kk[s[i]] == 1)
            {
                ret = i;
                break;
            }
        }
        return ret;
    }
}
// @lc code=end

