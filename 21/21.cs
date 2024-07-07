public class Solution
{
    public bool CloseStrings(string word1, string word2) {
        
        if(word1.Length != word2.Length)
        {
            return false;
        }

        int[] frequency1 = new int[26];
        int[] frequency2 = new int[26];

        foreach (char c in word1)
        {
            frequency1[c - 'a']++;
        }

        foreach (char c in word2)
        {
            frequency2[c - 'a']++;
        }

        Array.Sort(frequency1);
        Array.Sort(frequency2);

        return Enumerable.SequenceEqual(frequency1, frequency2);
    }

    static void Main(string[] args)
    {
        string word1 = "abc";
        string word2 = "bca";
        Solution solution = new Solution();
        Console.WriteLine(solution.CloseStrings(word1, word2));
    }
}
