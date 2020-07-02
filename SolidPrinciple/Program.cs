using System;

namespace SolidPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            InvoiceWithOpenClosePrinciple FInvoice = new FinalInvoice();
            InvoiceWithOpenClosePrinciple PInvoice = new ProposedInvoice();
            InvoiceWithOpenClosePrinciple RInvoice = new RecurringInvoice();

            double FInvoiceAmount = FInvoice.GetInvoiceDiscount(10000);
            double PInvoiceAmount = PInvoice.GetInvoiceDiscount(10000);
            double RInvoiceAmount = RInvoice.GetInvoiceDiscount(10000);

            Console.ReadLine();
        }
    }
}
