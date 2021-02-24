/*
 * @lc app=leetcode id=70 lang=c
 *
 * [70] Climbing Stairs
 */

// @lc code=start


int climbStairs(int n){
    static int num[46] = {0, 1, 2};
    if (num[n]!=0)
    {
        return num[n];
    }
    else
    {
        num[n] = climbStairs(n - 1) + climbStairs(n - 2);
        return num[n];
    }
}
// @lc code=end

