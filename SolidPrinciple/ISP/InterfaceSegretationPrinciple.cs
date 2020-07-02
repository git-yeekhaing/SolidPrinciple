using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciple.ISP
{
    class InterfaceSegretationPrinciple
    {
    }

    public interface IPrinterTasks2
    {
        void Print(string PrintContent);
        void Scan(string ScanContent);
    }

    interface IFaxTasks
    {
        void Fax(string content);
    }
    interface IPrintDuplexTasks
    {
        void PrintDuplex(string content);
    }
}
