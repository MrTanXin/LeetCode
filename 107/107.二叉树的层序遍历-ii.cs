/*
 * @lc app=leetcode.cn id=107 lang=csharp
 *
 * [107] 二叉树的层序遍历 II
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

public class Solution
{
    public IList<IList<int>> LevelOrderBottom(TreeNode root)
    {
        List<IList<int>> rtn = new List<IList<int>>();
        dfs(root,0,rtn);
        return rtn;
    }

    public void dfs(TreeNode root, int deep, List<IList<int>> rtn)
    {
        if (root==null)
        {
            return;
        }

        if (deep==rtn.Count)
        {
            rtn.Insert(0,new List<int>());
        }
        
        rtn[rtn.Count - 1 - deep].Add(root.val);
        dfs(root.left,deep+1,rtn);
        dfs(root.right,deep+1,rtn);
    }
}
// @lc code=end

