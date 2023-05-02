using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        //public Asiakas valittuasiakas;
        //public Alue valittualue;
        //public Mokki valittumokki;
        public Palvelu valittupalvelu;
        //public Posti valittuposti;
        public VarauksenPalvelut valittuvarauksenpalvelu;
        public Varaus tamavaraus;
        public List <Palvelu> palvelut;
        public List<VarauksenPalvelut> varauksienpalvelut;
        //public LinkedList<Asiakas> asiakkaat;
        //public List<Alue> alueet;
        //public List<Mokki> mokit;
        //public List<Posti> postit;

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
            tamavaraus = new Varaus();
            //tamavaraus.varaus_id = HAE SEURAAVA VAPAA ID
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
