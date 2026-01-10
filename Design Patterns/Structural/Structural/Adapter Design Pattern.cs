using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Text;

namespace Structural
{
  //Adapter pattern lets two incompatible classes work together by converting one interface into another.

    //Real-Life Example(Easiest) 🔌
    //    Mobile Charger Adapter

    //    Wall socket → 3-pin

    //    Mobile charger → 2-pin

    //    Adapter converts 3-pin → 2-pin

    //    👉 Adapter makes incompatible things compatible.

    class OldPrinter  //existing incompatible class
    {
        public void PrintText(string text)
        {
            Console.WriteLine("Old Printer Printing: " + text);
        }
    }

    interface INewPrinter  //Target Interface
    {
        void Print(String message);
    }

    class PrinterAdapter : INewPrinter  //Adapter class
    {
        private OldPrinter oldPrinter = new OldPrinter();

        public void Print(String message)
        {
            oldPrinter.PrintText(message);
        }
    }

    class Program  //Client Code

    {
        //static void Main(string[] args)
        //{
        //    INewPrinter printer = new PrinterAdapter();
        //    printer.Print("HelloWorld");
        //}
    }

}
