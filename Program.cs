namespace Challenge11._1
{
    internal class Program
    {
        public static void ColorSort(int[] nums)
        {
            int red0 = 0;
            int white1 = 0;
            int blue2 = 0;

            foreach (var num in nums)
            {
                if (num == 0) red0++;
                else if (num == 1) white1++;
                else if (num == 2) blue2++;
            }

            for (int i = 0; i < nums.Length; i++)
            {
                if (i < red0)
                    nums[i] = 0;
                else if (i < red0 + white1)
                    nums[i] = 1;
                else
                    nums[i] = 2;
            }
        }
        static void Main(string[] args)
        {
            int[] numbers = { 2, 0, 1 , 0 , 2, 2, 1, 0 };
            ColorSort(numbers);
            Console.WriteLine(string.Join(", ", numbers));
        }
    }
}
