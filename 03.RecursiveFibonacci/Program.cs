
namespace _03.RecursiveFibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine(GetFibonacci(n));
        }

        private static int GetFibonacci(int n)
        {
            int result;
            if (n is 1 or 2)
                result = 1;
            else
                result = GetFibonacci(n - 1) + GetFibonacci(n - 2);
            return result;

        }
    }
}
