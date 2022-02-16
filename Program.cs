using System;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number to find Factorial :");
            int fact = 1;
            int n = int.Parse(Console.ReadLine());
            while(n>0)
            {
                fact = fact * n;
                n--;
            }
            Console.WriteLine("factorial of this number is : " + fact);
            Console.ReadLine();
        }
    }
}
