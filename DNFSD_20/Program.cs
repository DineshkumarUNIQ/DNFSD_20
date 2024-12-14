using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNFSD_20
{
    internal class Program
    {
        int g = 45;
        static void Main(string[] args)
        {
            /* const int fo  = 123;
             dynamic fun = "name";
             fun = 123;
             fun = 12.3;
             fun = true;
             fun = 'v';
             fun = new int[5] { 1, 2, 3, 4, 5, };
             fun = "name";
             var name = "dinesh";
             var id = 123;
             int j;
             j = 34;
             int k=5, l=7,u=2,p=8;
             byte Id = 123;
             short a = 12345;
             int b = 3765789;
             long c = 434567;
             float d = 123.23f;
             double e = 123.23d;
             decimal f = 123.23m;
             bool g = true;
             string h = "HI";
            */
            
            uint a = 12;
            string Name = "Some";
            int Id = 100;
            double Salary = 10000.49;
            // COncantination
            Console.WriteLine("Concatenation");
            Console.WriteLine("Employee Name    : "+Name+ "\nEmployee Id      : " + Id+ "\nEmployee Salary  : " + Salary);
            // Formating  
            Console.WriteLine("Formating");
            Console.WriteLine("Employee Name    : {0} \nEmployee Id      : {1}\nEmployee Salary  : {2}",Name,Id,Salary);
            // Interpolation
            Console.WriteLine("Interpolation");
            Console.WriteLine($"Employee Name    : {Name} \nEmployee Id      : {Id}\nEmployee Salary  : {Salary}");







        }
    }
}
