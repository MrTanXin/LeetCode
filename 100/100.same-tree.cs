/*
 * @lc app=leetcode id=100 lang=csharp
 *
 * [100] Same Tree
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

// using System;
// using System.Collections.Generic;
// using System.Reflection.Metadata.Ecma335;
// using System.Runtime.InteropServices.ComTypes;

public class Solution
{
    public bool IsSameTree(TreeNode p, TreeNode q)
    {
        if (p == null && q == null)
        {
            return true;
        }

        if ((p == null && q != null) || (p != null && q == null))
        {
            return false;
        }

        return IsSameTree(p.left,q.left)&&IsSameTree(p.right,q.right);
        
    }
}
// @lc code=end

