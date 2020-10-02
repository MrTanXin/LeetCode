#include "stdio.h"
#include "malloc.h"

struct ListNode
{
    int val;
    struct ListNode *next;
};

struct ListNode *addTwoNumbers(struct ListNode *l1, struct ListNode *l2)
{
    struct ListNode *it1 = l1;
    struct ListNode *it2 = l2;
    int carry = 0;

    while (it1 != NULL && it2 != NULL)
    {
        it1->val += it2->val;
        it1 = it1->next;
        it2 = it2->next;
    }
    if (it1 == NULL && it2!=NULL)
    {
        it1->next = it2;
    }
    it1 = l1;
    while (it1)
    {
        it1->val += carry;
        carry = 0;
        if (it1->val / 10 != 0)
        {
            carry = it1->val / 10;
            it1->val = it1->val % 10;
        }
        it1 = it1->next
    }
    if (carry!=0)
    {
        it1 = malloc(sizeof(struct ListNode));
        it1->next=NULL;
        it1->val=carry;
        carry=0;
    }
    return l1;
}