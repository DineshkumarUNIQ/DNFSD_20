using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNFSD_20
{
    internal class MarkSheet
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a Student Name : ");
            string Name=Console.ReadLine();
            Console.Write("ENter a Class Name   : ");
            string Class=Console.ReadLine();
            Console.Write(" Enter a Tamil Subject Mark  :  ");
            int TamilMark=int.Parse(Console.ReadLine());
            Console.Write(" Enter a English Subject Mark  :  ");
            int EnglishMark = int.Parse(Console.ReadLine());
            Console.Write(" Enter a Maths Subject Mark  :  ");
            int MathsMark = int.Parse(Console.ReadLine());
            Console.Write(" Enter a Science Subject Mark  :  ");
            int SciencsMark = int.Parse(Console.ReadLine());
            Console.Write(" Enter a Social Science Subject Mark  :  ");
            int SocialMark = int.Parse(Console.ReadLine());
            string TamilGrade, EnglishGrade, MathsGrade, ScienceGrade, SocialGrade;
            if (TamilMark >= 35 && TamilMark <= 100)
            {
                if (TamilMark <= 100 && TamilMark >= 91) TamilGrade = "A";
                else if (TamilMark <= 90 && TamilMark >= 81) TamilGrade = "B";
                else if (TamilMark <= 80 && TamilMark >= 71) TamilGrade = "C";
                else if (TamilMark <= 70 && TamilMark >= 61) TamilGrade = "D";
                else TamilGrade = "E";
            }
            else TamilGrade = "Fail";
            if (EnglishMark >= 35 && EnglishMark <= 100)
            {
                if (EnglishMark <= 100 && EnglishMark >= 91) EnglishGrade = "A";
                else if (EnglishMark <= 90 && EnglishMark >= 81) EnglishGrade = "B";
                else if (EnglishMark <= 80 && EnglishMark >= 71) EnglishGrade = "C";
                else if (EnglishMark <= 70 && EnglishMark >= 61) EnglishGrade = "D";
                else EnglishGrade = "E";
            }
            else EnglishGrade = "Fail";
            if (MathsMark >= 35 && MathsMark <= 100)
            {
                if (MathsMark <= 100 && MathsMark >= 91) MathsGrade = "A";
                else if (MathsMark <= 90 && MathsMark >= 81) MathsGrade = "B";
                else if (MathsMark <= 80 && MathsMark >= 71) MathsGrade = "C";
                else if (MathsMark <= 70 && MathsMark >= 61) MathsGrade = "D";
                else MathsGrade = "E";
            }
            else MathsGrade = "Fail";
            if (SciencsMark >= 35 && SciencsMark <= 100)
            {
                if (SciencsMark <= 100 && SciencsMark >= 91) ScienceGrade = "A";
                else if (SciencsMark <= 90 && SciencsMark >= 81) ScienceGrade = "B";
                else if (SciencsMark <= 80 && SciencsMark >= 71) ScienceGrade = "C";
                else if (SciencsMark <= 70 && SciencsMark >= 61) ScienceGrade = "D";
                else ScienceGrade = "E";
            }
            else ScienceGrade = "Fail";
            if (SocialMark >= 35 && SocialMark <= 100)
            {
                if (SocialMark <= 100 && SocialMark >= 91) SocialGrade = "A";
                else if (SocialMark <= 90 && SocialMark >= 81) SocialGrade = "B";
                else if (SocialMark <= 80 && SocialMark >= 71) SocialGrade = "C";
                else if (SocialMark <= 70 && SocialMark >= 61) SocialGrade = "D";
                else SocialGrade = "E";
            }
            else SocialGrade = "Fail";
            int total = TamilMark + EnglishMark + MathsMark + SciencsMark + SocialMark;
            string OverAllGrade;
            if (TamilGrade == "Fail" || EnglishGrade == "Fail" || MathsGrade == "Fail" || ScienceGrade == "Fail" || SocialGrade == "Fail" )
                OverAllGrade = "No Grade Re Appear";
            else
            {
                if (total <= 500 && total >= 451) OverAllGrade = "First Class";
                else if (total <= 450 && total >= 401) OverAllGrade = "Second Class";
                else if (total <= 400 && total >= 351) OverAllGrade = "Third Class";
                else if (total <= 350 && total >= 301) OverAllGrade = "Fourth Class";
                else OverAllGrade = "Fifth Class";
            }
            Console.WriteLine("\n\n\n\n\n");
            Console.WriteLine("                            STATE BOARD");
            Console.WriteLine("                         GovernMent High School");
            Console.WriteLine($"Name  : {Name}         Register No  : 2468038        Class  : {Class}\n");
            Console.WriteLine("             Subject           Mark          Grade \n");
            Console.WriteLine($"            Tamil             {TamilMark}           {TamilGrade}");
            Console.WriteLine($"            English           {EnglishMark}           {EnglishGrade}");
            Console.WriteLine($"            Maths             {MathsMark}           {MathsGrade}");
            Console.WriteLine($"            Science           {SciencsMark}           {ScienceGrade}");
            Console.WriteLine($"            Social            {SocialMark}           {SocialGrade}\n");
            Console.WriteLine($"            Total             {total}           {OverAllGrade}");

        }
    }
}
