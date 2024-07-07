public class Solution
{
    public IList<IList<int>> FindDifference(int[] nums1, int[] nums2)
    {
        IList<int> distinctNums1 = new List<int>();
        IList<int> distinctNums2 = new List<int>();
        IList<IList<int>> result = new List<IList<int>>();

        for (int i = 0; i < nums1.Length; i++)
        {
            if(!nums2.Contains(nums1[i]) && !distinctNums1.Contains(nums1[i]))
            {
                distinctNums1.Add(nums1[i]);
            }
        }

        for (int i = 0; i < nums2.Length; i++)
        {
            if(!nums1.Contains(nums2[i]) && !distinctNums2.Contains(nums2[i]))
            {
                distinctNums2.Add(nums2[i]);
            }
        }

        result.Add(distinctNums1);
        result.Add(distinctNums2);

        return result;
    }

    static void Main(string[] args)
    {
        int[] nums = [1, 2, 3];
        int[] nums2 = [2, 4, 6];
        Solution solution = new Solution();
        Console.WriteLine(solution.FindDifference(nums, nums2));
    }
}
