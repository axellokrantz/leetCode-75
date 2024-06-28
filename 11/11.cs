using System.Numerics;

public class Solution
{
    public bool IsSubsequence(string s, string t)
    {
        if(string.IsNullOrEmpty(s)){
            return true;
        }

        int j = 0;
        for (int i = 0; i < t.Length; i++)
        {
            if (t[i] == s[j])
            {
                j++;
            }

            if (j == s.Length)
            {
                return true;
            }
        }
        return false;
    }

    static void Main(string[] args)
    {
        string s = "axc";
        string t = "ahbgdc";
        Solution solution = new Solution();
        Console.Write(solution.IsSubsequence(s, t));
    }
}