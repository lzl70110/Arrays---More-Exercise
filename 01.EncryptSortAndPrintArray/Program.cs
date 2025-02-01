using System.ComponentModel.Design;

namespace _01.EncryptSortAndPrintArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            string[] name = new string[count];
            int[] sum = new int[count];
            for (int i = 0; i < count; i++)
            {
                name[i] = Console.ReadLine();

                sum[i] = Encripting(name[i]);

            }
            Array.Sort(sum);
            foreach (int i in sum)
            {
                Console.WriteLine(i);
            }
        }
        static bool IsVovel(char ch)
        {
            char[] vovel = { 'a', 'e', 'i',  'o', 'u', 'A', 'E', 'I',  'O', 'U' };
            bool result = false;
            if (vovel.Contains(ch))
            {
                return true;
            }

            return false;
        }
        static int Encripting(string name)

        {
            int sum = 0;
            foreach (char ch1 in name)
                if (IsVovel(ch1))
                {
                    sum += ch1 * name.Length;

                }
                else
                {
                    //consonant
                    sum += ch1 / name.Length;
                }
            return sum;
        }

    }
}
