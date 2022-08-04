/*
 * @lc app=leetcode id=858 lang=csharp
 *
 * [858] Mirror Reflection
 */

// @lc code=start
using System;

public partial class Solution {
    // (x, y)
    public int MirrorReflection(int p, int q) {
        float px = 0;
        float py = 0;
        float x = p;
        float y = q;

        while (!(AtPoint(x, y, p, 0) || AtPoint(x, y, p, p) || AtPoint(x, y, 0, p)))
        {
            // left or right
            if (FEqual(x, p) || FEqual(x, 0))
            {
                x = FEqual(x, p) ? 0 : p;
                y = 
            }
            // top or down
            else
            {
                
            }
        }

        if (AtPoint(x, y, p, 0)) return 0;
        if (AtPoint(x, y, p, p)) return 1;
        if (AtPoint(x, y, 0, p)) return 2;
    }

    private bool AtPoint(float x, float y, float tx, float ty)
    {
        return FEqual(x, tx) && FEqual(y, ty);
    }

    private bool FEqual(float a, float b)
    {
        return MathF.Abs(a - b) < float.Epsilon;
    } 
}
// @lc code=end

