/*
 * @lc app=leetcode.cn id=110 lang=csharp
 *
 * [110] 平衡二叉树
 */

// @lc code=start
/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution
{
    public int[] deep = new int[2]{0,0};
    public bool IsBalanced(TreeNode root)
    {
        if(root==null) return true;

        if (root.left != null)
        {
            ResloveDeep(root.left, true,1);
        }

        if (root.right != null)
        {
            ResloveDeep(root.right, false,1);
        }
        
        int rtn =  deep[0] - deep[1];
        if (rtn < 2 && rtn > -2)
        {
            return true;
        }

        return false;
    }

    public void ResloveDeep(TreeNode root,bool IsLeft,int d)
    {
        if (root==null)
        {
            return;
        }

        if (IsLeft)
        {
            deep[0] = deep[0] > d ? deep[0] : d;
        }
        else
        {
            deep[1] = deep[1] > d ? deep[1] : d;
        }

        ResloveDeep(root.left, IsLeft, d + 1);
        ResloveDeep(root.right, IsLeft, d + 1);
    }
}
// @lc code=end

