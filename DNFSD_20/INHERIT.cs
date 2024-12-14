using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNFSD_20
{
    class A  // BAse class    Super class      parent class
    {
       public int a = 12;
       public int b= 13;
        public void Add()
        {
            Console.WriteLine("Addition value is  :  "+(a+b));
        }
    }
    class B:A  // Derived class    sub class   child class
    {
        public void Sub()
        {
            Console.WriteLine("Subtraction value is  :  " + (a - b));
        }

    }
    class C : A
    {
        public void Mul()
        {
            Console.WriteLine("Multiplication value is  :  " + (a * b));
        }
    }
    internal class INHERIT
    {
        static void Main(string[] args)
        {
         
            B b= new B();
            b.Add();
            b.Sub();

        }
    }
}
