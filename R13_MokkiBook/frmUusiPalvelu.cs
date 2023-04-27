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
    public partial class frmUusiPalvelu : Form
    {
        public Palvelu valittupalvelu = new Palvelu();
        public List<Palvelu> palvelut;
        public string query;
        public frmUusiPalvelu()
        {
            InitializeComponent();
            palvelut = GetPalvelut();
        }



        public void saveButton_Click(object sender, EventArgs e)
        {
     
        }

        private void frmUusiPalvelu_Load(object sender, EventArgs e)
        {
            this.palveluTableAdapter1.Fill(this.dataSet1.palvelu);
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
                            palvelu.tyyppi = reader.GetString(1);
                            palvelu.kuvaus = reader.GetString(1);
                            palvelu.hinta = reader.GetInt32(0);
                            palvelu.alv = reader.GetInt32(0);

                            pal.Add(palvelu);
                        }
                    }
                }
            }

            return pal;
        }
    }
}
