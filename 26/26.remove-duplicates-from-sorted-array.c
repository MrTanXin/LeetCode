/*
 * @lc app=leetcode id=26 lang=c
 *
 * [26] Remove Duplicates from Sorted Array
 */

// @lc code=start

int removeDuplicates(int *nums, int numsSize)
{
    if (numsSize == 0)
    {
        return 0;
    }
    int it = 0;
    int c = nums[it];
    for (int i = 0; i < numsSize; i++)
    {
        if (c == nums[i])
        {
        }
        else
        {
            it++;
            c = nums[it] = nums[i];
        }
    }
    return it + 1;
}
// @lc code=end
