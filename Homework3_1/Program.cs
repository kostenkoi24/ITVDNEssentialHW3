using System;

namespace Homework3_1
{
    class Program
    {
        static void Main(string[] args)
        {

            ExcelentPupil excelentPupil = new ExcelentPupil();
            GoodPupil goodPupil = new GoodPupil();
            BadPupil badPupil = new BadPupil();

            PrintLine("4 params");
            ClassRoom classRoom4 = new ClassRoom(excelentPupil, badPupil, goodPupil, excelentPupil);
            PrintLine();
            PrintLine("3 params");
            ClassRoom classRoom3 = new ClassRoom(excelentPupil, badPupil, goodPupil);
            PrintLine();
            PrintLine("2 params");
            ClassRoom classRoom2 = new ClassRoom(excelentPupil, badPupil);
            PrintLine();
            Console.ReadKey();
        }

        static void PrintLine(string p = "")
        {
            Console.WriteLine("{0} {1}",new string('-', 40), p);
        }
    }
}
