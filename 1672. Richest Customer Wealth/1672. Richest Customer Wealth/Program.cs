using System;
using System.Net.Http.Headers;

class Solution
{
    // You are given an m x n integer grid accounts where accounts[i][j] is the amount of money the i​​​​​​​​​​​th​​​​ customer has in the j​​​​​​​​​​​th​​​​ bank.
    // Return the wealth that the richest customer has.

    // A customer's wealth is the amount of money they have in all their bank accounts.
    // The richest customer is the customer that has the maximum wealth.

    public int MaximumWealth(int[][] accounts)
    {
        int maxValueSum = Int32.MinValue;

        foreach (int[] account in accounts)
        {
            // sum of individual array
            int sumOfWealth = 0;

            foreach (int wealth in account)
            {
                sumOfWealth += wealth;
            }

            maxValueSum = (maxValueSum < sumOfWealth) ? sumOfWealth : maxValueSum;
        }
        return maxValueSum;
    }

    public static void Main(string[] args)
    {
        var solution = new Solution();

        // Example 1:
        {
            int[][] accounts = new int[2][]
            {
                new int[] { 1, 2, 3 },
                new int[] { 3, 2, 1 }
            };
            
            Helper.DisplayExample($"accounts = [[1,2,3],[3,2,1]]",
                "6");
            Console.WriteLine(solution.MaximumWealth(accounts));
        }
        Console.WriteLine(new string('-', 50));


        // Example 2
        {
            // Input: accounts = [[1,5],[7,3],[3,5]]
            // Output: 10
            // Explanation:
            // 1st customer has wealth = 6
            // 2nd customer has wealth = 10
            // 3rd customer has wealth = 8
            // The 2nd customer is the richest with a wealth of 10.

            int[][] accounts = new int[3][]
            {
                new int[] { 1, 5 },
                new int[] { 7, 3 },
                new int[] { 3, 5 }
            };

            Helper.DisplayExample("accounts = [[1,5],[7,3],[3,5]]", "10");
            Console.WriteLine(solution.MaximumWealth(accounts));
        }
        Console.WriteLine(new string('-', 50));


        // Example 3
        {
            // Input: accounts = [[2,8,7],[7,1,3],[1,9,5]]
            // Output: 17
            int[][] accounts = new int[][]
            {
                new int[] { 2, 8, 7 },
                new int[] { 7, 1, 3 },
                new int[] { 1, 9, 5 }
            };

            Helper.DisplayExample("accounts = [[2,8,7],[7,1,3],[1,9,5]]", "17");
            Console.WriteLine(solution.MaximumWealth(accounts));
        }
    }
}