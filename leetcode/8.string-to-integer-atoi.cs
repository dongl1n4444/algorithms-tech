/*
 * @lc app=leetcode id=8 lang=csharp
 *
 * [8] String to Integer (atoi)
 */

// @lc code=start
using System;

public partial class Solution {

    // TODO: fsm

    public int MyAtoi(string s) {
        int total = 0;
        int neg = 1;
        int numIdx = int.MaxValue;
        int checkSpaceIdx = int.MaxValue;
        int checkNegIdx = int.MaxValue;
        for (int i = 0; i < s.Length; ++i)
        {
            if (s[i] == ' ')
            {
                if (checkSpaceIdx <= checkNegIdx && checkSpaceIdx <= numIdx)
                    checkSpaceIdx = i;
                else
                    break;
            }
            else if ((s[i] == '-' || s[i] == '+'))
            {
                if (checkNegIdx >= checkSpaceIdx && checkNegIdx > i && checkSpaceIdx <= numIdx)
                {
                    checkNegIdx = i;
                    if (s[i] == '-')
                        neg = -1;
                }
                else
                    break;
            }
            else if (s[i] >= '0' && s[i] <= '9')
            {
                if (numIdx != int.MaxValue && i - numIdx > 1)
                    break;

                numIdx = i;

                if (total > int.MaxValue / 10 ||
                    (total == int.MaxValue / 10 && s[i] > '7' && neg == 1) ||
                    (total == int.MaxValue / 10 && s[i] > '8' && neg == -1))
                {
                    if (neg == 1) return int.MaxValue;
                    else return int.MinValue;
                }

                total = total * 10 + (s[i] - '0');
            }
            else if (i < numIdx)
            {
                return 0;
            }
        }
        return total * neg;
    }
}
// @lc code=end

