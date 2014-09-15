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
        public void Fortschreiten(IEnumerable<string> dateiNamen, Action<string> beiDateiName, Action<int> beiFortschritt)
        {
            throw new NotImplementedException();
        }

        public void DateiDursuchen(string dateiNamen, string dateiInhalt, string begriff, Action<string> beiTreffer)
        {
            throw new NotImplementedException();
        }
    }
}
