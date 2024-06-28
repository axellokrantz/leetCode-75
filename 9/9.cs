using System.Numerics;

public class Solution
{
    public int Compress(char[] chars)
    {

        char c;
        int count;
        List<char> charList = new List<char>();

        for (int i = 0; i < chars.Length; i++)
        {
            c = chars[i];
            count = 0;

            while (i < chars.Length && chars[i] == c)
            {
                count++;
                i++;
            }
            i--;

            charList.Add(c);
            if (count > 1)
            {
                foreach (char ch in count.ToString())
                {
                    charList.Add(ch);
                }
            }

        }


        for (int i = 0; i < charList.Count; i++)
        {
            chars[i] = charList[i];
        }

        for (int i = charList.Count; i < chars.Length; i++)
        {
            chars[i] = ' ';
        }

        return charList.Count;
    }

    static void Main(string[] args)
    {
        char[] chars = { 'a', 'a', 'b', 'b', 'c', 'c', 'c' };
        Solution s = new Solution();
        Console.WriteLine("\n" + s.Compress(chars));
    }
}