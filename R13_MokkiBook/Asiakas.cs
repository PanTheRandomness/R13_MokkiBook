using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R13_MokkiBook
{
    internal class Asiakas
    {
        public List<Asiakas> asiakkaat = new List<Asiakas>(); //Asiakaslista

        public int asiakas_id { get;set;}
        public char postinro { get;set;}
        public string etunimi {get;set;}
        public string sukunimi { get; set;}
        public string lahiosoite { get;set;}
        public string email { get;set;}
        public string puhelinnro { get; set; }

        //Tässä lisätään asiakkaan tiedot listaan

 /*       public void LisaaAsiakas()
        {
            Asiakas a = new Asiakas();
            a.Asiakasid = tbAsiakasid.Text;
            a.Postinro = tbPostiNro.Text;

        Tähän tulisi lisää, mutta koodi ei toimi, kun laittaa tb tai dvg -alun

            asiakkaat.Add(a);
        }

        //tässä lisätään Asiakaslista datagridview:hyn

        private void btnLisaa_Click(object sender, EventArgs e)
        {
            LisaaAsiakas();
            dgvAsiakkaat.DataSource = null;
            dgvAsiakkaat.DataSource = asiakkaat;

        }
 */
    }
 

}
