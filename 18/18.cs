public class Solution
{
    public int PivotIndex(int[] nums)
    {
        int[] leftSum = new int[nums.Length + 1];
        int[] rightSum = new int[nums.Length + 1];

        for (int i = 1; i < leftSum.Length; i++)
        {
            leftSum[i] = leftSum[i - 1] + nums[i - 1];
        }

        for (int i = rightSum.Length - 2; i >= 0; i--)
        {
            rightSum[i] = rightSum[i + 1] + nums[i];
        }

        for (int i = 0; i < leftSum.Length - 1; i++)
        {
            if (leftSum[i] == rightSum[i + 1])
            {
                return i;
            }
        }

        return -1;
    }

    static void Main(string[] args)
    {
        int[] nums = [1,7,3,6,5,6];
        Solution solution = new Solution();
        Console.WriteLine(solution.PivotIndex(nums));
    }
}
