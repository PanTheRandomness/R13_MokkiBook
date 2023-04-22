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

        private void frmVaraukset_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.varaus' table. You can move, or remove it, as needed.
            this.varausTableAdapter.Fill(this.dataSet1.varaus);

        }

        private void dgvVaraukset_SelectionChanged(object sender, EventArgs e)
        {
            valitturivi = dgvVaraukset.CurrentRow.Index;
        }

        private void dtpAlku_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dtpLoppu_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cbAlue_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbMokki_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbAsiakas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnHae_Click(object sender, EventArgs e)
        {

        }

        private void btnRaportti_Click(object sender, EventArgs e)
        {

        }

        private void btnUusi_Click(object sender, EventArgs e)
        {
            frmUusiVaraus uv = new frmUusiVaraus();
            uv.ShowDialog();
        }

        private void tsmiMuokkaa_Click(object sender, EventArgs e)
        {
            //VALIDOI
        }

        private void tsmiVarauksenPalvelut_Click(object sender, EventArgs e)
        {
            frmVarauksenPalvelut vp = new frmVarauksenPalvelut();
            vp.ShowDialog();
        }

        private void tsmiPoista_Click(object sender, EventArgs e)
        {
            //VALIDOI
        }

        private void frmVaraukset_Leave(object sender, EventArgs e)
        {
            //VALIDOI
        }
    }
}
