using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace R13_MokkiBook
{
    public partial class frmHaePalvelu : Form
    {
        public Varaus kasiteltavavaraus;
        public Palvelu valittupalvelu;
        public VarauksenPalvelut lisattava;
        public int valitturivi = -1;
        public int palvelumaara;
        public string connectionString = "Dsn=Village Newbies;uid=root";
        public string query;
        public List<Palvelu> palvelut;
        public frmHaePalvelu(Varaus tuotu)
        {
            InitializeComponent();
            kasiteltavavaraus = tuotu;
            query = "SELECT * FROM palvelu WHERE palvelu.alue_id = (SELECT mokki.alue_id FROM mokki WHERE mokki.mokki_id = (SELECT varaus.mokki_mokki_id FROM varaus WHERE varaus.varaus_id = " + kasiteltavavaraus.varaus_id + "));";
            TuoData();
            palvelut = GetPalvelut();
        }
        public void TuoData()
        {
            OdbcConnection connection = new OdbcConnection(connectionString);
            connection.Open();
            //datagridviewin yhdistäminen tiettyyn kyselyyn
            DataTable dataTable = new DataTable();
            using (OdbcDataAdapter adapter = new OdbcDataAdapter(query, connection))
            {
                adapter.FillSchema(dataTable, SchemaType.Source);
                adapter.Fill(dataTable);
            }
            dgvAlueenPalvelut.DataSource = dataTable;
            dgvAlueenPalvelut.Columns[0].HeaderText = "Palvelutunnus";
            dgvAlueenPalvelut.Columns[1].HeaderText = "Aluetunnus";
            dgvAlueenPalvelut.Columns[2].HeaderText = "Nimi";
            dgvAlueenPalvelut.Columns[3].HeaderText = "Tyyppi";
            dgvAlueenPalvelut.Columns[4].HeaderText = "Kuvaus";
            dgvAlueenPalvelut.Columns[5].HeaderText = "Hinta";
            dgvAlueenPalvelut.Columns[6].HeaderText = "ALV";
        }
        public List<Palvelu> GetPalvelut()
        {
            List<Palvelu> pp = new List<Palvelu>();

            using (OdbcConnection connection = new OdbcConnection(connectionString))
            {
                connection.Open();
                using (OdbcCommand command = new OdbcCommand(query, connection))
                {
                    using (OdbcDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Palvelu p = new Palvelu();
                            p.palvelu_id = reader.GetInt32(0);
                            p.alue_id = reader.GetInt32(1);
                            p.nimi = reader.GetString(2);
                            p.tyyppi = reader.GetString(3);
                            p.kuvaus = reader.GetString(4);
                            p.hinta = reader.GetDouble(5);
                            p.alv = reader.GetDouble(6);
                            pp.Add(p);
                        }
                    }
                }
            }
            return pp;
        }

        private void dgvAlueenPalvelut_SelectionChanged(object sender, EventArgs e)
        {
            valitturivi = dgvAlueenPalvelut.CurrentRow.Index;
            valittupalvelu = palvelut[valitturivi];
            tbKuvaus.Text = valittupalvelu.kuvaus;
        }

        private void nudMaara_ValueChanged(object sender, EventArgs e)
        {
            palvelumaara = (int)nudMaara.Value;
        }

        private void btnLisaa_Click(object sender, EventArgs e)
        {
            if (nudMaara.Value == 0 || palvelumaara == 0)
            {
                if (MessageBox.Show("Lisättyjen palvelujen määärä on 0, palvelua ei lisätä. Haluatko silti poistua?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Palataan hakuun.");
                }
            }
            else
            {
                lisattava = new VarauksenPalvelut();
                lisattava.varaus_id = kasiteltavavaraus.varaus_id;
                lisattava.palvelu_id = valittupalvelu.palvelu_id;
                lisattava.lkm = palvelumaara;

                //Lisää palautettava-homman tietokantaan instancena
                using (OdbcConnection connection = new OdbcConnection(connectionString))
                {
                    //JOS ON JO PALVELU-->>> Lisää
                    connection.Open();
                    string lisaysquery = "INSERT INTO varauksen_palvelut(varaus_id, palvelu_id, lkm) VALUES(" + lisattava.varaus_id + ", " + lisattava.palvelu_id +", " + lisattava.lkm + ")";
                    using (OdbcCommand cmd= new OdbcCommand(lisaysquery, connection))
                    {
                        cmd.ExecuteNonQuery();
                    }

                    this.Close();
                    frmVarauksenPalvelut vp = new frmVarauksenPalvelut(kasiteltavavaraus);
                    vp.ShowDialog();
                }
            }
        }
    }
}
