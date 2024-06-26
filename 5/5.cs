public class Solution
{
    public string ReverseVowels(string s)
    {
        string vowels = "aoueiAOUEI";
        char[] result = s.ToCharArray();
        int i = 0;
        int j = s.Length - 1;

        while (i < j)
        {
            if (!vowels.Contains(s[i]))
            {
                i++;
            }
            else if(!vowels.Contains(s[j])){
                j--;
            }

            if (vowels.Contains(s[i]) && vowels.Contains(s[j]))
            {
                char temp = s[i];
                result[i] = s[j];
                result[j] = temp;
                i++;
                j--;
            }
        }
        return new string(result);
    }

    static void Main(string[] args)
    {
        string str = "hello";
        Solution s = new Solution();
        Console.WriteLine(s.ReverseVowels(str));
    }
}
