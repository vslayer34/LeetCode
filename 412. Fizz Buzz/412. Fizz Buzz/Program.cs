using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;


/*
 * Given an integer n, return a string array answer (1-indexed) where:
 
 * answer[i] == "FizzBuzz" if i is divisible by 3 and 5.
 * answer[i] == "Fizz" if i is divisible by 3.
 * answer[i] == "Buzz" if i is divisible by 5.
 * answer[i] == i (as a string) if none of the above conditions are true.
*/

class Solution
{
    public IList<string> FizzBuzz(int n)
    {
        List<string> answer = new List<string>(n);

        for (int i = 1; i <= n; i++)
        {
            string index = i switch
            {
                _ when i % 3 == 0 && i % 5 == 0 => "FizzBuzz",
                _ when i % 3 == 0 => "Fizz",
                _ when i % 5 == 0 => "Buzz",
                _ => i.ToString()
            };

            answer.Add(index);
        }
        return answer;
    }

    public static string ToString(IList<string> answer)
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("[ ");

        foreach (string item in answer)
        {
            sb.Append(item + ", ");
        }

        sb.Remove(sb.Length - 2, 2);
        sb.Append(" ]");

        return sb.ToString();
    }

    public static void Main(string[] args)
    {
        var solution = new Solution();

        // Example 1
        {
            Helper.DisplayExample(
                "n = 3",
                "[\"1\",\"2\",\"Fizz\"]");

            Console.WriteLine(ToString(solution.FizzBuzz(3)));
        }
        Console.WriteLine(new string('-', 50));


        // Example 2
        {
            Helper.DisplayExample(
                "n = 5",
                "[\"1\",\"2\",\"Fizz\",\"4\",\"Buzz\"]");

            Console.WriteLine(ToString(solution.FizzBuzz(5)));
        }
        Console.WriteLine(new string('-', 50));


        // Example 1
        {
            Helper.DisplayExample(
                "n = 15",
                "[\"1\",\"2\",\"Fizz\",\"4\",\"Buzz\",\"Fizz\",\"7\",\"8\",\"Fizz\",\"Buzz\",\"11\",\"Fizz\",\"13\",\"14\",\"FizzBuzz\"]");

            Console.WriteLine(ToString(solution.FizzBuzz(15)));
        }
        Console.WriteLine(new string('-', 50));
    }
}