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

        private void VarauksenPalvelutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVarauksenPalvelut palvelut = new frmVarauksenPalvelut();
            palvelut.ShowDialog();
        }

        private void tsmiPoista_Click(object sender, EventArgs e)
        {
            //VALIDOI: HALUATKO POISTAA?
            //Poistaako muuta kuin palvelun?
        }

        private void frmVaraukset_Leave(object sender, EventArgs e)
        {
            //VALIDOI: TALLENNETAANKO MUUTOKSET
        }

        private void cbAsiakas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbMokki_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbAlue_SelectedIndexChanged(object sender, EventArgs e)
        {
            //EI ALUETTA KOKO DATASETISSÄ??
        }

        private void dtpLoppu_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dtpAlku_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnHae_Click(object sender, EventArgs e)
        {

        }

        private void btnTulostaVarausRaportti_Click(object sender, EventArgs e)
        {

        }

        private void btnUusiVaraus_Click(object sender, EventArgs e)
        {

        }
    }
}
