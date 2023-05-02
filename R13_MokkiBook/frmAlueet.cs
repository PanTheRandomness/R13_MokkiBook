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
    public partial class frmAlueet : Form
    {
        public List<Alue> alueet;
        public frmAlueet()
        {
            InitializeComponent();
            alueet = new List<Alue>();
        }

        private void btnLisaa_Click(object sender, EventArgs e)
        {
            if (tbAlueId.Text == "" || tbNimi.Text ==  "")
            {
                MessageBox.Show("Täytä kaikki kentät");
            }
            else
            {

                Alue a = new Alue();
                a.alue_id = tbAlueId.Text;
                a.nimi = tbNimi.Text;

                alueet.Add(a);

                // Tyhjenna();
            }
        }
    }
}
