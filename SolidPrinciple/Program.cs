using SolidPrinciple.LSP;
using System;

namespace SolidPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Open-Close Principle
            /*
            InvoiceWithOpenClosePrinciple FInvoice = new FinalInvoice();
            InvoiceWithOpenClosePrinciple PInvoice = new ProposedInvoice();
            InvoiceWithOpenClosePrinciple RInvoice = new RecurringInvoice();

            double FInvoiceAmount = FInvoice.GetInvoiceDiscount(10000);
            double PInvoiceAmount = PInvoice.GetInvoiceDiscount(10000);
            double RInvoiceAmount = RInvoice.GetInvoiceDiscount(10000);
            */
            #endregion

            #region Liskov
            Apple apple = new Orange();
            Console.WriteLine(apple.GetColor());

            Console.WriteLine("===============================");

            Fruit fruit = new Orange2();
            Console.WriteLine(fruit.GetColor());

            fruit = new Apple2();
            Console.WriteLine(fruit.GetColor());

            Console.WriteLine("===============================");
            #endregion

            Console.ReadLine();
        }
    }
}
