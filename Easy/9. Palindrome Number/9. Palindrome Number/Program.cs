using System;

internal class Solution
{
    public bool IsPalindrome(int x)
    {
        // negative numbers can't be palindrome
        if (x < 0)
            return false;

        // hold the x in temp to play with it
        // with out changing the original value of x
        int temp = x;
        
        int lastDigit;
        int reverse = 0;
        int factor = 10;
        
        while (temp > 0)
        {
            // get the last digit
            lastDigit = temp % factor;

            // move through the tens, hundereds column
            reverse = (reverse * factor) + lastDigit;

            // remove last digit
            temp /= 10;
        }

        return x == reverse;
    }

    public static void Main(string[] args)
    {
        Solution solution = new Solution();
        
        // Example 1
        {
            // Input: x = 121
            // Output: true
            // Explanation: 121 reads as 121 from left to right and from right to left.

            int x = 121;

            Helper.DisplayExample("x = 121", true.ToString());
            Console.WriteLine(solution.IsPalindrome(x));
        }
        Console.WriteLine(new string('-', 100));



        // Example 2
        {
            // Input: x = -121
            // Output: false
            // Explanation: From left to right, it reads -121. From right to left, it becomes 121-.
            // Therefore it is not a palindrome.

            int x = -121;

            Helper.DisplayExample("x = -121", false.ToString());
            Console.WriteLine(solution.IsPalindrome(x));
        }
        Console.WriteLine(new string('-', 100));



        // Example 3
        {
            // Input: x = 10
            // Output: false
            // Explanation: Reads 01 from right to left. Therefore it is not a palindrome.

            int x = 10;

            Helper.DisplayExample("x = 10", false.ToString());
            Console.WriteLine(solution.IsPalindrome(x));
        }
    }
}