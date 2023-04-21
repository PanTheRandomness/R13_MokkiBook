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
    public partial class frmVarauksenPalvelut : Form
    {
        public frmVarauksenPalvelut()
        {
            InitializeComponent();
        }

        private void frmVarauksenPalvelut_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'varauksetData.varauksen_palvelut' table. You can move, or remove it, as needed.
            this.varauksen_palvelutTableAdapter.Fill(this.varauksetData.varauksen_palvelut);

        }
    }
}
