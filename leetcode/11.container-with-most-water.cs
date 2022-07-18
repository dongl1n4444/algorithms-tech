/*
 * @lc app=leetcode id=11 lang=csharp
 *
 * [11] Container With Most Water
 */

// @lc code=start
using System;

public partial class Solution {
    // public int MaxArea(int[] height) {
    //     int maxArea = 0;
    //     for (int i = 0; i < height.Length - 1; ++i)
    //     {
    //         if (height[i] == 0)
    //             continue;

    //         int offset = maxArea / height[i];

    //         for (int j = i + offset; j < height.Length; ++j)
    //         {
    //             if (height[j] == 0)
    //                 continue;

    //             int minHeight = Math.Min(height[i], height[j]);
    //             int len = j - i;
    //             int area = minHeight * len;
    //             if (area > maxArea)
    //             {
    //                 maxArea = area;
    //             }
    //         }
    //     }
    //     return maxArea;
    // }

    // two point
    public int MaxArea(int[] height) {
        int maxArea = 0;
        int l = 0;
        int r = height.Length - 1;
        while (l < r)
        {
            int minHeight = Math.Min(height[l], height[r]);
            int len = r - l;
            int area = minHeight * len;
            if (area > maxArea)
            {
                maxArea = area;
            }

            if (height[l] < height[r])
                l += 1;
            else
                r -= 1;
        }
        return maxArea;
    }
}
// @lc code=end

