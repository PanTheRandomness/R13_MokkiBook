using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.Odbc;

namespace R13_MokkiBook
{
    public partial class frmPalvelut : Form
    {
        public Palvelu valittupalvelu = new Palvelu();
        public List<Palvelu> palvelut;
        public string query;

        public frmPalvelut()
        {
            InitializeComponent();
            palvelut = GetPalvelut();
        }



        private void frmPalvelut_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.palvelu' table. You can move, or remove it, as needed.
           this.palveluTableAdapter.Fill(this.dataSet1.palvelu);
        }

        private void label1_Click(object sender, EventArgs e) //otsikko
        {

        }
    
        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
         

        }

    
        public List<Palvelu> GetPalvelut()
        {
            List<Palvelu> pal = new List<Palvelu>();
            string connectionString = "Dsn=Village Newbies;uid=root"; 
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
                            Palvelu palvelu = new Palvelu();
                            palvelu.palvelu_id = reader.GetInt32(0);
                            palvelu.nimi = reader.GetString(1);
                            palvelu.tyyppi = reader.GetInt32(2);
                            palvelu.kuvaus = reader.GetString(3);
                            palvelu.hinta = reader.GetInt32(4);
                            palvelu.alv = reader.GetInt32(5);

                            pal.Add(palvelu);
                        }
                    }
                }
            }

            return pal;
        }


        private void TsBtnLisaa_Click_1(object sender, EventArgs e)
        {
            frmUusiPalvelu up = new frmUusiPalvelu();
            up.ShowDialog();
        }

        private void tsTallenna_Click(object sender, EventArgs e)
        {
         
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
