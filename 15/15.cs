
public class Solution
{
    public int LongestOnes(int[] nums, int k)
    {
        int maxLength = 0;
        int length = 0;
        int start = 0;
        int end = 0;

        while (end < nums.Length)
        {

            if (nums[end] == 1)
            {
                end++;
                length++;
            }
            else if (k > 0)
            {
                k--;
                end++;
                length++;
            }
            else
            {
                if (nums[start] == 0)
                {
                    k++;
                }
                start++;
                length--;
            }
            maxLength = Math.Max(length, maxLength);
        }
        return maxLength;
    }

    static void Main(string[] args)
    {
        int k = 2;
        int[] nums = [1, 1, 1, 0, 0, 0, 1, 1, 1, 1, 0];
        Solution solution = new Solution();
        solution.LongestOnes(nums, k);
    }
}
