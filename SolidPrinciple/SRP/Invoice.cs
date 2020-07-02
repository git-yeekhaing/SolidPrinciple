using System;
using System.Net.Mail;

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
                MailMessage mailMessage = new MailMessage("EMailFrom", "EMailTo", "EMailSubject", "EMailBody");
                this.SendInvoiceEmail(mailMessage);
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
