/*
 * @lc app=leetcode id=8 lang=csharp
 *
 * [8] String to Integer (atoi)
 */

// @lc code=start
using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using System.Numerics;

public class Solution
{
    public int MyAtoi(string str)
    {
        StringBuilder s = new StringBuilder();
        BigInteger number = 0;
        string Trimstr = str.Trim();

        foreach (var item in Trimstr)
        {
            if (char.IsDigit(item) || ((item == '-' || item == '+') && number == 0))
            {
                s.Append(item);
                number++;
            }
            else break;
        }


        number = 0;
        BigInteger.TryParse(s.ToString(), out number);

        if (number > int.MaxValue)
        {
            return int.MaxValue;
        }

        if (number < int.MinValue)
            return int.MinValue;

        return (int)number;
    }
    // public static void Main()
    // {
    //     int i = new Solution().MyAtoi("-5-");
    // }
}


// @lc code=end

