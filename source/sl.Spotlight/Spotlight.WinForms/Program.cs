using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using sl.DateiSystemProvider;
using sl.Domaene;

namespace Spotlight.WinForms
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var dlgSuchen = new DlgSuchen();
            Func<string,string,DlgTreffer> Build_DlgTreffer = (pfad, begriff) => new DlgTreffer(pfad, begriff);

            var dateisys = new DateiSystemProvider();
            var dom = new Domaene();

            dlgSuchen.BeiSuchauftrag += (pfad, begriff) => {
                var dlgTreffer = Build_DlgTreffer(pfad, begriff);
                var spot = new Spotlight(dateisys, dom);

                spot.Suchen(pfad, begriff, 
                    dlgTreffer.Treffer_anzeigen, 
                    dlgTreffer.Fortschritt_anzeigen);

                dlgTreffer.Show();
            };

            Application.Run(dlgSuchen);
        }
    }
}
