/*
 * @lc app=leetcode id=14 lang=csharp
 *
 * [14] Longest Common Prefix
 */

// @lc code=start

// using System.Text;
// using System.Collections;
// using System;
public class Solution
{
    public string LongestCommonPrefix(string[] strs)
    {
        if (strs.Length == 0)
            return "";
        if (strs.Length == 1)
            return strs[0];

        StringBuilder stringBuilder = new StringBuilder();
        for (int i = 0; i < strs[0].Length; i++)
        {
            stringBuilder.Append(strs[0][i]);
            for (int j = 1; j < strs.Length; j++)
            {
                if(!strs[j].StartsWith(stringBuilder.ToString()))
                    return stringBuilder.Remove(stringBuilder.Length - 1, 1).ToString();
            }
        }
        return stringBuilder.ToString();
    }
}

// @lc code=end

