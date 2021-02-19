/*
 * @lc app=leetcode id=83 lang=c
 *
 * [83] Remove Duplicates from Sorted List
 */

// @lc code=start

// Definition for singly-linked list.
#include <stdio.h>

struct ListNode {
    int val;
    struct ListNode *next;
};



struct ListNode* deleteDuplicates(struct ListNode* head){
    if (head==NULL)
    {
        return NULL;
    }
    struct ListNode *p = head, *nf = NULL, *n = head;
    while (n!=0)
    {
        nf = n;
        
        
    }
    
}
// @lc code=end

