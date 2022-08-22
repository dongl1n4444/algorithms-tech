/*
 * @lc app=leetcode id=871 lang=csharp
 *
 * [871] Minimum Number of Refueling Stops
 */

// @lc code=start
using System;
using System.Collections.Generic;

public partial class Solution {
    // Time limit 
    // public int MinRefuelStops(int target, int startFuel, int[][] stations) 
    // {
    //     return KK(target, stations, 0, 0, startFuel, 0);
    // }
    
    // int KK(int target, int[][] stations, int nextStationIdx, int curDist, long curFuel, int count)
    // {
    //     if (nextStationIdx >= stations.Length)
    //     {
    //         if (curDist + curFuel >= target)
    //             return count;
    //         else
    //             return -1;
    //     }

    //     int off = stations[nextStationIdx][0] - curDist;
    //     if (curFuel < off)
    //         return -1;

    //     int k1 = KK(target, stations, nextStationIdx + 1, stations[nextStationIdx][0], curFuel + stations[nextStationIdx][1] - off, count + 1);
    //     if (k1 == -1)
    //         return -1;

    //     int k2 = KK(target, stations, nextStationIdx + 1, stations[nextStationIdx][0], curFuel - off, count);
    //     if (k1 >= 0 && k2 >= 0)
    //         return Math.Min(k1, k2);
    //     else if (k1 >= 0)
    //         return k1;
    //     else if (k2 >= 0)
    //         return k2;
    //     else
    //         return -1;
    // }

    // // dp
    // public int MinRefuelStops(int target, int startFuel, int[][] stations) 
    // {
    //     // 加油 i 次最大行驶距离
    //     int n = stations.Length;
    //     var dp = new long[n + 1];
    //     dp[0] = startFuel;
    //     for (int i = 0; i < n; ++i)
    //     {
    //         for (int j = i; j >= 0; j--)
    //         {
    //             if (dp[j] >= stations[i][0])
    //             {
    //                 dp[j + 1] = Math.Max(dp[j + 1], dp[j] + stations[i][1]);
    //             }
    //         }
    //     }

    //     for (int i = 0; i <= n; ++i)
    //         if (dp[i] >= target)
    //             return i;
    //     return -1;
    // }

    // 贪心，要到达某个位置，优先选择加最多的油
    public int MinRefuelStops(int target, int startFuel, int[][] stations) 
    {
        int n = stations.Length;
        int fuel = startFuel;
        List<int> ss = new List<int>();
        int dist = 0;
        int addFuelCount = 0;
        for (int i = 0; i <= n; ++i)
        {
            int nextDist = i < n ? stations[i][0] : target;
            fuel -= nextDist - dist;
            while (fuel < 0 && ss.Count > 0)
            {
                fuel += ss[ss.Count - 1];
                ss.RemoveAt(ss.Count - 1);
                addFuelCount += 1;
            }
            if (fuel < 0)
            {
                return -1;
            }
            dist = nextDist;
            if (i < n)
            {
                ss.Add(stations[i][1]);
                ss.Sort();
            }
        }
        return addFuelCount;
    }
}
// @lc code=end

