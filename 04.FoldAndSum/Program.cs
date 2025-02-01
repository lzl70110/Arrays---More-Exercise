


namespace _04.FoldAndSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] reversedNumbers = new int[numbers.Length / 2];
            int[] normalNumbers = new int[numbers.Length / 2];
            reversedNumbers = ReverseTheNumbers(numbers);

            //foreach (var item in reversedNumbers)
            //{
            //    Console.Write(item + " ");

            //}

            normalNumbers = GiveTheNormalNumbers(numbers);

            //Console.WriteLine();
            //foreach (var item in normalNumbers)
            //{
            //    Console.Write(item + " ");
            //}
            numbers = new int[numbers.Length/2];
            numbers = SumOfReversedAndNormalNumbers(reversedNumbers, normalNumbers);
            foreach (int number in numbers)
            {
                Console.Write(number + " ");
            }
        }

        private static int[] SumOfReversedAndNormalNumbers(int[] reversedNumbers, int[] normalNumbers)
        {
            int[] newArray = new int[reversedNumbers.Length];
            for (int i = 0; i < reversedNumbers.Length; i++)
            {
                newArray[i] = reversedNumbers[i] + normalNumbers[i];
                
            }
            return newArray;

        }

        private static int[] GiveTheNormalNumbers(int[] numbers)
        {
            int lng = numbers.Length / 2;
            int[] newArray = new int[lng];
            for (int i = 0; i < lng; i++)
            {
                newArray[i] = numbers[((lng) / 2) + i];
            }
            return newArray;
        }

        private static int[] ReverseTheNumbers(int[] numbers)
        {
            int lng = numbers.Length / 2;
            int[] newArray = new int[lng];
            for (int i = 0; i < lng / 2; i++)
            {
                newArray[i] = numbers[((lng - 1) / 2) - i];
                newArray[(lng / 2) + i] = numbers[(numbers.Length - 1) - i];
            }

            return newArray;
        }
    }
}
