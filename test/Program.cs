namespace test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] numbers={ { 1,0,0,0 }, { 1, 1, 0, 0 },{ 1, 2, 1,0},   { 1, 3, 3 ,1 }};
            foreach (int i in numbers)
            { Console.WriteLine(   i ); }
        }

    }
}
