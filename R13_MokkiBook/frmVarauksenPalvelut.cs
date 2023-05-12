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
    public partial class frmVarauksenPalvelut : Form //Tämän nimi käytännössä "Muokkaa varausta"
    {//Pan
        public int valitturivi = -1;
        public Varaus kasiteltavavaraus = new Varaus();
        public List<VarauksenPalvelut> varauksenpalvelut = new List<VarauksenPalvelut>();
        public List<Varaus> varaukset = new List<Varaus>();
        public VarauksenPalvelut valittupalvelu = new VarauksenPalvelut();
        public string tauluquery;
        public string palveluquery;
        public string connectionString = "Dsn=Village Newbies;uid=root";
        public bool palveluvalittu = false;
        public DateTime alku;
        public DateTime loppu;
        public frmVarauksenPalvelut(Varaus tuotuvaraus)
        {
            InitializeComponent();
            kasiteltavavaraus = tuotuvaraus;
            varauksenpalvelut = GetVarauksenPalvelut();
            varaukset = GetVaraukset();
            LokiinTallentaminen("Varauksen " + kasiteltavavaraus.varaus_id.ToString() + " palvelut avattiin käyttäjältä: ");
            lblVarausId.Text = "Varaustunnus: " + kasiteltavavaraus.varaus_id.ToString();
            stpAlku.Value = kasiteltavavaraus.varattu_alkupvm;
            stpLoppu.Value = kasiteltavavaraus.varattu_loppupvm;
        }
        private void frmVarauksenPalvelut_Load(object sender, EventArgs e)
        {
            PaivitaTaulu();
        }

        //Lokiin tallentaminen: Tämän teki Hanna
        public void LokiinTallentaminen(string teksti)
        {
            string kayttaja = Environment.UserName;

            StreamWriter sw = new StreamWriter("Kirjautumistiedot.txt", true);
            sw.WriteLine(DateTime.Now.ToString() + " " + teksti + " " + kayttaja);
            sw.Close();
        }

        //Hakee taulusta varauksen_palvelut
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

        //Hakee halutun varauksen_palvelu-instancen
        public VarauksenPalvelut GetValittuPalvelu()
        {
            VarauksenPalvelut vp = new VarauksenPalvelut();
            vp.varaus_id = varauksenpalvelut[valitturivi].varaus_id;
            vp.palvelu_id = varauksenpalvelut[valitturivi].palvelu_id;
            vp.lkm = varauksenpalvelut[valitturivi].lkm;
            return vp;
        }

        //Hakee listan kaikista varauksista
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

        //Päivittää datagridview:n
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

        //Käynnistää palvelun poistoprosessin varauksesta
        private void btnPoista_Click(object sender, EventArgs e)
        {
            if (palveluvalittu)
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
            else
                MessageBox.Show("Palvelua ei ole valittu. Valitse palvelu klikkaamalla sen riviä.");
        }

        //Poistaa palvelun varauksesta kokonaan
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

        //Avaa näkymän, josta varaukseen voi lisätä olemassa olevia palveluita
        private void btnHaePalvelu_Click(object sender, EventArgs e)
        {
            frmHaePalvelu hp = new frmHaePalvelu(kasiteltavavaraus, varauksenpalvelut);
            hp.ShowDialog();
        }

        //Poistaa tietyn määrän tietystä palvelusta varauskesta
        private void btnPoistaValittuMaara_Click(object sender, EventArgs e)
        {
            if (palveluvalittu)
            {
                if (nudPoistettavat.Value > 0)
                {
                    int uusimaara = LaskeUusiMaara();
                    if (uusimaara > 0)
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
            else
                MessageBox.Show("Palvelua ei ole valittu. Valitse palvelu klikkaamalla sen riviä.");
        }

        //Laskee poistoa jälkeisen määrän palvelulle, josta poistettiin vain osa
        public int LaskeUusiMaara()
        {
            int uusi;
            int vanha = valittupalvelu.lkm;
            int poistettava = int.Parse(nudPoistettavat.Text);

            uusi = vanha - poistettava;

            return uusi;
        }

        //Kirjaa poistumisen lokiin
        private void frmVarauksenPalvelut_FormClosed(object sender, FormClosedEventArgs e)
        {
            LokiinTallentaminen("Varauksen " + kasiteltavavaraus.varaus_id.ToString() + " palvelut suljettiin käyttäjältä: ");
        }

        //Varmistaa sulkemishalukkuuden
        private void frmVarauksenPalvelut_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Haluatko varmasti poistua?", "", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        //Käynnistää päivämäärän muutosprosessin
        private void btnVahvista_Click(object sender, EventArgs e)
        {
            switch (ValidPvm())
            {
                case 0:
                    if (MokkiVapaa())
                    {
                        TallennaVarauksenMuutokset();
                    }
                    else
                        MessageBox.Show("Kyseinen mökki ei ole vapaa kyseisellä ajanjaksolla."); ;
                    break;
                case 1:
                    if (MessageBox.Show("Varaukselle on valittu vain yksi päivä, luodaanko varaus silti?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        if (MokkiVapaa())
                        {
                            TallennaVarauksenMuutokset();
                        }
                        else
                            MessageBox.Show("Kyseinen mökki ei ole vapaa kyseisellä ajanjaksolla.");
                    }
                    break;
                case 2:
                    MessageBox.Show("Varausta ei voi luoda: Varauksen alkupäivä ei voi olla sen päättymispäivän jälkeen.");
                    break;
                default:
                    MessageBox.Show("Jokin meni nyt päiväyksen kanssa vikaan.");
                    break;
            }
        }

        //Ottaa uuden halutun alkupäivämäärän talteen
        private void stpAlku_ValueChanged(object sender, EventArgs e)
        {
            alku = stpAlku.Value;
        }

        //Ottaa uuden halutun loppupäivämäärän talteen
        private void stpLoppu_ValueChanged(object sender, EventArgs e)
        {
            loppu = stpLoppu.Value;
        }

        //Valitsee muokattavan palvelun
        private void dgvVarauksenPalvelut_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            valitturivi = dgvVarauksenPalvelut.CurrentRow.Index;
            valittupalvelu = GetValittuPalvelu();
            palveluvalittu = true;
        }

        //Varmistaa, että päivämäärät on syötetty oikein
        public int ValidPvm()
        {
            if (alku < loppu)
                return 0;
            else if (alku.Equals(loppu))
                return 1;
            else
                return 2;
        }

        //Varmistaa mökin vapauden muutetulle ajanjaksolle
        public bool MokkiVapaa()
        {
            foreach (Varaus v in varaukset)
            {
                if (v.varaus_id != kasiteltavavaraus.varaus_id)
                {
                    if (v.mokki_id == kasiteltavavaraus.mokki_id)
                    {
                        if (alku >= v.varattu_alkupvm && alku < v.varattu_loppupvm)
                        {
                            return false;
                        }
                        else if (loppu > v.varattu_alkupvm && loppu <= v.varattu_loppupvm)
                        {
                            return false;
                        }
                        else if (alku <= v.varattu_alkupvm && loppu >= v.varattu_loppupvm)
                        {
                            return false;
                        }
                    }
                }
            }
            return true;
        }

        //Varmistaa muokkaushalukkuuden päivämäärälle ja tallentaa muutokset tietokantaan
        public void TallennaVarauksenMuutokset()
        {
            string varmistus = "Muokataanko varausta \n ID:" + kasiteltavavaraus.varaus_id.ToString() + ", ajankohta: " + alku + " - " + loppu;
            if (MessageBox.Show(varmistus, "Varmistus", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                kasiteltavavaraus.varattu_pvm = DateTime.Now;
                kasiteltavavaraus.vahvistus_pvm = DateTime.Now;
                kasiteltavavaraus.varattu_alkupvm = alku;
                kasiteltavavaraus.varattu_loppupvm = loppu;

                using (OdbcConnection connection = new OdbcConnection(connectionString))
                {
                    connection.Open();
                    string varausquery = "UPDATE varaus SET asiakas_id = ?, mokki_mokki_id = ?, varattu_pvm = ?, vahvistus_pvm = ?, varattu_alkupvm = ?, varattu_loppupvm = ? WHERE varaus_id = ?;";
                    using (OdbcCommand cmd = new OdbcCommand(varausquery, connection))
                    {
                        cmd.Parameters.AddWithValue("@asiakas_id", kasiteltavavaraus.asiakas_id);
                        cmd.Parameters.AddWithValue("@mokki_mokki_id", kasiteltavavaraus.mokki_id);
                        cmd.Parameters.AddWithValue("@varattu_pvm", kasiteltavavaraus.varattu_pvm);
                        cmd.Parameters.AddWithValue("@vahvistus_pvm", kasiteltavavaraus.vahvistus_pvm);
                        cmd.Parameters.AddWithValue("@varattu_alkupvm", kasiteltavavaraus.varattu_alkupvm);
                        cmd.Parameters.AddWithValue("@varattu_loppupvm", kasiteltavavaraus.varattu_loppupvm);
                        cmd.Parameters.AddWithValue("@varaus_id", kasiteltavavaraus.varaus_id);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
        }

        //Käyttäjälle mahdollisuus päivittää taulu (esim. uuden lisäyksen tai muutoksen jälkeen) sulkematta nykyistä ikkunaa
        private void btnPaivita_Click(object sender, EventArgs e)
        {
            PaivitaTaulu();
        }
    }
}
