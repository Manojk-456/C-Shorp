using System;

namespace SumOfNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the max number to find range sum :");
            int n=int.Parse(Console.ReadLine());
            int sum = 0;
            while(n>0)
            {
                sum += n;
                Console.Write(n + "\t");
                n--;
            }
            Console.WriteLine();
            Console.WriteLine("sum of the number is : " + sum);
        }
    }
}
