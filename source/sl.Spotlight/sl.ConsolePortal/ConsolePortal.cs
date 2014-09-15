using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sl.kontrakte;

namespace sl.ConsolePortal
{
    public class ConsolePortal : IConsolePortal
    {
        public void TrefferAnzeigen(string dateiNamen)
        {
            Console.WriteLine(dateiNamen);
        }

        public void FortschrittAnzeigen(int fortschritt)
        {
           Console.WriteLine(fortschritt);
        }
    }
}
