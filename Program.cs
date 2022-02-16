using System;

namespace NumberPrint
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 to 100 number printing :");
            for(int i=1;i<=100;i++)
            {
                Console.Write(i + "\t");
            }
            Console.WriteLine();
            Console.WriteLine("100 to 1 number printing :");
            for(int i=100;i>=1;i--)
            {
                Console.Write(i + "\t");
            }
            Console.ReadLine();

        }
    }
}
