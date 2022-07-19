/*
 * @lc app=leetcode id=118 lang=csharp
 *
 * [118] Pascal's Triangle
 */

// @lc code=start
using System.Collections.Generic;

public partial class Solution {
    public IList<IList<int>> PascalsTriangle(int numRows) {
        var ret = new List<IList<int>>();

        for (int i = 0; i < numRows; ++i)
        {
            var row = new List<int>();
            ret.Add(row);
            if (i == 0)
                row.Add(1);
            else
            {
                var lastRow = ret[i - 1];
                for (int j = 0; j < i + 1; ++j)
                {
                    if (j == 0 || j == i)
                        row.Add(1);
                    else
                        row.Add(lastRow[j - 1] + lastRow[j]);
                }
            }
        }

        return ret;
    }
}
// @lc code=end

