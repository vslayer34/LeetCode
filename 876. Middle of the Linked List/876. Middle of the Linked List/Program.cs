using System;
using System.Reflection;
using System.Text;
using System.Xml.Linq;


// Definition for singly-linked list.
public class ListNode
{
    ListNode head;
    public int val;
    public ListNode? next;
    
    public ListNode(int val = 0, ListNode? next = null)
    {
        this.val = val;
        this.next = next;
    }

}

public class SingleLinkedList
{
    public ListNode? head;
    
    public void InsertLast(int data)
    {
        // if there is no node
        // create a new node and assign to the head
        if (head == null)
        {
            head = new ListNode(data);
        }
        else
        {
            // create new node and assign the data to it
            ListNode newNode = new ListNode(data);

            // create and node to see which node we are in
            // initialize it at first with the head node
            ListNode currentNode = head;
            
            // loop through the nodes untill we get the last node
            while (currentNode.next != null)
            {
                currentNode = currentNode.next;
            }

            // assign the new node to the last node that had no node next 
            currentNode.next = newNode;
        }
    }

    public string PrintLinkedList()
    {
        if (head == null) { return "Empty linked list"; }
        
        ListNode? currentNode = head;
        StringBuilder sb = new StringBuilder();
        
        while (currentNode != null)
        {
            sb.Append(currentNode.val + " => ");
            currentNode = currentNode.next;
        }
        // remove the last "=> "
        sb.Remove(sb.Length - 1 - 3, 3);

        return sb.ToString();
    }
}

class Solution
{
    // Given the head of a singly linked list, return the middle node of the linked list.

    // If there are two middle nodes, return the second middle node.

    public ListNode MiddleNode(ListNode head)
    {
        int listLength = 0;
        ListNode newNode = head;

        while (head != null)
        {
            listLength++;
            head = head.next;
        }

        int halfLength = listLength /= 2;

        int newIndex = 0;
        while ( newIndex < halfLength )
        {
            // iterate through the linked list untill we finish the loop
            // then we return the linked list from the point the loop stoped at
            newNode = newNode.next;
            newIndex++;
        }

        return newNode;
    }

    public string PrintNodes(ListNode head)
    {
        StringBuilder sb = new StringBuilder();

        while (head != null)
        {
            sb.Append(head.val + " => ");
            head = head.next;
        }

        sb.Remove(sb.Length - 1 - 3, 3);

        return sb.ToString();
    }

    public static void Main(string[] args)
    {
        Solution solution = new Solution();
        // Example 1
        {
            SingleLinkedList singleLinkedList = new SingleLinkedList();
            var outputList = new SingleLinkedList();
            /*Input: head = [1,2,3,4,5]
             * Output: [3,4,5]
             * Explanation: The middle node of the list is node 3.
             */
            int[] head = { 1, 2, 3, 4, 5 };
            foreach (int i in head)
            {
                singleLinkedList.InsertLast(i);
            }

            int[] output = { 3, 4, 5 };
            foreach (int i in output)
            {
                outputList.InsertLast(i);
            }

            Helper.DisplayExample(singleLinkedList.PrintLinkedList(),
                                  outputList.PrintLinkedList());
            Console.WriteLine(solution.PrintNodes(solution.MiddleNode(singleLinkedList.head)));
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