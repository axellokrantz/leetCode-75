using System.Numerics;

public class Solution
{

    public string GcdOfStrings(string str1, string str2)
    {
        int len1 = str1.Length;
        int len2 = str2.Length;
        int gcd = (int)BigInteger.GreatestCommonDivisor(len1, len2);

        string substr = str1.Substring(0, gcd);
        string str = str1 + str2;

        for (int i = 0; i < str.Length; i += gcd)
        {
            if (str.Substring(i, gcd) != substr)
            {
                return "";
            }
        }
        return "";
    }

    static void Main(string[] args)
    {
        Solution s = new Solution();
        Console.WriteLine(s.GcdOfStrings("1", "2"));
    }
}
