using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace R13_MokkiBook
{
    public partial class frmUusiVaraus : Form
    {
        public int valitturiviasiakas = -1;
        public int valitturivipalvelu = -1;
        public int valitturivimokki = -1;
        public int valitturivialue = -1;
        public int valitturivivarauksenpalvelu = -1;
        public double arvioituloppuhinta = 0;

        public Asiakas valittuasiakas;
        public Asiakas luotuasiakas;
        public Alue valittualue;
        public Mokki valittumokki;
        public Palvelu valittupalvelu;
        public Posti valittuposti;
        public VarauksenPalvelut valittuvarauksenpalvelu;
        public Varaus tamavaraus;
        public List <Palvelu> palvelut;
        public List<VarauksenPalvelut> varauksienpalvelut;
        public List<Asiakas> asiakkaat;
        public List<Alue> alueet;
        public List<Mokki> mokit;
        public List<Posti> postit;
        public List<Varaus> varaukset;

        public string connectionString = "Dsn=Village Newbies;uid=root";
        public string asiakasquery = "SELECT * FROM asiakas;";
        public string aluequery = "SELECT nimi FROM alue;";
        public string mokkiquery;
        public string palveluquery;
        public string postiquery;
        public string varauksenpalveluquery;
        //HAKU TOTEUTUU SEURAAVASTI: JOKAISTA TAULUA KOHDEN OMA QUERYSTRING, JOIHIN JOKAINEN HAKUKRITEERI LISÄTÄÄN XQUERY = OSAQUERY1 + OSAQUERY2 JNE
       
        public DateTime nyt = DateTime.Now;
        public DateTime alkupvm;
        public DateTime loppupvm;
        public bool mokkilukittu = false;
        public bool asiakasjuurivalittu = false;

        public frmUusiVaraus()
        {
            InitializeComponent();
            varaukset = GetVaraukset();
            palvelut = GetPalvelut();
            varauksienpalvelut = GetVarauksenPalvelut();
            asiakkaat = GetAsiakkaat();
            alueet = GetAlueet();
            mokit = GetMokit();
            postit = GetPostit();

            valittuasiakas = new Asiakas();
            valittualue = new Alue();
            valittumokki = new Mokki();
            valittupalvelu = new Palvelu();
            valittuvarauksenpalvelu = new VarauksenPalvelut();
            valittuposti = new Posti();

            PaivitaAsiakastaulu(asiakasquery);
            PaivitaAluetaulu(aluequery);
            LokiinTallentaminen("Avattiin uuden varauksen luontisivu käyttäjältä: ");

            tamavaraus = new Varaus();
            tamavaraus.varaus_id = HaeSeuraavaVapaaVarausID();
        }
        public void LokiinTallentaminen(string teksti)
        {
            string kayttaja = Environment.UserName;

            StreamWriter sw = new StreamWriter("Kirjautumistiedot.txt", true);
            sw.WriteLine(DateTime.Now.ToString() + " " + teksti + " " + kayttaja);
            sw.Close();
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

        public List<Palvelu> GetPalvelut()
        {
            List<Palvelu> pal = new List<Palvelu>();
            string query = "SELECT * FROM palvelu";

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
                            p.tyyppi = reader.GetInt32(3);
                            p.kuvaus = reader.GetString(4);
                            p.hinta = reader.GetDouble(5);
                            p.alv = reader.GetDouble(6);
                            pal.Add(p);
                        }
                    }
                }
            }
            return pal;
        }

        public List<VarauksenPalvelut> GetVarauksenPalvelut()
        {
            List<VarauksenPalvelut> vpal = new List<VarauksenPalvelut>();
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
                            VarauksenPalvelut vp = new VarauksenPalvelut();
                            vp.varaus_id = reader.GetInt32(0);
                            vp.palvelu_id = reader.GetInt32(1);
                            vp.lkm = reader.GetInt32(2);
                            vpal.Add(vp);
                        }
                    }
                }
            }
            return vpal;
        }

        public List<Asiakas> GetAsiakkaat()
        {
            List<Asiakas> asi = new List<Asiakas>();
            string query = "SELECT * FROM asiakas";

            using (OdbcConnection connection = new OdbcConnection(connectionString))
            {
                connection.Open();
                using (OdbcCommand command = new OdbcCommand(query, connection))
                {
                    using (OdbcDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Asiakas a = new Asiakas();
                            a.asiakas_id = reader.GetInt32(0);
                            a.postinro = reader.GetString(1);
                            a.etunimi = reader.GetString(2);
                            a.sukunimi = reader.GetString(3);
                            a.lahiosoite = reader.GetString(4);
                            a.email = reader.GetString(5);
                            a.puhelinnro = reader.GetString(6);
                            asi.Add(a);
                        }
                    }
                }
            }
            return asi;
        }

        public List<Alue> GetAlueet()
        {
            List<Alue> alu = new List<Alue>();
            string query = "SELECT * FROM alue";

            using (OdbcConnection connection = new OdbcConnection(connectionString))
            {
                connection.Open();
                using (OdbcCommand command = new OdbcCommand(query, connection))
                {
                    using (OdbcDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Alue a = new Alue();
                            a.alue_id = reader.GetInt32(0);
                            a.nimi = reader.GetString(1);
                            alu.Add(a);
                        }
                    }
                }
            }
            return alu;
        }

        public List<Mokki> GetMokit()
        {
            List<Mokki> mo = new List<Mokki>();
            string query = "SELECT * FROM mokki";

            using (OdbcConnection connection = new OdbcConnection(connectionString))
            {
                connection.Open();
                using (OdbcCommand command = new OdbcCommand(query, connection))
                {
                    using (OdbcDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Mokki m = new Mokki();
                            m.mokki_id = reader.GetInt32(0);
                            m.alue_id = reader.GetInt32(1);
                            m.postinro = reader.GetString(2);
                            m.mokkinimi = reader.GetString(3);
                            m.katuosoite = reader.GetString(4);
                            m.hinta = reader.GetDouble(5);
                            m.kuvaus = reader.GetString(6);
                            m.henkilomaara = reader.GetInt32(7);
                            m.varustelu = reader.GetString(8);
                            mo.Add(m);
                        }
                    }
                }
            }
            return mo;
        }

        public List<Posti> GetPostit()
        {
            List<Posti> po = new List<Posti>();
            string query = "SELECT * FROM posti";

            using (OdbcConnection connection = new OdbcConnection(connectionString))
            {
                connection.Open();
                using (OdbcCommand command = new OdbcCommand(query, connection))
                {
                    using (OdbcDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Posti p = new Posti();
                            p.postinro = reader.GetString(0);
                            p.toimipaikka = reader.GetString(1);
                            po.Add(p);
                        }
                    }
                }
            }
            return po;
        }
        public int HaeSeuraavaVapaaVarausID()
        {
            int id = 0;
            foreach(Varaus v in varaukset)
            {
                if(v.varaus_id > id)
                    id = v.varaus_id;
            }
            id++;
            return id;
        }
        public int HaeSeuraavaVapaaAsiakasID()
        {
            int id = 0;
            foreach (Asiakas a in asiakkaat)
            {
                if (a.asiakas_id > id)
                    id = a.asiakas_id;
            }
            id++;
            return id;
        }
        public void LuoVaraus()
        {

        }
        public void PaivitaAsiakastaulu(string asiakasquery)
        {
            OdbcConnection connection = new OdbcConnection(connectionString);
            connection.Open();
            DataTable dataTable = new DataTable();
            using (OdbcDataAdapter adapter = new OdbcDataAdapter(asiakasquery, connection))
            {
                adapter.FillSchema(dataTable, SchemaType.Source);
                adapter.Fill(dataTable);
            }
            dgvAsiakkaat.DataSource = dataTable;
            dgvAsiakkaat.Columns[0].HeaderText = "Asiakastunnus";
            dgvAsiakkaat.Columns[1].HeaderText = "Postinumero";
            dgvAsiakkaat.Columns[2].HeaderText = "Etunimi";
            dgvAsiakkaat.Columns[3].HeaderText = "Sukunimi";
            dgvAsiakkaat.Columns[4].HeaderText = "Lähiosoite";
            dgvAsiakkaat.Columns[5].HeaderText = "Sähköposti";
            dgvAsiakkaat.Columns[6].HeaderText = "Puhelinnumero";
        }
        public void PaivitaAluetaulu(string aluequery)
        {
            OdbcConnection connection = new OdbcConnection(connectionString);
            connection.Open();
            DataTable dataTable = new DataTable();
            using (OdbcDataAdapter adapter = new OdbcDataAdapter(aluequery, connection))
            {
                adapter.FillSchema(dataTable, SchemaType.Source);
                adapter.Fill(dataTable);
            }
            lbAlue.DataSource = dataTable;
        }
        public void PaivitaMokkitaulu(string mokkiquery)
        {

        }
        public void PaivitaPalvelutaulu(string palveluquery)
        {

        }
        public void PaivitaVarauksenPalvelutaulu(string varauksenpalveluquery)
        {

        }
        private void dtmLoppupvm_ValueChanged(object sender, EventArgs e)
        {
            loppupvm = dtmLoppupvm.Value;
        }

        private void dtpAlkupvm_ValueChanged(object sender, EventArgs e)
        {
            alkupvm = dtpAlkupvm.Value;
        }

        private void btnLuoVaraus_Click(object sender, EventArgs e)
        {
            if(!MokkiLukittu())
            {
                MessageBox.Show("Mökkiä ei ole lukittu.");
            }
            else
            {
                switch(ValidPvm())
                {
                    case 0:
                        //Huom muut vaatimukset! Validoi asiakas, alue, mökki, posti, määrä ja mökin vapaus!
                        LuoVaraus();
                        break;
                    case 1:
                        if (MessageBox.Show("Varaukselle on valittu vain yksi päivä, luodaanko varaus silti?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                            LuoVaraus();
                        break;
                    case 2:
                        MessageBox.Show("Varausta ei voi luoda: Varauksen alkupäivä ei voi olla sen åäättymispäivän jälkeen.");
                        break;
                    default:
                        MessageBox.Show("Jokin meni nyt päiväyksen kanssa vikaan.");
                        break;
                }
            }
        }

        private void btnPoistaPalvelu_Click(object sender, EventArgs e)
        {
            //Poista tietokannasta ko. varauksenpalvelu
        }

        private void tsmiTyhjenna_Click(object sender, EventArgs e)
        {
            //tyhjentää listboxin valinnan ja siihen liittyvän id:n/postinron
        }

        private void btnLisaaPalveluVaraukseen_Click(object sender, EventArgs e)
        {
            if (nudPalveluLkm.Value == 0)
            {
                //MessageBox ei lisätä- oletko varma?
            }
            else
            {
                
                //Lisää palautettava-homman tietokantaan instancena
            }
        }

        private void frmUusiVaraus_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void btnLisaa_Click(object sender, EventArgs e)
        {
            if (tbAsiakastunnus.Text.Length > 0)
            {
                int tunnus = int.Parse(tbAsiakastunnus.Text);
                if(EtsiAsiakas(tunnus))
                    MessageBox.Show("Asiakas on jo olemassa. Poista asiakastunnus kentästä luodaksesi uusi asiakas.");
                else
                {
                    TarkistaNimi();
                }
            }
        }
        public bool EtsiAsiakas(int tunnus)
        {
            foreach (Asiakas a in asiakkaat)
            {
                if(a.asiakas_id == tunnus)
                    return true;
            }
            return false;
        }
        public void TarkistaNimi()
        {
            if (tbEnimi.Text.Length > 0)
            {
                if (tbSnimi.Text.Length > 0)
                {
                    TarkistaOsoite();
                }
                else
                    MessageBox.Show("Uutta asiakasta ei voitu luoda: syötä sukunimi.");
            }
            else
                MessageBox.Show("Uutta asiakasta ei voitu luoda: syötä etunimi.");
        }
        public void TarkistaOsoite()
        {
            if (tbPostinoAsiakas.Text.Length > 0 && tbPostinoAsiakas.Text.Length < 6)
            {
                if(tbLahiosoiteAsiakas.Text.Length > 0)
                {
                    //Muotoa ei tarkisteta. Palaan tähän, jos on aikaa
                    TarkistaPuhno();
                }
                else
                    MessageBox.Show("Uutta asiakasta ei voitu luoda: syötä lähiosoite.");
            }
            else if (tbPostinoAsiakas.Text.Length > 5)
                MessageBox.Show("Uutta asiakasta ei voitu luoda: postinumero on liian pitkä.");
            else
                MessageBox.Show("Uutta asiakasta ei voitu luoda: syötä postinumero.");
        }
        public void TarkistaPuhno()
        {
            if(tbPuhno.Text.Length > 0)
            {
                //Muotoa ei tarkisteta. Palaan tähän, jos on aikaa
                TarkistaSahkoposti();
            }
            else
                MessageBox.Show("Uutta asiakasta ei voitu luoda: syötä puhelinnumero.");
        }
        public void TarkistaSahkoposti()
        {
            if(tbSahkoposti.Text.Length > 0)
            {
                //Muotoa ei tarkisteta. Palaan tähän, jos on aikaa
                LuoAsiakas();
            }
            else
                MessageBox.Show("Uutta asiakasta ei voitu luoda: syötä shköpostiosoite.");
        }
        public void LuoAsiakas()
        {
            luotuasiakas.asiakas_id = HaeSeuraavaVapaaAsiakasID();
            luotuasiakas.postinro = tbPostinoAsiakas.Text;
            luotuasiakas.etunimi = tbEnimi.Text;
            luotuasiakas.sukunimi = tbSnimi.Text;
            luotuasiakas.lahiosoite = tbLahiosoiteAsiakas.Text;
            luotuasiakas.email = tbSahkoposti.Text;
            luotuasiakas.puhelinnro = tbPuhno.Text;

            valittuasiakas = luotuasiakas;
            asiakasquery = "SELECT * FROM asiakas;";
            PaivitaAsiakastaulu(asiakasquery);
        }
        private void cbLukitseMokki_CheckedChanged(object sender, EventArgs e)
        {
            if (cbLukitseMokki.Checked == true)
            { 
                mokkilukittu = true;
                pnlMokki.Enabled = false;
            }
            else if (cbLukitseMokki.Checked == false)
            {
                mokkilukittu = false;
                pnlMokki.Enabled = true;
            }
        }

        public bool MokkiLukittu()
        {
            if (!mokkilukittu)
                return false;
            else return true;
        }
        public int ValidPvm()
        {
            if (alkupvm < loppupvm)
                return 0;
            else if (alkupvm.Equals(loppupvm))
                return 1;
            else
                return 2;
        }

        private void frmUusiVaraus_FormClosed(object sender, FormClosedEventArgs e)
        {
            LokiinTallentaminen("Suljettiin uuden varauksen luontisivu käyttäjältä: ");
        }

        private void tbEnimi_Leave(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            string nimi = tb.Text.Trim();

            if (nimi.Length > 0)
            {
                nimi = nimi.Substring(0, 1).ToUpper() + nimi.Substring(1, nimi.Length - 1).ToLower();
                tb.Text = nimi;
            }
        }

        private void tbPostinoAsiakas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!Char.IsDigit(e.KeyChar)) && (e.KeyChar != (char)8))
                e.Handled = true;
        }

        private void dgvAsiakkaat_SelectionChanged(object sender, EventArgs e)
        {
        }

        private void dgvAlueenPalvelut_SelectionChanged(object sender, EventArgs e)
        {
            valitturivipalvelu = dgvAlueenPalvelut.CurrentRow.Index;
            //valittupalvelu = palvelut[valitturivipalvelu];
        }

        private void dgvMokitUusiVaraus_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void lbAlue_SelectedIndexChanged(object sender, EventArgs e)
        {
            valitturivialue = lbAlue.SelectedIndex;
            valittualue = alueet[valitturivialue];
            tbAlueid.Text = valittualue.alue_id.ToString();
            //Häikkää alussa ei tyhjä
        }

        private void lbVarauksenPalvelut_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tbAlueid_TextChanged(object sender, EventArgs e)
        {
            if (tbAlueid.Text.Length > 0)
            {
                aluequery = "SELECT nimi FROM alue WHERE alue_id LIKE '" + tbAlueid.Text + "%';";
                PaivitaAluetaulu(aluequery);
            }
            else
            {
                aluequery = "SELECT nimi FROM alue;";
                PaivitaAluetaulu(aluequery);
            }
        }

        private void tbAsiakastunnus_TextChanged(object sender, EventArgs e)
        {
            if (tbAsiakastunnus.Text.Length > 0)
            {
                aluequery = "SELECT * FROM asiakas WHERE asiakas_id LIKE '" + tbAsiakastunnus.Text + "%';";
                PaivitaAsiakastaulu(aluequery);
            }
            else
            {
                aluequery = "SELECT * FROM asiakas;";
                PaivitaAsiakastaulu(aluequery);
            }
        }
        public void TyhjennaAsiakas()
        {
            asiakasjuurivalittu = false;
            valittuasiakas = null;
            asiakasquery = "SELECT * FROM asiakas;";
            PaivitaAsiakastaulu(asiakasquery);
            tbAsiakastunnus.Text = String.Empty;
            tbEnimi.Text = String.Empty;
            tbSnimi.Text = String.Empty;
            tbPostinoAsiakas.Text = String.Empty;
            tbLahiosoiteAsiakas.Text = String.Empty;
            tbSahkoposti.Text = String.Empty;
            tbPuhno.Text = String.Empty;
        }
        private void tbEnimi_TextChanged(object sender, EventArgs e)
        {
            if (asiakasjuurivalittu)
                TyhjennaAsiakas();
        }

        private void tbSnimi_TextChanged(object sender, EventArgs e)
        {
            if (asiakasjuurivalittu)
                TyhjennaAsiakas();
        }

        private void tbPostinoAsiakas_TextChanged(object sender, EventArgs e)
        {
            if (asiakasjuurivalittu)
                TyhjennaAsiakas();
        }

        private void tbLahiosoiteAsiakas_TextChanged(object sender, EventArgs e)
        {
            if (asiakasjuurivalittu)
                TyhjennaAsiakas();
        }

        private void tbPostitoimipaikkaAsiakas_TextChanged(object sender, EventArgs e)
        {
            if (asiakasjuurivalittu)
                TyhjennaAsiakas();
        }

        private void tbPuhno_TextChanged(object sender, EventArgs e)
        {
            if (asiakasjuurivalittu)
                TyhjennaAsiakas();
        }

        private void tbSahkoposti_TextChanged(object sender, EventArgs e)
        {
            if (asiakasjuurivalittu)
                TyhjennaAsiakas();
        }

        private void dgvAsiakkaat_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            valitturiviasiakas = dgvAsiakkaat.CurrentRow.Index;//Viittaukseksi ei voi objektiesiintymää??
            valittuasiakas = asiakkaat[valitturiviasiakas];
            asiakasjuurivalittu = true;

            tbEnimi.Text = valittuasiakas.etunimi;
            tbSnimi.Text = valittuasiakas.sukunimi;
            tbPostinoAsiakas.Text = valittuasiakas.postinro;
            tbAsiakastunnus.Text = valittuasiakas.asiakas_id.ToString();
            tbLahiosoiteAsiakas.Text = valittuasiakas.lahiosoite;
            tbSahkoposti.Text = valittuasiakas.email;
            tbPuhno.Text = valittuasiakas.puhelinnro;
        }
    }
}
