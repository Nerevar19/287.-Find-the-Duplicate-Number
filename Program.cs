namespace _287._Find_the_Duplicate_Number
{
    internal class Program
    {
        public static int FindDuplicate(int[] nums)
        {
            return nums.
                GroupBy(x => x).
                Where(x => x.Count() >= 2).
                Select(x => x.Key).
                ToArray()[0];
        }

        public static int FindDuplicate2(int[] nums)
        {
            var hs = new HashSet<int>(nums.Length - 1);

            foreach (int num in nums)
            {
                if (!hs.Contains(num)) hs.Add(num);
                else return num;
            }
            return 0;
        }

        static void Main(string[] args)
        {
            int[] nums = { 1, 3, 4, 2, 2 ,5 };
            Console.WriteLine(FindDuplicate2(nums));
        }
    }
}