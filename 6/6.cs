using System.Text.RegularExpressions;

public class Solution
{
    public string ReverseWords(string s)
    {
        string trimmedInput = s.TrimStart().TrimEnd();
        string singelSpaced = Regex.Replace(trimmedInput, @"\s+", " ");
        string[] words = singelSpaced.Split(' ');
        Array.Reverse(words);
        string result = string.Join(" ", words);
        return result;
    }

    static void Main(string[] args)
    {
        string str = " hello ";
        Solution s = new Solution();
        Console.WriteLine(s.ReverseWords(str));
    }
}