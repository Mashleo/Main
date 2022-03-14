using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Room
    {

        Printer PrinterOne = new Printer();
      
        public void MakeThisLazyPrinterWork(string value)
        {
            PrinterOne.Print($" Тект : Вот тут много текста,\n а принтер сейчас подкючен: {value}") ;
        }
         public void ReplacePrinter (Printer printer)
        {
            MakeThisLazyPrinterWork(printer.color);
            
        }
    }
}
