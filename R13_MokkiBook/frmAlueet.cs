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
    public partial class frmAlueet : Form
    {
        public Alue valittuAlue = new Alue();
        public List<Alue> alueet;

        public string query;
        private OdbcConnection connection;
        private OdbcDataAdapter dataAdapter;
        private DataTable dataTable;
        public frmAlueet()
        {
            InitializeComponent();
            alueet = GetAlueet();
        }

        public List<Alue> GetAlueet()
        {
            List<Alue> al = new List<Alue>();
            string connectionString = "Dsn=Village Newbies;uid=root";
            string query = "SELECT * FROM alue";

            using (OdbcConnection connection = new OdbcConnection(connectionString))
            {
                connection.Open();
                using (OdbcCommand command = new OdbcCommand(query, connection))
                {
                    using (OdbcDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Alue a = new Alue ();
                            a.alue_id = reader.GetInt32(0);
                            a.nimi = reader.GetString(1);

                            al.Add(a);
                        }
                    }
                }
            }
            return al;
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

                a.alue_id = int.Parse(tbAlueId.Text);
                a.nimi = tbNimi.Text;

                alueet.Add(a);
                dgvAlue.DataSource = null;
                dgvAlue.DataSource = alueet;

                // Tyhjenna();

            }

        }

        private void frmAlueet_Load(object sender, EventArgs e)
        {
            connection = new OdbcConnection("Dsn=Village Newbies;uid=root");
            connection.Open();

            // Create a new ODBC data adapter and select all rows from the table
            dataAdapter = new OdbcDataAdapter("SELECT * FROM alue", connection);

            // Create a new DataTable and fill it with the rows from the table
            dataTable = new DataTable();
            dataAdapter.Fill(dataTable);

            // Set the DataSource property of the DataGridView control to the DataTable
            dgvAlue.DataSource = dataTable;

            // Create an OdbcCommandBuilder object to automatically generate insert, update, and delete commands
            OdbcCommandBuilder commandBuilder = new OdbcCommandBuilder(dataAdapter);

            // Set the InsertCommand property of the dataAdapter to the generated insert command
            dataAdapter.InsertCommand = commandBuilder.GetInsertCommand();

            // Create a new DataSet object to hold the data retrieved from the database
            System.Data.DataSet dataSet = new System.Data.DataSet();

            // Fill the DataSet with data from the database
            dataAdapter.Fill(dataSet1);
        }
    }
}
