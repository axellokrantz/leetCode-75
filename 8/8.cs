using System.Numerics;

public class Solution
{
     public bool IncreasingTriplet(int[] nums)
    {
        if (nums.Length < 3)
        {
            return false;
        }

        int minSoFar = int.MaxValue;
        int maxFromEnd = int.MinValue;

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] <= minSoFar)
            {
                minSoFar = nums[i];
            }
            else if (nums[i] <= maxFromEnd)
            {
                maxFromEnd = nums[i];
            }
            else
            {
                return true;
            }
        }

        return false;
    }

    static void Main(string[] args)
    {
        int[] nums = { 2, 5, 5, 6 };
        Solution s = new Solution();
        Console.WriteLine(s.IncreasingTriplet(nums));
    }
}