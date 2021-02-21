/*
 * @lc app=leetcode.cn id=104 lang=csharp
 *
 * [104] 二叉树的最大深度
 */

// @lc code=start
/**
 * Definition for a binary tree node.
 */
//  public class TreeNode {
//      public int val;
//      public TreeNode left;
//      public TreeNode right;
//      public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
//          this.val = val;
//          this.left = left;
//          this.right = right;
//      }
//  }
public class Solution {
    int max=1;
    public int MaxDepth(TreeNode root) {
        if(root==null)
            return 0;
        visit(root, 1);
        return max;
    }

    public void visit(TreeNode root,int nowdeep)
    {
        if(root==null)
            return;
        max = nowdeep > max ? nowdeep : max;

        visit(root.left, nowdeep + 1);
        visit(root.right, nowdeep + 1);
    }
}
// @lc code=end

