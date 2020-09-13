/*
 * @lc app=leetcode id=20 lang=csharp
 *
 * [20] Valid Parentheses
 */

// @lc code=start
using System;
using System.Text;
using System.Collections;
public class Solution
{
    public bool IsValid(string s)
    {
        Stack stack = new Stack();
        foreach (var item in s)
        {
            switch (item)
            {
                case '(':
                    stack.Push(')');
                    break;
                case '[':
                    stack.Push(']');
                    break;
                case '{':
                    stack.Push('}');
                    break;

                default:
                    if (stack.Count==0||(Char)stack.Pop()!=item)
                        return false;
                    break;
            }

        }
        if(stack.Count!=0)
            return false;
        return true;
    }
}

// @lc code=end

