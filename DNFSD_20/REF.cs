using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNFSD_20
{
   
    class VALUE
    {
        public void Ad(out int a)  // a=a
        {
            a = 20;
            Console.WriteLine("Inside a function value of a is  :  "+a);
        }
    }
    internal class REF
    {
        static void Main(string[] args)
        {
            VALUE v=new VALUE();
            int a = 10;
            Console.WriteLine("before calling function value of a is   : "+a);   // 10
            v.Ad(out a);                                                             // 20
            Console.WriteLine("after calling function value of a is    : " + a); // 20
        }
    }
}
