/*
 * @lc app=leetcode id=509 lang=csharp
 *
 * [509] Fibonacci Number
 */

// @lc code=start
public partial class Solution {
    // O(2^n)
    // public int Fib(int n) {
    //     if (n <= 0)
    //         return 0;
    //     if (n == 1)
    //         return 1;

    //     return _Fib(n - 1) + _Fib(n - 2);
    // }

    // public int _Fib(int n) {
    //     if (n <= 0)
    //         return 0;
    //     if (n == 1)
    //         return 1;
    //     return _Fib(n - 1) + _Fib(n - 2);
    // }

    public int Fib(int n) {
        if (n < 2)
            return n;
        
        int p = 0;
        int q = 0;
        int r = 1;
        for (int i = 2; i <= n; ++i)
        {
            p = q;
            q = r;
            r = p + q;
        }

        return r;
    }
}
// @lc code=end

