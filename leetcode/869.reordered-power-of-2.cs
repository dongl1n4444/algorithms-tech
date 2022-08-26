/*
 * @lc app=leetcode id=869 lang=csharp
 *
 * [869] Reordered Power of 2
 */

// @lc code=start
using System;
using System.Collections.Generic;

public partial class Solution {
    public bool ReorderedPowerOf2(int n) {
        if (IsPowerOf2(n))
            return true;

        var ll = new List<int>();
        while (n > 0)
        {
            int k = n % 10;
            n = n / 10;
            ll.Add(k);
        }
        
        // 全排列
        bool[] visited = new bool[ll.Count];
        Array.Fill(visited, false);
        var ret = KK(0, ll, visited, 0);

        return ret;
    }

    private bool KK(int fillIdx, List<int> nums, bool[] visited, int total)
    {
        int len = nums.Count;
        if (fillIdx >= len)
        {
            Console.WriteLine("xx-- > " + total);
            return IsPowerOf2(total);
        }

        for (int i = 0; i < len; ++i)
        {
            if (visited[i])
                continue;

            var k = nums[i];
            if (fillIdx == 0 && (k == 0 || k % 2 != 0))
                continue;
            if (fillIdx == len - 1 && k == 0)
                continue;

            visited[i] = true;
            int v = (int)(Math.Pow(10, fillIdx)) * k;
            
            total += v;
            bool ret = KK(fillIdx + 1, nums, visited, total);
            if (ret == true)
                return true;

            total -= v;
            visited[i] = false;
        }

        return false;
    }

    private bool IsPowerOf2(int n)
    {
        // 2 ^ 30
        return n > 0 && 1073741824 % n == 0;
    }
}
// @lc code=end

