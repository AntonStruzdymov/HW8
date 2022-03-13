using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW8Library
{
    public class BluePrinter:Printer
    {
        public override void Print(string value)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            base.Print(value);
            Console.ResetColor();
        }   
        
        
    }
}
