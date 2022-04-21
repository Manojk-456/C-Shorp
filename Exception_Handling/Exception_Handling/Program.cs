using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Handling
{
    class Program
    {
        int result=0;

        //Program()
        //{
        //    result = 0;
        //}

        public void div(int a, int b)
        {
            try
            {
                result = a / b;
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Exception caught: {0}", e);
            }
            finally
            {
                Console.WriteLine("Result: {0}", result);
            }
        }
        static void Main(string[] args)
            {
            Program obj = new Program();
            obj.div(12, 0);
            Console.ReadLine();
        }
        
    }
}


/* usern define Exception */
//using System;

namespace UserDefinedException
{
    class TestTemperature
    {
        static void Main(string[] args)
        {
            Temperature temp = new Temperature();
            try
            {
                temp.showTemp();
            }
            catch (TempIsZeroException e)
            {
                Console.WriteLine("TempIsZeroException: {0}", e.Message);
            }
            Console.ReadKey();
        }
    }
}
public class TempIsZeroException : Exception
{
    public TempIsZeroException(string message) : base(message)
    {
    }
}
public class Temperature
{
    int temperature =0;

    public void showTemp()
    {

        if (temperature == 0)
        {
            throw (new TempIsZeroException("Zero Temperature found"));
        }
        else
        {
            Console.WriteLine("Temperature: {0}", temperature);
        }
    }
}
