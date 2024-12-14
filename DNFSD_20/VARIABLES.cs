using System;

using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DNFSD_20
{
    internal class VARIABLES
    {
        public static (int,int) Input()
        {
            Console.WriteLine("Enter a first input");
            int input1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a Second input");
            int input2 = int.Parse(Console.ReadLine());
            return (input1,input2);

        }
        public void one(int a = 10, int b = 10)
        {
            Console.WriteLine($"first Parameter {a}  secont parameter  {b}");
        }
        public static int two(int a, int b)
        {
            Console.WriteLine($"first Parameter {a}  secont parameter  {b}");

            int c = a + b;
            return c;
        }
        static void print(int output)
        {
            Console.WriteLine("The Addition result is  : " + output);

        }
        static void Main(string[] args)
        {

        }
    }
}
