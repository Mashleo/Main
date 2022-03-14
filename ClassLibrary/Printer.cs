using System;

namespace ClassLibrary
{
    public class Printer
    {
        public string color { get; set; }
        public void Print(string value)
        {
            Console.WriteLine(value);
        }
    }
}
