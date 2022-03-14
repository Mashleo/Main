using System;
using ClassLibrary;

namespace HomeWork8
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var roomWithPrinters = new Room();
            roomWithPrinters.MakeThisLazyPrinterWork(" Обычный. проба печати ");

            var bluePrinter = new BluePrinter();
            roomWithPrinters.ReplacePrinter(bluePrinter);
            Console.ResetColor();
           
            var grenPrinter = new GreenPrinter();
            roomWithPrinters.ReplacePrinter(grenPrinter);
            Console.ResetColor();

           
            
            

            
        }
    }
}
