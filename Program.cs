using System;

namespace ConsoleApp2
{
      class Program
      {
          static void Main(string[] args)
          {
             for(int i=1;i<=5;i++)
              {
                  Console.Write("*"+" ");
              }
              Console.WriteLine();
             for(int i=1;i<=4;i++)
              {
                  for(int j=1;j<=5;j++)
                  {
                      if(j==3)
                      {
                          Console.Write("*");
                      }
                      Console.Write("  ");

                  }
                  Console.WriteLine();
              }
              Console.ReadLine();
          }
      }
  }
   
 }
