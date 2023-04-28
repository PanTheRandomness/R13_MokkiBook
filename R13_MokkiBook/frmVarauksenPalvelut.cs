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
        public List<VarauksenPalvelut> varauksenpalvelut = new List<VarauksenPalvelut>();
        public VarauksenPalvelut valittupalvelu = new VarauksenPalvelut();
        public string tauluquery;
        public string palveluquery;
        public string connectionString = "Dsn=Village Newbies;uid=root";
        public frmVarauksenPalvelut(Varaus tuotuvaraus)
        {
            InitializeComponent();
            kasiteltavavaraus = tuotuvaraus;
            varauksenpalvelut = GetVarauksenPalvelut();
        }

        private void frmVarauksenPalvelut_Load(object sender, EventArgs e)
        {
            tauluquery = "SELECT * FROM varauksen_palvelut WHERE varaus_id = " + kasiteltavavaraus.varaus_id.ToString();
            //JOS COMBOBOX LISÄYKSEEN palveluquery = "SELECT palvelu.nimi FROM palvelu WHERE palvelu.alue_id = (SELECT mokki.alue_id FROM mokki WHERE mokki.mokki_id = (SELECT varaus.mokki_mokki_id FROM varaus WHERE varaus.varaus_id = " + kasiteltavavaraus.mokki_id + "));";
            /*List<String> palvelunimet = new List<string>();
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
            cbPalvelu.DataSource = palvelunimet;*/

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
        }
        public List<VarauksenPalvelut> GetVarauksenPalvelut()
        {
            List<VarauksenPalvelut> vP = new List<VarauksenPalvelut>();
            string query = "SELECT * FROM varauksen_palvelut";

            using (OdbcConnection connection = new OdbcConnection(connectionString))
            {
                connection.Open();
                using (OdbcCommand command = new OdbcCommand(query, connection))
                {
                    using (OdbcDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            VarauksenPalvelut vv = new VarauksenPalvelut();
                            vv.varaus_id = reader.GetInt32(0);
                            vv.palvelu_id = reader.GetInt32(1);
                            vv.lkm = reader.GetInt32(2);
                            vP.Add(vv);
                        }
                    }
                }
            }
            return vP;
        }

        private void dgvVarauksenPalvelut_SelectionChanged(object sender, EventArgs e)
        {
            valitturivi = dgvVarauksenPalvelut.CurrentRow.Index;
            valittupalvelu = GetValittuPalvelu();
        }
        public VarauksenPalvelut GetValittuPalvelu()
        {
            VarauksenPalvelut vp = new VarauksenPalvelut();
            vp.varaus_id = varauksenpalvelut[valitturivi].varaus_id;
            vp.palvelu_id = varauksenpalvelut[valitturivi].palvelu_id;
            vp.lkm = varauksenpalvelut[valitturivi].lkm;
            return vp;
        }

        /*private void btnLisaa_Click(object sender, EventArgs e)
        {
            frmUusiPalvelu up = new frmUusiPalvelu();
            up.ShowDialog();
        }*/

        private void btnPoista_Click(object sender, EventArgs e)
        {
            //if (MessageBox.Show("Haluatko varmasti poistaa palvelun tästä varauksesta?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            //{

            //}
            //VALIDOI
        }

        private void btnHaePalvelu_Click(object sender, EventArgs e)
        {
            frmHaePalvelu hp = new frmHaePalvelu(kasiteltavavaraus);
            hp.ShowDialog();
        }
        public void LisaaPalveluVaraukseen()
        {

        }
    }
}
