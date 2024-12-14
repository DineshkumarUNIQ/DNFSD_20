using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNFSD_20
{

    class one
    {
        public void Test1()
        {
            Console.WriteLine("Public function");
        }
        private void Test2()
        {
            Console.WriteLine("private function");
        }

        protected void Test3()
        {
            Console.WriteLine("protected function");
        }
        internal void Test4()
        {
            Console.WriteLine("internal function");
        }
        internal protected void Test5()
        {
            Console.WriteLine("internal protected function");
        }
    }
    internal class OOP:one
    {
      
        static void Main(string[] args)
        {
            OOP o1 = new OOP(); 
            o1.Test1();
            o1.Test3();
            o1.Test4();     
            o1.Test5();
        }
    }
}
