/*
 * @lc app=leetcode id=5 lang=csharp
 *
 * [5] Longest Palindromic Substring
 */

// @lc code=start
using System.Diagnostics;

public partial class Solution {
    public string LongestPalindrome(string s) {
        int len = s.Length;
        int maxLen = int.MinValue;
        string maxStr = "";
        for (int i = 0; i < len; ++i)
        {
            int a = i;
            int off = 0;
            while (off <= len - i)
            {
                for (int b = len - 1 - off; b >= a; )
                {
                    // Debug.WriteLine(s[a] + " - " + s[b]);

                    if (s[a] != s[b])
                        break;

                    a += 1;
                    b -= 1;
                    
                    if (a == b || a - b == 2 || a - b == 1)
                    {
                        if (maxLen < len - 1 - off - i + 1)
                        {
                            maxLen = len - 1 - off - i + 1;
                            maxStr = s.Substring(i, maxLen);
                        }
                    }
                }

                // Debug.WriteLine("--- off > " + (off + 1));
                a = i;
                off += 1;
            }

        }
        return maxStr;
    }
}
// @lc code=end

