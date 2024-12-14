using System;

namespace DNFSD_20
{
    interface IHike
    {
          double Calculate();
    }
    interface AHike1
    {

        double Calculate1();


    }

    class Hike : IHike, AHike1
    {
        public  double Calculate()
        {
            Console.WriteLine("Hike calculation : ");
            return 12.36;
        }
        public double Calculate1()
        {
            Console.WriteLine("Hike1 calculation1 : ");
            return 12.316;
        }
    }
    internal class ABS
    {
        static void Main(string[] args)
        {
            IHike h = new Hike();
            AHike1 h1 = new Hike();
            double hike = h.Calculate();
            Console.WriteLine(hike);
         
        }
    }
}
