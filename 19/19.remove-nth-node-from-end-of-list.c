/*
 * @lc app=leetcode id=19 lang=c
 *
 * [19] Remove Nth Node From End of List
 */

// @lc code=start
#include "stdio.h"
#include "malloc.h"
// Definition for singly-linked list.
struct ListNode
{
    int val;
    struct ListNode *next;
};

struct ListNode *removeNthFromEnd(struct ListNode *head, int n)
{
    struct ListNode *front = head;
    struct ListNode *behind = head;

    while (front != NULL)
    {
        front = front->next;

        if (n-- < 0)
            behind = behind->next;
    }
    if (n == 0)
        head = head->next;
    else
        behind->next = behind->next->next;
    return head;
}

int main()
{
    struct ListNode *head = (struct ListNode *)malloc(sizeof(struct ListNode));
    head->val = 1;
    head->next = (struct ListNode *)malloc(sizeof(struct ListNode));
    head->next->val = 2;
    head->next->next = (struct ListNode *)malloc(sizeof(struct ListNode));
    head->next->next->val = 3;
    head->next->next->next = (struct ListNode *)malloc(sizeof(struct ListNode));
    head->next->next->next->val = 4;
    head->next->next->next->next = (struct ListNode *)malloc(sizeof(struct ListNode));
    head->next->next->next->next->val = 5;
    head->next->next->next->next->next = (struct ListNode *)malloc(sizeof(struct ListNode));
    head->next->next->next->next->next->val = 6;
    head->next->next->next->next->next->next = NULL;

    removeNthFromEnd(head, 2);

    return 0;
}
// @lc code=end
