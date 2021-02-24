/*
 * @lc app=leetcode id=4 lang=csharp
 *
 * [4] Median of Two Sorted Arrays
 */

// @lc code=start

// using System;
// using System.Collections;
public class Solution
{
    public double FindMedianSortedArrays(int[] nums1, int[] nums2)
    {
        int total = nums1.Length + nums2.Length;
        int[] nums = new int[total];
        int it = 0;
        for (int i = 0; i < nums1.Length; i++)
        {
            nums[it++] = nums1[i];
        }
        for (int i = 0; i < nums2.Length; i++)
        {
            nums[it++] = nums2[i];
        }
        Array.Sort(nums);

        if (total % 2 == 1) return nums[total / 2];
        else return (nums[total / 2 - 1] + nums[total / 2]) / 2.0;
    }
}
// @lc code=end

