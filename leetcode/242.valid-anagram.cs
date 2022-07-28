/*
 * @lc app=leetcode id=242 lang=csharp
 *
 * [242] Valid Anagram
 */

// @lc code=start
using System.Collections.Generic;

public partial class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length)
            return false;

        Dictionary<char, int> kk2 = new Dictionary<char, int>();
        for (int i = 0; i < s.Length; ++i)
        {
            var ch = s[i];
            if (kk2.ContainsKey(ch) == false)
                kk2[ch] = 0;
            kk2[ch] += 1;
        }

        for (int i = 0; i < t.Length; ++i)
        {
            var ch = t[i];
            if (kk2.ContainsKey(ch) == false)
                return false;
            kk2[ch] -= 1;
            if (kk2[ch] < 0)
                return false;
        }
        return true;
    }
}
// @lc code=end

