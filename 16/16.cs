public class Solution
{
    public int LongestSubarray(int[] nums)
    {

        int end = 0;
        int start = 0;
        int zeroCount = 0;
        int maxLength = 0;

        while (end < nums.Length)
        {
            if (nums[end] == 0)
            {
                zeroCount++;
            }

            while (zeroCount > 1)
            {
                if (nums[start] == 0)
                {
                    zeroCount--;
                }
                start++;
            }
            maxLength = Math.Max(end - start + 1, maxLength);
            end++;
        }
        return maxLength - 1;
    }

    static void Main(string[] args)
    {
        int[] nums = [1,1,1];
        Solution solution = new Solution();
        Console.WriteLine(solution.LongestSubarray(nums));
    }
}
