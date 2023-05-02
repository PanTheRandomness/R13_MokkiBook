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
    public partial class frmAsiakkaat : Form
    {
        public List<Asiakas> asiakkaat;

        public frmAsiakkaat()
        {
            InitializeComponent();
            asiakkaat = new List<Asiakas>();
        }

        private void frmAsiakkaat_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.asiakas' table. You can move, or remove it, as needed.
            this.asiakasTableAdapter.Fill(this.dataSet1.asiakas);

        }
       
        public void LisaaAsiakas()
        {
            Asiakas a = new Asiakas();
            a.asiakas_id = int.Parse(tbAsiakasid.Text);
            a.postinro = tbPostiNro.Text;
            a.etunimi = tbEtunimi.Text;
            a.sukunimi = tbSukunimi.Text;
            a.lahiosoite = tbLahiosoite.Text;
            a.email = tbEmail.Text;
            a.puhelinnro = tbPuhelinnro.Text;
            asiakkaat.Add(a);
        }

        //Asiakaslista datagridview:hyn

        private void btnLisaa_Click(object sender, EventArgs e)
        {
            LisaaAsiakas();
            dgvAsiakkaat.DataSource = null;
            dgvAsiakkaat.DataSource = asiakkaat;

        }

    }
}
