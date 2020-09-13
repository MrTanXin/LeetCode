/*
 * @lc app=leetcode id=21 lang=c
 *
 * [21] Merge Two Sorted Lists
 */

// @lc code=start

// Definition for singly-linked list.
// #include <malloc.h>
// struct ListNode
// {
//     int val;
//     struct ListNode *next;
// };

struct ListNode *mergeTwoLists(struct ListNode *l1, struct ListNode *l2)
{
    if (l1==NULL&&l2==NULL)
    {
        return NULL;
    }
    
    struct ListNode *it1 = l1;
    struct ListNode *it2 = l2;
    struct ListNode l3;
    struct ListNode *it3 = &l3;
    while (it1 && it2)
    {
        if (it1->val < it2->val)
        {
            it3->next = it1;
            it1 = it1->next;
            it3 = it3->next;
        }
        else
        {
            it3->next = it2;
            it2 = it2->next;
            it3 = it3->next;
        }
    }

    if (it1)
    {
        it3->next = it1;
    }
    if (it2)
    {
        it3->next = it2;
    }
    return l3.next;
}
// @lc code=end
