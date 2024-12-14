using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNFSD_20
{
    public class SAMPLE
    {
        private static SAMPLE ins = null;
        private SAMPLE()
        {
            Console.WriteLine("STATIC CONSTRUCTOR");
        }
        public void SUB()
        {
            Console.WriteLine("Instance function");
        }
        public static SAMPLE INSTANCE()
        {
            if (ins == null)
            {
                ins = new SAMPLE();
                return ins;
            }
            throw new Exception("You are try to create more then one instance");
        }
    }
    internal class CONST
    {
        static void Main(string[] args)
        {
            SAMPLE s = SAMPLE.INSTANCE();
            s.SUB();
            SAMPLE s1 = SAMPLE.INSTANCE();
            s1.SUB();
        }
    }
}
