using System;
using System.Collections.Generic;
using sl.kontrakte;

namespace sl.DateiSystemProvider
{
    public class DateiSystemProvider : IDateiSystemProvider
    {
        public void DateienBestimmen(string pfad, Action<IEnumerable<string>> beiDateinamen, Action<int> beiFortschritt)
        {
        }

        public void DateiRelevant(string dateiNamen, Action<string> beiDateiInhalt)
        {
        }
    }
}
