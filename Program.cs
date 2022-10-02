namespace ContainerWithMostWater
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] height = {1,8,6,2,5,4,8,3,7};
            int left = 0;
            int right = height.Length - 1;

            int res = 0;

            while (left < right)
            {
                int minHeight = Math.Min(height[left], height[right]);
                res = Math.Max(res, minHeight * (right - left));

                if (height[left] <= height[right])
                {
                    left++;
                }
                else
                {
                    right--;
                }
            }
            Console.WriteLine(res);
        }
    }
}
