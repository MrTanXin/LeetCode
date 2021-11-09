/*
 * @lc app=leetcode.cn id=3 lang=csharp
 *
 * [3] 无重复字符的最长子串
 */

// @lc code=start
public class Solution
{
    public int LengthOfLongestSubstring(string s)
    {
        if (s.Length == 0) return 0;
        if (s.Length == 1) return 1;

        int max = -1;

        for (int i = 0; i < s.Length; i++) // 开始位置
        {
            for (int j = max + 1; j <= s.Length - i; j++) // 窗口长度
            {
                var len = s.Substring(i, j).ToHashSet().Count();
                if (len == max + 1)
                {
                    max++;
                }
                else
                {
                    break;
                }

            }
        }

        return max;
    }
}
// @lc code=end

