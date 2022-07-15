/*
 * @lc app=leetcode id=695 lang=csharp
 *
 * [695] Max Area of Island
 */

// @lc code=start
using System;
using System.Collections.Generic;

public partial class Solution {
    // bfs or dfs
    public int MaxAreaOfIsland(int[][] grid) {
        int m = grid.Length;
        int n = grid[0].Length;
        var visited = new bool[m, n];

        int maxIslandCount = 0;
        
        var ff = new Stack<KeyValuePair<int, int>>();
        for (int i = 0; i < m; ++i)
        {
            for (int j = 0; j < n; ++j)
            {
                if (visited[i, j])
                    continue;
                if (grid[i][j] == 0)
                    continue;

                int islandCount = 0;
                ff.Push(new KeyValuePair<int, int>(i, j));
                visited[i, j] = true;

                while (ff.Count > 0)
                {
                    var kk = ff.Pop();
                    islandCount += 1;
                    int x = kk.Value;
                    int y = kk.Key;
                    
                    int upY = y - 1;
                    if (upY >= 0 && visited[upY, x] == false)
                    {
                        if (grid[upY][x] == 1)
                            ff.Push(new KeyValuePair<int, int>(upY, x));
                        visited[upY, x] = true;
                    }

                    int leftX = x - 1;
                    if (leftX >= 0 && visited[y, leftX] == false)
                    {
                        if (grid[y][leftX] == 1)
                            ff.Push(new KeyValuePair<int, int>(y, leftX));
                        visited[y, leftX] = true;
                    }

                    int rightX = x + 1;
                    if (rightX < n && visited[y, rightX] == false)
                    {
                        if (grid[y][rightX] == 1)
                            ff.Push(new KeyValuePair<int, int>(y, rightX));
                        visited[y, rightX] = true;
                    }

                    int downY = y + 1;
                    if (downY < m && visited[downY, x] == false)
                    {
                        if (grid[downY][x] == 1)
                            ff.Push(new KeyValuePair<int, int>(downY, x));
                        visited[downY, x] = true;
                    }
                }

                maxIslandCount = Math.Max(maxIslandCount, islandCount);
            }
        }

        return maxIslandCount;
    }
}
// @lc code=end

