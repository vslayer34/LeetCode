using System;
using System.Text;

internal class Solution
{
    /*You are given a string s, which contains stars *.
     * In one operation, you can:
     * Choose a star in s.
     * Remove the closest non-star character to its left, as well as remove the star itself.
     * Return the string after all stars have been removed.
     * 
     * Note:
     * The input will be generated such that the operation is always possible.
     * It can be shown that the resulting string will always be unique.
     */

    public string RemoveStars(string inputString)
    {
        // string builder to build new string
        StringBuilder sb = new StringBuilder();

        // loop through the given string
        foreach (char letter in inputString)
        {
            // if we found star
            // we remove the last letter we added to the string
            // then continue to next letter
            if (letter == '*')
            {
                sb.Remove(sb.Length - 1, 1);
                continue;
            }

            // append the letters to the new string
            sb.Append(letter);
        }

        return sb.ToString();
    }

    public static void Main(string[] args)
    {
        Solution solution = new Solution();
        
        // Example 1
        {
            /*Input: s = "leet**cod*e"
             * Output: "lecoe"
             * Explanation: Performing the removals from left to right:
             * - The closest character to the 1st star is 't' in "leet**cod*e". s becomes "lee*cod*e".
             * - The closest character to the 2nd star is 'e' in "lee*cod*e". s becomes "lecod*e".
             * - The closest character to the 3rd star is 'd' in "lecod*e". s becomes "lecoe".
             * There are no more stars, so we return "lecoe".
             */

            string s = "leet**cod*e";
            Helper.DisplayExample(
                example: "s = \"leet**cod*e\"",
                output: "lecoe");
            Console.WriteLine(solution.RemoveStars(s));
        }
        Console.WriteLine(new string('-', 100));



        // Example 2
        {
            /*Input: s = "erase*****"
             * Output: ""
             * Explanation: The entire string is removed, so we return an empty string.
             */

            string s = "erase*****";
            Helper.DisplayExample(
                example: "s = \"erase*****\"",
                output: "");
            Console.WriteLine(solution.RemoveStars(s));
        }
        Console.WriteLine(new string('-', 100));
    }
}