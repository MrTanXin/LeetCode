using System.Collections.Generic;

using System;
/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution
{

    private List<int> list = new List<int>();
    private Random random = new Random();


    public Solution(ListNode head)
    {
        while (head != null)
        {
            list.Add(head.val);
            head = head.next;
        }
    }

    public int GetRandom()
    {
        return list[random.Next(list.Count)];
    }
}

/**
 * Your Solution object will be instantiated and called as such:
 * Solution obj = new Solution(head);
 * int param_1 = obj.GetRandom();
 */