/*
 * @lc app=leetcode id=53 lang=c
 *
 * [53] Maximum Subarray
 */

// @lc code=start


int maxSubArray(int* nums, int numsSize){
    int sum = 0;
    int max = INT_MIN;
    for(int i = 0; i < numsSize; i++)
    {
        sum = (sum >= 0) ? sum + nums[i] : nums[i];
        max = sum > max ? sum : max;
    }
    return max;
}
// @lc code=end

