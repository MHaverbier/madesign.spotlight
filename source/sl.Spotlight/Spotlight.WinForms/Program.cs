using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Retlang.Channels;
using Retlang.Fibers;
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

            // build
            var dlgSuchen = new DlgSuchen();
            Func<string,string,DlgTreffer> Build_DlgTreffer = (pfad, begriff) => new DlgTreffer(pfad, begriff);

            var dateisys = new DateiSystemProvider();
            var dom = new Domaene();

            var fiUI = new DispatcherFiber();


            // bind
            dlgSuchen.BeiSuchauftrag += (pfad, begriff) => {
                // build
                var dlgTreffer = Build_DlgTreffer(pfad, begriff);

                var chTreffer = new Channel<string>();
                var chFortschritt = new Channel<int>();
                var chSuchen = new Channel<bool>();
                var fiSuchen = new PoolFiber();

                // bind
                chSuchen.Subscribe(fiSuchen, _ => {
                    var spot = new Spotlight(dateisys, dom);

                    spot.Suchen(pfad, begriff, 
                        treffer => chTreffer.Publish(treffer),
                        fortschritt => chFortschritt.Publish(fortschritt));
                });
                chTreffer.Subscribe(fiUI, dlgTreffer.Treffer_anzeigen);
                chFortschritt.Subscribe(fiUI, dlgTreffer.Fortschritt_anzeigen);

                // run
                dlgTreffer.Show();
                fiSuchen.Start();
                chSuchen.Publish(true);
            };


            // run
            fiUI.Start();
            Application.Run(dlgSuchen);
        }
    }
}
