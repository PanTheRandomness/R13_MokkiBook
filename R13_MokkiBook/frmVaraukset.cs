using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
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
        public Varaus valittuvaraus = new Varaus();
        public List<Varaus> varaukset;

        public frmVaraukset()
        {
            InitializeComponent();
            varaukset = GetVaraukset();
        }
        public List<Varaus> GetVaraukset()
        {
            List<Varaus> var = new List<Varaus>();
            string connectionString = "Dsn=Village Newbies;uid=root";
            string query = "SELECT * FROM varaus";

            using (OdbcConnection connection = new OdbcConnection(connectionString))
            {
                connection.Open();
                using (OdbcCommand command = new OdbcCommand(query, connection))
                {
                    using (OdbcDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Varaus varaus = new Varaus();
                            varaus.varaus_id = reader.GetInt32(0);
                            varaus.asiakas_id = reader.GetInt32(1);
                            varaus.mokki_id = reader.GetInt32(2);
                            varaus.varattu_pvm = reader.GetDateTime(3);
                            varaus.vahvistus_pvm = reader.GetDateTime(4);
                            varaus.varattu_alkupvm = reader.GetDateTime(5);
                            varaus.varattu_loppupvm = reader.GetDateTime(6);

                            var.Add(varaus);
                        }
                    }
                }
            }
            return var;
        }
        public Varaus GetValittuVaraus(int rivi)
        {
            Varaus v = new Varaus();
            v.varaus_id = varaukset[rivi].varaus_id;
            v.asiakas_id = varaukset[rivi].asiakas_id;
            v.mokki_id = varaukset[rivi].mokki_id;
            v.varattu_pvm = varaukset[rivi].varattu_pvm;
            v.vahvistus_pvm = varaukset[rivi].vahvistus_pvm;
            v.varattu_alkupvm = varaukset[rivi].varattu_alkupvm;
            v.varattu_loppupvm = varaukset[rivi].varattu_loppupvm;
            return v;
        }

        private void frmVaraukset_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.alue' table. You can move, or remove it, as needed.
            this.alueTableAdapter.Fill(this.dataSet1.alue);
            // TODO: This line of code loads data into the 'dataSet1.mokki' table. You can move, or remove it, as needed.
            this.mokkiTableAdapter.Fill(this.dataSet1.mokki);
            // TODO: This line of code loads data into the 'dataSet1.varaus' table. You can move, or remove it, as needed.
            this.varausTableAdapter.Fill(this.dataSet1.varaus);

        }

        private void dgvVaraukset_SelectionChanged(object sender, EventArgs e)
        {
            valitturivi = dgvVaraukset.CurrentRow.Index;
            valittuvaraus = GetValittuVaraus(valitturivi);
        }

        private void dtpAlku_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dtpLoppu_ValueChanged(object sender, EventArgs e)
        {
            //EI voi olla pienempi kuin alku
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
            //Esittää dgv:ssä vain 
        }

        private void btnRaportti_Click(object sender, EventArgs e)
        {
            pdRaportti.ShowDialog();
            //MITÄ VIELÄ?
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
            frmVarauksenPalvelut vp = new frmVarauksenPalvelut(valittuvaraus.varaus_id);
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

        private void cmsVaraustaulunMenu_Opening(object sender, CancelEventArgs e)
        {

        }

        private void tyhjennaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //tyhjentää hakukriteerin sender.jotain
        }
    }
}
