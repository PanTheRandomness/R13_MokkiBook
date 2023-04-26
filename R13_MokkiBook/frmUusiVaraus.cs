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
    public partial class frmUusiVaraus : Form
    {
        public frmUusiVaraus()
        {
            InitializeComponent();
        }

        private void frmUusiVaraus_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.asiakas' table. You can move, or remove it, as needed.
            this.asiakasTableAdapter.Fill(this.dataSet1.asiakas);

        }

        private void mtbSp_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
