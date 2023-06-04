using System;

internal class Solution
{
    public string LongestCommonPrefix(string[] strs)
    {
        string longestCommonPrefix = string.Empty;
        string comparingString = string.Empty;

        // Get the shortest noun in the array
        string leastNounInLength = strs.FirstOrDefault(x => x.Length == strs.Min(y => y.Length));

        for (int i = 0; i < leastNounInLength.Length; i++)
        {
            // add the letter to compare with the rest of the nouns in the array
            comparingString += leastNounInLength[i];

            // 
            foreach (string noun in strs)
            {
                // if it fails to find the letters in the noun it
                // the comparing string clears itself
                // and copy the last value to longestCommonPrefix
                if (!noun.Contains(comparingString))
                {
                    comparingString = string.Empty;
                    break;
                }
                // if no noun starts with the prefix
                // set the comparing string to empty string
                else if (!noun.StartsWith(comparingString))
                {
                    comparingString = string.Empty;
                    return string.Empty;
                }
            }

            // to get the longest common prefix not just any prefix
            if (comparingString.Length > longestCommonPrefix.Length)
            {
                longestCommonPrefix = comparingString;
            }
        }

        //if (longestCommonPrefix == string.Empty || !longestCommonPrefix.StartsWith(leastNounInLength[0]))
        //{
        //    return "";
        //}

        return longestCommonPrefix;
    }
    
    public static void Main(string[] args)
    {
        // Write a function to find the longest common prefix string amongst an array of strings.
        //If there is no common prefix, return an empty string "".
        Solution solution = new Solution();
        
        // Example 1
        {
            // Input: str = { "flower", "flow", "flight" }
            // Output: "fl"

            string[] str = new string[3] { "flower", "flow", "flight" };

            Helper.DisplayExample(
                "str = { \"flower\", \"flow\", \"flight\" }\n",
                "fl");

            Console.WriteLine(solution.LongestCommonPrefix(str));
        }
        Console.WriteLine(new string('-', 100));



        // Example 2
        {
            // Input: str = { "dog", "racecar", "car" }
            // Output: ""

            string[] str = new string[3] { "dog", "racecar", "car" };

            Helper.DisplayExample(
                "str = { \"dog\", \"racecar\", \"car\" }\n",
                "");

            Console.WriteLine(solution.LongestCommonPrefix(str));
        }
        Console.WriteLine(new string('-', 100));



        // Example 3
        {
            // Input: str = { "reflower", "flow", "flight" }
            // Output: ""

            string[] str = new string[3] { "reflower", "flow", "flight" };

            Helper.DisplayExample(
                "str = { \"reflower\", \"flow\", \"flight\" }\n",
                "");

            Console.WriteLine(solution.LongestCommonPrefix(str));
        }
        Console.WriteLine(new string('-', 100));
    }
}