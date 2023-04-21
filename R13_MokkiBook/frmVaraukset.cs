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
    }
}
