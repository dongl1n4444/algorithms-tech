/*
 * @lc app=leetcode id=659 lang=csharp
 *
 * [659] Split Array into Consecutive Subsequences
 */

// @lc code=start
using System.Collections.Generic;

public partial class Solution {
    // public bool IsPossible(int[] nums) {
    //     Dictionary<int, List<int>> kk = new Dictionary<int, List<int>>();
    //     for (int i = 0; i < nums.Length; ++i)
    //     {
    //         var k = nums[i];
    //         if (kk.ContainsKey(k) == false)
    //             kk[k] = new List<int>();
    //         if (kk.ContainsKey(k - 1))
    //         {
    //             var prevLen = kk[k - 1][0];
    //             kk[k - 1].RemoveAt(0);
    //             if (kk[k - 1].Count == 0)
    //                 kk.Remove(k - 1);
    //             kk[k].Add(prevLen + 1);
    //             kk[k].Sort();
    //         }
    //         else
    //         {
    //             kk[k].Add(1);
    //             kk[k].Sort();
    //         }
    //     }

    //     foreach (var kv in kk)
    //     {
    //         if (kv.Value[0] < 3)
    //             return false;
    //     }

    //     return true;
    // }

    // 贪心 greedy algorithm - 局部最优 - 3 个
    public bool IsPossible(int[] nums) {
        Dictionary<int, int> countMap = new Dictionary<int, int>();
        Dictionary<int, int> endMap = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; ++i)
        {
            var v = nums[i];
            if (countMap.ContainsKey(v) == false)
                countMap[v] = 0;
            countMap[v] += 1;
        }

        for (int i = 0; i < nums.Length; ++i)
        {
            int v = nums[i];
            int c = countMap[v];
            if (c == 0)
                continue;
            
            int pv = v - 1;
            if (endMap.ContainsKey(pv) && endMap[pv] > 0)
            {
                int pvc = endMap[pv];
                endMap[pv] = pvc - 1;
                if (endMap.ContainsKey(v) == false)
                    endMap[v] = 0;
                endMap[v] += 1;
                countMap[v] = c - 1;
            }
            else
            {
                int vc1 = 0;
                int vc2 = 0;
                countMap.TryGetValue(v + 1, out vc1);
                countMap.TryGetValue(v + 2, out vc2);
                if (vc1 > 0 && vc2 > 0)
                {
                    countMap[v + 1] = vc1 - 1;
                    countMap[v + 2] = vc2 - 1;
                    countMap[v] = c - 1;
                    if (endMap.ContainsKey(v + 2) == false)
                        endMap[v + 2] = 0;
                    endMap[v + 2] += 1;
                }
                else
                {
                    return false;
                }
            }
        }

        return true;
    }
}
// @lc code=end

