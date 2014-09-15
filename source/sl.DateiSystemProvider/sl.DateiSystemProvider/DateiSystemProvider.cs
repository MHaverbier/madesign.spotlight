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

            var files = Directory.GetFiles(pfad, "*", SearchOption.AllDirectories);

            beiDateinamen(files);
        }

        public void DateiRelevant(string dateiNamen, Action<string> beiDateiInhalt)
        {
            if (dateiNamen.EndsWith(".txt"))
            {
                var f = new FileInfo(dateiNamen);
                var fileSize = f.Length;

                if (fileSize <= int.MaxValue)
                {
                    var file = File.OpenRead(dateiNamen);
                    var buffer = new byte[fileSize];

                    file.Read(buffer, 0, (int) fileSize);
                    beiDateiInhalt(buffer.ToString());
                }
            }
            //try
            //{
            //    using (var fileStream = File.OpenRead(dateiNamen))
            //    {
            //        if (fileStream.CanRead)
            //        {
            //            // search for "\0\0", if there: no text file 
            //        }
            //    }
            //}
            //catch (Exception)
            //{
            //}
            
        }
    }
}
