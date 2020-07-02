using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciple
{
    public class InvoiceWithOpenClosePrinciple
    {
        public virtual double GetInvoiceDiscount(double amount)
        {
            return amount - 10;
        }       
    }

    public class FinalInvoice : InvoiceWithOpenClosePrinciple
    {
        public override double GetInvoiceDiscount(double amount)
        {
            return base.GetInvoiceDiscount(amount) - 50;
        }
    }

    public class ProposedInvoice : InvoiceWithOpenClosePrinciple
    {
        public override double GetInvoiceDiscount(double amount)
        {
            return base.GetInvoiceDiscount(amount) - 40;
        }
    }

    public class RecurringInvoice : InvoiceWithOpenClosePrinciple
    {
        public override double GetInvoiceDiscount(double amount)
        {
            return base.GetInvoiceDiscount(amount) - 30;
        }
    }
}
