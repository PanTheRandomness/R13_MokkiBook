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
            // TODO: This line of code loads data into the 'alueenPAlvelutDataSet.palvelu' table. You can move, or remove it, as needed.
            this.palveluTableAdapter.Fill(this.alueenPAlvelutDataSet.palvelu);
            // TODO: This line of code loads data into the 'dataSet1.varaus' table. You can move, or remove it, as needed.
            this.varausTableAdapter.Fill(this.dataSet1.varaus);
            // TODO: This line of code loads data into the 'dataSet1.mokki' table. You can move, or remove it, as needed.
            this.mokkiTableAdapter.Fill(this.dataSet1.mokki);
            // TODO: This line of code loads data into the 'dataSet1.posti' table. You can move, or remove it, as needed.
            this.postiTableAdapter.Fill(this.dataSet1.posti);
            // TODO: This line of code loads data into the 'dataSet1.alue' table. You can move, or remove it, as needed.
            this.alueTableAdapter.Fill(this.dataSet1.alue);
            // TODO: This line of code loads data into the 'dataSet1.asiakas' table. You can move, or remove it, as needed.
            this.asiakasTableAdapter.Fill(this.dataSet1.asiakas);

        }

        private void mtbSp_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void dtmLoppupvm_ValueChanged(object sender, EventArgs e)
        {
            //Ei voi olla ennen alkupvm

        }

        private void dtpAlkupvm_ValueChanged(object sender, EventArgs e)
        {
            //ei voi olla aiemmin kuin nyt
        }

        private void dgvMokitUusiVaraus_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnLuoVaraus_Click(object sender, EventArgs e)
        {
            //Messagebox validointi
        }
    }
}
