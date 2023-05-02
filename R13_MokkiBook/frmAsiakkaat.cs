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
    public partial class frmAsiakkaat : Form
    {
        public frmAsiakkaat()
        {
            InitializeComponent();
           
        }
        private void frmAsiakkaat_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.asiakas' table. You can move, or remove it, as needed.
            this.asiakasTableAdapter.Fill(this.dataSet1.asiakas);

        }
      
        public List<Asiakas> asiakkaat = new List<Asiakas>();
        public void LisaaAsiakas()
        {
            string connectionString = "Dsn=Village Newbies;uid=root";
            string query = "SELECT * FROM asiakkaat";

            try
            {

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
                                a.etunimi = reader.GetString(1);
                                a.sukunimi = reader.GetString(1);
                                a.lahiosoite = reader.GetString(1);
                                a.email = reader.GetString(1);
                                a.puhelinnro = reader.GetString(1);

                                asiakkaat.Add(a);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred. Please try again later.");
            }
        }

       private void btnPoista_Click(object sender, EventArgs e)
        {

            int rowindex = dgvAsiakkaat.CurrentRow.Index;

            asiakkaat.RemoveAt(rowindex);

            dgvAsiakkaat.DataSource = null;
            dgvAsiakkaat.DataSource = asiakkaat;

        }

    }
}
