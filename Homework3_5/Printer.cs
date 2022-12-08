using System;
using System.Collections.Generic;
using System.Text;

namespace Homework3_5
{
    class Printer
    {
        
        public void Print(string value)
       {
           var type = this.GetType();

            if (type != typeof(Printer))
            {
                Console.ForegroundColor = ConsoleColor.DarkBlue;
            }
                        
            Console.WriteLine(value);
            Console.ResetColor();
        }
    }
}
