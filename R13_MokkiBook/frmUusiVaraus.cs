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

namespace R13_MokkiBook
{
    public partial class frmUusiVaraus : Form
    {
        public int valitturiviasiakas = -1;
        public int valitturivipalvelu = -1;
        public int valitturivimokki = -1;
        public int valitturivialue = -1;
        public int valitturivipostitoimipaikka = -1;
        public double arvioituloppuhinta = 0;

        public Asiakas valittuasiakas;
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
        public string asiakasquery;
        public string aluequery;
        public string mokkiquery;
        public string palveluquery;
        public string postiquery;
        public string varauksenpalveluquery;
        //HAKU TOTEUTUU SEURAAVASTI: JOKAISTA TAULUA KOHDEN OMA QUERYSTRING, JOIHIN JOKAINEN HAKUKRITEERI LISÄTÄÄN XQUERY = OSAQUERY1 + OSAQUERY2 JNE
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

            tamavaraus = new Varaus();
            tamavaraus.varaus_id = HaeSeuraavaVapaaID();
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
        public int HaeSeuraavaVapaaID()
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
        private void frmUusiVaraus_Load(object sender, EventArgs e)
        {
            
        }
        public void PaivitaAsiakastaulu(string asiakasquery)
        {

        }
        public void PaivitaAluetaulu(string aluequery)
        {

        }
        public void PaivitaMokkitaulu(string mokkiquery)
        {

        }
        public void PaivitaPalvelutaulu(string palveluquery)
        {

        }
        public void PaivitaPostitaulu(string postiquery)
        {

        }
        public void PaivitaVarauksenPalvelutaulu(string varauksenpalveluquery)
        {

        }
        private void dtmLoppupvm_ValueChanged(object sender, EventArgs e)
        {
            //Ei voi olla ennen alkupvm

        }

        private void dtpAlkupvm_ValueChanged(object sender, EventArgs e)
        {
            //ei voi olla aiemmin kuin nyt
            /*if (dtpAlku.Value > haku.varattu_loppupvm)
            {
                MessageBox.Show("Alkupäivämäärä ei voi olla loppupäivämäärän jälkeen.");
                dtpAlku.Value = nyt;
            }
            else if (dtpAlku.Value < nyt)
            {
                MessageBox.Show("Alkupäivämäärä ei voi olla nykyistä päivämäärää aiemmin.");
                dtpAlku.Value = nyt;
            }
            else
                haku.varattu_alkupvm = dtpAlku.Value;*/
        }

        private void dgvMokitUusiVaraus_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnLuoVaraus_Click(object sender, EventArgs e)
        {
            //Messagebox validointi
        }

        private void tbEnimi_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbSnimi_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbPostinoAsiakas_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbLahiosoiteAsiakas_TextChanged(object sender, EventArgs e)
        {
            //Näyttää
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
            //JOS EI TALLENNETTU--> POISTA TÄMÄ VARAUS!! VARMISTA ETTEI JÄÄ TIETOKANTAAN
        }
    }
}
