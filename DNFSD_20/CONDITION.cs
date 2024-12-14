using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNFSD_20
{
    internal class CONDITION
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Start of the application");
            Console.WriteLine("Before if block");
            int pwd = 0379;
            Console.WriteLine("Enter your password");
            int psd = Convert.ToInt32(Console.ReadLine());
            if (psd == pwd)
            {
                Console.WriteLine("you are now in yourmobile");
                Console.WriteLine("and you can do what ever you want in it");
                int APlo = 4589;
                Console.WriteLine("Enter a applock password");
                int APP = int.Parse(Console.ReadLine());
                if (APP == APlo)

                    Console.WriteLine("You are now entered in a application");

                else Console.WriteLine("password is in correct : !!");

            }

            else
            {
                Console.WriteLine("You entered a wrong password");
                Console.WriteLine("Enter a crt password");
            }

            Console.WriteLine("Enter your in time  :  ");
            double intime = double.Parse(Console.ReadLine());

            if (intime >= 9 && intime <= 10.30) 
            {
                Console.WriteLine("You are present today  !!");
                if (intime >= 9 && intime < 9.30) Console.WriteLine("You can leave the office at 5pm");
                 if (intime >= 9.30 && intime<10) Console.WriteLine("You can leave the office at 5.30pm");
                 if (intime >= 10 && intime<=10.30) Console.WriteLine("You can leave the office at 6pm");
                if (intime == 10.30) Console.WriteLine("You can leave the office at 6.30pm");
            }
            else Console.WriteLine("You are absent today  !!");
    Console.WriteLine("After if block");
            Console.WriteLine("Rest of the aplication");
          
        

            if (input == 0) Console.WriteLine("Zero");
           else if (input == 1) Console.WriteLine("One");
            else if (input == 2) Console.WriteLine("Two");
            else if(input == 3) Console.WriteLine("Three");
            else if (input == 4) Console.WriteLine("Four");
            else if (input == 5) Console.WriteLine("Five");
           else if (input == 6) Console.WriteLine("Six");

          

          Console.WriteLine("Enter a Input :  ");
            int input = int.Parse(Console.ReadLine());

          
             switch (input)
             {
                 case 0: Console.WriteLine("Zero");break;
                 case 1: Console.WriteLine("one");break;
                 case 2: Console.WriteLine("two");break;
                 case 3: Console.WriteLine("Three");break;
                 case 4: Console.WriteLine("Four");break;
                 case 5: Console.WriteLine("Five");break;
                 case 6: Console.WriteLine("Six");break;
             }

             */

            int age = 19;
            string eligiable = "";
            if (age >= 18)
            {
                eligiable = "You are eligible to vote";       
            }
            else
            {
                eligiable = "You are not eligiable";          
            }
            Console.WriteLine("If else  :  "+eligiable);
            string elig = age >= 19 ? "You are eligible to vote" : "You are not eligiable";
            Console.WriteLine("Short hand if else  : "+elig);
        }
    }
}
