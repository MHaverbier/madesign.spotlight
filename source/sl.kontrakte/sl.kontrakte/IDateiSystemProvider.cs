using System;
using System.Collections.Generic;

namespace sl.kontrakte
{
    public interface IDateiSystemProvider
    {
        void DateienBestimmen(
            string pfad,
            Action<IEnumerable<string>> beiDateinamen,
            Action<int> beiFortschritt );

        void DateiRelevant(string dateiNamen, Action<string> beiDateiInhalt);
    }
}
