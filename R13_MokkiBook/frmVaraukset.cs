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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace R13_MokkiBook
{
    public partial class frmVaraukset : Form
    {
        public string connectionString = "Dsn=Village Newbies;uid=root";
        public string hakuquery = "SELECT * FROM varaus";
        public int valitturivi = -1;
        public DateTime nyt = DateTime.Now;
        public Varaus valittuvaraus;
        public List<Varaus> varaukset;

        public frmVaraukset()
        {
            InitializeComponent();
            varaukset = GetVaraukset();
        }
        public List<Varaus> GetVaraukset()
        {
            List<Varaus> var = new List<Varaus>();
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
        public Varaus GetValittuVaraus()
        {
            Varaus v = new Varaus();
            v.varaus_id = varaukset[valitturivi].varaus_id;
            v.asiakas_id = varaukset[valitturivi].asiakas_id;
            v.mokki_id = varaukset[valitturivi].mokki_id;
            v.varattu_pvm = varaukset[valitturivi].varattu_pvm;
            v.vahvistus_pvm = varaukset[valitturivi].vahvistus_pvm;
            v.varattu_alkupvm = varaukset[valitturivi].varattu_alkupvm;
            v.varattu_loppupvm = varaukset[valitturivi].varattu_loppupvm;
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
            //HUUTAA JOS KLIKKAA ULKOPUOLELTA
            valitturivi = dgvVaraukset.CurrentRow.Index;
            valittuvaraus = GetValittuVaraus();
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

            //frmUusiVaraus muokkaus = new frmUusiVaraus();
            //muokkaus.ShowDialog();
        }

        private void tsmiVarauksenPalvelut_Click(object sender, EventArgs e)
        {
            frmVarauksenPalvelut vp = new frmVarauksenPalvelut(valittuvaraus);
            vp.ShowDialog();
        }

        private void tsmiPoista_Click(object sender, EventArgs e)
        {
            //VALIDOI
        }

        private void btnHae_Click_1(object sender, EventArgs e)
        {
            if (ValidPvm())
            {

            }
            else
                MessageBox.Show("Hakua ei voitu suorittaa: Varauksen alkupäivämäärän on oltava ennen sen päättymispäivämäärää.");
        }

        public bool ValidPvm()
        {
            if(dtpAlku.Value < dtpLoppu.Value)
                return true;
            else
                return false;
        }

        private void btnTyhjennaHaku_Click(object sender, EventArgs e)
        {
            hakuquery = "SELECT * FROM  varaus";
        }

        public void PaivitaTaulu()
        {
            OdbcConnection connection = new OdbcConnection(connectionString);
            connection.Open();
            DataTable dataTable = new DataTable();
            using (OdbcDataAdapter adapter = new OdbcDataAdapter(hakuquery, connection))
            {
                adapter.FillSchema(dataTable, SchemaType.Source);
                adapter.Fill(dataTable);
            }
            dgvVaraukset.DataSource = dataTable;

            dgvVaraukset.Columns[0].HeaderText = "Varaustunnus";
            dgvVaraukset.Columns[1].HeaderText = "Asiakastunnus";
            dgvVaraukset.Columns[2].HeaderText = "Mökki";
            dgvVaraukset.Columns[3].HeaderText = "Varaus tehty";
            dgvVaraukset.Columns[4].HeaderText = "Varaus vahvistettu";
            dgvVaraukset.Columns[5].HeaderText = "Varauksen alkupäivä";
            dgvVaraukset.Columns[6].HeaderText = "Varauksen päättymispäivä";
        }
    }
}
