using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
