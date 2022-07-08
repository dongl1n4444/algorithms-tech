/*
 * @lc app=leetcode id=63 lang=csharp
 *
 * [63] Unique Paths II
 */

// @lc code=start
public partial class Solution {
    // 动态规划
    // T - O(mn), S - O(m)
    public int UniquePathsWithObstacles(int[][] obstacleGrid) {
        int m = obstacleGrid.Length;
        int n = obstacleGrid[0].Length;
        
        // int[,] f = new int[m, n];
        // f[0, 0] = 1;
        // for (int i = 0; i < m; ++i)
        // {
        //     for (int j = 0; j < n; ++j)
        //     {
        //         if (obstacleGrid[i][j] == 1)
        //         {
        //             f[i, j] = 0;
        //             continue;
        //         }

        //         if (i > 0)
        //             f[i, j] += f[i - 1, j];
        //         if (j > 0)
        //             f[i, j] += f[i, j - 1];
        //     }
        // }
        // return f[m - 1, n - 1];

        // 滚动数组
        int[] f = new int[n];
        f[0] = obstacleGrid[0][0] == 1 ? 0 : 1;
        for (int i = 0; i < m; ++i)
        {
            for (int j = 0; j < n; ++j)
            {
                if (obstacleGrid[i][j] == 1)
                {
                    f[j] = 0;
                    continue;
                }

                if (j > 0 && obstacleGrid[i][j - 1] == 0)
                    f[j] += f[j - 1];
            }
        }
        return f[n - 1];
    }
}
// @lc code=end

