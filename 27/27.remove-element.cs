/*
 * @lc app=leetcode id=27 lang=csharp
 *
 * [27] Remove Element
 */

// @lc code=start
public class Solution
{
    public int RemoveElement(int[] nums, int val)
    {
        int it = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] != val)
            {
                nums[it++] = nums[i];
            }

        }
        return it;
    }


}
// @lc code=end

