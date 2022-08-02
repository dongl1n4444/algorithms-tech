/*
 * @lc app=leetcode id=378 lang=csharp
 *
 * [378] Kth Smallest Element in a Sorted Matrix
 */

// @lc code=start
public partial class Solution {
    // sort then find > O(n*n)
    public int KthSmallest(int[][] matrix, int k) {
        int colLength = matrix[0].Length;
        int[] pp = new int[matrix.Length];
        while (k > 0)
        {
            int minVal = int.MaxValue;
            int minValI = 0;
            for (int i = 0; i < matrix.Length; ++i)
            {
                var j = pp[i];
                if (j >= colLength)
                    continue;

                if (matrix[i][j] < minVal)
                {
                    minValI = i;
                    minVal = matrix[i][j];
                }
            }
            pp[minValI] += 1;
            k -= 1;

            if (k == 0)
            {
                return matrix[minValI][pp[minValI] - 1];
            }
        }

        return 0;
    }
}
// @lc code=end

