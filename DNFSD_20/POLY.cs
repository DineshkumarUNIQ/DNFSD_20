using System;

namespace DNFSD_20
{  
    class DARK
    {
        public void One()
        {
            Console.WriteLine("Method One ");
        }
        public virtual void One(int a)
        {
            Console.WriteLine("Method One Integer parameter ");
        }
        public void One(string b)
        {
            Console.WriteLine("Method One string parameter ");
        }
    }
    class DARK1:DARK
    {
        public  override void One(int a)
        {
            base.One(a);
            Console.WriteLine(" child class Method One Integer parameter ");
        }
    }
    class DARK2:DARK1
    {
        public override void One(int a)
        {
           base.One(a);
            Console.WriteLine(" second child class Method One Integer parameter ");
        }
    }
    internal class POLY
    {
        static void Main(string[] args)
        {
            DARK d=new DARK2();
            d.One(3);

        }
    }
}