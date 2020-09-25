/*
 * @lc app=leetcode id=5 lang=c
 *
 * [5] Longest Palindromic Substring
 */

// @lc code=start
#include <string.h>

int IsPalindromic(char *s, int f, int b)
{
    if (strlen(s) == 0)
    {
        return "";
    }

    for (int i = 0; i <= (b - f) / 2; i++)
    {
        if (s[f + i] == s[b - i])
        {
            continue;
        }
        else
        {
            return 0;
        }
    }
    return 1;
}

char *longestPalindrome(char *s)
{
    char longstr[1050] = {'\0'};
    int len = strlen(s);
    for (int front = 0; front < len; front++)
    {
        for (int rare = len - 1; rare >= front; rare--)
        {
            if (rare-front+1<strlen(longstr))
            {
                break;
            }
            
            if (s[front] == s[rare])
            {
                if (IsPalindromic(s, front, rare) == 1 && strlen(longstr) < rare - front + 1)
                {
                    strncpy(longstr, s + front, rare - front + 1);
                }
            }
            else
            {
                continue;
            }
        }
    }
    const char *p = longstr;
    return p;
}


int main()
{
    char s[1000] = {'\0'};
    strcpy(s, longestPalindrome("aaaabbbbbbbbbbccccccccccddddddddddeeeeeeeeeeffffffffffgggggggggghhhhhhhhhhiiiiiiiiiijjjjjjjjjjkkkkkkkkkkllllllllllmmmmmmmmmmnnnnnnnnnnooooooooooppppppppppqqqqqqqqqqrrrrrrrrrrssssssssssttttttttttuuuuuuuuuuvvvvvvvvvvwwwwwwwwwwxxxxxxxxxxyyyyyyyyyyzzzzzzzzzzyyyyyyyyyyxxxxxxxxxxwwwwwwwwwwvvvvvvvvvvuuuuuuuuuuttttttttttssssssssssrrrrrrrrrrqqqqqqqqqqppppppppppoooooooooonnnnnnnnnnmmmmmmmmmmllllllllllkkkkkkkkkkjjjjjjjjjjiiiiiiiiiihhhhhhhhhhggggggggggffffffffffeeeeeeeeeeddddddddddccccccccccbbbbbbbbbbaaaaaaaabbbbbbbbbbccccccccccddddddddddeeeeeeeeeeffffffffffgggggggggghhhhhhhhhhiiiiiiiiiijjjjjjjjjjkkkkkkkkkkllllllllllmmmmmmmmmmnnnnnnnnnnooooooooooppppppppppqqqqqqqqqqrrrrrrrrrrssssssssssttttttttttuuuuuuuuuuvvvvvvvvvvwwwwwwwwwwxxxxxxxxxxyyyyyyyyyyzzzzzzzzzzyyyyyyyyyyxxxxxxxxxxwwwwwwwwwwvvvvvvvvvvuuuuuuuuuuttttttttttssssssssssrrrrrrrrrrqqqqqqqqqqppppppppppoooooooooonnnnnnnnnnmmmmmmmmmmllllllllllkkkkkkkkkkjjjjjjjjjjiiiiiiiiiihhhhhhhhhhggggggggggffffffffffeeeeeeeeeeddddddddddccccccccccbbbbbbbbbbaaaa"));
    return 0;
}

// @lc code=end
