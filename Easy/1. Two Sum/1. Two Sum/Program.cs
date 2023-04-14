using System;
using System.Text;

internal class Solution
{
    /*Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
     * You may assume that each input would have exactly one solution, and you may not use the same element twice.
     * You can return the answer in any order.
     */


    public int[] TwoSum(int[] nums, int target)
    {
        var numsList = nums.ToList();
        numsList.Sort();
        //Console.WriteLine(printArray(numsList.ToArray()));

        int[] result = new int[2];

        int leftPointer = 0;
        int rightPointer = numsList.Count - 1;

        for (int i = 0; i < numsList.Count; i++)
        {
            if (numsList[rightPointer] + numsList[leftPointer] < target)
            {
                leftPointer++;
                continue;
            }

            else if (numsList[rightPointer] + numsList[leftPointer] > target)
            {
                rightPointer--;
                continue;
            }

            else if (numsList[rightPointer] + numsList[leftPointer] == target)
            {
                result[0] = nums.ToList().IndexOf(numsList[leftPointer]);
                result[1] = nums.ToList().IndexOf(numsList[rightPointer]);

                // if a duplicate index exits
                // add one to the index
                // then search of the index again
                // then remove the one added

                if (result[1] == result[0])
                {
                    nums[result[0]] += 1;
                    result[1] = nums.ToList().IndexOf(numsList[rightPointer]);
                    nums[result[0]] -= 1;
                }
                break;
            }
        }

        return result;
    }

    public string printArray(int[] result)
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("[");

        foreach (int i in result)
        {
            sb.Append(i + ",");
        }

        sb.Remove(sb.Length - 1, 1);
        sb.Append("]");

        return sb.ToString();
    }


    public static void Main(string[] args)
    {
        Solution solution = new Solution();

        // Example 1
        {
            // Input: nums = [2,7,11,15], target = 9
            // Output: [0,1]
            // Explanation: Because nums[0] + nums[1] == 9, we return [0, 1].
            int[] nums = { 2, 7, 11, 15 };
            int target = 9;

            Helper.DisplayExample("Input: nums = [2,7,11,15], target = 9", "[0,1]");
            
            var result = solution.TwoSum(nums, target);
            Console.WriteLine(solution.printArray(result));
        }
        Console.WriteLine(new string('-', 100));



        // Example 2
        {
            // Input: nums = [3,2,4], target = 6
            // Output: [1,2]
            int[] nums = { 3, 2, 4 };
            int target = 6;

            Helper.DisplayExample("Input: nums = [3,2,4], target = 6", "[1,2]");

            var result = solution.TwoSum(nums, target);
            Console.WriteLine(solution.printArray(result));
        }
        Console.WriteLine(new string('-', 100));



        // Example 3
        {
            // Input: nums = [3,3], target = 6
            // Output: [0,1]
            int[] nums = { 3, 3 };
            int target = 6;

            Helper.DisplayExample("Input: nums = [3,3], target = 6", "[0,1]");

            var result = solution.TwoSum(nums, target);
            Console.WriteLine(solution.printArray(result));
        }
        Console.WriteLine(new string('-', 100));



        // Example 4
        {
            // Input: nums = [-1,-2,-3,-4,-5], target = -8
            // Output: [0,1]
            int[] nums = { -1, -2, -3, -4, -5 };
            int target = -8;

            Helper.DisplayExample("Input: nums = [-1,-2,-3,-4,-5], target = -8", "[4,2]");

            var result = solution.TwoSum(nums, target);
            Console.WriteLine(solution.printArray(result));
        }
        Console.WriteLine(new string('-', 100));



        // Example 4
        {
            // Input: nums = [3,2,3], target = 6
            // Output: [0,2]
            int[] nums = { 3, 2, 3, };
            int target = 6;

            Helper.DisplayExample("Input: nums = [3,2,3], target = 6", "[0,2]");

            var result = solution.TwoSum(nums, target);
            Console.WriteLine(solution.printArray(result));
        }
        Console.WriteLine(new string('-', 100));
    }
}