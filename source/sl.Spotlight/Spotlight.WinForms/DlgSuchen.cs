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
    public partial class DlgSuchen : Form
    {
        public DlgSuchen()
        {
            InitializeComponent();
        }

        private void btnSuchen_Click(object sender, EventArgs e)
        {
            BeiSuchauftrag(txtPfad.Text, txtBegriff.Text);
        }


        public event Action<string, string> BeiSuchauftrag;
    }
}
