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
    public partial class frmMokit : Form
    {
        public List<Mokki> mokit; 
        public frmMokit()

        {
            InitializeComponent();
            mokit = new List<Mokki>();
        }

        private void frmMokit_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.alue' table. You can move, or remove it, as needed.
            this.alueTableAdapter.Fill(this.dataSet1.alue);
            // TODO: This line of code loads data into the 'dataSet1.mokki' table. You can move, or remove it, as needed.
            this.mokkiTableAdapter.Fill(this.dataSet1.mokki);

        }

        private void btnLisaa_Click(object sender, EventArgs e)
        {
            LisaaMokki();
        }
  

        public void LisaaMokki()
        {

            if (tbMokkiId.Text == "" || tbAlueId.Text == "" || tbPostinumero.Text == "" || tbKatuosoite.Text == "" || tbHinta.Text == "" || tbKuvaus.Text == "" || tbHenkilomaara.Text == "" || tbVarustelu.Text == "")
            {
                MessageBox.Show("Täytä kaikki kentät");
            }
            else
            {
                
                Mokki m = new Mokki();

                m.mokki_id = tbMokkiId.Text;
                m.alue_id = tbAlueId.Text;
                m.postinro = tbPostinumero.Text;
                m.mokkinimi = tbMokinnimi.Text;
                m.katuosoite = tbKatuosoite.Text;
                m.hinta = tbHinta.Text;
                m.kuvaus = tbKuvaus.Text;
                m.henkilomaara = tbHenkilomaara.Text;
                m.varustelu = tbVarustelu.Text;

                mokit.Add(m);

               // Tyhjenna();
            }

        }

    }
}
