using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotlight
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Count() != 2)
            {
                Console.WriteLine("Programm beendet! Bitte immer mit 2 Parametern starten");
            }
            var pfad = args[0];
            var begriff = args[1];

            
        }

        private static void Suchen(string pfad, string begriff)
        {
            
        }

        private static void Filtern(IEnumerable<string> dateinamen, string begriff)
        {
            
        }
    }
}
