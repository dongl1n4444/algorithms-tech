/*
 * @lc app=leetcode id=383 lang=csharp
 *
 * [383] Ransom Note
 */

// @lc code=start
using System.Collections.Generic;

public partial class Solution {
    // O: rm
    // S: m
    public bool CanConstruct(string ransomNote, string magazine) {
        int rlen = ransomNote.Length;
        int mlen = magazine.Length;

        if (rlen > mlen)
            return false;

        int[] kk = new int[26];
        for (int i = 0; i < mlen; ++i)
        {
            var c = magazine[i];
            kk[c - 'a'] += 1;
        }
        for (int i = 0; i < rlen; ++i)
        {
            var c = ransomNote[i];
            var idx = c - 'a';
            kk[idx] -= 1;
            if (kk[idx] < 0)
                return false;
        }
        return true;
    }
}
// @lc code=end

