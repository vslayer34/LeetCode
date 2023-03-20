using System;

internal class ClassName
{
    public static void Main(string[] args)
    {
        Solution solution = new Solution();

        // Example 1
        Helper.DisplayExample(
            "root = [10,4,6]",
            "True");
        Console.WriteLine(solution.CheckTree(new TreeNode(10, new TreeNode(4), new TreeNode(6))));
        Console.WriteLine();


        // Example 2
        Helper.DisplayExample(
            "Input: root = [5,3,1]",
            "False");
        Console.WriteLine(solution.CheckTree(new TreeNode(5, new TreeNode(3), new TreeNode(1))));
        Console.WriteLine();
    }
}