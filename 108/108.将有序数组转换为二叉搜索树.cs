/*
 * @lc app=leetcode.cn id=108 lang=csharp
 *
 * [108] 将有序数组转换为二叉搜索树
 */

// @lc code=start
/**
 Definition for a binary tree node.
*/
// public class TreeNode
// {
//     public int val;
//     public TreeNode left;
//     public TreeNode right;
//     public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
//     {
//         this.val = val;
//         this.left = left;
//         this.right = right;
//     }
// }

public class Solution
{
    public TreeNode SortedArrayToBST(int[] nums)
    {
        return ToTree(nums, 0, nums.Length-1);
    }
    public TreeNode ToTree(int[] nums, int min, int max)
    {
          if(min>max) return null;
        int mid = (min + max) / 2;
        TreeNode t = new TreeNode(nums[mid]);
        t.left = ToTree(nums, min, mid - 1);
        t.right = ToTree(nums, mid + 1, max);
        return t;
    }
}
// @lc code=end

