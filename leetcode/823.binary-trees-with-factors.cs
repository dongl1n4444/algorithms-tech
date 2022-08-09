/*
 * @lc app=leetcode id=823 lang=csharp
 *
 * [823] Binary Trees With Factors
 */

// @lc code=start
using System;
using System.Collections.Generic;

public partial class Solution {
    private static int mod = (int)(MathF.Pow(10, 9)) + 7;

    public int NumFactoredBinaryTrees(int[] arr) {
        Dictionary<int, long> mm = new Dictionary<int, long>();
        var hh = new HashSet<int>();
        for (int i = 0; i < arr.Length; ++i)
        {
            hh.Add(arr[i]);
        }

        long count = 0;
        for (int i = 0; i < arr.Length; ++i)
        {
            count += KKK(arr, arr[i], mm, hh);
        }
        return (int)(count % mod);
    }

    long KKK(int[] arr, int v, Dictionary<int, long> mm, HashSet<int> hh)
    {
        if (mm.ContainsKey(v))
            return mm[v];
        if (hh.Contains(v) == false)
            return 0;

        long count = 0;
        for (int i = 0; i < arr.Length; ++i)
        {
            if (v == arr[i])
            {
                count += 1;
                continue;
            }

            if (v % arr[i] != 0)
                continue;
            
            int m = v / arr[i];
            if (mm.ContainsKey(arr[i]) == false)
                KKK(arr, arr[i], mm, hh);

            count += (KKK(arr, m, mm, hh) * mm[arr[i]]) % mod;
        }

        mm[v] = count % mod;
        return mm[v];
    }
}
// @lc code=end

