/*
 * @lc app=leetcode id=326 lang=csharp
 *
 * [326] Power of Three
 */

// @lc code=start

// 1   - 0000 0001
// 3   - 0000 0011
// 9   - 0000 1001
// 27  - 0001 1011
// 81  - 0101 0001
// 243 - 1111 0011

public partial class Solution {
    public bool IsPowerOfThree(int n) {
        // 只能是质数才能使用
        return n > 0 && 1162261467 % n == 0;
    }
}
// @lc code=end

