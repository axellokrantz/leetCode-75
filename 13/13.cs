
public class Solution
{
    public double FindMaxAverage(int[] nums, int k)
    {
        double maxAvg;
        double sum = 0;

        if(nums.Length < k){
            return 0;
        }

        for (int i = 0; i < k; i++)
        {
            sum += nums[i];
        }

        maxAvg = sum / k;

        for (int i = k; i < nums.Length; i++)
        {
            sum -= nums[i - k];
            sum += nums[i];
            maxAvg = double.Max(maxAvg, sum/k);
        }

        return maxAvg;
    }

    static void Main(string[] args)
    {
        int[] nums = [4, 4, 1, 3, 1, 3, 2, 2, 5, 5, 1, 5, 2, 1, 2, 3, 5, 4];
        int k = 5;
        Solution solution = new Solution();
        solution.FindMaxAverage(nums, k);
    }
}
