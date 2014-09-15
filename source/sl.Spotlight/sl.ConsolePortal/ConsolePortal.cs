using System;
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
            if (fortschritt == -1)
            {
                Console.WriteLine("Init");
            }
            else
            {
                Console.WriteLine(fortschritt + "%");
            }
        }
    }
}
