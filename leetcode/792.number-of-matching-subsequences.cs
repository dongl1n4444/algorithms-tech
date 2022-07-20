/*
 * @lc app=leetcode id=792 lang=csharp
 *
 * [792] Number of Matching Subsequences
 */

// @lc code=start
using System.Collections.Generic;

public partial class Solution {
    // force
    // public int NumMatchingSubseq(string s, string[] words) {
    //     HashSet<char> ww = new HashSet<char>();
    //     for (int i = 0; i < s.Length; ++i)
    //         ww.Add(s[i]);

    //     int count = 0;
    //     for (int m = 0; m < words.Length; ++m)
    //     {
    //         var kk = words[m];
    //         if (kk.Length > s.Length)
    //             continue;
            
    //         int j = 0;
    //         int i = 0;
    //         int findCount = 0;
    //         for (; i < kk.Length; ++i)
    //         {
    //             var k = kk[i];
    //             if (ww.Contains(k) == false)
    //                 break;
                
    //             for (; j < s.Length; ++j)
    //             {
    //                 if (k == s[j])
    //                 {
    //                     j += 1;
    //                     findCount += 1;
    //                     break;
    //                 }
    //             }
    //         }

    //         if (kk.Length == findCount)
    //         {
    //             count += 1;
    //         }
    //     }
    //     return count;
    // }

    public int NumMatchingSubseq(string s, string[] words) {
        Dictionary<char,  List<KeyValuePair<int, int>>> kkk = new Dictionary<char, List<KeyValuePair<int, int>>>();
        for (int i = 0; i < words.Length; ++i)
        {
            AddBucket(kkk, words[i][0], new KeyValuePair<int, int>(i, 0));
        }

        int count = 0;
        for (int i = 0; i < s.Length; ++i)
        {
            var k = s[i];
            List<KeyValuePair<int, int>> ss;
            if (kkk.TryGetValue(k, out ss))
            {
                for (int j = ss.Count - 1; j >= 0; --j)
                {
                    var kv = ss[j];
                    if (kv.Value + 1 >= words[kv.Key].Length)
                    {
                        count += 1;
                        ss.RemoveAt(j);
                    }
                    else
                    {
                        ss.RemoveAt(j);
                        AddBucket(kkk, words[kv.Key][kv.Value + 1], new KeyValuePair<int, int>(kv.Key, kv.Value + 1));
                    }
                }
            }
        }

        return count;
    }

    private void AddBucket(Dictionary<char,  List<KeyValuePair<int, int>>> kkk, char fc, KeyValuePair<int, int> kv)
    {
        List<KeyValuePair<int, int>> ss;
        if (kkk.TryGetValue(fc, out ss) == false)
        {
            ss = new List<KeyValuePair<int, int>>();
            kkk[fc] = ss;
        }   
        ss.Add(kv);
    }
}
// @lc code=end

