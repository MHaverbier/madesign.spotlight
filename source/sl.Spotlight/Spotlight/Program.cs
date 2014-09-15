using System;
using sl.ConsolePortal;
using sl.DateiSystemProvider;
using sl.Domaene;

namespace Spotlight
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initialisiert die Bausteine
            var dateiSystemProvider = new DateiSystemProvider();
            var consolePortal = new ConsolePortal();
            var domäne = new Domaene();

            var spotlight = new Spotlight(dateiSystemProvider, domäne);

            // integrieren
            spotlight.Suchen(args[0], args[1],
                consolePortal.TrefferAnzeigen,
                consolePortal.FortschrittAnzeigen);
            Console.ReadLine();
        }
    }
}
