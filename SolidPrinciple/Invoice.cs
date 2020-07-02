using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciple
{
    public class Invoice
    {
        public long InvAmount { get; set; }
        public DateTime InvDate { get; set; }

        public void AddInvoice()
        {
            try
            {

            }
            catch (Exception ex)
            {
                System.IO.File.WriteAllText(@"c:\ErrorLog.txt", ex.ToString());
            }
        }

        public void DeleteInvoice()
        {
            try
            {

            }
            catch (Exception ex)
            {
                System.IO.File.WriteAllText(@"c:\ErrorLog.txt", ex.ToString());
            }
        }

        public void SendInvoiceEmail(MailMessage mailMessage)
        {
            try
            {

            }
            catch (Exception ex)
            {
                System.IO.File.WriteAllText(@"c:\ErrorLog.txt", ex.ToString());
            }
        }

    }
}
