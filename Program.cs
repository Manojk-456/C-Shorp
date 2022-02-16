using System;

namespace Matrix2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] data = new int[3,3];
            Console.WriteLine("Enter 9 digit for matrix :");
            for(int i=0;i<3;i++)
            {
                for(int j=0;j<3;j++)
                {
                    data[i,j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("Display the input element");
            for(int i=0;i<3;i++)
            {
                for(int j=0;j<3;j++)
                {
                    Console.Write(data[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();

        }
    }
}
