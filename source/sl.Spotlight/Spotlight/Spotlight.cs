using System;
using System.Collections.Generic;
using sl.kontrakte;

namespace Spotlight
{
    public class Spotlight
    {
        private readonly IDateiSystemProvider _dateiSystemProvider;
        private readonly IDomäne _domäne;

        public Spotlight(IDateiSystemProvider dateiSystemProvider, IDomäne domäne)
        {
            _dateiSystemProvider = dateiSystemProvider;
            _domäne = domäne;
        }

        public void Suchen(string pfad, string begriff, Action<string> beiTreffer, Action<int> beiFortschritt)
        {
            _dateiSystemProvider.DateienBestimmen(pfad,
                dateinamen => Filtern(dateinamen, begriff, 
                    beiTreffer, 
                    beiFortschritt),
                beiFortschritt);
        }

        private void Filtern(IEnumerable<string> dateinamen, string begriff, Action<string> beiTreffer, Action<int> beiFortschritt)
        {
            _domäne.Fortschreiten(dateinamen,
                dateiName => _dateiSystemProvider.DateiRelevant(dateiName,
                    dateiInhalt => _domäne.DateiDursuchen(dateiName, dateiInhalt, begriff,
                        beiTreffer)),
                beiFortschritt);
        }
    }
}
