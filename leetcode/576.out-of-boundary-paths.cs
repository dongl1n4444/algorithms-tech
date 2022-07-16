/*
 * @lc app=leetcode id=576 lang=csharp
 *
 * [576] Out of Boundary Paths
 */

// @lc code=start
using System;

public partial class Solution {
    private static readonly int[][] fdir = new int[][]{
        new int[]{0, -1}, // up
        new int[]{0, 1}, // down
        new int[]{-1, 0}, // left
        new int[]{1, 0}, // right
    };

    private static readonly int modulo = (int)(Math.Pow(10, 9)) + 7;
    
    // dfs
    // public int FindPaths(int m, int n, int maxMove, int startRow, int startColumn) {
    //     // int modulo = (int)(Math.Pow(10, 9)) + 7;
    //     int[,,] moveCache = new int[m, n, maxMove + 1];
    //     for (int i = 0; i < m; ++i)
    //     {
    //         for (int j = 0; j < n; ++j)
    //         {
    //             for (int k = 0; k < maxMove + 1; ++k)
    //             {
    //                 moveCache[i, j, k] = -1;
    //             }
    //         }
    //     }
        
    //     return _FindPathsDfs(moveCache, m, n, maxMove, startRow, startColumn) % modulo;
    // }

    private int _FindPathsDfs(int[,,] moveCache, int m, int n, int move, int i, int j)
    {
        if (i < 0 || j < 0 || i >= m || j >= n)
            return 1;

        if (move == 0)
            return 0;

        if (i - move >= 0 && j - move >= 0 && i + move < m && j + move < n)
            return 0;

        if (moveCache[i, j, move] != -1)
            return moveCache[i, j, move];
        
        int total = 0;
        for (int k = 0; k < fdir.Length; ++k)
        {
            var dir = fdir[k];
            total = (total + _FindPathsDfs(moveCache, m, n, move - 1, i + dir[1], j + dir[0])) % modulo;
        }
    
        moveCache[i, j, move] = total;
        return total;
    }

    // dynamic
    public int FindPaths(int m, int n, int maxMove, int startRow, int startColumn) {
        int[,,] dp = new int[m, n, maxMove + 1];
        for (int k = 0; k < maxMove + 1; ++k)
        {
            for (int i = 0; i < m; ++i)
            {
                for (int j = 0; j < n; ++j)
                {
                    if (k == 0)
                    {
                        dp[i, j, k] = 0;
                        continue;
                    }

                    if (i > 0)
                        dp[i, j, k] = (dp[i, j, k] + dp[i - 1, j, k - 1]) % modulo;
                    else
                        dp[i, j, k] += 1;
                    if (j > 0)
                        dp[i, j, k] = (dp[i, j, k] + dp[i, j - 1, k - 1]) % modulo;
                    else
                        dp[i, j, k] += 1;
                    if (i < m - 1)
                        dp[i, j, k] = (dp[i, j, k] + dp[i + 1, j, k - 1]) % modulo;
                    else
                        dp[i, j, k] += 1;
                    if (j < n - 1)
                        dp[i, j, k] = (dp[i, j, k] + dp[i, j + 1, k - 1]) % modulo;
                    else
                        dp[i, j, k] += 1;
                }
            }
          
        }
    
        return dp[startRow, startColumn, maxMove];
    }
}
// @lc code=end

