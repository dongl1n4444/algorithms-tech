using System;
using System.Linq;
using System.Diagnostics;

namespace leetcode
{
    public class Program
    {
        public static string ArrayToString<T>(T[] values)
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
            // TestLengthOfLongestSubstring(s);
            // TestFindMedianSortedArrays(s);
            // TestLongestPalindrome(s);
            // TestZigzagConvert(s);
            // TestReverseInteger(s);
            // TestMyAtoi(s);
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

        static void TestFindMedianSortedArrays(Solution s)
        {
            var output = s.FindMedianSortedArrays(new int[]{1,3}, new int[]{2});
            Console.WriteLine("nums1 = [1,3], nums2 = [2]\nOutput:" + output);
            output = s.FindMedianSortedArrays(new int[]{1,2}, new int[]{3,4});
            Console.WriteLine("nums1 = [1,2], nums2 = [3,4]\nOutput:" + output);
            output = s.FindMedianSortedArrays(new int[]{0,0,0,0,0}, new int[]{-1,0,0,0,0,0,1});
            Console.WriteLine("nums1 = [1,3], nums2 = [2]\nOutput:" + output);
            output = s.FindMedianSortedArrays(new int[]{-1,0,0,0,0,0,1}, new int[]{0,0,0,0,0});
            Console.WriteLine("nums1 = [1,3], nums2 = [2]\nOutput:" + output);
            output = s.FindMedianSortedArrays(new int[]{}, new int[]{1});
            Console.WriteLine("nums1 = [], nums2 = [1]\nOutput:" + output);
            output = s.FindMedianSortedArrays(new int[]{1}, new int[]{1});
            Console.WriteLine("nums1 = [1], nums2 = [1]\nOutput:" + output);
        }

        static void TestLongestPalindrome(Solution s)
        {
            var output = s.LongestPalindrome("babad");
            Console.WriteLine("Input: s = \"babad\"\nOutput:" + output);
            output = s.LongestPalindrome("cbbd");
            Console.WriteLine("Input: s = \"cbbd\"\nOutput:" + output);
            output = s.LongestPalindrome("a");
            Console.WriteLine("Input: s = \"a\"\nOutput:" + output);
            output = s.LongestPalindrome("abcba");
            Console.WriteLine("Input: s = \"abcba\"\nOutput:" + output);
            output = s.LongestPalindrome("aacabdkacaa");
            Console.WriteLine("Input: s = \"aacabdkacaa\"\nOutput:" + output);
        }

        static void TestZigzagConvert(Solution s)
        {
            var output = s.ZigzagConvert("PAYPALISHIRING", 3);
            Console.WriteLine("Input: s = \"PAYPALISHIRING\", numRows = 3\nOutput:" + output);
            output = s.ZigzagConvert("PAYPALISHIRING", 4);
            Console.WriteLine("Input: s = \"PAYPALISHIRING\", numRows = 4\nOutput:" + output);
            output = s.ZigzagConvert("A", 1);
            Console.WriteLine("Input: s = \"A\", numRows = 1\nOutput:" + output);
        }

        static void TestReverseInteger(Solution s)
        {
            var output = s.ReverseInteger(123);
            Console.WriteLine("Input: x = 123\nOutput:" + output);
            output = s.ReverseInteger(-123);
            Console.WriteLine("Input: x = -123\nOutput:" + output);
            output = s.ReverseInteger(120);
            Console.WriteLine("Input: x = 120\nOutput:" + output);
            output = s.ReverseInteger(1534236469);
            Console.WriteLine("Input: x = 1534236469\nOutput:" + output);
            output = s.ReverseInteger(-2147483648);
            Console.WriteLine("Input: x = -2147483648\nOutput:" + output);
            output = s.ReverseInteger(-2147483412);
            Console.WriteLine("Input: x = -2147483412\nOutput:" + output);
        }

        static void TestMyAtoi(Solution s)
        {
            var output = s.MyAtoi("42");
            Console.WriteLine("Input: s = \"42\"\nOutput:" + output);
            output = s.MyAtoi("   -42");
            Console.WriteLine("Input: s = \"   -42\"\nOutput:" + output);
            output = s.MyAtoi("4193 with words");
            Console.WriteLine("Input: s = \"4193 with words\"\nOutput:" + output);
            output = s.MyAtoi("words and 987");
            Console.WriteLine("Input: s = \"words and 987\"\nOutput:" + output);
            output = s.MyAtoi("-91283472332");
            Console.WriteLine("Input: s = \"-91283472332\"\nOutput:" + output);
            output = s.MyAtoi("3.14159");
            Console.WriteLine("Input: s = \"3.14159\"\nOutput:" + output);
        }
    }
}
