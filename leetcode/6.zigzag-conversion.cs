/*
 * @lc app=leetcode id=6 lang=csharp
 *
 * [6] Zigzag Conversion
 */

// @lc code=start
using System.Text;

public partial class Solution {
    // public string ZigzagConvert(string s, int numRows) {
    //     if (numRows == 1)
    //         return s;

    //     int col = 0;
    //     int len = s.Length;
    //     while (len > 0)
    //     {
    //         for (int i = 0; i < numRows; ++i)
    //         {
    //             if (i == 0)
    //                 len -= numRows;
    //             else
    //                 len -= 1;
                
    //             col += 1;
    //             if (len <= 0)
    //                 break;
    //         }
    //     }

    //     int idx = 0;
    //     char[,] ss = new char[numRows, col];
    //     for (int i = 0; i < col; ++i)
    //     {
    //         for (int j = 0; j < numRows; ++j)
    //         {
    //             ss[j, i] = default(char);
    //             if (i % (numRows - 1) == 0)
    //                 ss[j, i] = s[idx++];
    //             else if (j == numRows - 1 - i % (numRows - 1))
    //                 ss[j, i] = s[idx++];

    //             if (idx >= s.Length)
    //                 break;
    //         }

    //         if (idx >= s.Length)
    //             break;
    //     }

    //     StringBuilder sb = new StringBuilder();
    //     for (int i = 0; i < numRows; ++i)
    //     {
    //         for (int j = 0; j < col; ++j)
    //         {
    //             if (ss[i, j] == default(char))
    //                 continue;

    //             sb.Append(ss[i, j]);
    //         }
    //     }
    //     return sb.ToString();
    // }

    public string ZigzagConvert(string s, int numRows) {
        if (numRows == 1)
            return s;

        int len = s.Length;
        int off = 2 * numRows - 2;

        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < numRows; ++i)
        {
            for (int j = 0; j + i < len; j += off)
            {
                sb.Append(s[i + j]);
                if (i != 0 && i != numRows - 1 && j + off - i < len)
                    sb.Append(s[j + off - i]);
            }
        }
        return sb.ToString();
    }
}
// @lc code=end

