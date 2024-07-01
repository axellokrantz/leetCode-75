public class Solution
{
    public int LargestAltitude(int[] gain)
    {
        int[] pref = new int[gain.Length + 1];
        foreach (var item in pref)
        {
            pref[item] = 0;
        }

        for (int i = 1; i < pref.Length; i++)
        {
            pref[i] = pref[i - 1] + gain[i - 1];
        }

        return pref.Max();
    }

    static void Main(string[] args)
    {
        int[] gain = [-5, 1, 5, 0, -7];
        Solution solution = new Solution();
        Console.WriteLine(solution.LargestAltitude(gain));
    }
}
