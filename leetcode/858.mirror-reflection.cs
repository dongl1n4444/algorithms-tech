/*
 * @lc app=leetcode id=858 lang=csharp
 *
 * [858] Mirror Reflection
 */

// @lc code=start
using System;

public partial class Solution {
    // https://leetcode.cn/problems/mirror-reflection/solution/zhao-zui-xiao-gong-bei-shu-jie-ti-by-ivan1/
    // 两数最小公倍数和最大公约数乘积等于两数的乘积，所以L / p = q / m (L: 最小公倍数， m：最大公约数)
    public int MirrorReflection(int p, int q) {
        int g = gcd(p, q);
        int m = p / g; // = l / q
        int n = q / g; // = l / p
        m %= 2;
        n %= 2;

        // 
        if (m == 1 && n == 1)
            return 1;
        return m == 1 ? 0 : 2;
    }

    // 最大公约数
    public int gcd(int a, int b)
    {
        if (a == 0) return b;
        return gcd(b % a, a);
    }
}
// @lc code=end

