using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spotlight.WinForms
{
    public partial class DlgTreffer : Form
    {
        public DlgTreffer(string pfad, string begriff)
        {
            InitializeComponent();

            lblPfad.Text = pfad;
            lblBegriff.Text = begriff;
        }


        public void Fortschritt_anzeigen(int fortschritt)
        {
            if (fortschritt < 1)
                progressBar1.Text = "Initialisierung...";
            else
                progressBar1.Value = fortschritt;
        }


        public void Treffer_anzeigen(string dateiname)
        {
            listBox1.Items.Add(dateiname);
        }
    }
}
