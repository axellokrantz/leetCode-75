public class Solution
{
    public int MaxArea(int[] height)
    {

        int maxArea = int.MinValue;
        int area = int.MinValue;
        int right = height.Length - 1;
        int left = 0;

        while (left < right)
        {
            if (height[left] >= height[right])
            {
                area = height[right] * (right - left);
            }
            else{
                area = height[left] * (right - left);
            }

            maxArea = int.Max(maxArea, area);

            if(height[left] > height[right]){
                right--;
            }
            else{
                left++;
            }            
        }

        return maxArea;
    }

    static void Main(string[] args)
    {
        int[] height = [1, 1];
        Solution solution = new Solution();
        Console.Write(solution.MaxArea(height));
    }
}
