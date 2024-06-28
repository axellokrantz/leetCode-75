public class Solution
{
    public int[] ProductExceptSelf(int[] nums)
    {

        int n = nums.Length;
        int[] prefix = new int[n];
        int[] suffix = new int[n];

        for (int i = 0; i < nums.Length; i++)
        {
            prefix[i] = 1;
            suffix[i] = 1;
        }

        for (int i = 1; i < n; i++)
        {
            prefix[i] = nums[i - 1] * prefix[i - 1];
        }

        for (int i = n - 2; i >= 0; i--)
        {
            suffix[i] = nums[i + 1] * suffix[i + 1];
        }

        for (int i = 0; i < n; i++)
        {
            nums[i] = prefix[i] * suffix[i];
        }

        return nums;
    }

    static void Main(string[] args)
    {
        int[] nums = { 2, 3, 4, 5, 6 };
        Solution s = new Solution();
        Console.WriteLine(s.ProductExceptSelf(nums));
    }
}