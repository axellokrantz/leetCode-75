using System.Text;
public class Solution
{

    public string MergeAlternately(string word1, string word2)
    {
        StringBuilder result = new StringBuilder();
        int j = 0;

        if (word1.Length >= word2.Length)
        {
            for (int i = 0; i < word2.Length; i++)
            {
                result.Append(word1[i]);
                result.Append(word2[i]);
                j++;
            }
            result.Append(word1.Substring(j));
        }
        else
        {
            for (int i = 0; i < word1.Length; i++)
            {
                result.Append(word1[i]);
                result.Append(word2[i]);
                j++;
            }
            result.Append(word2.Substring(j));
        }
        return result.ToString();
    }

    static void Main(string[] args)
    {
        Solution s = new Solution();
        Console.WriteLine(s.MergeAlternately("1", "2"));
    }
}
