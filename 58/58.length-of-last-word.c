/*
 * @lc app=leetcode id=58 lang=c
 *
 * [58] Length of Last Word
 */

// @lc code=start


int lengthOfLastWord(char * s){
    int count = 0;
    for (int i = strlen(s)-1; i >= 0; i--)
    {
        if (s[i]!=' ')
        {
            count++;
        }
        else if (s[i]==' ' && count==0)
        {
            continue;
        }else
        {
            return count;
        }
    }
    return count;
}
// @lc code=end

