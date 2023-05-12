using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace R13_MokkiBook
{
    public partial class frmVarauksenPalvelut : Form
    {//Pan
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
            LokiinTallentaminen("Varauksen " + kasiteltavavaraus.varaus_id.ToString() + " palvelut avattiin käyttäjältä: ");
        }
        private void frmVarauksenPalvelut_Load(object sender, EventArgs e)
        {
            PaivitaTaulu();
        }
        public void LokiinTallentaminen(string teksti)
        {
            string kayttaja = Environment.UserName;

            StreamWriter sw = new StreamWriter("Kirjautumistiedot.txt", true);
            sw.WriteLine(DateTime.Now.ToString() + " " + teksti + " " + kayttaja);
            sw.Close();
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
        public void PaivitaTaulu()
        {
            tauluquery = "SELECT * FROM varauksen_palvelut WHERE varaus_id = " + kasiteltavavaraus.varaus_id.ToString();

            OdbcConnection connection = new OdbcConnection(connectionString);
            connection.Open();
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
        private void btnPoista_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Haluatko varmasti poistaa palvelun tästä varauksesta?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                PoistaVarauksesta();
                PaivitaTaulu();
            }
            else
            {
                MessageBox.Show("Mitään ei poistettu.");
            }
        }
        public void PoistaVarauksesta()
        {
            using (OdbcConnection connection = new OdbcConnection(connectionString))
            {
                connection.Open();
                string poistoquery = "DELETE FROM varauksen_palvelut WHERE varaus_id = " + valittupalvelu.varaus_id + " AND palvelu_id = " + valittupalvelu.palvelu_id + ";";
                using (OdbcCommand cmd = new OdbcCommand(poistoquery, connection))
                {
                    cmd.ExecuteNonQuery();
                }
            }
            LokiinTallentaminen("Varauksesta " + valittupalvelu.varaus_id.ToString() + " poistettiin palvelu " + valittupalvelu.palvelu_id.ToString() + " käyttäjältä: ");
        }
        private void btnHaePalvelu_Click(object sender, EventArgs e)
        {
            frmHaePalvelu hp = new frmHaePalvelu(kasiteltavavaraus, varauksenpalvelut);
            hp.ShowDialog();
        }
        private void btnPoistaValittuMaara_Click(object sender, EventArgs e)
        {
            if(nudPoistettavat.Value > 0)
            {
                int uusimaara = LaskeUusiMaara();
                if(uusimaara > 0)
                {
                    using (OdbcConnection connection = new OdbcConnection(connectionString))
                    {
                        connection.Open();
                        string paivitysquery = "UPDATE varauksen_palvelut SET varaus_id = " + valittupalvelu.varaus_id + ", palvelu_id = " + valittupalvelu.palvelu_id + ", lkm = " + uusimaara + " WHERE varaus_id = " + valittupalvelu.varaus_id + " AND palvelu_id = " + valittupalvelu.palvelu_id + "; ";
                        using (OdbcCommand cmd = new OdbcCommand(paivitysquery, connection))
                        {
                            cmd.ExecuteNonQuery();
                        }
                        PaivitaTaulu();
                        LokiinTallentaminen("Varauksesta " + valittupalvelu.varaus_id.ToString() + " poistettiin " + uusimaara.ToString() + " kpl palvelua " + valittupalvelu.palvelu_id.ToString() + " käyttäjältä: ");
                    }
                }
                else
                {
                    if (MessageBox.Show("Valitsemillasi arvoilla koko palvelu poistetaan. Poistetaanko silti?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        PoistaVarauksesta();
                        PaivitaTaulu();
                    }
                    else
                        MessageBox.Show("Mitään ei poistettu. Voit jatkaa muokkausta");
                }
            }
            else
            {
                MessageBox.Show("Poistettavien määrän on oltava suurempi kuin 0.");
            }
        }
        public int LaskeUusiMaara()
        {
            int uusi;
            int vanha = valittupalvelu.lkm;
            int poistettava = int.Parse(nudPoistettavat.Text);

            uusi = vanha - poistettava;

            return uusi;
        }
        private void frmVarauksenPalvelut_FormClosed(object sender, FormClosedEventArgs e)
        {
            LokiinTallentaminen("Varauksen " + kasiteltavavaraus.varaus_id.ToString() + " palvelut suljettiin käyttäjältä: ");
        }
        private void frmVarauksenPalvelut_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Haluatko varmasti poistua?", "", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
