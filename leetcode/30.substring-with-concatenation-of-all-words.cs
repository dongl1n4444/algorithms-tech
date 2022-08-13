/*
 * @lc app=leetcode id=30 lang=csharp
 *
 * [30] Substring with Concatenation of All Words
 */

// @lc code=start
using System.Collections.Generic;

public partial class Solution {
    // public IList<int> FindSubstring(string s, string[] words) {
    //     int wlength = words[0].Length;
    //     int tlength = wlength * words.Length;
    //     if (s.Length < tlength)
    //         return new List<int>();

    //     var hh = new Dictionary<string, int>();
    //     for (int i = 0; i < words.Length; ++i)
    //     {
    //         var ss = words[i];
    //         MapSet(hh, ss, 1);
    //     }
    
    //     var ret = new List<int>();

    //     var hh2 = new Dictionary<string, int>();
    //     int mcount = 0;
    //     int startIdx = 0;
    //     for (int i = 0; i <= s.Length - wlength;)
    //     {
    //         if (mcount == 0 && i > s.Length - tlength)
    //             break;

    //         var ss = s.Substring(i, wlength);
    //         if (hh.ContainsKey(ss))
    //         {
    //             if (mcount == 0)
    //                 startIdx = i;

    //             i += wlength;
    //             mcount += 1;
    //             MapSet(hh2, ss, 1);

    //             // check match
    //             if (mcount == words.Length)
    //             {
    //                 bool match = true;
    //                 foreach (var k0 in hh)
    //                 {
    //                     if (hh2.ContainsKey(k0.Key) == false ||
    //                         hh2[k0.Key] != k0.Value)
    //                     {
    //                         match = false;
    //                         break;
    //                     }
    //                 }

    //                 if (match)
    //                     ret.Add(startIdx);

    //                 i = startIdx + 1;
    //                 mcount = 0;
    //                 hh2.Clear();
    //             }
    //         }
    //         else
    //         {
    //             if (mcount != 0)
    //                 i = startIdx;

    //             i += 1;
    //             mcount = 0;
    //             hh2.Clear();
    //         }
    //     }

    //     return ret;
    // }

    // void MapSet(Dictionary<string, int> hh, string k, int count)
    // {
    //     int had = 0;
    //     if (hh.TryGetValue(k, out had) == false)
    //     {
    //         had = 0;
    //     }
    //     hh[k] = had + count;
    // }

    // 滑动窗口
    public IList<int> FindSubstring(string s, string[] words) {
        int m = words.Length;
        int n = words[0].Length;
        int ls = s.Length;
        var res = new List<int>();

        for (int i = 0; i < n; ++i)
        {
            var diff = new Dictionary<string, int>();
            for (int j = 0; j < m; ++j)
            {
                var w = s.Substring(i + j * n, n);
                if (!diff.ContainsKey(w))
                    diff[w] = 0;
                diff[w] += 1;
            }
            for (int j = 0; j < m; ++j)
            {
                var w = words[j];
                if (!diff.ContainsKey(w))
                    diff[w] = 0;
                diff[w] -= 1;
                if (diff[w] == 0)
                    diff.Remove(w);
            }
            for (int start = i; start < ls - m * n + 1; start += n)
            {
                if (start != i)
                {
                    var w = s.Substring(start + (m - 1) * n, n);
                    if (!diff.ContainsKey(w))
                        diff[w] = 0;
                    diff[w] += 1;
                    if (diff[w] == 0)
                        diff.Remove(w);

                    w = s.Substring(start - n, n);
                    if (!diff.ContainsKey(w))
                        diff[w] = 0;
                    diff[w] -= 1;
                    if (diff[w] == 0)
                        diff.Remove(w);
                }
 
                if (diff.Count == 0)
                {
                    res.Add(start);
                }
            }
        }
        return res;
    }
}
// @lc code=end

