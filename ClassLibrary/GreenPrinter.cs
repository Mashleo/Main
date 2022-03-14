using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
     public class GreenPrinter : Printer
    {
        public GreenPrinter()
        {
          color = "Зеленый";
            Console.ForegroundColor = ConsoleColor.Green;
        }
       
    }
}
