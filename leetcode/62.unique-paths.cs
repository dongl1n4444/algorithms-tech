/*
 * @lc app=leetcode id=62 lang=csharp
 *
 * [62] Unique Paths
 */

// @lc code=start
using System.Collections.Generic;

public partial class Solution {
    // dfs
    // private int FakeGridIdx(int r, int c, int m, int n)
    // {
    //     return r * n + c;
    // }

    // public int UniquePaths(int m, int n) {
    //     var visited = new Dictionary<int, int>();
    //     return _DFS(visited, 0, 0, m, n);
    // }

    // private int _DFS(Dictionary<int, int> visited, int frowIdx, int fcolIdx, int m, int n)
    // {
    //     var fkv = FakeGridIdx(frowIdx, fcolIdx, m, n);
    //     if (visited.ContainsKey(fkv))
    //         return visited[fkv];

    //     int pathCount = 0;
    //     int rowIdx = frowIdx;
    //     int colIdx = fcolIdx;

    //     if (rowIdx == m - 1 && colIdx == n - 1)
    //     {
    //         pathCount += 1;
    //     }

    //     if (rowIdx + 1 < m)
    //     {
    //         pathCount += _DFS(visited, rowIdx + 1, colIdx, m, n);
    //     }
        
    //     if (colIdx + 1 < n)
    //     {
    //         pathCount += _DFS(visited, rowIdx, colIdx + 1, m, n);
    //     }

    //     visited[fkv] = pathCount;
    //     return pathCount;
    // }

    // dp
    public int UniquePaths(int m, int n) {
        int[,] pp = new int[m, n];
        for (int i = 0; i < m; ++i)
            pp[i, 0] = 1;
        for (int j = 0; j < n; ++j)
            pp[0, j] = 1;
        for (int i = 1; i < m; ++i)
        {
            for (int j = 1; j < n; ++j)
            {
                pp[i, j] = pp[i - 1, j] + pp[i, j - 1];
            }
        }
        return pp[m - 1, n - 1];
    }
}
// @lc code=end

