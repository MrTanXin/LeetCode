/*
 * @lc app=leetcode id=83 lang=c
 *
 * [83] Remove Duplicates from Sorted List
 */

// @lc code=start

// Definition for singly-linked list.
// #include <stdio.h>

// struct ListNode {
//     int val;
//     struct ListNode *next;
// };



struct ListNode* deleteDuplicates(struct ListNode* head){
    if (!head)
    {
        return head;
    }
    
    struct ListNode *iterator = head->next , *iteratorFront = head;
    
    while (iterator)
    {
        if (iteratorFront->val == iterator->val)
        {
            iteratorFront->next = iterator->next;
            free(iterator);
            iterator = iteratorFront->next;
        }
        else
        {
            iteratorFront = iterator;
            iterator = iterator->next;
        }
    }
    return head;
}
// @lc code=end

