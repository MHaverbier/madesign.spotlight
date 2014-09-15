using System;
using System.Collections.Generic;
using System.Linq;
using sl.kontrakte;

namespace sl.Domaene
{
    public class Domaene : IDomäne
    {
        public void Fortschreiten( IEnumerable<string> dateiNamen, Action<string> beiDateiName, Action<int> beiFortschritt )
        {
            var dateiAnzahl = dateiNamen.Count();
            var dateiNummer = 0;

            var fortschritt = -1;

            foreach ( var dateiName in dateiNamen )
            {
                var neuerFortschritt = dateiNummer * 100 / dateiAnzahl;
                if ( neuerFortschritt != fortschritt )
                {
                    fortschritt = neuerFortschritt;
                    beiFortschritt( fortschritt );
                }

                beiDateiName( dateiName );
                dateiNummer++;
            }
            beiFortschritt( 100 );
        }

        public void DateiDursuchen( string dateiNamen, string dateiInhalt, string begriff, Action<string> beiTreffer )
        {
            if ( dateiInhalt.Contains( begriff ) )
            {
                beiTreffer( dateiNamen );
            }
        }
    }
}
