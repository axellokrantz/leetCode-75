using System;

public class Solution
{
    public int MaxOperations(int[] nums, int k)
    {

        int i = 0;
        int j = nums.Length - 1;
        int result = 0;
        Array.Sort(nums);
        int sum;

        while (i < j)
        {
            sum = nums[i] + nums[j];

            if (sum == k)
            {
                result++;
                i++;
                j--;
            }
            else if (sum < k)
            {
                i++;
            }
            else
            {
                j--;
            }
        }

        return result;
    }

    static void Main(string[] args)
    {
        int[] nums = [4, 4, 1, 3, 1, 3, 2, 2, 5, 5, 1, 5, 2, 1, 2, 3, 5, 4];
        int k = 5;
        Solution solution = new Solution();
        solution.MaxOperations(nums, k);
    }
}
