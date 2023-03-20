using System;

internal class ClassName
{
    public static void Main(string[] args)
    {
        var solution = new Solution();
        
        // Example 1
        Helper.DisplayExample(
            "num1 = 12, num2 = 5",
            "17");
        
        Console.WriteLine(solution.Sum(12, 5));
        Console.WriteLine();


        // Example 2
        Helper.DisplayExample(
            "num1 = -10, num2 = 4",
            "-6");
       
        Console.WriteLine(solution.Sum(-10, 4));
        Console.WriteLine();
    }
}