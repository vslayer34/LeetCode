namespace MergeTwoSortedListsApp;
class Program
{
    private static void Main(string[] args)
    {
        ListNode list1;
        ListNode list2;
        // Example 1
        // Input: list1 = [1,2,4], list2 = [1,3,4]
        // Output: [1,1,2,3,4,4]
        {
            list1 = new(1, new(2, new(4)));
            list2 = new ListNode(1, new(3, new(4)));

            MergeTwoLists(list1, list2);
        }
    }

    public static ListNode MergeTwoLists(ListNode list1, ListNode list2)
    {
        ListNode newList = new();
        
        
        throw new NotImplementedException();
    }
}



class ListNode
{
    public int val;
    public ListNode? next;

    public ListNode(int val = 0, ListNode? next = null)
    {
        this.val = val;
        this.next = next;
    }
}