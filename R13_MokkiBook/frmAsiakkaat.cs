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
        public Asiakas valittuAsiakas = new Asiakas();
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
       
        public List<Asiakas> GetAsiakkaat()
        {
            List<Asiakas> asi = new List<Asiakas>();
            string connectionString = "Dsn=Village Newbies;uid=root";
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

        private void frmAsiakkaat_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.asiakas' table. You can move, or remove it, as needed.
            this.asiakasTableAdapter.Fill(this.dataSet1.asiakas);
            connection = new OdbcConnection("Dsn=Village Newbies;uid=root");
            connection.Open();

            // Create a new ODBC data adapter and select all rows from the table
            dataAdapter = new OdbcDataAdapter("SELECT * FROM asiakas", connection);

            // Create a new DataTable and fill it with the rows from the table
            dataTable = new DataTable();
            dataAdapter.Fill(dataTable);

            // Set the DataSource property of the DataGridView control to the DataTable
            dgvAsiakkaat.DataSource = dataTable;

            // Create an OdbcCommandBuilder object to automatically generate insert, update, and delete commands
            OdbcCommandBuilder commandBuilder = new OdbcCommandBuilder(dataAdapter);

            // Set the InsertCommand property of the dataAdapter to the generated insert command
            dataAdapter.InsertCommand = commandBuilder.GetInsertCommand();

            // Create a new DataSet object to hold the data retrieved from the database
            System.Data.DataSet dataSet = new System.Data.DataSet();

            // Fill the DataSet with data from the database
            dataAdapter.Fill(dataSet1);
        }
        

        private void btnLisaa_Click(object sender, EventArgs e)
        {

            DataRow newRow = dataTable.NewRow();
            newRow["asiakas_id"] = tbAsiakasid.Text;
            newRow["postinro"] = tbPostiNro.Text;
            newRow["etunimi"] = tbEtunimi.Text;
            newRow["sukunimi"] = tbSukunimi.Text;
            newRow["lahiosoite"] = tbLahiosoite.Text;
            newRow["email"] = tbEmail.Text;
            newRow["puhelinnro"] = tbPuhelinnro.Text;
            

            dataTable.Rows.Add(newRow);
            dataAdapter.Update(dataTable);

            tbAsiakasid.Text = String.Empty;
            tbPostiNro.Text = String.Empty;
            tbEtunimi.Text = String.Empty;
            tbSukunimi.Text = String.Empty;
            tbLahiosoite.Text = String.Empty;
            tbEmail.Text = String.Empty;
            tbPuhelinnro.Text = String.Empty;

        }

        private void btnMuokkaa_Click(object sender, EventArgs e)
        {
            // Get the current DataRow from the DataGridView control
            DataRow currentRow = ((DataRowView)dgvAsiakkaat.CurrentRow.DataBoundItem).Row;

            // Update the values of the current DataRow with the input from the TextBox controls
            currentRow["asiakas_id"] = tbAsiakasid.Text;
            currentRow["postinro"] = tbPostiNro.Text;
            currentRow["etunimi"] = tbEtunimi.Text;
            currentRow["sukunimi"] = tbSukunimi.Text;
            currentRow["lahiosoite"] = tbLahiosoite.Text;
            currentRow["email"] = tbEmail.Text;
            currentRow["puhelinnro"] = tbPuhelinnro.Text;

            // Update the database
            dataAdapter.Update(dataTable);

            tbAsiakasid.Text = String.Empty;
            tbPostiNro.Text = String.Empty;
            tbEtunimi.Text = String.Empty;
            tbSukunimi.Text = String.Empty;
            tbLahiosoite.Text = String.Empty;
            tbEmail.Text = String.Empty;
            tbPuhelinnro.Text = String.Empty;
        }

        private void btnPoista_Click(object sender, EventArgs e)
        {

            // Get the current DataRow from the DataGridView control
            DataRow currentRow = ((DataRowView)dgvAsiakkaat.CurrentRow.DataBoundItem).Row;

            // Delete the current DataRow from the DataTable and update the database
            currentRow.Delete();
            dataAdapter.Update(dataTable);
            tbAsiakasid.Text = String.Empty;
            tbPostiNro.Text = String.Empty;
            tbEtunimi.Text = String.Empty;
            tbSukunimi.Text = String.Empty;
            tbLahiosoite.Text = String.Empty;
            tbEmail.Text = String.Empty;
            tbPuhelinnro.Text = String.Empty;

        }

    }
}
