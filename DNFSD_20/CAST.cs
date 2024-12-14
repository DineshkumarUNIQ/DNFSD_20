using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNFSD_20
{
    internal class CAST
    {
        static void Main(string[] args)
        {
            // byte a = 12;

            // int b = a;
            //// b = 3245678;
            //long c = b;
            // decimal k = c;
            // Console.WriteLine("Byte  : "+a);
            // Console.WriteLine("Integer  : "+b);
            // Console.WriteLine("Longg :  "+c);
            // Console.WriteLine("decimal  : "+k);


            //long a = 122345654;
            //int b = (int)a;
            //short c = (short)b;
            // Console.WriteLine("long  : "+a);
            //Console.WriteLine("Integer  : "+b);

            Console.WriteLine("Enter your name   : ");
            string Name = Console.ReadLine();
            Console.WriteLine("Enter your ID     :");
            int Id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your Salary :");
            double Salary = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Employee Name    : {Name} \nEmployee Id      : {Id}\nEmployee Salary  : {Salary}");

        }
    }
}
