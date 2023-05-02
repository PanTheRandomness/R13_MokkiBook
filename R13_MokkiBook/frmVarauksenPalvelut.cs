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

            dgvVarauksenPalvelut.Columns[0].HeaderText = "Varaustunnus";
            dgvVarauksenPalvelut.Columns[1].HeaderText = "Palvelutunnus";
            dgvVarauksenPalvelut.Columns[2].HeaderText = "Lkm";
        }
        public List<VarauksenPalvelut> GetVarauksenPalvelut()
        {
            List<VarauksenPalvelut> vP = new List<VarauksenPalvelut>();

            using (OdbcConnection connection = new OdbcConnection(connectionString))
            {
                connection.Open();
                using (OdbcCommand command = new OdbcCommand("SELECT * FROM varauksen_palvelut", connection))
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

        private void btnPoista_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Haluatko varmasti poistaa palvelun tästä varauksesta?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

            }
            else
            {

            }
        }

        private void btnHaePalvelu_Click(object sender, EventArgs e)
        {
            frmHaePalvelu hp = new frmHaePalvelu(kasiteltavavaraus, varauksenpalvelut);
            hp.ShowDialog();
            this.Hide();
        }
        public void LisaaPalveluVaraukseen()
        {

        }
    }
}
