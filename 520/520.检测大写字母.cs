/*
 * @lc app=leetcode.cn id=520 lang=csharp
 *
 * [520] 检测大写字母
 */

// @lc code=start
public class Solution {
    public bool DetectCapitalUse(string word) {
        
        if(word == word.ToLower() 
        || word == word.ToUpper() 
        || word == word.Substring(0,1).ToUpper() + word.Substring(1).ToLower()){
            return true;
        }

    }
}
// @lc code=end

