using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
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
        public List<Asiakas> asiakkaat;

        public string query;
        private OdbcConnection connection;
        private OdbcDataAdapter dataAdapter;
        private DataTable dataTable;
        public frmAsiakkaat()
        {
            InitializeComponent();
            asiakkaat = GetAsiakkaat();

        }
        private void frmAsiakkaat_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.asiakas' table. You can move, or remove it, as needed.
            this.asiakasTableAdapter.Fill(this.dataSet1.asiakas);

        }
       
        public List<Asiakas> GetAsiakkaat()
        {
            List<Asiakas> asi = new List<Asiakas>();
            string connectionString = "Dsn=Village Newbies;uid=root";
            string query = "SELECT * FROM asiakkaat";


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

                                asi.Add(a);
                            }
                        }
                    }
                }
                return asi;
            }
 

       private void btnPoista_Click(object sender, EventArgs e)
        {

            // Get the current DataRow from the DataGridView control
            DataRow currentRow = ((DataRowView)dgvAsiakkaat.CurrentRow.DataBoundItem).Row;

            // Delete the current DataRow from the DataTable and update the database
            currentRow.Delete();
            dataAdapter.Update(dataTable);

        }

    }
}
