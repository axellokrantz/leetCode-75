using System.Numerics;

public class Solution
{
    public void MoveZeroes(int[] nums)
    {
        int j = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if(nums[i] != 0){
                nums[j] = nums[i];
                j++;
            }
        }

        for (int i = j; i < nums.Length; i++)
        {
            nums[i] = 0;
        }

        foreach (var item in nums)
        {
            Console.Write(item);
        }
    }

    static void Main(string[] args)
    {
        int[] nums = { 0, 1, 0, 3, 12 };
        Solution s = new Solution();
        s.MoveZeroes(nums);
    }
}