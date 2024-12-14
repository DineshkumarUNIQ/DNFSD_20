using System;
using System.ComponentModel;
using System.Reflection.Emit;
using System.Security.Cryptography.X509Certificates;

namespace DNFSD_20
{
    class ONE
    {

        // without parameter without return type
        public int  Add(int a, int b)
        {
         
            int c = a + b;
            return c;
           
        }

    }
    class GHH
    {
        public static int Sub(int a, int b)
        {
            int c = a - b;
            return c;
        }
    }
    class Print
    {
        public static void PRINT(int result)
        {
            Console.WriteLine("result value is  : " + result);
        }
    }
    internal class Loop
    {
        private static void Main(string[] args)
        {
            ONE o = new ONE();
            Console.WriteLine("start of the application  : ");
            Console.WriteLine("Enter a first value  :");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a second value :");
            int b = int.Parse(Console.ReadLine());
            int c = GHH.Sub(a, b);
            Print.PRINT(c);
            c = o.Add(a,b);
            Print.PRINT(c);
            Console.WriteLine("REST of the application  : ");
        }
    }
}

