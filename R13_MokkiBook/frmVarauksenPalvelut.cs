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
        public int valitturivi = -1;
        public Varaus kasiteltavavaraus = new Varaus();
        //public List<Palvelu> varauksenpalvelut = new List<Palvelu>();
        //public Palvelu valittupalvelu = new Palvelu();
        public frmVarauksenPalvelut(Varaus tuotuvaraus)
        {
            InitializeComponent();
            kasiteltavavaraus = tuotuvaraus;
        }

        private void frmVarauksenPalvelut_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'varauksenPAlvelutDataSet.varauksen_palvelut' table. You can move, or remove it, as needed.
            this.varauksen_palvelutTableAdapter1.Fill(this.varauksenPAlvelutDataSet.varauksen_palvelut);

            //TUOHON FILLIIN JOTAIN QUERYHOMMIA

            // TODO: This line of code loads data into the 'dataSet1.palvelu' table. You can move, or remove it, as needed.
            this.palveluTableAdapter.Fill(this.dataSet1.palvelu);
            // TODO: This line of code loads data into the 'dataSet1.varauksen_palvelut' table. You can move, or remove it, as needed.
            this.varauksen_palvelutTableAdapter.Fill(this.dataSet1.varauksen_palvelut);

        }

        private void dgvVarauksenPalvelut_SelectionChanged(object sender, EventArgs e)
        {
            valitturivi = dgvVarauksenPalvelut.CurrentRow.Index;
        }

        private void btnLisaa_Click(object sender, EventArgs e)
        {
            /*frmUusiPalvelu up = new frmUusiPalvelu(); VAATII DGV-PARAMETRIN??
            up.ShowDialog();*/
        }

        private void btnPoista_Click(object sender, EventArgs e)
        {
            //if (MessageBox.Show("Haluatko varmasti poistaa palvelun tästä varauksesta?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            //{

            //}
            //VALIDOI
        }

        private void btnLisaaValittu_Click(object sender, EventArgs e)
        {
            //Lisää varaukseen
        }

        private void cbPalvelu_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
