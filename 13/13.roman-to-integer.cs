/*
 * @lc app=leetcode id=13 lang=csharp
 *
 * [13] Roman to Integer
 */

// @lc code=start
public class Solution
{
    public int RomanToInt(string s)
    {

        string val = s
        .Replace("IV", "Q")  //Q --> 4
        .Replace("IX", "W")  //W --> 9
        .Replace("XL", "E")  //E --> 40
        .Replace("XC", "R")  //R --> 90
        .Replace("CD", "T")  //T --> 400
        .Replace("CM", "Y"); //Y --> 900 

        int sum = 0;

        foreach (var item in val)
        {
            switch (item)
            {
                case 'M':
                    sum += 1000;
                    break;
                case 'D':
                    sum += 500;
                    break;
                case 'C':
                    sum += 100;
                    break;
                case 'L':
                    sum += 50;
                    break;
                case 'X':
                    sum += 10;
                    break;
                case 'V':
                    sum += 5;
                    break;
                case 'I':
                    sum += 1;
                    break;

                case 'Q':
                    sum += 4;
                    break;
                case 'W':
                    sum += 9;
                    break;
                case 'E':
                    sum += 40;
                    break;
                case 'R':
                    sum += 90;
                    break;
                case 'T':
                    sum += 400;
                    break;
                case 'Y':
                    sum += 900;
                    break;
                default:
                    sum += 0;
                    break;
            }
        }
        return sum;
    }


}
// @lc code=end

