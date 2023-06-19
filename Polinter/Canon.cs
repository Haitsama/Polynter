using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polinter
{
    public class Canon : IPrinters
    {
        void IPrinters.Print(Printer printer)
        {
            Console.WriteLine("Canon printer printing....");
        }
        void IPrinters.Show(Printer printer)
        {
            Console.WriteLine("Canon display dimension : 9.5*12");
        }
    }
}
