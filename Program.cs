namespace Challenge11._1
{
    internal class Program
    {
        public static void InsertionSort(int[] nums)
        {
            for (int i = 1; i < nums.Length; i++)
            {
                int key = nums[i];
                int j = i - 1;
                while (j >= 0 && nums[j] > key)
                {
                    nums[j + 1] = nums[j];
                    j--;
                }
                nums[j + 1] = key;
            }
        }
        static void Main(string[] args)
        {
            int[] numbers = { 2, 0, 1  };
            InsertionSort(numbers);
            Console.WriteLine(string.Join(", ", numbers));
        }
    }
}
