using System;
using System.Diagnostics.CodeAnalysis;

internal class Solution
{
    public int RomanToInt(string s)
    {
        // Dictionary for all roman numbers
        Dictionary<char, int> romanMap = new Dictionary<char, int>(7)
        {
            { 'I', 1 },
            { 'V', 5 },
            { 'X', 10 },
            { 'L', 50 },
            { 'C', 100 },
            { 'D', 500 },
            { 'M', 1000 }
        };

        // the number to be returned
        int number = 0;

        for (int i = 0; i < s.Length; i++)
        {
            // check the next letter
            // if its value is greater
            // we subtract the current index from the next index
            // then jump the i iterator to skip that number
            if (i != s.Length - 1 && romanMap[s[i + 1]] > romanMap[s[i]])
            {
                number += romanMap[s[i + 1]] - romanMap[s[i]];
                i += 1;
                continue;
            }


            // get the value of each letter
            // and added to the number
            if (romanMap.ContainsKey(s[i]))
            {
                number += romanMap[s[i]];
            }
        }

        return number;
    }

    //********************************************************************************************

    public static void Main(string[] args)
    {
        Solution solution = new Solution();
        // Example 1
        {
            // input s = "III"
            // output = 3

            string romanNumber = "III";

            Helper.DisplayExample("input: III\n", "3");
            Console.WriteLine(solution.RomanToInt(romanNumber));
        }
        Console.WriteLine(new string('-', 100));



        // Example 2
        {
            // input s = "LVIII"
            // output = 58

            string romanNumber = "LVIII";

            Helper.DisplayExample("input: LVIII\n", "58");
            Console.WriteLine(solution.RomanToInt(romanNumber));
        }
        Console.WriteLine(new string('-', 100));



        // Example 3
        {
            // input s = "MCMXCIV"
            // output = 1994

            string romanNumber = "MCMXCIV";

            Helper.DisplayExample("input: MCMXCIV\n", "1994");
            Console.WriteLine(solution.RomanToInt(romanNumber));
        }
        Console.WriteLine(new string('-', 100));
    }
}