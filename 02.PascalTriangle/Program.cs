

using System.Runtime.InteropServices;

namespace _02.PascalTriangle
{
    /*
1 
1 1 
1 2 1 
1 3 3 1
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            int[] numbers = { 1 };
            
            for (int i = 1; i <= lines; i++)
            {
                int[] newArray= new int[i];
                newArray = Calculate(newArray, numbers, i);
                PrintLine(newArray);    
                numbers = newArray;
            }
        }

        private static int[] Calculate(int[] newArray, int[] numbers, int line)
        {
            newArray[0] = 1;
            newArray[line-1]=1;
            for (int i = 1; i < line - 1; i++)
            {
                newArray[i] = numbers[i]+numbers[i-1];  
            }
            return newArray;
        }
        private static void PrintLine(int[] newLine)
        {
            foreach (var item in newLine)
            {
                Console.Write( item+ " " );
            }
            Console.WriteLine(  );
        }
    }
}
