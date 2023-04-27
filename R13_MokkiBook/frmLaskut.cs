using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.Odbc;
using System.Drawing.Printing;

namespace R13_MokkiBook
{
    public partial class frmLaskut : Form
    {
        public Lasku valittulasku = new Lasku();
        public List<Lasku> laskut;
        public string query;
        public frmLaskut()
        {
            InitializeComponent();
            laskut = GetLaskut();
        }

        private void frmLaskut_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.lasku' table. You can move, or remove it, as needed.
            this.laskuTableAdapter.Fill(this.dataSet1.lasku);
        }
        public List<Lasku> GetLaskut()
        {
            List<Lasku> las = new List<Lasku>();
            string connectionString = "Dsn=Village Newbies;uid=root";
            string query = "SELECT * FROM lasku";

            using (OdbcConnection connection = new OdbcConnection(connectionString))
            {
                connection.Open();
                using (OdbcCommand command = new OdbcCommand(query, connection))
                {
                    using (OdbcDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Lasku lasku = new Lasku();
                            lasku.lasku_id = reader.GetInt32(1);
                            lasku.varaus_id = reader.GetInt32(1);
                            lasku.summa = reader.GetInt32(0);
                            lasku.alv = reader.GetInt32(0);

                            las.Add(lasku);
                        }
                    }
                }
            }

            return las;
        }

        private void tsBtnTulosta_Click(object sender, EventArgs e)
        {
          
        }
       }
}
