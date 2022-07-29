/*
 * @lc app=leetcode id=890 lang=csharp
 *
 * [890] Find and Replace Pattern
 */

// @lc code=start
using System.Collections.Generic;

public partial class Solution {
    public IList<string> FindAndReplacePattern(string[] words, string pattern) {
        
        var ret = new List<string>();
        var kk = new Dictionary<char, char>();
        var kk2 = new Dictionary<char, char>();
        for (int i = 0; i < words.Length; ++i)
        {
            var w = words[i];
            if (w.Length != pattern.Length)
                continue;
            kk.Clear();
            kk2.Clear();

            int j = 0;
            for (; j < pattern.Length; ++j)
            {
                var wc = w[j];
                var pc = pattern[j];

                char rr;
                if (kk.TryGetValue(pc, out rr))
                {
                    if (rr != wc)
                        break;
                }
                else if (kk2.TryGetValue(wc, out rr))
                {
                    if (rr != pc)
                        break;
                }
                else
                {
                    kk[pc] = wc;
                    kk2[wc] = pc;
                }
            }
            if (j == pattern.Length)
            {
                ret.Add(w);
            }
        }
        return ret;
    }
}
// @lc code=end

