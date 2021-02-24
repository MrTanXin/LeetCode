/*
 * @lc app=leetcode id=67 lang=csharp
 *
 * [67] Add Binary
 */

// @lc code=start
// using System;
// using System.Collections;
public class Solution {
    public string AddBinary(string a, string b)
        {
            Stack<char> Sa = new Stack<char>(a);
            Stack<char> Sb = new Stack<char>(b);
            //char[] rtn = new char[Math.Max(a.Length,b.Length)+1];
            StringBuilder rtn = new StringBuilder();
            bool carry = false;

            while (Sa.Count != 0 || Sb.Count != 0 || carry != false)
            {
                int ia = (Sa.Count != 0) ? Sa.Pop() - '0' : 0;
                int ib = (Sb.Count != 0) ? Sb.Pop() - '0' : 0;

                char r = (char)((int)(ia + ib + (carry == false ? 0 : 1)) + '0');

                if (r > '1')
                {
                    r -= (char)2;
                    carry = true;
                }
                else
                {
                    carry = false;
                }

                rtn.Append(r);
            }
            String output = String.Concat(rtn.ToString().Reverse().AsEnumerable().Select(x => x).ToArray());
            return output;
        }
}
// @lc code=end

