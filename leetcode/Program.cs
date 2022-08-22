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
            // Test858MirrorReflection(s);
            // Test377CombinationSum4(s);
            // Test300LengthOfLIS(s);
            // Test823NumFactoredBinaryTrees(s);
            // Test108SortedArrayToBST(s);
            // Test98IsValidBST(s);
            // Test235LowestCommonAncestor(s);
            // Test30FindSubstring(s);
            // Test14LongestCommonPrefix(s);
            // Test387FirstUniqChar(s);
            // Test804UniqueMorseRepresentations(s);
            // Test1338MinSetSize(s);
            // Test659IsPossible(s);
            // Test871MinRefuelStops(s);
            Test342IsPowerOfFour(s);
        }

        static void Test342IsPowerOfFour(Solution s)
        {
            var output = s.IsPowerOfFour(16);
            Console.WriteLine("Input: s = leetcode\nOutput:" + output);
            output = s.IsPowerOfFour(5);
            Console.WriteLine("Input: s = leetcode\nOutput:" + output);
            output = s.IsPowerOfFour(1);
            Console.WriteLine("Input: s = leetcode\nOutput:" + output);
        }

        static void Test871MinRefuelStops(Solution s)
        {
            var output = s.MinRefuelStops(1, 1, new int[][]{});
            Console.WriteLine("Input: s = leetcode\nOutput:" + output);
            output = s.MinRefuelStops(100, 1, new int[][]{new int[]{10, 100}});
            Console.WriteLine("Input: s = leetcode\nOutput:" + output);
            output = s.MinRefuelStops(100, 10, new int[][]{new int[]{10, 60}, new int[]{20, 30}, new int[]{30, 30}, new int[]{60, 40}});
            Console.WriteLine("Input: s = leetcode\nOutput:" + output);
        }

        static void Test659IsPossible(Solution s)
        {
            var output = s.IsPossible(new int[]{1,2,3,3,4,5});
            Console.WriteLine("Input: s = leetcode\nOutput:" + output);
            output = s.IsPossible(new int[]{1,2,3,3,4,4,5,5});
            Console.WriteLine("Input: s = leetcode\nOutput:" + output);
            output = s.IsPossible(new int[]{1,2,3,4,4,5});
            Console.WriteLine("Input: s = leetcode\nOutput:" + output);
        }

        static void Test1338MinSetSize(Solution s)
        {
            var output = s.MinSetSize(new int[]{2,28,92,30,100,52,28,48,91,27,66,19,11,53,91,95,74,51,65,65,96,81,21,55,98,3,2,89,99,57,78,34,50,2,57,76,23,90,89,36,53,22,73,59,95,45});
            Console.WriteLine("Input: s = leetcode\nOutput:" + output);
            // output = s.MinSetSize(new int[]{3,3,3,3,5,5,5,2,2,7});
            // Console.WriteLine("Input: s = leetcode\nOutput:" + output);
            // output = s.MinSetSize(new int[]{7,7,7,7,7,7});
            // Console.WriteLine("Input: s = loveleetcode\nOutput:" + output);
        }

        static void Test804UniqueMorseRepresentations(Solution s)
        {
            var output = s.UniqueMorseRepresentations(new string[]{"gin","zen","gig","msg"});
            Console.WriteLine("Input: s = leetcode\nOutput:" + output);
            output = s.UniqueMorseRepresentations(new string[]{"a"});
            Console.WriteLine("Input: s = loveleetcode\nOutput:" + output);
        }

        static void Test387FirstUniqChar(Solution s)
        {
            var output = s.FirstUniqChar("leetcode");
            Console.WriteLine("Input: s = leetcode\nOutput:" + output);
            output = s.FirstUniqChar("loveleetcode");
            Console.WriteLine("Input: s = loveleetcode\nOutput:" + output);
            output = s.FirstUniqChar("aabb");
            Console.WriteLine("Input: s = aabb\nOutput:" + output);
        }

        static void Test14LongestCommonPrefix(Solution s)
        {
            var output = s.LongestCommonPrefix(new string[]{"flower","flow","flight"});
            Console.WriteLine("Input: strs = [\"flower\",\"flow\",\"flight\"]\nOutput:" + output);
        }

        static void Test30FindSubstring(Solution s)
        {
            var output = s.FindSubstring("ababaab", new string[]{"ab","ba","ba"});
            Console.WriteLine("Input: s = \"barfoothefoobarman\", words = [\"foo\",\"bar\"]\nOutput:" + ArrayToString<int>(output.ToArray()));
            output = s.FindSubstring("barfoothefoobarman", new string[]{"foo","bar"});
            Console.WriteLine("Input: s = \"barfoothefoobarman\", words = [\"foo\",\"bar\"]\nOutput:" + ArrayToString<int>(output.ToArray()));
            output = s.FindSubstring("barfoofoobarthefoobarman", new string[]{"bar","foo","the"});
            Console.WriteLine("Input: s = \"barfoothefoobarman\", words = [\"foo\",\"bar\"]\nOutput:" + ArrayToString<int>(output.ToArray()));
        }

        static void Test235LowestCommonAncestor(Solution s)
        {
            var p = new TreeNode(2, new TreeNode(0), new TreeNode(4, new TreeNode(3), new TreeNode(5)));
            var q = new TreeNode(8, new TreeNode(7), new TreeNode(9));
            var root = new TreeNode(6, p, q);
            var output = s.LowestCommonAncestor2(root, p, q);
            Console.WriteLine("Input: nums = [6,2,8,0,4,7,9,null,null,3,5], p = 2, q = 8\nOutput:" + output.val);
        }


        static void Test98IsValidBST(Solution s)
        {
            var t = new TreeNode(2, new TreeNode(1), new TreeNode(3));
            var output = s.IsValidBST(t);
            Console.WriteLine("Input: nums = [2,1,3] - true\nOutput:" + output.ToString());

            t = new TreeNode(5, new TreeNode(1), new TreeNode(4, new TreeNode(3), new TreeNode(6)));
            output = s.IsValidBST(t);
            Console.WriteLine("Input: nums = [5,1,4,null,null,3,6] - false\nOutput:" + output.ToString());

            t = new TreeNode(5, new TreeNode(4), new TreeNode(6, new TreeNode(3), new TreeNode(7)));
            output = s.IsValidBST(t);
            Console.WriteLine("Input: nums = [5,1,4,null,null,3,6] - false\nOutput:" + output.ToString());

            t = new TreeNode(3, new TreeNode(1, new TreeNode(0), new TreeNode(2)), new TreeNode(5, new TreeNode(4), new TreeNode(6)));
            output = s.IsValidBST(t);
            Console.WriteLine("Input: nums = [3,1,5,0,2,4,6] - true\nOutput:" + output.ToString());
        }

        static void Test108SortedArrayToBST(Solution s)
        {
            var output = s.SortedArrayToBST(new int[]{-10,-3,0,5,9});
            Console.WriteLine("Input: nums = [-10,-3,0,5,9]\nOutput:" + output.ToString());
        }

        static void Test823NumFactoredBinaryTrees(Solution s)
        {
            var output = s.NumFactoredBinaryTrees(new int[]{45,42,2,18,23,1170,12,41,40,9,47,24,33,28,10,32,29,17,46,11,759,37,6,26,21,49,31,14,19,8,13,7,27,22,3,36,34,38,39,30,43,15,4,16,35,25,20,44,5,48});
            Console.WriteLine("Input: nums = [18,3,6,2]\nOutput:" + output);
            //output = s.NumFactoredBinaryTrees(new int[]{2, 4});
            //Console.WriteLine("Input: nums = [2, 4]\nOutput:" + output);
            //output = s.NumFactoredBinaryTrees(new int[]{2,4,5,10});
            //Console.WriteLine("Input: nums = [2,4,5,10]\nOutput:" + output);
            // output = s.NumFactoredBinaryTrees(new int[]{60588000,36158400,950040,162450288,446000100,1807920,31590000,360,166153680,6,91213584,34186320,915124000,68600,6497400,10,194304,951035904,393822000,23522400,14400,821376000,80,881118000,576000,3660480,106801200,180690300,5100,1573200,36288000,38,197643600,221852925,8820,36000,822294528,13935240,236307456,17409600,443741760,62868,548800000,25271064,34848,344137500,8383500,186,45,100980,722358000,63000000,16442400,1579500,684,12970692,243540,232560,149153400,437400,16215,713460,75524400,118800,1575,106920,10150,13770000,33999966,177811200,64680,2880768,632459520,8675100,498700800,213572700,18657600,22,6993,49,177147000,6480,20,3910368,85201200,1764,120093120,16022160,290822400,6219200,29376000,235290,20979000,5,384,959140,443944800,11303040,952560,47736000,33404280,39936,11864320,144270720,12868224,18289152,87230682,145860,262548,10276500,12,612,179010000,622987200,108475200,1012,60,14880,10924200,2285568,149178000,1573936,195695500,213269760,24975,12000,3706560,168382080,114724,87650640,8019000,8035200,8621844,514500,155,132612480,1676700,627318720,39330,17,926100000,283360,69949440,856575,4092,130,720,958035000,5396820,2668,6606336,169708000,2352240,26,40608000,324576,3220,4945920,187697664,350,3965520,40500,9000,142560,39580800,447051000,19077120,36605250,775,19404,87514000,2673,9720,4942080,56752500,118216665,858,18225,3124800,1530,380160,24554880,2762100,646945200,173210400,22376250,731076192,161,44705100,145981440,18223660,215424,878526000,22883952,92092,7306200,32,2708160,566957475,17305344,119556000,411402240,1292544,454480,2208,27498240,249230520,88058880,2108,527800,455,49846104,801900,252450,7644,129540320,2241675,1330,71089200,2709630,43545600,497250,4972968,826277760,249091200,68827500,60900,271282240,13910400,88609950,46189440,3088800,582912000,4284000,304980000,32736,992,52992,454545000,14064960,72967500,892584000,61678260,3410,49104000,840931520,107805600,200475,35384580,4289408,599079390,777,465696,7956000,540960,3385200,8741250,17748,2528240,2248480,83076840,366282000,15120000,6871956,15586560,992673792,367200,65577600,635796000,150,62524000,7551600,1716660,85932,209986560,6167826,1557192,20702500,157320,14427072,553402080,203290560,3830112,1500,120992256,89280,66943800,8937984,30,32457600,75140,874,34398000,390600,955500,32542560,51068160,6624,545368824,316461600,236670,598067712,97538400,3240000,664801200,6120,477487296,445419000,38318280,148800,7,1055600,9128700,6472800,13176240,535680,7998,345960,1262250,78693120,1364,15,13800,406000,42,23,703872,787939152,24288,37795758,6300000,145704960,124,46920,3142656,31725,92,186300,1470,73500,3495250,196416,639878400,65800,1015680,131176500,37264500,243984000,19227000,917280,9384000,81840,454406400,795217500,147420000,6976800,14651280,116,11960,153740160,799948800,5184000,501686640,1020,773500,145763550,26417664,11446380,13,14817600,406125720,7068600,730667520,3371004,2677752,2692305,70615314,1771,388411200,20175075,14742000,139991040,302400,40131360,21740796,5996025,205615179,469193472,23220,8286300,19706400,2812992,72886425,3072,6557760,551779200,960,74592,185427840,40068864,883872000,85250,3499200,2210,402772500,1274,106260,4392080,953146480,90744192,132699840,4270560,361746000,342720,673536600,2418,234600,967255800,34500,8910,196040,374190336,9790200,694747200,5385600,907200,493426080,804683880,13820544,7999488,4879680,88400,13765500,28,377,172339200,97152,427680,41731200,92610,13950000,564200,2520,74970,11603592,16,18200,201386250,474525,531468,1860,51840,677376,59520,4457400,8912376,6742008,11013975,566280,330832,110707200,172727100,382200,942480,10200,3210480,2033600,11289564,6667920,675347400,79994880,27676800,158100,133722000,66769920,332041248,25,1545600,21450,655966080,11814660,223200,4151040,1016064,35,1607040,924,586333020,174787200,63756,18957120,788900000,351900000,1380,5441800,374,44200,38640,8307684,109707264,2178,7440,6577200,29435,264600000,12960000,2646,891691416,475656192,214033920,431708160,70340256,404736,39104,787059000,3208500,220103100,191268,66960000,18500832,856016640,173901000,1238688,157489920,54782,550946880,242573760,257040,282720,117645000,165369600,13110,434079360,9133344,621000,174037500,126960,6147900,137491200,29559600,700,185220000,317520000,200344320,14036,26601120,3535488,3649940,16240,61659000,430848,779483250,363528000,419764800,729933750,386661600,111481920,35700,6561000,68695200,70,297,83700,990,113076810,461538,787529952,4324,20727,40350150,218700,846720,540,29889000,1016600,277704000,62734080,14856192,210924000,589248000,5760,222393600,30180600,166059400,31021056,98208,21,21168,98208000,13464,1555200,16077600,288,4332042,320550912,204989400,785664,67897440,65472,16228800,70560,80352,8,9520896,71280,4862,44,12545280,657395200,39,64152000,283719996,247443840,924159600,20286000,268065,138983850,9300,5286120,61534200,496601280,875033280,6370,5940,364,29412,261360,1248,477290880,5880,669600,82174400,53568,483000,36,18,29728512,12057760,3046680,44660,368874000,167040,4276800,83462400,11050,638,34300000,27,509110272,437132430,81200,33,6277500,113601600,14850,10789200,157216500,20348928,10701900,365904000,1728,1782960,1255800,38321400,3542,6229872,40864824,514483200,43,1159200,413100,1127100,8019,198251550,47,30950400,2115,46,45900,233280000,125736,200508,5742,222456,442520,245188944,162288000,5589000,76923,2461536,415457280,715936320,179289600,14826240,17150000,13759200,63240,7001280,663000,22776600,221925825,920700,1421000,1715616,30198960,1766100,2480,290,460,1556640,1015,145411200,11350500,824199480,539028000,11865150,882000,19,830297000,159840,7632800,81053840,68250,77873400,123965952,164826900,23040,347200,51323580,30294000,140777000,1023,147556500,273420,13665960,2760,21780,77552640,3245760,341433225,930,12740,441,960498,184988160,219240000,125854344,13986,174960,53978400,2163168,456840000,1513400,179676000,90810720,28569600,4923072,807003000,49758720,47404500,480,42340320,837000000,3,3720,15847920,1400,1715000,251160,198,504708750,8932000,6311250,1458240,96,37235712,911400,255816,142084800,39346560,2384640,38491200,1872000,899640,14586,294624,37,239760,469476000,1015200,531454000,411840,36352800,15367680,273454272,63987840,22416750,24500,171535,683384832,47586240,82800,112266,12746370,429545025,875769840,125468160,74,39412800,45904320,9313920,1589760,24,570240,72912000,107880,1758120,7980,2614640,34,12987000,3124044,728640,21420,4,22855680,21600,99,11,203076720,90132,687447000,5049000,747225,37620,13363200,209265525,171169600,461039040,36946,79197560,35280,108100,22032000,343062720,29141775,906782240,297600,298378080,486129600,979104000,22151360,74576700,1647030,58870,828100,1064,58605120,12182400,860288,41,62107500,9,310495680,71951360,29,105995232,13838,1617000,832431600,328671,510,3826550,689018400,10959300,48,3294060,22720320,132022800,24663600,40,520,6756750,429624000,79497600,11427840,489167910,54734592,10847520,887284800,223948800,735139125,3478200,470235,649152000,86619456,932536800,2976,675,491756100,73780,1142784,5488560,1473780,301693392,8819902,88357500,40392,579600,457113600,2,692841600,77189112,49538412,18086640,104976000,35162400,4320,435,107892000,14,832,257094000,345,323389440,813440,13392000,29760,8391600,599400,1713600,154560,7380480,127429200,198360,8625,459345600,13117650,1309440,85680,41972175,75710880,87339648,55296000,1054,10098,269414640,787644000,34560,253,721353600,28072,5984,148764,84630,25966080,141120,46368,101680,31,82197720,3312400,2980800,18247680,12453120,9108,3050400});
            // Console.WriteLine("Input: nums = [2,4,5,10]\nOutput:" + output);
        }

        static void Test300LengthOfLIS(Solution s)
        {
            var output = s.LengthOfLIS(new int[]{10,9,2,5,3,7,101,18});
            Console.WriteLine("Input: nums = [10,9,2,5,3,7,101,18]\nOutput:" + output);
            output = s.LengthOfLIS(new int[]{0,1,0,3,2,3});
            Console.WriteLine("Input: nums = [0,1,0,3,2,3]\nOutput:" + output);
            output = s.LengthOfLIS(new int[]{7,7,7,7,7,7,7});
            Console.WriteLine("Input: nums = [7,7,7,7,7,7,7]\nOutput:" + output);
        }

        static void Test377CombinationSum4(Solution s)
        {
            var output = s.CombinationSum4(new int[]{1,2,3}, 4);
            Console.WriteLine("Input: nums = [1,2,3], target = 4\nOutput:" + output);
            output = s.CombinationSum4(new int[]{9}, 3);
            Console.WriteLine("Input: nums = [9], target = 3\nOutput:" + output);
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
