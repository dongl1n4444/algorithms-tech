/*
 * @lc app=leetcode id=1338 lang=csharp
 *
 * [1338] Reduce Array Size to The Half
 */

// @lc code=start
using System;
using System.Diagnostics;
using System.Collections.Generic;

public partial class Solution {
    public int MinSetSize(int[] arr) {
        Dictionary<int, int> kk = new Dictionary<int, int>();
        int len = arr.Length;
        int halfLen = len / 2;
        for (int i = 0; i < len; ++i)
        {
            int v = arr[i];
            if (kk.ContainsKey(v) == false)
            {
                kk[v] = 0;
            }
            kk[v] += 1;
        }
        // sort
        var ll = new List<int>();
        foreach (var kv in kk)
        {
            ll.Add(kv.Value);
        }
        ll.Sort();

        int tt = 0;
        for (int i = ll.Count - 1; i >= 0; --i)
        {
            tt += ll[i];
            if (tt >= halfLen)
                return ll.Count - i;
        }
        return halfLen;
    }
}
// @lc code=end

