namespace _05.LongestIncreasingSubsequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine()
                .Split().Select(int.Parse)
                .ToArray();
            List<int> lis = FindLIS(nums);
            Console.WriteLine(string.Join(" ", lis));

        }
        static List<int> FindLIS(int[] arr)
        {
            int n = arr.Length;
            if (n == 0) return new List<int>();

            int[] lengths = new int[n];
            int[] previous = new int[n];
            Array.Fill(lengths, 1);
            Array.Fill(previous, -1);

            int maxLength = 1, lastIndex = 0;

            for (int i = 1; i < n; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (arr[j] < arr[i] && lengths[j] + 1 > lengths[i])
                    {
                        lengths[i] = lengths[j] + 1;
                        previous[i] = j;
                    }
                }
                if (lengths[i] > maxLength)
                {
                    maxLength = lengths[i];
                    lastIndex = i;
                }
            }

            List<int> lis = new List<int>();
            for (int i = lastIndex; i != -1; i = previous[i])
            {
                lis.Add(arr[i]);
            }
            lis.Reverse();
            return lis;
        }
    }
}
