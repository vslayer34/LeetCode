using System;

internal class Solution
{
    // Given a string s containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.

    // An input string is valid if:
    // Open brackets must be closed by the same type of brackets.
    // Open brackets must be closed in the correct order.
    // Every close bracket has a corresponding open bracket of the same type.

    public bool IsValid(string s)
    {
        // if the string length is odd then there can not be any matching brackets
        if (s.Length % 2 != 0)
            return false;

        // list of the brackets
        List<char> openBrackets = new List<char>() { '(', '{', '[' };
        List<char> closedBrackets = new List<char>() { ')', '}', ']' };

        // number of matching open and closed brackets in the loop
        int numMatchingOpenBrackets = 0;
        int numMatchingClosedBrackets = 0;

        // List of index of the open brackets in the list so if the next closed bracket matchs it
        // it's the same closing bracket
        // it's a list so if we have something like this: {[]}
        // we check the last index in the list for matching position
        // then we remove it so we get the position of the next bracket
        List<int> indexOpen = new List<int>();

        foreach (char c in s)
        {
            if (openBrackets.Contains(c))
            {
                // increment the number of opening brackets
                // and get the index of it in the list
                numMatchingOpenBrackets++;
                indexOpen.Add(openBrackets.IndexOf(c));
                continue;
            }

            // if count of indexOpen is zero then the starting bracket was closed
            if (indexOpen.Count == 0)
                return false;

            // checks if the closing bracket matchs the previouse opening bracket
            // before incrementing the matching closing bracket number
            if (closedBrackets.Contains(c) && closedBrackets.IndexOf(c) == indexOpen.Last())
            {
                numMatchingClosedBrackets++;
                //indexOpen.RemoveAt(indexOpen.Count - 1);
            }

            indexOpen.RemoveAt(indexOpen.Count - 1);
        }

        return numMatchingClosedBrackets == numMatchingOpenBrackets;
    }

    public static void Main(string[] args)
    {
        Solution solution = new Solution();

        // Example 1
        {
            // Input: s = "()"
            string s = "()";
            
            Helper.DisplayExample("Input: s = \"()\"", "True");
            Console.WriteLine(solution.IsValid(s));
        }
        Console.WriteLine(new string('-', 100));



        // Example 2
        {
            // Input: s = "()[]{}"
            string s = "()[]{}";

            Helper.DisplayExample("Input: s = \"()[]{}\"", "True");
            Console.WriteLine(solution.IsValid(s));
        }
        Console.WriteLine(new string('-', 100));

        

        // Example 3
        {
            // Input: s = "(]"
            string s = "(]";

            Helper.DisplayExample("Input: s = \"(]\"", "False");
            Console.WriteLine(solution.IsValid(s));
        }
        Console.WriteLine(new string('-', 100));



        // Example 3
        {
            // Input: s = "{[]}"
            string s = "{[]}";

            Helper.DisplayExample("Input: s = \"{[]}\"", "True");
            Console.WriteLine(solution.IsValid(s));
        }
        Console.WriteLine(new string('-', 100));
    }
}