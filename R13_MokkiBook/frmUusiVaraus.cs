using iTextSharp.text;
using Org.BouncyCastle.Utilities.Collections;
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
using static System.Net.WebRequestMethods;

namespace R13_MokkiBook
{
    public partial class frmUusiVaraus : Form
    {//Pan
        //Validointia olisi voinut lisätä, mutta ei nyt enää kerkeä
        public int valitturiviasiakas = -1;
        public int valitturivipalvelu = -1;
        public int valitturivimokki = -1;
        public int valitturivialue = -1;
        public int valitturivivarauksenpalvelu = -1;
        public int lisattavapalvelumaara = 0;
        public double arvioituloppuhinta = 0;
        public double minhinta = 0;
        public double maxhinta = 0;

        public Asiakas valittuasiakas;
        public Asiakas luotuasiakas;
        public Alue valittualue;
        public Mokki valittumokki;
        public Mokki haettavamokki;
        public Palvelu valittupalvelu;
        public Posti valittuposti;
        public VarauksenPalvelut valittuvarauksenpalvelu;
        public Varaus tamavaraus;
        public List <Palvelu> palvelut;
        public List<VarauksenPalvelut> varauksenpalvelut;
        public List<String> varauksenpalvelunimet;
        public List<Asiakas> asiakkaat;
        public List<Alue> alueet;
        public List<Mokki> mokit;
        public List<Posti> postit;
        public List<Varaus> varaukset;

        BindingSource bs = new BindingSource();
        public string connectionString = "Dsn=Village Newbies;uid=root";
        public string asiakasquery = "SELECT * FROM asiakas;";
        public string aluequery = "SELECT nimi FROM alue;";
        public string mokkiquery = "SELECT * FROM mokki;";
        public string palveluquery = "SELECT * FROM palvelu;";
        public string palvelupoistoquery;
        public string palvelulisaysquery;
        public string postiqueryasiakas;
        public string varauksenpalveluquery;
        public string varausquery;
       
        public DateTime nyt = DateTime.Now;
        public DateTime alkupvm;
        public DateTime loppupvm;
        public bool mokkilukittu = false;
        public bool asiakasjuurivalittu = false;
        public bool alkupvmmuutettu = false;
        public bool loppupvmmuutettu = false;
        public bool aluevalittu = false;
        public bool varausluotu = false;
        public bool varauksessaonjopalvelu = false;
        public bool palveluvalittu = false;
        public bool varauksenpalveluvalittu = false;

        public frmUusiVaraus()
        {
            InitializeComponent();
            varaukset = GetVaraukset();
            tamavaraus = new Varaus();
            tamavaraus.varaus_id = HaeSeuraavaVapaaVarausID();
            palvelut = GetPalvelut();
            varauksenpalvelut = new List<VarauksenPalvelut>();
            varauksenpalvelunimet = new List<String>();
            bs.DataSource = varauksenpalvelunimet;
            asiakkaat = GetAsiakkaat();
            alueet = GetAlueet();
            mokit = GetMokit();
            postit = GetPostit();

            valittuasiakas = new Asiakas();
            luotuasiakas = new Asiakas();
            valittualue = new Alue();
            valittumokki = new Mokki();
            haettavamokki = new Mokki();
            valittupalvelu = new Palvelu();
            valittuvarauksenpalvelu = new VarauksenPalvelut();
            valittuposti = new Posti();

            PaivitaAsiakastaulu(asiakasquery);
            PaivitaAluetaulu(aluequery);
            PaivitaMokkitaulu(mokkiquery);
            PaivitaPalvelutaulu(palveluquery);
            LokiinTallentaminen("Avattiin uuden varauksen luontisivu käyttäjältä: ");
        }

        //Lokiin tallentaminen: Tämän teki Hanna
        public void LokiinTallentaminen(string teksti)
        {
            string kayttaja = Environment.UserName;

            StreamWriter sw = new StreamWriter("Kirjautumistiedot.txt", true);
            sw.WriteLine(DateTime.Now.ToString() + " " + teksti + " " + kayttaja);
            sw.Close();
        }

        //Hakee ko. palvelun hinnan
        public double GetPalvelunHinta(VarauksenPalvelut vp)
        {
            double palhinta = 0;
            using (OdbcConnection connection = new OdbcConnection(connectionString))
            {
                string query = "SELECT hinta FROM palvelu WHERE palvelu_id = " + vp.palvelu_id + ";";
                connection.Open();
                using (OdbcCommand command = new OdbcCommand(query, connection))
                {
                    using (OdbcDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            palhinta = reader.GetDouble(0);
                            palhinta = palhinta * vp.lkm;
                        }
                    }
                }
            }
            return palhinta;
        }

        //Palauttaa listan kaikista varauksista
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

        //Palauttaa listan kaikista palveluista
        public List<Palvelu> GetPalvelut()
        {
            List<Palvelu> pal = new List<Palvelu>();

            using (OdbcConnection connection = new OdbcConnection(connectionString))
            {
                connection.Open();
                using (OdbcCommand command = new OdbcCommand(palveluquery, connection))
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

        //Palauttaa listan kaikista asiakkaista
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

        //Palauttaa listan kaikista alueista
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

        //Palauttaa listan kaikista mökeistä
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

        //Palauttaa listan kaikista postitoimipaikoista
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

        //Hakee seuraavan vapaan varaustunnuksen nykyiselle varaukselle käytettäväksi
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

        //Hakee seuraavan vapaan asiakastunnuksen uudelle asiakkaalle
        public int HaeSeuraavaVapaaAsiakasID()
        {
            int id = 1;
            foreach (Asiakas a in asiakkaat)
            {
                if (a.asiakas_id == id)
                    id++;
                else
                    return id;
            }
            return id;
        }

        //Varmistaa annettujen tietojen olevan oikeat ja luo uuden varauksen järjestelmään.
        //Voisi luoda myös laskun, mutta se tehdään omassa osiossaan
        public void LuoVaraus()
        {
            tamavaraus.asiakas_id = valittuasiakas.asiakas_id;
            tamavaraus.mokki_id = valittumokki.mokki_id;
            tamavaraus.varattu_alkupvm = alkupvm;
            tamavaraus.varattu_loppupvm = loppupvm;

            if (MessageBox.Show("Olethan varmistanut lisäpalvelut?", "Varmistus", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                tamavaraus.varattu_pvm = DateTime.Now;
                tamavaraus.vahvistus_pvm = DateTime.Now;
                string varmistus = "Luodaanko varaus \n ID:" + tamavaraus.varaus_id.ToString() + ", ajankohta: " + tamavaraus.varattu_alkupvm + " - " + tamavaraus.varattu_loppupvm +
                "\n Asiakas: " + valittuasiakas.etunimi + " " + valittuasiakas.sukunimi + ", ID: " + valittuasiakas.asiakas_id.ToString() +
                "\n Alue: " + valittualue.nimi + ", ID:" + valittualue.alue_id.ToString() +
                "\n Mökki: " + valittumokki.mokkinimi + ", ID: " + valittumokki.mokki_id.ToString() + ", henkilökapasiteetti: " + valittumokki.henkilomaara.ToString() + ", mökin hinta: " + valittumokki.hinta.ToString() + " €" +
                "\n Arvioitu loppuhinta lisäpalveluineen: " + arvioituloppuhinta.ToString() + " €";

                if (MessageBox.Show(varmistus, "Varmistus", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    tamavaraus.varattu_pvm = DateTime.Now;
                    tamavaraus.vahvistus_pvm = DateTime.Now;

                    using (OdbcConnection connection = new OdbcConnection(connectionString))
                    {
                        connection.Open();
                        varausquery = "INSERT INTO varaus(varaus_id, asiakas_id, mokki_mokki_id, varattu_pvm, vahvistus_pvm, varattu_alkupvm, varattu_loppupvm)" +
                            " VALUES(?, ?, ?, ?, ?, ?, ?);";
                        using (OdbcCommand cmd = new OdbcCommand(varausquery, connection))
                        {
                            cmd.Parameters.AddWithValue("@varaus_id", tamavaraus.varaus_id);
                            cmd.Parameters.AddWithValue("@asiakas_id", tamavaraus.asiakas_id);
                            cmd.Parameters.AddWithValue("@mokki_id", tamavaraus.mokki_id);
                            cmd.Parameters.AddWithValue("@varattu_pvm", tamavaraus.varattu_pvm);
                            cmd.Parameters.AddWithValue("@vahvistus_pvm", tamavaraus.vahvistus_pvm);
                            cmd.Parameters.AddWithValue("@varattu_alkupvm", tamavaraus.varattu_alkupvm);
                            cmd.Parameters.AddWithValue("@varattu_loppupvm", tamavaraus.varattu_loppupvm);
                            cmd.ExecuteNonQuery();
                        }
                    }
                    foreach (VarauksenPalvelut vp in varauksenpalvelut)
                    {
                        LisaaPalveluVaraukseen(vp);
                    }
                    LokiinTallentaminen("Luotiin varaus " + tamavaraus.varaus_id + " käyttäjältä: ");
                    varausluotu = true;
                    this.Close();
                }
            }
        }

        //Päivittää asiakkaita käsittelevän datagrigview:n
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

        //Päivittää alueita käsittelevän listboxin
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

        //Päivittää mökkejä käsittelevän datagrigview:n
        public void PaivitaMokkitaulu(string mokkiquery)
        {
            OdbcConnection connection = new OdbcConnection(connectionString);
            connection.Open();
            DataTable dataTable = new DataTable();
            using (OdbcDataAdapter adapter = new OdbcDataAdapter(mokkiquery, connection))
            {
                adapter.FillSchema(dataTable, SchemaType.Source);
                adapter.Fill(dataTable);
            }
            dgvMokitUusiVaraus.DataSource = dataTable;
            dgvMokitUusiVaraus.Columns[0].HeaderText = "Mökkitunnus";
            dgvMokitUusiVaraus.Columns[1].HeaderText = "Aluetunnus";
            dgvMokitUusiVaraus.Columns[2].HeaderText = "Postinumero";
            dgvMokitUusiVaraus.Columns[3].HeaderText = "Nimi";
            dgvMokitUusiVaraus.Columns[4].HeaderText = "Lähiosoite";
            dgvMokitUusiVaraus.Columns[5].HeaderText = "Hinta";
            dgvMokitUusiVaraus.Columns[6].HeaderText = "Kuvaus";
            dgvMokitUusiVaraus.Columns[7].HeaderText = "Henkilömäärä";
            dgvMokitUusiVaraus.Columns[8].HeaderText = "Varustelu";
        }

        //Päivittää  valitun mökin alueelta löytyviä palveluita käsittelevän datagrigview:n
        public void PaivitaPalvelutaulu(string palveluquery)
        {
            OdbcConnection connection = new OdbcConnection(connectionString);
            connection.Open();
            DataTable dataTable = new DataTable();
            using (OdbcDataAdapter adapter = new OdbcDataAdapter(palveluquery, connection))
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

        //Päivittää uuteen varaukseen lisättyjä lisäpalveluita käsittelevän listboxin
        public void PaivitaVarauksenPalvelutaulu() 
        {
            varauksenpalvelunimet.Clear();
            if (varauksenpalvelut.Count > 0)
            {
                foreach (VarauksenPalvelut vp in varauksenpalvelut)
                {
                    string palvelunnimi = "";
                    using (OdbcConnection connection = new OdbcConnection(connectionString))
                    {
                        string query = "SELECT nimi FROM palvelu WHERE palvelu_id = " + vp.palvelu_id + ";";
                        connection.Open();
                        using (OdbcCommand command = new OdbcCommand(query, connection))
                        {
                            using (OdbcDataReader reader = command.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    palvelunnimi = reader.GetString(0);
                                    palvelunnimi += ", " + vp.lkm;
                                    varauksenpalvelunimet.Add(palvelunnimi);
                                }
                            }
                        }
                    }
                }
            }
            bs.ResetBindings(true);
            lbVarauksenPalvelut.DataSource = bs;
        }

        //Ottaa talteen varauksen päättymispäivän
        private void dtmLoppupvm_ValueChanged(object sender, EventArgs e)
        {
            loppupvm = dtmLoppupvm.Value;
            loppupvmmuutettu = true;
        }

        //Ottaa talteen varauksen alkamispäivän
        private void dtpAlkupvm_ValueChanged(object sender, EventArgs e)
        {
            alkupvm = dtpAlkupvm.Value;
            alkupvmmuutettu = true;
        }

        //Käynnistää varauksen luomisprosessin
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
                        Validointi();
                        break;
                    case 1:
                        if (MessageBox.Show("Varaukselle on valittu vain yksi päivä, luodaanko varaus silti?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                            Validointi();
                        break;
                    case 2:
                        MessageBox.Show("Varausta ei voi luoda: Varauksen alkupäivä ei voi olla sen päättymispäivän jälkeen.");
                        break;
                    default:
                        MessageBox.Show("Jokin meni nyt päiväyksen kanssa vikaan.");
                        break;
                }
            }
        }

        //Käynnistää annettujen tietojen validoinnin
        public void Validointi()
        {
            string msg = "Varausta ei voitu luoda: ";
            if (ValidAsiakas(ref msg))
            {
                if (!mokkilukittu)
                {
                    msg += "Mökkiä ei ole lukittu.";
                    MessageBox.Show(msg);
                }
                else
                {
                    if (ValidAlue())
                    {
                        if (ValidMokki(ref msg))
                        {
                            alkupvm = dtpAlkupvm.Value;
                            loppupvm = dtmLoppupvm.Value;
                            if (MokkiVapaa())
                                LuoVaraus();
                            else
                            {
                                msg += "Kyseinen mökki ei ole vapaa kyseisellä ajanjaksolla.";
                                MessageBox.Show(msg);
                            }
                        }
                        else
                            MessageBox.Show(msg);
                    }
                    else
                    {
                        msg += "";
                        MessageBox.Show(msg);
                    }
                }
            }
            else
                MessageBox.Show(msg);
        }

        //Varmistaa ko. mökin varauden varauken aikavälillä
        public bool MokkiVapaa()
        {
            foreach (Varaus v in varaukset)
            {
                if (v.mokki_id == valittumokki.mokki_id)
                {
                    if (alkupvm >= v.varattu_alkupvm && alkupvm < v.varattu_loppupvm)
                    {
                        return false;
                    }
                    else if (loppupvm > v.varattu_alkupvm && loppupvm <= v.varattu_loppupvm)
                    {
                        return false;
                    }
                    else if (alkupvm <= v.varattu_alkupvm && loppupvm >= v.varattu_loppupvm)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        //Varmistaa poistohalukkuuden ja käynnistää palvelun poistamisen varauksesta
        private void btnPoistaPalvelu_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Haluatko varmasti poistaa palvelun varauksesta?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (varauksenpalveluvalittu)
                    PoistaPalveluListasta(valitturivivarauksenpalvelu);
                else
                    MessageBox.Show("Poistettavaa varausta ei ole valittu.");
            }
        }

        //Tyhjentää kaikki palvelut varauksesta
        public void TyhjennaVarauksenPalvelut()
        {
            varauksenpalvelut.Clear();
            arvioituloppuhinta = 0;
            tbLoppuhinta.Text = arvioituloppuhinta.ToString();
            lisattavapalvelumaara = 0;
            nudPalveluLkm.Value = 0;
            PaivitaVarauksenPalvelutaulu();
            varauksenpalveluvalittu = false;
        }

        //Käynnistää ja validoi palvelun lisäyksen varaukseen
        private void btnLisaaPalveluVaraukseen_Click(object sender, EventArgs e)
        {
            if(!btnLisaaPalveluVaraukseen.Enabled)
            {
                MessageBox.Show("Mökin valintaa ei ole lukittu. Lukitse mökin valinta muokataksesi varauksen palveluja.");
            }
            else
            {
                if (palveluvalittu)
                {
                    if (nudPalveluLkm.Value <= 0)
                    {
                        MessageBox.Show("Palvelua ei voitu lisätä: lisättävän palvelun lukumäärä ei kelpaa.");
                    }
                    else
                    {
                        LisaaPalveluListaan(lisattavapalvelumaara, valittupalvelu);
                    }
                }
                else
                    MessageBox.Show("Palvelua ei voitu lisätä: Valitse lisättävä palvelu.");
            }
        }

        //Lisää palvelun varaukseen
        //(tai siis listaan, varauksen_palvelu-instancet luodaan tietokantaan vasta varauksen luonnin jälkeen (kustutaan LuoVaraus-funtiossa)
        public void LisaaPalveluListaan(int lkm, Palvelu lisattava)
        {
            VarauksenPalvelut vp = new VarauksenPalvelut();
            vp.varaus_id = tamavaraus.varaus_id;
            vp.palvelu_id = lisattava.palvelu_id;
            vp.lkm = lkm;
            if(!PalveluJoVarauksessa(vp))
            {
                varauksenpalvelut.Add(vp);
            }
            varauksessaonjopalvelu = false;
            PaivitaVarauksenPalvelutaulu();
            PaivitaLoppuhinta();
        }

        //Palauttaa tiedon siitä, onko palvelu jo lisättyy varaukseen.
        //Jos on, sitä muokataan, jos ei, se lisätään listaan.
        public bool PalveluJoVarauksessa(VarauksenPalvelut vp)
        {
            int uusimaara = 0;
            foreach(VarauksenPalvelut v in varauksenpalvelut)
            {
                if(v.varaus_id == vp.varaus_id && v.palvelu_id == vp.palvelu_id)
                {
                    uusimaara = v.lkm + vp.lkm;
                    vp.lkm = uusimaara;
                    v.lkm = uusimaara;
                    varauksessaonjopalvelu = true;
                }
            }
            return varauksessaonjopalvelu;
        }

        //Poistaa palvelun varauksen palveluiden listasta
        public void PoistaPalveluListasta(int rivi)
        {
            varauksenpalvelut.RemoveAt(rivi);
            varauksenpalveluvalittu = false;
            PaivitaVarauksenPalvelutaulu();
            PaivitaLoppuhinta();
        }

        //Päivittää arvioidun loppuhinnan
        public void PaivitaLoppuhinta()
        {
            double palveluidenhinta = 0;
            foreach(VarauksenPalvelut vp in varauksenpalvelut)
            {
                palveluidenhinta += GetPalvelunHinta(vp);
            }
            arvioituloppuhinta = valittumokki.hinta + palveluidenhinta;
            tbLoppuhinta.Text = arvioituloppuhinta.ToString();
        }

        //Luo järjestelmään instancet varauksen palveluista
        public void LisaaPalveluVaraukseen(VarauksenPalvelut vp)
        {
            using (OdbcConnection connection = new OdbcConnection(connectionString))
            {
                connection.Open();
                varauksenpalveluquery = "INSERT INTO varauksen_palvelut(varaus_id, palvelu_id, lkm) " +
                    "VALUES(" + vp.varaus_id + ", " + vp.palvelu_id + ", " + vp.lkm + ");";
                using (OdbcCommand cmd = new OdbcCommand(varauksenpalveluquery, connection))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }

        //Varmistaa poistumishalukkuuden
        private void frmUusiVaraus_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!varausluotu)
            {
                if (MessageBox.Show("Haluatko varmasti poistua?", "", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }

        //Käynnistää uuden asiakkaan luonnin
        private void btnLisaa_Click(object sender, EventArgs e)
        {
            if (tbAsiakastunnus.Text.Length > 0)
                MessageBox.Show("Asiakas on jo olemassa. Poista asiakastunnus kentästä luodaksesi uusi asiakas.");
            else
                TarkistaNimi();
        }

        //Tarkistaa uuden asiakkaan nimen
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

        //Tarkistaa uuden asiakkaan osoitteen olemassaolon
        public void TarkistaOsoite()
        {
            if (tbPostinoAsiakas.Text.Length > 0 && tbPostinoAsiakas.Text.Length < 6)
            {
                if(tbLahiosoiteAsiakas.Text.Length > 0)
                {
                    //Muotoa ei tarkisteta.
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

        //Tarkistaa uuden asiakkan puhelinnumeron olemassaolon
        public void TarkistaPuhno()
        {
            if(tbPuhno.Text.Length > 0)
            {
                //Muotoa ei tarkisteta.
                TarkistaSahkoposti();
            }
            else
                MessageBox.Show("Uutta asiakasta ei voitu luoda: syötä puhelinnumero.");
        }

        //Tarkistaa uuden asiakkan sähköpostiosoitteen olemassaolon
        public void TarkistaSahkoposti()
        {
            if(tbSahkoposti.Text.Length > 0)
            {
                //Muotoa ei tarkisteta.
                LuoAsiakas();
            }
            else
                MessageBox.Show("Uutta asiakasta ei voitu luoda: syötä shköpostiosoite.");
        }

        //Luo uuden asiakkaan
        public void LuoAsiakas()
        {
            luotuasiakas.asiakas_id = HaeSeuraavaVapaaAsiakasID();
            luotuasiakas.postinro = tbPostinoAsiakas.Text;
            luotuasiakas.etunimi = tbEnimi.Text;
            luotuasiakas.sukunimi = tbSnimi.Text;
            luotuasiakas.lahiosoite = tbLahiosoiteAsiakas.Text;
            luotuasiakas.email = tbSahkoposti.Text;
            luotuasiakas.puhelinnro = tbPuhno.Text;

            if (!PostiLoytyi(luotuasiakas.postinro))
                LuoPosti(luotuasiakas.postinro, tbPostitoimipaikkaAsiakas.Text);

            using (OdbcConnection connection = new OdbcConnection(connectionString))
            {
                connection.Open();
                string lisaysquery = "INSERT INTO asiakas(asiakas_id, postinro, etunimi, sukunimi, lahiosoite, email, puhelinnro) VALUES(" + luotuasiakas.asiakas_id + ", '" + luotuasiakas.postinro + "', '" + luotuasiakas.etunimi + "', '" + luotuasiakas.sukunimi + "', '" + luotuasiakas.lahiosoite + "', '" + luotuasiakas.email + "', '" + luotuasiakas.puhelinnro + "');";
                using (OdbcCommand cmd = new OdbcCommand(lisaysquery, connection))
                {
                    cmd.ExecuteNonQuery();
                }
                LokiinTallentaminen("Luotiin asiakas " + luotuasiakas.asiakas_id + " käyttäjältä: ");
            }
            asiakkaat = GetAsiakkaat();
            asiakasquery = "SELECT * FROM asiakas;";
            PaivitaAsiakastaulu(asiakasquery);

            valittuasiakas = luotuasiakas;
        }

        //Palauttaa tiedon, löytyykö postinumero jo tietokannasta
        public bool PostiLoytyi(string pn)
        {
            foreach(Posti p in postit)
            {
                if (p.postinro == pn)
                    return true;
            }
            return false;
        }

        //Luo uuden postitoimipaikan tietokantaan (ja postinumeron)
        public void LuoPosti(string pnro, string ptp)
        {
            using (OdbcConnection connection = new OdbcConnection(connectionString))
            {
                connection.Open();
                string lisaysquery = "INSERT INTO posti(postinro, toimipaikka) VALUES(" + pnro + ", '" + ptp + "');";
                using (OdbcCommand cmd = new OdbcCommand(lisaysquery, connection))
                {
                    cmd.ExecuteNonQuery();
                }
                LokiinTallentaminen("Luotiin postinumero " + pnro + " käyttäjältä: ");
            }
            postit = GetPostit();
        }

        //Varmistaa onko "vastaus lukittu" mökin kannalta
        //Ei siis anna muokata lisäpalveluita, ennen kuin mökin valinta on varmistettu
        private void cbLukitseMokki_CheckedChanged(object sender, EventArgs e)
        {
            if (cbLukitseMokki.Checked == true)
            { 
                mokkilukittu = true;
                pnlMokki.Enabled = false;
                pnlPalvelut.Enabled = true;
                dgvAlueenPalvelut.Enabled = true;
                nudPalveluLkm.Enabled = true;
                btnLisaaPalveluVaraukseen.Enabled = true;
                btnPoistaPalvelu.Enabled = true;
                lbVarauksenPalvelut.Enabled = true;
                PaivitaLoppuhinta();

                if (ValidAlue())
                {
                    palveluquery = "SELECT * FROM palvelu WHERE alue_id = " + valittualue.alue_id + ";";
                    PaivitaPalvelutaulu(palveluquery);
                }
                else
                    MessageBox.Show("Mökkiä tai sen aluetta ei ole valittu riittävän hyvin, joten alueen palveluita ei voida muokata.");

                palveluquery = "SELECT * FROM palvelu WHERE alue_id = (SELECT alue_id FROM mokki WHERE mokki_id = " + valittumokki.mokki_id.ToString() + ");";
                palvelut = GetPalvelut();
                PaivitaPalvelutaulu(palveluquery);
            }
            else if (cbLukitseMokki.Checked == false)
            {
                mokkilukittu = false;
                pnlMokki.Enabled = true;
                dgvAlueenPalvelut.Enabled = false;
                nudPalveluLkm.Enabled = false;
                btnLisaaPalveluVaraukseen.Enabled = false;
                btnPoistaPalvelu.Enabled = false;
                lbVarauksenPalvelut.Enabled = false;
                varauksenpalveluvalittu = false;

                palveluquery = "SELECT * FROM palvelu;";
                PaivitaPalvelutaulu(palveluquery);
                pnlPalvelut.Enabled = false;
            }
        }

        //Palauttaa tiedon siitä, onko mökkivalinta lukittu
        public bool MokkiLukittu()
        {
            if (!mokkilukittu)
                return false;
            else return true;
        }

        //Varmistaa varauksen päivämäärien oikean muodon
        public int ValidPvm()
        {
            if (alkupvm < loppupvm)
                return 0;
            else if (alkupvm.Equals(loppupvm))
                return 1;
            else
                return 2;
        }

        //Varmistaa, ettei asiakas ole jäänyt tyhjäksi
        public bool ValidAsiakas(ref string msg)
        {
            if(valittuasiakas == null && tbEnimi.Text == "" && tbSnimi.Text == "" && tbAsiakastunnus.Text == "" && tbPostitoimipaikkaAsiakas.Text == "" && tbLahiosoiteAsiakas.Text == "" && tbPostinoAsiakas.Text == "" && tbPuhno.Text == "" && tbSahkoposti.Text == "")
            {
                msg += "Varaukselle ei ole osoitettu asiakasta.";
                return false;
            }
            else if (valittuasiakas == null && !(tbEnimi.Text == "" && tbSnimi.Text == "" && tbPostitoimipaikkaAsiakas.Text == "" && tbLahiosoiteAsiakas.Text == "" && tbPostinoAsiakas.Text == "" && tbPuhno.Text == "" && tbSahkoposti.Text == ""))
            {
                if (!AsiakasLoytyi())
                {
                    if (MessageBox.Show("Varaukselle ei ole osoitettu valmista olemassa olevaa asiakasta. Luodaanko uusi?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        LuoAsiakas();
                        return true;
                    }
                    else
                    {
                        msg += "Varaukselle ei ole osoitettu asiakasta.";
                        return false;
                    }
                }
                else
                    return true;
            }
            return true;
        }

        //Varmistaa, ettei alue ole jäänyt tyhjäksi
        public bool ValidAlue()
        {
            if(valittualue != null)
                return true;
            return false;
        }

        //Varmistaa, että mökki on valittu, ja sen tiedot eivät ole ristiriidassa muiden varauksen tietojen kanssa
        public bool ValidMokki(ref string msg)
        {
            if (valittumokki != null)
            {
                if (nudHlomaara.Value >= 1)
                {
                    if (nudHlomaara.Value <= valittumokki.henkilomaara)
                        return true;
                    else
                        msg = "Valitun mökin henkilökapasiteetti on liian pieni valitulle henkilöpäärälle. Valitse toinen mökki tai vähennä henkilömäärää.";
                }
                else
                    msg = "Valittu henkilömäärä on liian pieni. (pienempi kuin 1)";
            }
            else
                msg = "Mökkiä ei ole valittu.";
            return false;
        }

        //Kirjaa sulkemisen lokiin
        private void frmUusiVaraus_FormClosed(object sender, FormClosedEventArgs e)
        {
            LokiinTallentaminen("Suljettiin uuden varauksen luontisivu käyttäjältä: ");
        }

        //Tarkistaa uuden asiakkaan etu- ja sukunimen, sekä postitoimipaikan muodon
        private void tbEnimi_Leave(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            string nimi = tb.Text.Trim();

            if (nimi.Length > 0)
            {
                nimi = nimi.Substring(0,1).ToUpper() + nimi.Substring(1, nimi.Length - 1).ToLower();
                tb.Text = nimi;
            }
        }

        //Varmistaa, että kutsuvaan kenttään syötetään vain numeroita
        private void tbPostinoAsiakas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!Char.IsDigit(e.KeyChar)) && (e.KeyChar != (char)8))
                e.Handled = true;
        }

        //Hakee syötetyn aluetunnuksen alueen nimen.
        //Voi palauttaa useampia, jos alueiden tunnukset yltävät useampinumeroisiin lukuihin ja on syötetty tunnusta lyhyempi luku
        private void tbAlueid_TextChanged(object sender, EventArgs e)
        {
            if (tbAlueid.Text.Length > 0)
            {
                aluequery = "SELECT nimi FROM alue WHERE alue_id LIKE '" + tbAlueid.Text + "%';";
                PaivitaAluetaulu(aluequery);
                palveluquery = "SELECT * FROM palvelu WHERE alue_id LIKE '" + tbAlueid.Text + "%';";
                palvelut = GetPalvelut();
                PaivitaPalvelutaulu(palveluquery);
                if (lbAlue.Items.Count > 0)
                {
                    if(lbAlue.Items.Count == 1)
                    {
                        if (GetValittuAlue(lbAlue.Text))
                        {
                            aluevalittu = true;
                            palveluquery = "SELECT * FROM palvelu WHERE alue_id = " + valittualue.alue_id + ";";
                            palvelut = GetPalvelut();
                            PaivitaPalvelutaulu(palveluquery);
                        }
                        else
                        {
                            MessageBox.Show("Aluetunnuksen tunnistamisessa häiriö.");
                            aluevalittu = false;
                        }
                    }    
                }
                else aluevalittu = false;
            }
            else
            {
                aluequery = "SELECT nimi FROM alue;";
                PaivitaAluetaulu(aluequery);
                aluevalittu = false;
                palveluquery = "SELECT * FROM palvelu;";
                palvelut = GetPalvelut();
                PaivitaPalvelutaulu(palveluquery);
            }
        }

        //Päivittää asiakastaulun päivityslauseen
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

        //Tyhjentää valinnan asiakkaasta
        public void TyhjennaAsiakas()
        {
            asiakasjuurivalittu = false;
            valittuasiakas.asiakas_id = HaeSeuraavaVapaaAsiakasID();
            valittuasiakas.etunimi = "";
            valittuasiakas.postinro = "";
            valittuasiakas.lahiosoite = "";
            valittuasiakas.email = "";
            valittuasiakas.puhelinnro = "";

            asiakasquery = "SELECT * FROM asiakas;";
            PaivitaAsiakastaulu(asiakasquery);
            tbAsiakastunnus.Text = String.Empty;
            tbEnimi.Text = String.Empty;
            tbSnimi.Text = String.Empty;
            tbPostinoAsiakas.Text = String.Empty;
            tbLahiosoiteAsiakas.Text = String.Empty;
            tbSahkoposti.Text = String.Empty;
            tbPuhno.Text = String.Empty;
            tbPostitoimipaikkaAsiakas.Text = String.Empty;
        }

        //Ottaa etunimen talteen uutta asiakasta varten
        private void tbEnimi_TextChanged(object sender, EventArgs e)
        {
            luotuasiakas.etunimi = tbEnimi.Text;
        }

        //Ottaa sukunimen talteen uutta asiakasta varten
        private void tbSnimi_TextChanged(object sender, EventArgs e)
        {
            luotuasiakas.sukunimi = tbSnimi.Text;
        }

        //Ottaa postinumeron talteen uutta asiakasta varten
        private void tbPostinoAsiakas_TextChanged(object sender, EventArgs e)
        {
            luotuasiakas.postinro = tbPostinoAsiakas.Text;
        }

        //Ottaa lähiosoitteen talteen uutta asiakasta varten
        private void tbLahiosoiteAsiakas_TextChanged(object sender, EventArgs e)
        {
            luotuasiakas.lahiosoite = tbLahiosoiteAsiakas.Text;
        }

        //Ottaa puhelinnumeron talteen uutta asiakasta varten
        private void tbPuhno_TextChanged(object sender, EventArgs e)
        {
            luotuasiakas.puhelinnro = tbPuhno.Text;
        }

        //Ottaa sähköpostiosoitteen talteen uutta asiakasta varten
        private void tbSahkoposti_TextChanged(object sender, EventArgs e)
        {
            luotuasiakas.email = tbSahkoposti.Text;
        }

        //Ottaa datagridview:sta valitun asiakkaan talteen
        private void dgvAsiakkaat_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            valittuasiakas = GetValittuAsiakas(dgv.CurrentRow.Index);

            asiakasjuurivalittu = true;

            tbEnimi.Text = valittuasiakas.etunimi;
            tbSnimi.Text = valittuasiakas.sukunimi;
            tbPostinoAsiakas.Text = valittuasiakas.postinro;
            tbAsiakastunnus.Text = valittuasiakas.asiakas_id.ToString();
            tbLahiosoiteAsiakas.Text = valittuasiakas.lahiosoite;
            tbSahkoposti.Text = valittuasiakas.email;
            tbPuhno.Text = valittuasiakas.puhelinnro;
            postiqueryasiakas = "SELECT toimipaikka FROM posti WHERE postinro = (SELECT postinro FROM asiakas WHERE asiakas_id = " + valittuasiakas.asiakas_id + ");";
            HaePostinro(postiqueryasiakas);
        }

        //Palauttaa käsiteltävän asiakkaan
        public Asiakas GetValittuAsiakas(int rivi)
        {
            Asiakas a = new Asiakas();
            a.asiakas_id = asiakkaat[rivi].asiakas_id;
            a.postinro = asiakkaat[rivi].postinro;
            a.etunimi = asiakkaat[rivi].etunimi;
            a.sukunimi = asiakkaat[rivi].sukunimi;
            a.lahiosoite = asiakkaat[rivi].lahiosoite;
            a.email = asiakkaat[rivi].email;
            a.puhelinnro = asiakkaat[rivi].puhelinnro;

            return a;
        }

        //Ottaa valitun alueen talteen, ja palauttaa onnistuiko se
        public bool GetValittuAlue(string nimi)
        {
            Alue a = new Alue();
            a.nimi = nimi;

            foreach(Alue alue in alueet)
            {
                if (alue.nimi == nimi)
                    valittualue = alue;
                return true;
            }
            return false;
        }

        //Hakee tietokannasta postinumeron
        public void HaePostinro (string postiqueryasiakas)
        {
            using (OdbcConnection connection = new OdbcConnection(connectionString))
            {
                connection.Open();
                using (OdbcCommand command = new OdbcCommand(postiqueryasiakas, connection))
                {
                    using (OdbcDataReader reader = command.ExecuteReader())
                    {
                        while(reader.Read())
                        {
                            string luettutoimipaikka = reader.GetString(0);

                            tbPostitoimipaikkaAsiakas.Text = luettutoimipaikka;
                        }
                    }
                }
            }
        }

        //Tarkistaa onko annettu asiakas jo olemassa
        //Jos on, ottaa sen talteen
        public bool AsiakasLoytyi()
        {
            Asiakas a = new Asiakas();
            a.postinro = tbPostinoAsiakas.Text;
            a.etunimi = tbEnimi.Text;
            a.sukunimi = tbSnimi.Text;
            a.lahiosoite = tbLahiosoiteAsiakas.Text;
            a.email = tbSahkoposti.Text;
            a.puhelinnro = tbPuhno.Text;

            if(tbAsiakastunnus.Text.Length > 0)
            {
                a.asiakas_id = int.Parse(tbAsiakastunnus.Text);

                foreach (Asiakas asi in asiakkaat)
                {
                    if (a == asi)
                    {
                        valittuasiakas = asi;
                        return true;
                    }
                }
            }
            else
            {
                foreach (Asiakas asi in asiakkaat)
                {
                    if (a.postinro == asi.postinro && a.etunimi == asi.etunimi && a.sukunimi == asi.sukunimi && a.lahiosoite == asi.lahiosoite && a.email == asi.email && a.puhelinnro == asi.puhelinnro)
                    {
                        valittuasiakas = asi;
                        return true;
                    }
                }
            }

            return false;
        }

        //Käynnistää mökin haun
        private void btnHaemokki_Click(object sender, EventArgs e)
        {
            if(tbMokkitunnus.Text.Length>0)
            {
                haettavamokki.mokki_id = int.Parse(tbMokkitunnus.Text);
                mokkiquery = "SELECT * FROM mokki WHERE mokki_id LIKE '" + haettavamokki.mokki_id + "%';";
                PaivitaMokkitaulu(mokkiquery);
            }
            else
            {
                MuodostaMokkiHakuQuery();
                PaivitaMokkitaulu(mokkiquery);
            }
        }

        //Varmistaa, syötetään vain muneroita tai välimerkki
        private void tbMinhinta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!Char.IsDigit(e.KeyChar)) && (e.KeyChar != (char)8) && (e.KeyChar != (char)46)) //Jos ei toimi: pilkku = 44
                e.Handled = true;
        }

        //Varmistaa, että hinta on syötetty oikein
        private void tbMinhinta_Leave(object sender, EventArgs e)
        {
            if (tbMinhinta.Text.Length > 0)
            {
                if (!(Double.TryParse(tbMinhinta.Text, out minhinta)))
                    MessageBox.Show("Minimihintaa ei voitu kääntää- olisiko pilkkuvirhe?");
            }
            else minhinta = 0;
        }
        private void frmUusiVaraus_Load(object sender, EventArgs e)
        {
            this.palveluTableAdapter.Fill(this.dataSet1.palvelu);
        }

        //Tyhjentää asiakasvalinnan
        private void btnTyhjValinta_Click(object sender, EventArgs e)
        {
            TyhjennaAsiakas();
        }

        //Varmistaa, ettei haettavassa mökissä ole liian pieni määrä henkilöitä
        private void nudHlomaara_ValueChanged(object sender, EventArgs e)
        {
            if(nudHlomaara.Value < 1)
                nudHlomaara.Value = 1;
        }

        //Ottaa valitun alueen talteen
        private void lbAlue_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            valitturivialue = lbAlue.SelectedIndex;
            valittualue = alueet[valitturivialue];
            tbAlueid.Text = valittualue.alue_id.ToString();
            aluevalittu = true;
        }

        //Yhdistää kaikki mökin hakukriteerit yhdeksi hakulauseeksi
        public void MuodostaMokkiHakuQuery()
        {
            mokkiquery = "SELECT * FROM mokki" + MuodostaPVMHaku() + MuodostaAlueHaku() + MuodostaLKMHaku() + MuodostaHintaHaku() + ";";
        }

        //Muodostaa hakulauseen ajanjaksosta (mitkä mökit vapaita)
        //Saattaa olla keskeneräinen, en nyt muista juuri ennen palautusta
        public string MuodostaPVMHaku()
        {
            string pal = "";
            if(alkupvmmuutettu && loppupvmmuutettu)
            {
                pal = " WHERE mokki_id NOT IN (SELECT mokki_mokki_id FROM varaus WHERE varattu_alkupvm BETWEEN '" + alkupvm + "' AND '" + loppupvm + "' OR varattu_loppupvm BETWEEN '" + alkupvm + "' AND '" + loppupvm + "')";
            }
            return pal;
        }

        //Muodostaa hakulauseen alueesta
        public string MuodostaAlueHaku()
        {
            string pal = "";
            if(alkupvmmuutettu && loppupvmmuutettu)
            {
                if (aluevalittu)
                    pal = " AND alue_id = " + valittualue.alue_id.ToString();
            }
            else
            {
                if(aluevalittu)
                    pal = " WHERE alue_id = " + valittualue.alue_id.ToString();
            }
            return pal;
        }

        //Muodostaa hakulauseen henkilömäärästä
        public string MuodostaLKMHaku()
        {
            string pal = "";
            if(aluevalittu || (alkupvmmuutettu && loppupvmmuutettu))
            {
                if (nudHlomaara.Value > 1)
                    pal = " AND henkilomaara >= " + nudHlomaara.Value.ToString();
            }
            else
            {
                if (nudHlomaara.Value > 1)
                    pal = " WHERE henkilomaara >= " + nudHlomaara.Value.ToString();
            }
            return pal;
        }

        //Muodostaa hakulauseen minimi- ja maksimihinnoista
        public string MuodostaHintaHaku()
        {
            string pal = "";
            if(aluevalittu || (alkupvmmuutettu && loppupvmmuutettu) || nudHlomaara.Value > 1)
            {
                if (minhinta > 0 && maxhinta > 0)
                    pal = " AND hinta BETWEEN '" + minhinta + "' AND '" + maxhinta;
                else if (minhinta > 0 && maxhinta <= 0)
                    pal = " AND hinta > " + minhinta;
                else if (minhinta <= 0 && maxhinta > 0)
                    pal = " AND hinta < " + maxhinta;
            }
            else
            {
                if (minhinta > 0 && maxhinta > 0)
                    pal = " WHERE hinta BETWEEN '" + minhinta + "' AND '" + maxhinta;
                else if (minhinta > 0 && maxhinta <= 0)
                    pal = " WHERE hinta > " + minhinta;
                else if (minhinta <= 0 && maxhinta > 0)
                    pal = " WHERE hinta < " + maxhinta;
            }
            return pal;
        }

        //Käynnistää ajan nollauksen
        private void btnNollaaAika_Click(object sender, EventArgs e)
        {
            NollaaAika();
        }

        //Nollaa varauksen ajanjakson
        public void NollaaAika()
        {
            dtpAlkupvm.Value = nyt;
            dtmLoppupvm.Value = nyt;
            alkupvm = nyt;
            loppupvm = nyt;
            alkupvmmuutettu = false;
            loppupvmmuutettu = false;
        }

        //Nollaa varauksen aluevalinnan
        public void NollaaAlue()
        {
            aluevalittu = false;
            tbAlueid.Text = "";
            aluequery = "SELECT nimi FROM alue;";
            PaivitaAluetaulu(aluequery);
        }

        //Varmistaa, että hinta on syötetty oikein
        private void tbMaxhinta_Leave(object sender, EventArgs e)
        {
            if(tbMaxhinta.Text.Length > 0)
            {
                if (!(Double.TryParse(tbMaxhinta.Text, out maxhinta)))
                    MessageBox.Show("Maksimihintaa ei voitu kääntää- olisiko pilkkuvirhe?");
            }
            else maxhinta = 0;
        }

        //Tyhjentää mökin haun
        private void tbnTyhjennaMokkihaku_Click(object sender, EventArgs e)
        {
            mokkiquery = "SELECT * FROM mokki;";
            PaivitaMokkitaulu(mokkiquery);
            nudHlomaara.Value = 1;
            tbMinhinta.Text = "0";
            tbMaxhinta.Text = "0";
            minhinta = 0;
            maxhinta = 0;
            tbLoppuhinta.Text = "0";
            arvioituloppuhinta = 0;
            tbMokkitunnus.Text = "";
            NollaaAika();
            NollaaAlue();
        }

        //Varmistaa, ettei loppuhintaan syötetä mitään
        private void tbLoppuhinta_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        //Ottaa talteen lisättävän palvelun lukumäärän, jos palvelu on valittu
        private void nudPalveluLkm_ValueChanged(object sender, EventArgs e)
        {
            if (!palveluvalittu)
            {
                MessageBox.Show("Määrää ei voi muokata: Valitse lisättävä palvelu.");
                nudPalveluLkm.Value = 0;
            }
            else
                lisattavapalvelumaara = (int)nudPalveluLkm.Value;
        }

        //Ottaa talteen valitun palvelun
        private void lbVarauksenPalvelut_SelectedIndexChanged(object sender, EventArgs e)
        {
            valitturivivarauksenpalvelu = lbVarauksenPalvelut.SelectedIndex;
            varauksenpalveluvalittu = true;
        }

        //Ottaa talteen valitun varaukseen lisätyn palvelun
        private void dgvAlueenPalvelut_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            valitturivipalvelu = dgvAlueenPalvelut.CurrentRow.Index;
            valittupalvelu = palvelut[valitturivipalvelu];
            palveluvalittu = true;
        }

        //Ottaa talteen valitun mökin
        private void dgvMokitUusiVaraus_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            valitturivimokki = dgvMokitUusiVaraus.CurrentRow.Index;
            valittumokki = mokit[valitturivimokki];
            arvioituloppuhinta = valittumokki.hinta;
            tbLoppuhinta.Text = arvioituloppuhinta.ToString();
            tbAlueid.Text = valittumokki.alue_id.ToString();
            valittualue = alueet[int.Parse(tbAlueid.Text)];
            tbMokkitunnus.Text = valittumokki.mokki_id.ToString();
            TyhjennaVarauksenPalvelut();
        }
    }
}
