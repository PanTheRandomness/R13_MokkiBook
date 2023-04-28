using System;
using System.Collections;
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
    public partial class frmVarauksenPalvelut : Form
    {
        public int valitturivi = -1;
        public Varaus kasiteltavavaraus = new Varaus();
        public List<Palvelu> varauksenpalvelut = new List<Palvelu>();
        public Palvelu valittupalvelu = new Palvelu();
        public string tauluquery;
        public string palveluquery;
        public string connectionString = "Dsn=Village Newbies;uid=root";
        public frmVarauksenPalvelut(Varaus tuotuvaraus)
        {
            InitializeComponent();
            kasiteltavavaraus = tuotuvaraus;
        }

        private void frmVarauksenPalvelut_Load(object sender, EventArgs e)
        {
            tauluquery = "SELECT * FROM varauksen_palvelut WHERE varaus_id = " + kasiteltavavaraus.varaus_id.ToString();
            palveluquery = "SELECT palvelu.nimi FROM palvelu WHERE palvelu.alue_id = (SELECT mokki.alue_id FROM mokki WHERE mokki.mokki_id = (SELECT varaus.mokki_mokki_id FROM varaus WHERE varaus.varaus_id = " + kasiteltavavaraus.mokki_id + "));";
            OdbcConnection connection = new OdbcConnection(connectionString);
            connection.Open();
            //datagridviewin yhdistäminen tiettyyn kyselyyn
            DataTable dataTable = new DataTable();
            using (OdbcDataAdapter adapter = new OdbcDataAdapter(tauluquery, connection))
            {
                adapter.FillSchema(dataTable, SchemaType.Source);
                adapter.Fill(dataTable);
            }
            dgvVarauksenPalvelut.DataSource = dataTable;
            //comboboxin yhdistäminen tiettyyn kyselyyn
            List<String> palvelunimet = new List<string>();
            using (OdbcCommand command = new OdbcCommand(palveluquery, connection))
            {
                using (OdbcDataReader reader = command.ExecuteReader())
                {
                    while(reader.Read())
                    {
                        string palvelunnimi = reader.GetString(0);
                        palvelunimet.Add(palvelunnimi);
                    }
                }
            }
            cbPalvelu.DataSource = palvelunimet;
        }

        private void dgvVarauksenPalvelut_SelectionChanged(object sender, EventArgs e)
        {
            valitturivi = dgvVarauksenPalvelut.CurrentRow.Index;
        }

        private void btnLisaa_Click(object sender, EventArgs e)
        {
            frmUusiPalvelu up = new frmUusiPalvelu();
            up.ShowDialog();
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
