using System;

namespace ConsoleApp1
{
    public class StringPrinter
    {
        public string PrintString()
        {
            return "Hello";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            StringPrinter sp = new StringPrinter();
            Console.WriteLine(sp.PrintString());
        }
    }
}
