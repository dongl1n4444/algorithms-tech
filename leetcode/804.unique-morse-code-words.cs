/*
 * @lc app=leetcode id=804 lang=csharp
 *
 * [804] Unique Morse Code Words
 */

// @lc code=start
using System.Collections.Generic;
using System.Text;

public partial class Solution {
    public static readonly string[] MorseCode = new string[]{
        ".-","-...","-.-.","-..",".","..-.","--.","....","..",".---","-.-",".-..","--","-.","---",".--.","--.-",".-.","...","-","..-","...-",".--","-..-","-.--","--.."
    };

    public int UniqueMorseRepresentations(string[] words) {
        var kk = new HashSet<string>();
        var sb = new StringBuilder();

        for (int i = 0; i < words.Length; ++i)
        {
            var w = words[i];
            for (int j = 0; j < w.Length; ++j)
            {
                var idx = w[j] - 'a';
                sb.Append(MorseCode[idx]);
            }
            kk.Add(sb.ToString());
            sb.Clear();
        }

        return kk.Count;
    }
}
// @lc code=end

