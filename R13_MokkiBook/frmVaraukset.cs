using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace R13_MokkiBook
{
    public partial class frmVaraukset : Form
    {
        public int valitturivi = -1;
        public frmVaraukset()
        {
            InitializeComponent();
        }

        private void dgvVaraukset_SelectionChanged(object sender, EventArgs e)
        {
            valitturivi = dgvVaraukset.CurrentRow.Index;
        }

        private void frmVaraukset_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'varauksetData.varauksen_palvelut' table. You can move, or remove it, as needed.
            this.taVaraus.Fill(this.varauksetData.varaus);
        }
    }
}
