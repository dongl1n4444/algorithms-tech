/*
 * @lc app=leetcode id=871 lang=csharp
 *
 * [871] Minimum Number of Refueling Stops
 */

// @lc code=start
using System;
using System.Collections.Generic;

public partial class Solution {
    public int MinRefuelStops(int target, int startFuel, int[][] stations) 
    {
        return KK(target, stations, 0, 0, startFuel, 0);
    }
    
    int KK(int target, int[][] stations, int nextStationIdx, int curDist, int curFuel, int count)
    {
        if (nextStationIdx >= stations.Length)
        {
            if (curDist + curFuel >= target)
                return count;
            else
                return -1;
        }

        int off = stations[nextStationIdx][0] - curDist;
        if (curFuel < off)
            return -1;

        int k1 = KK(target, stations, nextStationIdx + 1, stations[nextStationIdx][0], curFuel + stations[nextStationIdx][1] - off, count + 1);
        if (k1 == -1)
            return -1;

        int k2 = KK(target, stations, nextStationIdx + 1, stations[nextStationIdx][0], curFuel - off, count);
        if (k1 >= 0 && k2 >= 0)
            return Math.Min(k1, k2);
        else if (k1 >= 0)
            return k1;
        else if (k2 >= 0)
            return k2;
        else
            return -1;
    }
}
// @lc code=end

