public class Solution
{

    public IList<bool> KidsWithCandies(int[] candies, int extraCandies)
    {
        int greatest = candies.Max();
        IList<bool> result = new List<bool>(candies.Length);
        
        for (int i = 0; i < candies.Length; i++)
        {
            if (candies[i] + extraCandies >= greatest)
            {
                result.Add(true);
            }
            else
            {
                result.Add(false);
            }
        }
        return result;   
    }

    static void Main(string[] args)
    {
        int[] candies = { 2, 3, 5, 1, 3 };
        int extraCandies = 3;
        Solution s = new Solution();
        Console.WriteLine(s.KidsWithCandies(candies, extraCandies));
    }
}
