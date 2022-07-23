/*
 * @lc app=leetcode id=12 lang=csharp
 *
 * [12] Integer to Roman
 */

// @lc code=start
using System.Text;
using System.Collections.Generic;

public partial class Solution {
    public static Dictionary<int, string> IntToRomanIdxs = new Dictionary<int, string>()
    {
        {1, "I"},
        {4, "IV"},
        {5, "V"},
        {9, "IX"},
        {10, "X"},
        {40, "XL"},
        {50, "L"},
        {90, "XC"},
        {100, "C"},
        {400, "CD"},
        {500, "D"},
        {900, "CM"},
        {1000, "M"}
    };

    private static List<int> RomanIntKeys = new List<int>()
    {
        1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1
    };

    public string IntToRoman(int num) {
        
        StringBuilder sb = new StringBuilder();

        for (int i = 0; i < RomanIntKeys.Count; )
        {
            var val = RomanIntKeys[i];
            if (num >= val)
            {
                num -= val;
                sb.Append(IntToRomanIdxs[val]);
            }
            else
            {
                ++i;
            }
        }
        return sb.ToString();
    }
}
// @lc code=end

