using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
     public class BluePrinter : Printer
    {
        public BluePrinter()
        {
            color =  "Синий";
            Console.ForegroundColor = ConsoleColor.Blue;
        }
       
        
    }
}
