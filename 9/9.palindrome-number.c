/*
 * @lc app=leetcode id=9 lang=c
 *
 * [9] Palindrome Number
 */

// @lc code=start


bool isPalindrome(int x){
    if (x==0)
    {
        return true;
    }    
    if(x<0||x%10==0)
        return false;
    long long newNumber = 0;
    int src = x;
    while(x!=0)
    {
        newNumber=newNumber*10+x%10;
        x/=10;
    }
    if (src==newNumber)
    {
        return true;
    }
    return false;
    
}
// @lc code=end

