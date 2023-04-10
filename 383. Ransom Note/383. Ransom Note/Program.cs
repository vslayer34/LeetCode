using System;

internal class Solution
{
    // Given two strings ransomNote and magazine, return true if ransomNote can be constructed by using the letters from magazine and false otherwise.

    // Each letter in magazine can only be used once in ransomNote.


    public bool CanConstruct(string ransomNote, string magazine)
    {
        Dictionary<char, int> magazineLetters = new Dictionary<char, int>();
        foreach (char c in magazine)
        {
            if (magazineLetters.ContainsKey(c))
            {
                magazineLetters[c]++;
            }
            else
            {
                magazineLetters.Add(c, 1);
            }
        }

        foreach (char c in ransomNote)
        {
            if (!magazineLetters.ContainsKey(c) || magazineLetters[c] == 0)
            {
                return false;
            }
            else
            {
                magazineLetters[c]--;
            }
        }

        return true;
    }


    public static void Main(string[] args)
    {
        Solution solution = new Solution();
        // Example 1
        {
            // Input: ransomNote = "a", magazine = "b"
            Helper.DisplayExample("Input: ransomNote = \"a\", magazine = \"b\"", "False");

            string ransomNote = "a";
            string magazine = "b";
            
            Console.WriteLine(solution.CanConstruct(ransomNote, magazine));
        }
        Console.WriteLine(new string('-', 100));


        // Example 2
        {
            // ransomNote = "aa", magazine = "ab"
            Helper.DisplayExample("ransomNote = \"aa\", magazine = \"ab\"", "False");

            string ransomNote = "aa";
            string magazine = "ab";

            Console.WriteLine(solution.CanConstruct(ransomNote, magazine));
        }
        Console.WriteLine(new string('-', 100));


        // Example 1
        {
            // ransomNote = "aa", magazine = "aab"
            Helper.DisplayExample("ransomNote = \"aa\", magazine = \"aab\"", "True");

            string ransomNote = "aa";
            string magazine = "aab";

            Console.WriteLine(solution.CanConstruct(ransomNote, magazine));
        }
        Console.WriteLine(new string('-', 100));
    }
}