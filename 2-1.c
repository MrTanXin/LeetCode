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
    struct ListNode *it3;
    int carry = 0;

    while (it1 != NULL && it2 != NULL)
    {
        it3 = it1;
        it1->val += it2->val;

        it1->val += carry;
        carry = 0;
        if (it1->val / 10 != 0)
        {
            carry = it1->val / 10;
            it1->val = it1->val % 10;
        }

        it1 = it1->next;
        it2 = it2->next;
    }
    if (it1 == NULL && it2 != NULL)
    {
        it3->next = it2;
        it3 = it3->next;

        while (it3)
        {
            it3->val += carry;
            carry = 0;
            if (it3->val / 10)
            {
                carry = it3->val / 10;
                it3->val = it3->val % 10;
            }
            if (it3->next != NULL)
            {
                it3 = it3->next;
            }
            else
            {
                break;
            }
        }
    }
    else
    {
        while (it1)
        {
            it1->val+=carry;
            carry=0;
            if (it1->val/10)
            {
                carry = it1->val / 10;
                it1->val = it1->val % 10;
            }
            if (it1->next != NULL)
            {
                it1 = it1->next;
            }
            else
            {
                it3=it1;
                break;
            }
        }
        
        
    }
    

    if (carry != 0)
    {
        it3->next = malloc(sizeof(struct ListNode));
        it3 = it3->next;
        it3->next = NULL;
        it3->val = carry;
        carry = 0;
    }
    return l1;
}

int main()
{
    struct ListNode *l1 = malloc(sizeof(struct ListNode));
    struct ListNode *l2 = malloc(sizeof(struct ListNode));

    struct ListNode *it1 = l1;

    l2->val = 5;
    l2->next = NULL;

    it1->val = 9;
    it1->next = malloc(sizeof(struct ListNode));
    it1 = it1->next;
    it1->val = 9;
    it1->next = NULL;

    // it1->next = NULL;
    // it1->val = 5;

    addTwoNumbers(l1, l2);

    return 0;
}