public class Solution
{

    public bool CanPlaceFlowers(int[] flowerbed, int n)
    {
        int plotCount = 0;

        for (int i = 0; i < flowerbed.Length; i++)
        {
            if (flowerbed[i] == 0)
            {
                bool leftEmpty = (i == 0) || (flowerbed[i-1] == 0);
                bool rightEmpty = (i == flowerbed.Length - 1) || (flowerbed[i + 1] == 0);
                
                if(leftEmpty && rightEmpty){
                    flowerbed[i] = 1;
                    plotCount++;
                }
            }
        }
        return plotCount >= n;
    }

    static void Main(string[] args)
    {
        int[] flowers = { 1, 0, 0, 0, 1 };
        int n = 1;
        Solution s = new Solution();
        Console.WriteLine(s.CanPlaceFlowers());
    }
}
