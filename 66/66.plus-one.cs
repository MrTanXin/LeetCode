/*
 * @lc app=leetcode id=66 lang=csharp
 *
 * [66] Plus One
 */

// @lc code=start
public class Solution
{
    public int[] PlusOne(int[] digits)
    {
        for (int i = digits.Length - 1; i >= 0; i--)
        {
            digits[i] += 1;
            if (digits[i] != 10)
                return digits;
            else
                digits[i] = 0;
            continue;
        }
        if (digits[0] == 0)
        {
            List<int> list = new List<int>(digits);
            list.Insert(0, 1);
            return list.ToArray();
        }
        return digits;
    }
}
// @lc code=end

