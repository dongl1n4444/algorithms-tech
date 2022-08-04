using System;
using System.Linq;
using System.Diagnostics;

namespace leetcode
{
    public class Program
    {
        public static long GetTimeStamp()
        {
            TimeSpan ts = DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0, 0);
            return Convert.ToInt64(ts.TotalSeconds);
        }

        public static long TimeEslapsed(long s)
        {
            return GetTimeStamp() - s;
        }

        public static string ArrayToString<T>(T[] values)
        {
            return string.Format("[{0}]", string.Join(",", values.Select(x => x.ToString()).ToArray()));
        }

        public static void Log(string kk)
        {
            Console.WriteLine(kk);
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
            // TestCandy(s);
            // TestLongestConsecutive(s);
            // TestFib(s);
            // TestIsInterleave(s);
            // TestUniquePathsWithObstacles(s);
            // TestRightSideView(s);
            // TestIsPalindrome(s);
            // TestLevelOrder(s);
            // TestBuildTree(s);
            // TestMaxAreaOfIsland(s);
            // TestFindPaths(s);
            // Test11MaxArea(s);
            // Test118PascalsTriangle(s);
            // Test792NumMatchingSubseq(s);
            // Test92ReverseBetween(s);
            // Test86Partition(s);
            // Test12IntToRoman(s);
            // Test34SearchRange(s);
            // Test236LowestCommonAncestor(s);
            // Test114Flatten(s);
            // Test242IsAnagram(s);
            // Test890FindAndReplacePattern(s);
            // Test62UniquePaths(s);
            // Test378KthSmallest(s);
            // Test729MyCalendar(s);
            Test858MirrorReflection(s);
        }

        static void Test858MirrorReflection(Solution s)
        {
            var output = s.MirrorReflection(2, 1);
            Console.WriteLine("Input: m = 3, n = 2\nOutput:" + output);
            output = s.MirrorReflection(3, 1);
            Console.WriteLine("Input: m = 3, n = 2\nOutput:" + output);
        }

        static void Test729MyCalendar(Solution s)
        {
            MyCalendar obj = new MyCalendar();
            Console.WriteLine("[10,20]" + obj.Book(10, 20));
            Console.WriteLine("[15,25]" + obj.Book(15, 25));
            Console.WriteLine("[20,30]" + obj.Book(20, 30));
        }

        static void Test378KthSmallest(Solution s)
        {
            var output = s.KthSmallest(new int[][]{
                new int[]{1, 2},
                new int[]{1, 3},
            }, 2);
            Console.WriteLine("Input: m = 3, n = 2\nOutput:" + output);

            output = s.KthSmallest(new int[][]{
                new int[]{1, 5, 9},
                new int[]{10, 11, 13},
                new int[]{12, 13, 15}
            }, 8);
            Console.WriteLine("Input: m = 3, n = 2\nOutput:" + output);
            output = s.KthSmallest(new int[][]{
                new int[]{-5}
            }, 1);
            Console.WriteLine("Input: m = 23, n = 12\nOutput:" + output);
        }

        static void Test62UniquePaths(Solution s)
        {
            var output = s.UniquePaths(3, 2);
            Console.WriteLine("Input: m = 3, n = 2\nOutput:" + output);
            var t0 = GetTimeStamp();
            output = s.UniquePaths(23, 12);
            Console.WriteLine("Input: m = 23, n = 12\nOutput:" + output + "-" + TimeEslapsed(t0));
        }

        static void Test890FindAndReplacePattern(Solution s)
        {
            var output = s.FindAndReplacePattern(new string[]{"abc","deq","mee","aqq","dkd","ccc"}, "abb");
            Console.WriteLine("Input: words = [abc,deq,mee,aqq,dkd,ccc], pattern = abb\nOutput:" + ArrayToString<string>(output.ToArray()));
            output = s.FindAndReplacePattern(new string[]{"a","b","c"}, "a");
            Console.WriteLine("Input: words = [a,b,c], pattern = a\nOutput:" + ArrayToString<string>(output.ToArray()));
        }

        static void Test242IsAnagram(Solution s)
        {
            var output = s.IsAnagram("anagram", "nagaram");
            Console.WriteLine("Input: s = anagram, t = nagaram\nOutput:" + output);
            output = s.IsAnagram("rat", "car");
            Console.WriteLine("Input: s = rat, t = car\nOutput:" + output);
        }

        static void Test114Flatten(Solution s)
        {
            var root = new TreeNode(1, new TreeNode(2, new TreeNode(3), new TreeNode(4)), new TreeNode(5, null, new TreeNode(6)));
            s.Flatten(root);
            // Console.WriteLine("Input: nums = [5,7,7,8,8,10], target = 8\nOutput:" + output.val);
            root = null;
            s.Flatten(root);
            root = new TreeNode(0);
            s.Flatten(root);
        }

        static void Test236LowestCommonAncestor(Solution s)
        {
            var p = new TreeNode(5, new TreeNode(6), new TreeNode(2, new TreeNode(7), new TreeNode(4)));
            var q = new TreeNode(1, new TreeNode(0), new TreeNode(8));
            var root = new TreeNode(3, p, q);
            var output = s.LowestCommonAncestor(root, p, q);
            Console.WriteLine("Input: nums = [5,7,7,8,8,10], target = 8\nOutput:" + output.val);
        }

        static void Test34SearchRange(Solution s)
        {
            var output = s.SearchRange(new int[]{5,7,7,8,8,10}, 8);
            Console.WriteLine("Input: nums = [5,7,7,8,8,10], target = 8\nOutput:" + ArrayToString<int>(output));
            output = s.SearchRange(new int[]{5,7,7,8,8,10}, 6);
            Console.WriteLine("Input: nums = [5,7,7,8,8,10], target = 6\nOutput:" + ArrayToString<int>(output));
            output = s.SearchRange(new int[]{1}, 1);
            Console.WriteLine("Input: nums = [], target = 0\nOutput:" + ArrayToString<int>(output));
        }

        static void Test12IntToRoman(Solution s)
        {
            var output = s.IntToRoman(3);
            Console.WriteLine("Input: num = 3\nOutput:" + output);
            output = s.IntToRoman(58);
            Console.WriteLine("Input: num = 58\nOutput:" + output);
            output = s.IntToRoman(1994);
            Console.WriteLine("Input: num = 1994\nOutput:" + output);
            output = s.IntToRoman(20);
            Console.WriteLine("Input: num = 20\nOutput:" + output);
        }

        static void Test86Partition(Solution s)
        {
            var head = new ListNode(1, new ListNode(4, new ListNode(3, new ListNode(2, new ListNode(5, new ListNode(2))))));
            var output = s.Partition(head, 3);
            Console.WriteLine("Input: head = [1,2,3,4,5], left = 2, right = 4\nOutput:" + output);

            head = new ListNode(2, new ListNode(1));
            output = s.Partition(head, 2);
            Console.WriteLine("Input: head = [1,2,3,4,5], left = 2, right = 4\nOutput:" + output);

            head = new ListNode(1, new ListNode(1));
            output = s.Partition(head, 2);
            Console.WriteLine("Input: head = [1,2,3,4,5], left = 2, right = 4\nOutput:" + output);
        }

        static void Test92ReverseBetween(Solution s)
        {
            var head = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5)))));
            var output = s.ReverseBetween(head, 2, 4);
            Console.WriteLine("Input: head = [1,2,3,4,5], left = 2, right = 4\nOutput:" + output);
           
            head = new ListNode(5);
            output = s.ReverseBetween(head, 1, 1);
            Console.WriteLine("Input: head = [5], left = 1, right = 1\nOutput:" + output);
        
            head = new ListNode(3, new ListNode(5));
            output = s.ReverseBetween(head, 2, 2);
            Console.WriteLine("Input: head = [5], left = 1, right = 1\nOutput:" + output);

            head = new ListNode(3, new ListNode(5));
            output = s.ReverseBetween(head, 1, 2);
            Console.WriteLine("Input: head = [5], left = 1, right = 1\nOutput:" + output);
        }

        static void Test792NumMatchingSubseq(Solution s)
        {
            var output = s.NumMatchingSubseq("rwpddkvbnnuglnagtvamxkqtwhqgwbqgfbvgkwyuqkdwhzudsxvjubjgloeofnpjqlkdsqvruvabjrikfwronbrdyyjnakstqjac", new string[]{"wpddkvbnn","lnagtva","kvbnnuglnagtvamxkqtwhqgwbqgfbvgkwyuqkdwhzudsxvju","rwpddkvbnnugln","gloeofnpjqlkdsqvruvabjrikfwronbrdyyj","vbgeinupkvgmgxeaaiuiyojmoqkahwvbpwugdainxciedbdkos","mspuhbykmmumtveoighlcgpcapzczomshiblnvhjzqjlfkpina","rgmliajkiknongrofpugfgajedxicdhxinzjakwnifvxwlokip","fhepktaipapyrbylskxddypwmuuxyoivcewzrdwwlrlhqwzikq","qatithxifaaiwyszlkgoljzkkweqkjjzvymedvclfxwcezqebx"});
            Console.WriteLine("Input: s = \"abcde\", words = [a,bb,acd,ace]\nOutput:" + output);

            output = s.NumMatchingSubseq("abcde", new string[]{"a","bb","acd","ace"});
            Console.WriteLine("Input: s = \"abcde\", words = [a,bb,acd,ace]\nOutput:" + output);
            output = s.NumMatchingSubseq("dsahjpjauf", new string[]{"ahjpjau","ja","ahbwzgqnuk","tnmlanowax"});
            Console.WriteLine("Input: s = dsahjpjauf, words = [ahjpjau,ja,ahbwzgqnuk,tnmlanowax]\nOutput:" + output);
        }

        static void Test118PascalsTriangle(Solution s)
        {
            var output = s.PascalsTriangle(5);
            // Console.WriteLine("Input: 5\nOutput:" + output);
            output = s.PascalsTriangle(1);
            // Console.WriteLine("Input: 1\nOutput:" + output);
        }

        static void Test11MaxArea(Solution s)
        {
            var output = s.MaxArea(new int[]{1,8,6,2,5,4,8,3,7});
            Console.WriteLine("Input: [1,8,6,2,5,4,8,3,7]\nOutput:" + output);
            output = s.MaxArea(new int[]{1,1});
            Console.WriteLine("Input: [1,1]\nOutput:" + output);
        }

        static void TestFindPaths(Solution s)
        {
            var output = s.FindPaths(2, 2, 2, 0, 0);
            Console.WriteLine("Input: m = 2, n = 2, maxMove = 2, startRow = 0, startColumn = 0\nOutput:" + output);
            output = s.FindPaths(1, 3, 3, 0, 1);
            Console.WriteLine("Input: m = 1, n = 3, maxMove = 3, startRow = 0, startColumn = 1\nOutput:" + output);
            var ts = GetTimeStamp();
            output = s.FindPaths(8, 7, 16, 1, 5);
            Console.WriteLine("Input: m = 1, n = 3, maxMove = 3, startRow = 0, startColumn = 1\nOutput:" + output + "\nTime:" + TimeEslapsed(ts));
            ts = GetTimeStamp();
            output = s.FindPaths(8, 50, 23, 5, 26);
            Console.WriteLine("Input: m = 1, n = 3, maxMove = 3, startRow = 0, startColumn = 1\nOutput:" + output + "\nTime:" + TimeEslapsed(ts));
        }

        static void TestMaxAreaOfIsland(Solution s)
        {
            var output = s.MaxAreaOfIsland(new int[][]{
                new int[]{0,0,1,0,0,0,0,1,0,0,0,0,0},
                new int[]{0,0,0,0,0,0,0,1,1,1,0,0,0},
                new int[]{0,1,1,0,1,0,0,0,0,0,0,0,0},
                new int[]{0,1,0,0,1,1,0,0,1,0,1,0,0},
                new int[]{0,1,0,0,1,1,0,0,1,1,1,0,0},
                new int[]{0,0,0,0,0,0,0,0,0,0,1,0,0},
                new int[]{0,0,0,0,0,0,0,1,1,1,0,0,0},
                new int[]{0,0,0,0,0,0,0,1,1,0,0,0,0},
            });
            Console.WriteLine("Input: root = [3,9,20,null,null,15,7]\nOutput:" + output);
           
            output = s.MaxAreaOfIsland(new int[][]{new int[]{0,0,0,0,0,0,0,0}});
            Console.WriteLine("Input: root = [3,9,20,null,null,15,7]\nOutput:" + output);
        }

        static void TestBuildTree(Solution s)
        {
            var output = s.BuildTree(new int[]{3,9,20,15,7}, new int[]{9,3,15,20,7});
            // Console.WriteLine("Input: root = [3,9,20,null,null,15,7]\nOutput:" + ArrayToString<int>(output.ToArray()));
            output = s.BuildTree(new int[]{-1}, new int[]{-1});
            // Console.WriteLine("Input: root = [3,9,20,null,null,15,7]\nOutput:" + ArrayToString<int>(output.ToArray()));
        }

        static void TestLevelOrder(Solution s)
        {
            var t4 = new TreeNode(15);
            var t5 = new TreeNode(7);
            var t2 = new TreeNode(9);
            var t3 = new TreeNode(20, t4, t5);
            var t1 = new TreeNode(3, t2, t3);

            var output = s.LevelOrder(t1);
            // Console.WriteLine("Input: root = [3,9,20,null,null,15,7]\nOutput:" + ArrayToString<int>(output.ToArray()));

            t1 = new TreeNode(1);
            output = s.LevelOrder(t1);
            // Console.WriteLine("Input: root = [1]\nOutput:" + ArrayToString<int>(output.ToArray()));
        
            output = s.LevelOrder(null);
            // Console.WriteLine("Input: root = []\nOutput:" + ArrayToString<int>(output.ToArray()));
        }

        static void TestIsPalindrome(Solution s)
        {
            var output = s.IsPalindrome(121);
            Console.WriteLine("Input: x = 121\nOutput:" + output);
            output = s.IsPalindrome(-121);
            Console.WriteLine("Input: x = -121\nOutput:" + output);
            output = s.IsPalindrome(10);
            Console.WriteLine("Input: x = 10\nOutput:" + output);
        }

        static void TestRightSideView(Solution s)
        {
            var t5 = new TreeNode(5);
            var t4 = new TreeNode(4);
            var t2 = new TreeNode(2, null, t5);
            var t3 = new TreeNode(3, null, t4);
            var t1 = new TreeNode(1, t2, t3);

            var output = s.RightSideView(t1);
            Console.WriteLine("Input: root = [1,2,3,null,5,null,4]\nOutput:" + ArrayToString<int>(output.ToArray()));


            var tt3 = new TreeNode(3);
            var tt1 = new TreeNode(1, null, tt3);
            output = s.RightSideView(tt1);
            Console.WriteLine("Input: root = [1,null,3]\nOutput:" + ArrayToString<int>(output.ToArray()));
        
            output = s.RightSideView(null);
            Console.WriteLine("Input: root = []\nOutput:" + ArrayToString<int>(output.ToArray()));

            t2 = new TreeNode(2);
            t1 = new TreeNode(1, t2);
            output = s.RightSideView(t1);
            Console.WriteLine("Input: root = [1,2]\nOutput:" + ArrayToString<int>(output.ToArray()));
        }

        static void TestUniquePathsWithObstacles(Solution s)
        {
            var output = s.UniquePathsWithObstacles(new int[][]{new int[]{0,0,0}, new int[]{0,1,0}, new int[]{0,0,0}});
            Console.WriteLine("Input: obstacleGrid = [[0,0,0],[0,1,0],[0,0,0]]\nOutput:" + output);
            output = s.UniquePathsWithObstacles(new int[][]{new int[]{0,1}, new int[]{0,0}});
            Console.WriteLine("Input: obstacleGrid = [[0,1],[0,0]]\nOutput:" + output);
        }

        static void TestIsInterleave(Solution s)
        {
            var output = s.IsInterleave("aabcc", "dbbca", "aadbbcbcac");
            Console.WriteLine("Input: s1 = aabcc, s2 = dbbca, s3 = aadbbcbcac\nOutput:" + output);
            output = s.IsInterleave("aabcc", "dbbca", "aadbbbaccc");
            Console.WriteLine("Input: s1 = aabcc, s2 = dbbca, s3 = aadbbbaccc\nOutput:" + output);
            output = s.IsInterleave("", "", "");
            Console.WriteLine("Input: s1 = , s2 = , s3 = \nOutput:" + output);
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

        static void TestCandy(Solution s)
        {
            var output = s.Candy(new int[]{1, 0, 2});
            Console.WriteLine("Input: ratings = [1,0,2]\nOutput:" + output);
            output = s.Candy(new int[]{1, 2, 2});
            Console.WriteLine("Input: ratings = [1,2,2]\nOutput:" + output);
            output = s.Candy(new int[]{1,3,4,5,2});
            Console.WriteLine("Input: ratings = [1,3,4,5,2]\nOutput:" + output);
        }

        static void TestLongestConsecutive(Solution s)
        {
            var output = s.LongestConsecutive(new int[]{100,4,200,1,3,2});
            Console.WriteLine("Input: nums = [100,4,200,1,3,2]\nOutput:" + output);
            output = s.LongestConsecutive(new int[]{0,3,7,2,5,8,4,6,0,1});
            Console.WriteLine("Input: nums = [0,3,7,2,5,8,4,6,0,1]\nOutput:" + output);
        }

        static void TestFib(Solution s)
        {
            var output = s.Fib(2);
            Console.WriteLine("Input: n = 2\nOutput:" + output);
            output = s.Fib(3);
            Console.WriteLine("Input: n = 3\nOutput:" + output);
        }
    }
}
