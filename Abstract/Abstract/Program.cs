using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{


    abstract class abc:check
    {
        public abstract void test(int num1, int num2);
        public void show()
        {
            Console.WriteLine("Hello manoj kumar :");
        }

    }

    class add : abc
    {
        public override void test(int num1, int num2)
        {
            int sum = num1 + num2;
            Console.WriteLine("sum of {0} and {1} number is : {2}", num1, num2, sum);
        }
    }
    class sub : abc
    {
        public override void test(int num1, int num2)
        {
            int sub = num1 - num2;
            Console.WriteLine("sub  of {0} and {1} number is : {2}", num1, num2, sub);
        }
    }

    class mult : abc
    {
        public override void test(int num1, int num2)
        {
            int mult = num1 * num2;
            Console.WriteLine("mult of {0} and {1} number is : {2}", num1, num2, mult);
        }
    }

    class div : abc
    {
        public override void test(int num1, int num2)
        {
            int div = num1 / num2;
            Console.WriteLine("div  of {0} and {1} number is : {2}", num1, num2, div);
        }
    }

    class mod : abc
    {
        public override void test(int num1, int num2)
        {
            int mod = num1 % num2;
            Console.WriteLine("mod  of {0} and {1} number is : {2}", num1, num2, mod);
        }
    }

    class check
    {
        public void check1()
        {
            Console.WriteLine("check method is inherited in the parent class : ");
        }
    }
   
    class Program
    {
        static void Main(string[] args)
        {
            add obj = new add();
            abc pobj;
            pobj = obj;
            pobj.show();
            pobj.check1();
            obj.test(12, 23);

            sub obj1 = new sub();
            obj1.test(12, 23);


            mult obj2 = new mult();
            obj2.test(12, 23);


            div obj3 = new div();
            obj3.test(12, 23);


            mod obj4 = new mod();
            obj4.test(12, 23);

            
            Console.ReadLine();


        }
       
    }

}
