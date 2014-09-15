using System;
using System.Collections.Generic;
using System.Linq;
using sl.ConsolePortal;
using sl.DateiSystemProvider;
using sl.Domaene;

namespace Spotlight
{
    class Program
    {
        private static sl.kontrakte.IDateiSystemProvider _dateiSystemProvider = null;
        private static sl.kontrakte.IConsolePortal _consolePortal = null;
        private static sl.kontrakte.IDomäne _domäne = null;

        private static string _pfad;
        private static string _begriff;
        private static string _dateiName;

        static void Main(string[] args)
        {
            if (args.Count() != 2)
            {
                Console.WriteLine("Programm beendet! Bitte immer mit 2 Parametern starten");
            }

            _pfad = args[0];
            _begriff = args[1];

            // Initialisiert die Bausteine
            _dateiSystemProvider = new DateiSystemProvider();
            _consolePortal = new ConsolePortal();
            _domäne = new Domaene();

            // integrieren
            Suchen(_pfad);
            Console.ReadLine();
        }

        private static void Suchen(string pfad)
        {
            _dateiSystemProvider.DateienBestimmen(pfad, Filtern, _consolePortal.FortschrittAnzeigen);
        }

        private static void Filtern(IEnumerable<string> dateinamen)
        {
            _domäne.Fortschreiten(dateinamen, BeiDateiName,_consolePortal.FortschrittAnzeigen);
        }

        private static void BeiDateiName(string dateiName)
        {
            _dateiName = dateiName;
            _dateiSystemProvider.DateiRelevant(dateiName, BeiDateiInhalt);
        }

        private static void BeiDateiInhalt(string dateiInhalt)
        {
            _domäne.DateiDursuchen(_dateiName, dateiInhalt, _begriff, _consolePortal.TrefferAnzeigen);
        }
    }
}
