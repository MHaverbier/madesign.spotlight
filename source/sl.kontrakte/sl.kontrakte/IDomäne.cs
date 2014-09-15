using System;
using System.Collections.Generic;

namespace sl.kontrakte
{
    public interface IDomäne
    {
        void Fortschreiten(IEnumerable<string> dateiNamen, Action<string> beiDateiName, Action<int> beiFortschritt);

        void DateiDursuchen(string dateiNamen, string dateiInhalt, string begriff, Action<string> beiTreffer);
    }
}