using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW8Library
{
    public class Room
    {
        Printer printer;
        public void MakeThisLazyPrinterWork(string value)
        {
            printer.Print(value);
        }
        public void CurrentPrinter(Printer printer)
        {
            this.printer = printer;
        }
    }
}
