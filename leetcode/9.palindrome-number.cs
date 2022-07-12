/*
 * @lc app=leetcode id=9 lang=csharp
 *
 * [9] Palindrome Number
 */

// @lc code=start
public partial class Solution {
    // public bool IsPalindrome(int x) {
    //     if (x < 0)
    //         return false;
    //     int origin = x;
    //     int val = 0;
    //     while (x > 0)
    //     {
    //         int k = x % 10;
    //         x /= 10;
    //         if (val == int.MaxValue / 10 && k >= 7)
    //             return false;
    //         val = val * 10 + k;
    //     }
    //     return val == origin;
    // }

    // half len
    public bool IsPalindrome(int x) {
        if (x < 0 || (x % 10 == 0 && x != 0))
            return false;
        int val = 0;
        while (x > val)
        {
            val = val * 10 + x % 10;
            x /= 10;            
        }
        return val == x || val / 10 == x;
    }
}
// @lc code=end

