/*
 * @lc app=leetcode id=97 lang=csharp
 *
 * [97] Interleaving String
 */

// @lc code=start
using System.Collections.Generic;

public partial class Solution {
    public bool IsInterleave(string s1, string s2, string s3) {
        // 动态规划
        int m = s1.Length;
        int n = s2.Length;
        int t = s3.Length;
        if (m + n != t) 
            return false;

        bool[,] f = new bool[m + 1, n + 1];
        for (int i = 0; i < m; ++i)
        {
            for (int j = 0; j < n; ++j)
                f[i, j] = false;
        }

        f[0, 0] = true;
        for (int i = 0; i <= m; ++i)
        {
            for (int j = 0; j <= n; ++j)
            {
                int p = i + j - 1;
                if (i > 0)
                {
                    f[i, j] = f[i, j] || (f[i - 1, j] && s1[i - 1] == s3[p]);
                }
                if (j > 0)
                {
                    f[i, j] = f[i, j] || (f[i, j - 1] && s2[j - 1] == s3[p]);
                }
            }
        }

        return f[m, n];
    }
}
// @lc code=end

