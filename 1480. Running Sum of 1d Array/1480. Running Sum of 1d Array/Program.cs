using System.Text;

public class Solution
{
    public int[] RunningSum(int[] nums)
    {
        int sum = 0;
        int[] newArray = new int[nums.Length];
        for (int i = 0; i < nums.Length; i++)
        {
            // add the index of the old array + the sum of the numbers we pathed through
            newArray[i] += nums[i] + sum;
            
            // add the sum of the numbers we pathed through
            sum += nums[i];
        }
        return newArray;
    }



    // ToString to Write arrays in the console
    public static string ToString(int[]? numbers)
    {
        if (numbers == null) { return "Null"; }

        StringBuilder sb = new StringBuilder();
        sb.Append("[ ");
        foreach (int i in numbers)
        {
            sb.Append(i + ", ");
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
            // Input: nums = [1,2,3,4]
            // output : [1, 3, 6, 10]
            // Explanation: Running sum is obtained as follows: [1, 1+2, 1+2+3, 1+2+3+4].

            int[] nums = { 1, 2, 3, 4 };
            Console.WriteLine($"Input: {ToString(nums)}");
            int[] newArray = solution.RunningSum(nums);
            Console.WriteLine($"Output: {ToString(newArray)}");
        }
        Console.WriteLine(new String('-', 50));


        // Example 2
        {
            // Input: nums = [1,1,1,1,1]
            // Output: [1,2,3,4,5]
            // Explanation: Running sum is obtained as follows: [1, 1 + 1, 1 + 1 + 1, 1 + 1 + 1 + 1, 1 + 1 + 1 + 1 + 1].
            int[] nums = { 1, 1, 1, 1, 1 };
            Console.WriteLine($"Input: {ToString(nums)}");

            int[] newArray = solution.RunningSum(nums);
            Console.WriteLine($"Output: {ToString(newArray)}");
        }
        Console.WriteLine(new String('-', 50));

        
        
        // Example 3
        {
            // Input: nums = [3,1,2,10,1]
            // Output: [3,4,6,16,17]

            int[] nums = { 3, 1, 2, 10, 1 };
            Console.WriteLine($"Input: {ToString(nums)}");

            Console.WriteLine($"Output: {ToString(solution.RunningSum(nums))}");
        }
    }
}