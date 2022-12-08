using System;

namespace Homework3_5
{
    class Program
    {
        static void Main(string[] args)
        {

            Printer printer = new Printer();
            DerivativePrinter derivativePrinter = new DerivativePrinter();
            DerivativePrinter derivativePrinter2 = new DerivativePrinter();


            
            derivativePrinter.Print("deriv");
            printer.Print("base");
            derivativePrinter2.Print("deriv2");


            Console.ReadKey();
        }
    }

    class DerivativePrinter : Printer
    {
                

    }
}
