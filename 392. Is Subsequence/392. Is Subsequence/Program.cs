using System;

internal class Solution
{
    /* Given two strings s and t, return true if s is a subsequence of t, or false otherwise.
     * 
     * A subsequence of a string is a new string that is formed from the original string by deleting some (can be none) of the characters without disturbing the relative positions of the remaining characters.
     * (i.e., "ace" is a subsequence of "abcde" while "aec" is not).
     */

    public bool IsSubsequence(string s, string t)
    {
        if (s == string.Empty) { return true; }
        // a new string to hold the the newly formed t string
        string comparerString = "";

        // loop through the t string
        // if the index if the letter if s == equals t we go throught the loop

        // if not we remove the character from t and decrement the loop by 1
        // to start the comparison and the whole operation again
        // till iteration through t is done
        for (int i = 0; i < t.Length; i++)
        {
            try
            {
                if (!s[i].Equals(t[i]))
                {
                    t = t.Remove(i, 1);
                    i--;
                    continue;
                }
            }
            // if the index is out of bounds the method returns
            catch
            {
                break;
            }

            // the matching character is added to the comparerer string
            comparerString += t[i];

            if (comparerString.Equals(s))
                return true;
        }

        // return is the s string excacly matches the t comparer string
        return false;
    }

    public static void Main(string[] args)
    {
        Solution solution = new Solution();

        // Example 1
        {
            // Input: s = "abc", t = "ahbgdc"
            // Output: true

            string s = "abc";
            string t = "ahbgdc";

            Helper.DisplayExample("s = \"abc\", t = \"ahbgdc\"", true.ToString());
            Console.WriteLine(solution.IsSubsequence(s: s, t: t));
        }
        Console.WriteLine(new string('-', 50));



        // Example 2
        {
            // Input: s = "axc", t = "ahbgdc"
            // Output: true

            string s = "axc";
            string t = "ahbgdc";

            Helper.DisplayExample("s = \"axc\", t = \"ahbgdc\"", false.ToString());
            Console.WriteLine(solution.IsSubsequence(s: s, t: t));
        }
        Console.WriteLine(new string('-', 50));



        // Example 2
        {
            // Input: s = "", t = "ahbgdc"
            // Output: true

            string s = "";
            string t = "ahbgdc";

            Helper.DisplayExample("s = \"\", t = \"ahbgdc\"", false.ToString());
            Console.WriteLine(solution.IsSubsequence(s: s, t: t));
        }
        Console.WriteLine(new string('-', 50));
    }
}