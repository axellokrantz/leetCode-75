
public class Solution
{
    public int MaxVowels(string s, int k)
    {
        HashSet<char> vowels = new HashSet<char> { 'a', 'o', 'u', 'e', 'i' };
        int count = 0;
        int maxCount = 0;

        for (int i = 0; i < k; i++)
        {
            if(vowels.Contains(s[i]))
            {
                count++;
            }
        }
        
        maxCount = Math.Max(maxCount, count);

        for (int i = k; i < s.Length; i++)
        {
            if (vowels.Contains(s[i]))
            {
                count++;
            }
            if (vowels.Contains(s[i-k]))
            {
                count--;
            }

            maxCount = Math.Max(maxCount, count);

        }
        return maxCount;
    }

    static void Main(string[] args)
    {
        string s = "aeiou";
        int k = 2;
        Solution solution = new Solution();
        solution.MaxVowels(s, k);
    }
}
