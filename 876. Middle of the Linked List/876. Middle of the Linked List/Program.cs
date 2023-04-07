using System;
using System.Reflection;
using System.Xml.Linq;


// Definition for singly-linked list.
public class ListNode
{
    public int val;
    public ListNode next;
    
    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
}

class Solutions
{
    // Given the head of a singly linked list, return the middle node of the linked list.

    // If there are two middle nodes, return the second middle node.

    public ListNode MiddleNode(ListNode head)
    {
        //
        return head;
    }

    public ListNode CreateLinkedList(int? value, int[]? head = null)
    {
        ListNode linkedList = new ListNode();
        linkedList.val = head[0];

        for (int i  = 1; i < head.Length; i++)
        {
            linkedList.next = new ListNode();

        }
    }

    public static void Main(string[] args)
    {
        // Example 1
        {
            /*Input: head = [1,2,3,4,5]
             * Output: [3,4,5]
             * Explanation: The middle node of the list is node 3.
             */
            int[] head = { 1, 2, 3, 4, 5 };
            foreach (int i in head)
            {
                ListNode linkedList = new ListNode(i, );
            }


        }



        // Example 2
        {
            /*Input: head = [1,2,3,4,5,6]
             * Output: [4,5,6]
             * Explanation: Since the list has two middle nodes with values 3 and 4, we return the second one.
             */
        }
    }
}