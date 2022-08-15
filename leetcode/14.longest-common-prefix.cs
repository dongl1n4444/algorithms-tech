/*
 * @lc app=leetcode id=14 lang=csharp
 *
 * [14] Longest Common Prefix
 */

// @lc code=start
public partial class Solution {
    public string LongestCommonPrefix(string[] strs) {
        int p = 0;
        bool check = true;
        while (check)
        {
            char k = char.MinValue;
            for (int i = 0; i < strs.Length; ++i)
            {
                if (p >= strs[i].Length)
                {
                    check = false;
                    break;
                }

                if (i == 0)
                {
                    k = strs[i][p];
                    continue;
                }

                if (strs[i][p] != k)
                {
                    check = false;
                    break;
                }
            }

            if (check)
                p += 1;
        }

        return p >= 0 ? strs[0].Substring(0, p) : "";
    }
}
// @lc code=end

