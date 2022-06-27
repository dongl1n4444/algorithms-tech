/*
 * @lc app=leetcode id=4 lang=csharp
 *
 * [4] Median of Two Sorted Arrays
 */

// @lc code=start
using System;
using System.Diagnostics;

public partial class Solution {
    // public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
    //     int[] nums3 = new int[nums1.Length + nums2.Length];
    //     for (int i = 0; i < nums1.Length; ++i)
    //     {
    //         nums3[i] = nums1[i];
    //     }
    //     int curNums3Length = nums1.Length;
    //     int nums3Length = nums1.Length + nums2.Length;

    //     // insert nums2 to nums3
    //     if (nums1.Length == 0)
    //     {
    //         for (int i = 0; i < nums2.Length; ++i)
    //         {
    //             nums3[i] = nums2[i];
    //         }
    //     }
    //     else
    //     {
    //         for (int i = 0; i < nums2.Length; ++i)
    //         {
    //             var num = nums2[i];
                
    //             int beginIdx = 0;
    //             int endIdx = curNums3Length;

    //             while (beginIdx < endIdx)
    //             {
    //                 int midIdx = (beginIdx + endIdx) / 2;
    //                 var midVal = nums3[midIdx];
    //                 if (num < midVal)
    //                 {
    //                     endIdx = midIdx;
    //                 }
    //                 else if (num > midVal)
    //                 {
    //                     beginIdx = midIdx + 1;
    //                 }
    //                 else
    //                 {
    //                     for (int j = nums3Length - 1; j >= midIdx && j > 0; --j)
    //                     {
    //                         nums3[j] = nums3[j - 1];
    //                     }
    //                     nums3[midIdx] = num;
    //                     break;
    //                 }

    //                 // Debug.WriteLine($"xx-- beginIdx {beginIdx}, endIdx {endIdx}, midIdx {midIdx}");
    //                 if (beginIdx >= endIdx)
    //                 {
    //                     for (int j = nums3Length - 1; j > beginIdx && j > 0; --j)
    //                     {
    //                         nums3[j] = nums3[j - 1];
    //                     }
    //                     nums3[beginIdx] = num;
    //                     break;
    //                 }
    //             }

    //             // insert
    //             curNums3Length += 1;
    //         }
    //     }

    //     // print array
    //     // Debug.WriteLine("xx-- num3 > " + leetcode.Program.ArrayToString(nums3));

    //     // result
    //     int half = nums3Length / 2;
    //     if (nums3Length % 2 == 0)
    //         return (nums3[half - 1] + nums3[half]) * 0.5f;
    //     else
    //         return nums3[half];
    // }

    // O(m+n)
    // public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
    //     int[] nums3 = new int[nums1.Length + nums2.Length];

    //     int i = 0;
    //     int j = 0;
    //     int idx = 0;
    //     while (i < nums1.Length && j < nums2.Length)
    //     {
    //         if (nums1[i] < nums2[j])
    //             nums3[idx++] = nums1[i++];
    //         else
    //             nums3[idx++] = nums2[j++];
    //     }
    //     while (i < nums1.Length)
    //     {
    //         nums3[idx++] = nums1[i++];
    //     }
    //     while (j < nums2.Length)
    //     {
    //         nums3[idx++] = nums2[j++];
    //     }

    //     // print array
    //     // Debug.WriteLine("xx-- num3 > " + leetcode.Program.ArrayToString(nums3));

    //     // result
    //     int half = nums3.Length / 2;
    //     if (nums3.Length % 2 == 0)
    //         return (nums3[half - 1] + nums3[half]) * 0.5f;
    //     else
    //         return nums3[half];
    // }

    // https://leetcode.cn/problems/median-of-two-sorted-arrays/solution/xun-zhao-liang-ge-you-xu-shu-zu-de-zhong-wei-s-114/
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        int m = nums1.Length;
        int n = nums2.Length;
        int length = m + n;
        if (length % 2 == 1)
        {
            return FinkKTh(nums1, nums2, length / 2 + 1);
        }
        else
        {
            return (FinkKTh(nums1, nums2, length / 2) + FinkKTh(nums1, nums2, length / 2 + 1)) * 0.5f;
        }
    }

    /* 主要思路：要找到第 k (k>1) 小的元素，那么就取 pivot1 = nums1[k/2-1] 和 pivot2 = nums2[k/2-1] 进行比较
     * 这里的 "/" 表示整除
     * nums1 中小于等于 pivot1 的元素有 nums1[0 .. k/2-2] 共计 k/2-1 个
     * nums2 中小于等于 pivot2 的元素有 nums2[0 .. k/2-2] 共计 k/2-1 个
     * 取 pivot = min(pivot1, pivot2)，两个数组中小于等于 pivot 的元素共计不会超过 (k/2-1) + (k/2-1) <= k-2 个
     * 这样 pivot 本身最大也只能是第 k-1 小的元素
     * 如果 pivot = pivot1，那么 nums1[0 .. k/2-1] 都不可能是第 k 小的元素。把这些元素全部 "删除"，剩下的作为新的 nums1 数组
     * 如果 pivot = pivot2，那么 nums2[0 .. k/2-1] 都不可能是第 k 小的元素。把这些元素全部 "删除"，剩下的作为新的 nums2 数组
     * 由于我们 "删除" 了一些元素（这些元素都比第 k 小的元素要小），因此需要修改 k 的值，减去删除的数的个数
    */
    public int FinkKTh(int[] nums1, int[] nums2, int k) {
        
        int length1 = nums1.Length;
        int length2 = nums2.Length;
        int index1 = 0;
        int index2 = 0;
        
        while (true)
        {
            if (index1 == length1)
                return nums2[index2 + k - 1];
            if (index2 == length2)
                return nums1[index1 + k - 1];
            if (k == 1)
                return Math.Min(nums1[index1], nums2[index2]);
            
            int half = k / 2;
            int nindex1 = Math.Min(index1 + half, length1) - 1;
            int nindex2 = Math.Min(index2 + half, length2) - 1;
            if (nums1[nindex1] <= nums2[nindex2])
            {
                k -= (nindex1 - index1 + 1);
                index1 = nindex1 + 1;
            }
            else
            {
                k -= (nindex2 - index2 + 1);
                index2 = nindex2 + 1;
            }
        }
    }
}
// @lc code=end

