using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sl.kontrakte;

namespace sl.Domaene
{
    public class Domaene : IDomäne
    {
        public void Fortschreiten( IEnumerable<string> dateiNamen, Action<string> beiDateiName, Action<int> beiFortschritt )
        {
            var dateiAnzahl = dateiNamen.Count();
            var dateiNummer = 0;
            foreach ( var dateiName in dateiNamen )
            {
                beiFortschritt( dateiNummer * 100 / dateiAnzahl );
                beiDateiName( dateiName );
                dateiNummer++;
            }
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
