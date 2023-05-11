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

namespace R13_MokkiBook
{
    public partial class frmUusiVaraus : Form
    {//Pan
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
        public bool varauksessaonjopalvelu = false;//?
        public bool palveluvalittu = false;
        public bool varauksenpalveluvalittu = false;

        public frmUusiVaraus()
        {
            InitializeComponent();
            varaukset = GetVaraukset();
            tamavaraus = new Varaus();
            tamavaraus.varaus_id = HaeSeuraavaVapaaVarausID();
            // varausquery = "INSERT INTO varaus (varaus_id, asiakas_id, mokki_mokki_id, varattu_pvm, vahvistus_pvm, varattu_alkupvm, varattu_loppupvm) VALUES('" + tamavaraus.varaus_id + "', '1', '1', " + nyt.ToShortDateString() + ", " + nyt.ToShortDateString() + ", " + nyt.ToShortDateString() + ", " + nyt.ToShortDateString() + ");"; 
            //Pakko laittaa ykköset nuihin ihan vaan, muuten ei luo HUOM! Jos ei ole olemassa asiakasta 1 ja mökkiä 1, ei toimi!
            //LisaaTamavarausVarauksiin(varausquery);
            //varaukset = GetVaraukset();
            //
            //Nämä aiheuttivat errorin? 
            palvelut = GetPalvelut();
            //varauksenpalvelut = GetVarauksenPalvelut();
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
        public void LokiinTallentaminen(string teksti)
        {
            string kayttaja = Environment.UserName;

            StreamWriter sw = new StreamWriter("Kirjautumistiedot.txt", true);
            sw.WriteLine(DateTime.Now.ToString() + " " + teksti + " " + kayttaja);
            sw.Close();
        }
        public void LisaaTamavarausVarauksiin(string varausquery)
        {
            using (OdbcConnection connection = new OdbcConnection(connectionString))
            {
                connection.Open();
                using (OdbcCommand cmd = new OdbcCommand(varausquery, connection))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public void PoistaTamavarausVarauksista()
        {
            using (OdbcConnection connection = new OdbcConnection(connectionString))
            {
                varausquery = "DELETE FROM varaus WHERE varaus_id = " + tamavaraus.varaus_id + ";";
                connection.Open();
                using (OdbcCommand cmd = new OdbcCommand(varausquery, connection))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }
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

        //public List<VarauksenPalvelut> GetVarauksenPalvelut()// Tässä käsiteltäisiin luomattoman/keskeneräisen varauksen palveluita... ei voi luoda palvelue ennen kuin se on oikeasti valmis!!
        //{
            //List<VarauksenPalvelut> vpal = new List<VarauksenPalvelut>();
            /*string query = "SELECT * FROM varauksen_palvelut WHERE varaus_id = " + tamavaraus.varaus_id + ";";

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
            }*/
            //return vpal;
        //}
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
        public void LuoVaraus()
        {

            //jos kaikki onnistuu:
            //UPDATE??
            varausluotu = true;
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
        public void PaivitaVarauksenPalvelutaulu() 
        {
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
                                }
                            }
                        }
                    }
                    varauksenpalvelunimet.Add(palvelunnimi);
                }
                bs.ResetBindings(true);
                lbVarauksenPalvelut.DataSource = bs;
            }
            else
                lbVarauksenPalvelut.Items.Clear();
            /*varauksenpalvelut = GetVarauksenPalvelut();
            OdbcConnection connection = new OdbcConnection(connectionString);
            connection.Open();
            DataTable dataTable = new DataTable();
            using (OdbcDataAdapter adapter = new OdbcDataAdapter(varauksenpalveluquery, connection))
            {
                adapter.FillSchema(dataTable, SchemaType.Source);
                adapter.Fill(dataTable);
            }
            lbVarauksenPalvelut.DataSource = dataTable;*/
        }
        private void dtmLoppupvm_ValueChanged(object sender, EventArgs e)
        {
            loppupvm = dtmLoppupvm.Value;
            loppupvmmuutettu = true;
        }

        private void dtpAlkupvm_ValueChanged(object sender, EventArgs e)
        {
            alkupvm = dtpAlkupvm.Value;
            alkupvmmuutettu = true;
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
        public void Validointi()
        {
            string msg = "Varausta ei voitu luoda: ";
            if (ValidAsiakas(ref msg))//toimiiko?
            {
                if (!mokkilukittu)
                    MessageBox.Show("Varausta ei voitu luoda: Mökkiä ei ole lukittu.");
                else//Huom muut vaatimukset! Validoi alue, mökki & sen vapaus, posti, määrä!
                {
                    if (ValidAlue())
                    {
                        if (ValidMokki())
                        {
                            if (MokkiVapaa())
                                LuoVaraus();
                            else
                                MessageBox.Show("Kyseinen mökki ei ole vapaa kyseisellä ajanjaksolla.");
                        }
                    }
                    else
                        MessageBox.Show("");
                }
            }
            else
                MessageBox.Show(msg);
        }

        public bool MokkiVapaa()
        {
            //jos ei return false
            return true;
        }

        private void btnPoistaPalvelu_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Haluatko varmasti poistaa palvelun varauksesta?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                //palvelupoistoquery = "DELETE FROM varauksen_palvelut WHERE varaus_id = " + valittuvarauksenpalvelu.varaus_id + " AND palvelu_id = " + valittuvarauksenpalvelu.palvelu_id + ";";
                //PoistaPalveluVarauskesta(palvelupoistoquery);
                if (varauksenpalveluvalittu)
                    PoistaPalveluListasta(valitturivivarauksenpalvelu);
                else
                    MessageBox.Show("Poistettavaa varausta ei ole valittu.");
            }
        }

       /* public void PoistaPalveluVarauskesta(string poistoquery)
        {
            using (OdbcConnection connection = new OdbcConnection(connectionString))
            {
                connection.Open();
                using (OdbcCommand cmd = new OdbcCommand(poistoquery, connection))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }*/

        public void TyhjennaVarauksenPalvelut()
        {
            varauksenpalvelut.Clear();
            arvioituloppuhinta = 0;
            tbLoppuhinta.Text = arvioituloppuhinta.ToString();
            lisattavapalvelumaara = 0;
            nudPalveluLkm.Value = 0;
            PaivitaVarauksenPalvelutaulu();
            varauksenpalveluvalittu = false;
            /*foreach(VarauksenPalvelut vp in varauksenpalvelut)
            {   //olisi voinut varmaankin jokun yleisenkin poistokäskyn laittaa, mutta aivot haluaa nyt näin
                palvelupoistoquery = "DELETE FROM varauksen_palvelut WHERE varaus_id = " + vp.varaus_id + " AND palvelu_id = " + vp.palvelu_id + ";";
                PoistaPalveluVarauskesta(palvelupoistoquery);
            }*/
        }

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
                        //LisaaPalveluVaraukseen();
                        //varauksenpalveluquery = "SELECT palvelu_id, lkm FROM varauksen_palvelut WHERE varaus_id = " + tamavaraus.varaus_id + ";";
                        LisaaPalveluListaan(lisattavapalvelumaara, valittupalvelu);
                    }
                }
                else
                    MessageBox.Show("Palvelua ei voitu lisätä: Valitse lisättävä palvelu.");
            }
        }
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
            PaivitaVarauksenPalvelutaulu();
            PaivitaLoppuhinta();
        }
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
        public void PoistaPalveluListasta(int rivi)
        {
            varauksenpalvelut.RemoveAt(rivi);
            varauksenpalveluvalittu = false;
            PaivitaVarauksenPalvelutaulu();
            PaivitaLoppuhinta();
        }
        public void PaivitaLoppuhinta()
        {
            double palveluidenhinta = 0;
            foreach(VarauksenPalvelut vp in varauksenpalvelut)
            {
                palveluidenhinta += GetPalvelunHinta(vp);
            }
            arvioituloppuhinta = valittumokki.hinta + palveluidenhinta;
            tbLoppuhinta.Text = arvioituloppuhinta.ToString();//2 desimaalia??
        }
        public void LisaaPalveluVaraukseen()
        {
            /*valittuvarauksenpalvelu.varaus_id = tamavaraus.varaus_id;
            valittuvarauksenpalvelu.palvelu_id = valittupalvelu.palvelu_id;
            valittuvarauksenpalvelu.lkm = (int)nudPalveluLkm.Value;

            foreach (VarauksenPalvelut vap in varauksenpalvelut)
            {
                if ((vap.varaus_id == valittuvarauksenpalvelu.varaus_id) && (vap.palvelu_id == valittuvarauksenpalvelu.palvelu_id))
                {
                    varauksessaonjopalvelu = true;
                    valittuvarauksenpalvelu.lkm = vap.lkm + (int)nudPalveluLkm.Value;
                }
            }
            if (!varauksessaonjopalvelu)
            {
                using (OdbcConnection connection = new OdbcConnection(connectionString))
                {
                    connection.Open();
                    palvelulisaysquery = "INSERT INTO varauksen_palvelut(varaus_id, palvelu_id, lkm) VALUES(" + valittuvarauksenpalvelu.varaus_id + ", " + valittuvarauksenpalvelu.palvelu_id + ", " + valittuvarauksenpalvelu.lkm + ");";
                    using (OdbcCommand cmd = new OdbcCommand(palvelulisaysquery, connection))
                    {
                        cmd.ExecuteNonQuery(); //System.Data.Odbc.OdbcException: 'ERROR [23000] [ma-3.1.18][10.6.12-MariaDB]Cannot add or update a child row: a foreign key constraint fails (`vn`.`varauksen_palvelut`, CONSTRAINT `fk_varaus` FOREIGN KEY (`varaus_id`) REFERENCES `varaus` (`varaus_id`))'
                    }
                }
            }
            else
            {
                using (OdbcConnection connection = new OdbcConnection(connectionString))
                {
                    connection.Open();
                    palvelulisaysquery = "UPDATE varauksen_palvelut SET varaus_id = " + valittuvarauksenpalvelu.varaus_id + ", palvelu_id = " + valittuvarauksenpalvelu.palvelu_id + ", lkm = " + valittuvarauksenpalvelu.lkm + " WHERE varaus_id = " + valittuvarauksenpalvelu.varaus_id + " AND palvelu_id = " + valittuvarauksenpalvelu.palvelu_id + "; ";
                    using (OdbcCommand cmd = new OdbcCommand(palvelulisaysquery, connection))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }
            }*/
        }
        private void frmUusiVaraus_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Haluatko varmasti poistua?", "", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
        private void btnLisaa_Click(object sender, EventArgs e)
        {
            if (tbAsiakastunnus.Text.Length > 0)
                MessageBox.Show("Asiakas on jo olemassa. Poista asiakastunnus kentästä luodaksesi uusi asiakas.");
            else
                TarkistaNimi();
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
        public bool PostiLoytyi(string pn)
        {
            foreach(Posti p in postit)
            {
                if (p.postinro == pn)
                    return true;
            }
            return false;
        }
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
                varauksenpalveluvalittu = false;//MENEEKÖ TÄHÄN VAI MUUALLE

                palveluquery = "SELECT * FROM palvelu;";
                PaivitaPalvelutaulu(palveluquery);
                pnlPalvelut.Enabled = false;
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
        public bool ValidAlue()//Tarkista vielä- pitäisikö katsoa mätsääkö alue mökkiin??
        {
            if(valittualue != null)
                return true;
            return false;
        }

        public bool ValidMokki()//Tarkista vielä- pitäisikö katsoa mätsääkö alue mökkiin??
        {
            return true;
            //ei valmis!!
        }

        private void frmUusiVaraus_FormClosed(object sender, FormClosedEventArgs e)
        {
            LokiinTallentaminen("Suljettiin uuden varauksen luontisivu käyttäjältä: ");
            /*if (!varausluotu)//MIKSEI POISTA?
            {
                PoistaTamavarausVarauksista();
            }*/
        }

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

        private void tbPostinoAsiakas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!Char.IsDigit(e.KeyChar)) && (e.KeyChar != (char)8))
                e.Handled = true;
        }

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
        private void tbEnimi_TextChanged(object sender, EventArgs e)
        {
            valittuasiakas.etunimi = tbEnimi.Text;
        }

        private void tbSnimi_TextChanged(object sender, EventArgs e)
        {
            valittuasiakas.sukunimi = tbSnimi.Text;
        }

        private void tbPostinoAsiakas_TextChanged(object sender, EventArgs e)
        {
            valittuasiakas.postinro = tbPostinoAsiakas.Text;
        }

        private void tbLahiosoiteAsiakas_TextChanged(object sender, EventArgs e)
        {
            valittuasiakas.lahiosoite = tbLahiosoiteAsiakas.Text;
        }

        private void tbPostitoimipaikkaAsiakas_TextChanged(object sender, EventArgs e)
        {
          //HAE POSTINUMERO POSTITAULUSTA?
        }

        private void tbPuhno_TextChanged(object sender, EventArgs e)
        {
            valittuasiakas.puhelinnro = tbPuhno.Text;
        }

        private void tbSahkoposti_TextChanged(object sender, EventArgs e)
        {
            valittuasiakas.email = tbSahkoposti.Text;
        }

        private void dgvAsiakkaat_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
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

        private void lbVarauksenPalvelut_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            
        }

        private void tbMinhinta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!Char.IsDigit(e.KeyChar)) && (e.KeyChar != (char)8) && (e.KeyChar != (char)46)) //Jos ei toimi: pilkku = 44
                e.Handled = true;
        }

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

        private void dgvAlueenPalvelut_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
        }

        private void dgvMokitUusiVaraus_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            valitturivimokki = dgvMokitUusiVaraus.CurrentRow.Index;
            valittumokki = mokit[valitturivimokki];
            arvioituloppuhinta = valittumokki.hinta;
            tbLoppuhinta.Text = arvioituloppuhinta.ToString();
            tbAlueid.Text = valittumokki.alue_id.ToString();
            tbMokkitunnus.Text = valittumokki.mokki_id.ToString();
            TyhjennaVarauksenPalvelut();
        }

        private void btnTyhjValinta_Click(object sender, EventArgs e)
        {
            TyhjennaAsiakas();
        }

        private void nudHlomaara_ValueChanged(object sender, EventArgs e)
        {
            if(nudHlomaara.Value < 1)
                nudHlomaara.Value = 1;
        }

        private void lbAlue_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            valitturivialue = lbAlue.SelectedIndex;
            valittualue = alueet[valitturivialue];
            tbAlueid.Text = valittualue.alue_id.ToString();
            aluevalittu = true;
        }
        public void MuodostaMokkiHakuQuery()
        {
            mokkiquery = "SELECT * FROM mokki" + MuodostaPVMHaku() + MuodostaAlueHaku() + MuodostaLKMHaku() + MuodostaHintaHaku() + ";";
        }
        public string MuodostaPVMHaku()
        {
            string pal = "";
            if(alkupvmmuutettu && loppupvmmuutettu)
            {
                pal = " WHERE mokki_id NOT IN (SELECT mokki_mokki_id FROM varaus WHERE varattu_alkupvm BETWEEN '" + alkupvm + "' AND '" + loppupvm + "' OR varattu_loppupvm BETWEEN '" + alkupvm + "' AND '" + loppupvm + "')";
            }
            return pal;
        }
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
        private void btnNollaaAika_Click(object sender, EventArgs e)
        {
            NollaaAika();
        }
        public void NollaaAika()
        {
            dtpAlkupvm.Value = nyt;
            dtmLoppupvm.Value = nyt;
            alkupvm = nyt;
            loppupvm = nyt;
            alkupvmmuutettu = false;
            loppupvmmuutettu = false;
        }
        public void NollaaAlue()
        {
            aluevalittu = false;
            tbAlueid.Text = "";
            aluequery = "SELECT nimi FROM alue;";
            PaivitaAluetaulu(aluequery);
        }
        public void NollaaPalvelut()//MIHIN TÄMÄ?
        {
            varauksenpalvelut.Clear();
            nudPalveluLkm.Value = 0;
            palveluquery = "SELECT * FROM palvelu;";
            PaivitaPalvelutaulu(palveluquery);
            //varauksenpalveluquery = "SELECT * FROM varauksen_palvelut WHERE varaus_id = " + tamavaraus.varaus_id.ToString() + ";";
            //JA poista
            PaivitaVarauksenPalvelutaulu();
        }

        private void tbMaxhinta_Leave(object sender, EventArgs e)
        {
            if(tbMaxhinta.Text.Length > 0)
            {
                if (!(Double.TryParse(tbMaxhinta.Text, out maxhinta)))
                    MessageBox.Show("Maksimihintaa ei voitu kääntää- olisiko pilkkuvirhe?");
            }
            else maxhinta = 0;
        }

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

        private void tbLoppuhinta_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

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

        private void dgvAlueenPalvelut_SelectionChanged(object sender, EventArgs e)
        {
            if (mokkilukittu)
            {
                valitturivipalvelu = dgvAlueenPalvelut.CurrentRow.Index;
                valittupalvelu = palvelut[valitturivipalvelu];
                palveluvalittu = true;
                //TyhjennaVarauksenPalvelut();
            }
        }

        private void lbVarauksenPalvelut_SelectedIndexChanged(object sender, EventArgs e)
        {
            valitturivivarauksenpalvelu = lbVarauksenPalvelut.SelectedIndex;
            varauksenpalveluvalittu = true;
        }
    }
}
