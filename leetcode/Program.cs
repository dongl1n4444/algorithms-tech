using System;
using System.Linq;
using System.Diagnostics;

namespace leetcode
{
    class Program
    {
        static string ArrayToString<T>(T[] values)
        {
            return string.Format("[{0}]", string.Join(",", values.Select(x => x.ToString()).ToArray()));
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Solution s = new Solution();
            // TestTwoSum(s);
            // TestRomanToInteger(s);
            // TestAddTowNumbers(s);
            TestLengthOfLongestSubstring(s);
        }

        static void TestTwoSum(Solution s)
        {
            var output = s.TwoSum(new int[]{2, 7, 11, 15}, 9);
            Console.WriteLine("Input: nums = [2,7,11,15], target = 9\nOutput:" + ArrayToString(output));
            // Debug.Assert(output[0] == 0 && output[1] == 1);
            output = s.TwoSum(new int[]{3, 2, 4}, 6);
            Console.WriteLine("Input: nums = [3,2,4], target = 6\nOutput:" + ArrayToString(output));
            output = s.TwoSum(new int[]{3, 3}, 6);
            Console.WriteLine("Input: nums = [3,3], target = 6\nOutput:" + ArrayToString(output));
        }

        static void TestRomanToInteger(Solution s)
        {
            var output = s.RomanToInt("III");
            Console.WriteLine("Input: s = \"III\"\nOutput:" + output);
            output = s.RomanToInt("LVIII");
            Console.WriteLine("Input:s = \"LVIII\"\nOutput:" + output);
            output = s.RomanToInt("MCMXCIV");
            Console.WriteLine("Input: \"MCMXCIV\"\nOutput:" + output);
        }

        static void TestAddTowNumbers(Solution s)
        {
            var output = s.AddTwoNumbers(ListNode.Create(new int[]{2,4,3}), ListNode.Create(new int[]{5,6,4}));
            Console.WriteLine("Input: l1 = [2,4,3], l2 = [5,6,4]\nOutput:" + output);
            output = s.AddTwoNumbers(ListNode.Create(new int[]{9,9,9,9,9,9,9}), ListNode.Create(new int[]{9,9,9,9}));
            Console.WriteLine("Input: l1 = [9,9,9,9,9,9,9], l2 = [9,9,9,9]\nOutput:" + output);
        }

        static void TestLengthOfLongestSubstring(Solution s)
        {
            var output = s.LengthOfLongestSubstring("abcabcbb");
            Console.WriteLine("Input: s = \"abcabcbb\"\nOutput:" + output);
            output = s.LengthOfLongestSubstring("bbbbb");
            Console.WriteLine("Input: s = \"bbbbb\"\nOutput:" + output);
            output = s.LengthOfLongestSubstring("pwwkew");
            Console.WriteLine("Input: s = \"pwwkew\"\nOutput:" + output);
            output = s.LengthOfLongestSubstring(" ");
            Console.WriteLine("Input: s = \" \"\nOutput:" + output);
            output = s.LengthOfLongestSubstring("");
            Console.WriteLine("Input: s = \"\"\nOutput:" + output);
            output = s.LengthOfLongestSubstring("au");
            Console.WriteLine("Input: s = \"au\"\nOutput:" + output);
            output = s.LengthOfLongestSubstring("dvdf");
            Console.WriteLine("Input: s = \"dvdf\"\nOutput:" + output);
            output = s.LengthOfLongestSubstring("abba");
            Console.WriteLine("Input: s = \"abba\"\nOutput:" + output);
        }
    }
}
