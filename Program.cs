using System;

namespace Table
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number to find Table :");
            int n = int.Parse(Console.ReadLine());
            for(int i=1;i<=10;i++)
            {
                Console.WriteLine(n + " * " + i + " = " + n * i);
            }
            Console.ReadLine();
        }
    }
}
