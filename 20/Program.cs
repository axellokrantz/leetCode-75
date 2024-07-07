public class Solution
{
    public bool UniqueOccurrences(int[] arr)
    {
        Dictionary<int, int> dict = new Dictionary<int, int>();
        HashSet<int> set = new HashSet<int>();

        for (int i = 0; i < arr.Length; i++)
        {
            if (!dict.ContainsKey(arr[i]))
            {
                dict.Add(arr[i], 1);
            }
            else
            {
                dict[arr[i]]++;
            }
        }

        foreach (var count in dict)
        {
            if(!set.Add(count.Value)){
                return false;
            }
        }

        return true;
    }

    static void Main(string[] args)
    {
        int[] arr = [1,2,2,1,1,3];
        Solution solution = new Solution();
        Console.WriteLine(solution.UniqueOccurrences(arr));
    }
}
