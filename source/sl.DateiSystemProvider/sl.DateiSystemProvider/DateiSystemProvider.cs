using System;
using System.Collections.Generic;
using System.IO;
using sl.kontrakte;

namespace sl.DateiSystemProvider
{
    public class DateiSystemProvider : IDateiSystemProvider
    {
        public void DateienBestimmen(string pfad, Action<IEnumerable<string>> beiDateinamen, Action<int> beiFortschritt)
        {
            beiFortschritt(-1);

            var dateiNamen = new List<string>();

            ApplyAllFiles(pfad, dateiNamen.Add);
            beiDateinamen(dateiNamen);
        }

        static void ApplyAllFiles(string folder, Action<string> fileAction)
        {
            foreach (var file in Directory.GetFiles(folder))
            {
                fileAction(file);
            }
            foreach (var subDir in Directory.GetDirectories(folder))
            {
                try
                {
                    ApplyAllFiles(subDir, fileAction);
                }
                catch
                {
                    // swallow, log, whatever
                }
            }
        }

        public void DateiRelevant(string dateiname, Action<string> beiDateiInhalt)
        {
            if (dateiname.EndsWith(".txt") || dateiname.EndsWith(".cs")) {
                var allText = File.ReadAllText(dateiname);
                beiDateiInhalt(allText);
            }
        }
    }
}
