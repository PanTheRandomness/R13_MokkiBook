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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace R13_MokkiBook
{
    public partial class frmMokit : Form
    {

        public Mokki valittuMokki = new Mokki();
        public List<Mokki> mokit;

        public string query;
        private OdbcConnection connection;
        private OdbcDataAdapter dataAdapter;
        private DataTable dataTable;

        public frmMokit()
        {
            InitializeComponent();
            mokit = GetMokit();
        }


        public List<Mokki> GetMokit()
        {
            List<Mokki> mok = new List<Mokki>();
            string connectionString = "Dsn=Village Newbies;uid=root";
            string query = "SELECT * FROM mokki";

            using (OdbcConnection connection = new OdbcConnection(connectionString))
            {
                connection.Open();
                using (OdbcCommand command = new OdbcCommand(query, connection))
                {
                    using (OdbcDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Mokki m = new Mokki();
                            m.mokki_id = reader.GetInt32(0);
                            m.alue_id = reader.GetInt32(0);
                            m.postinro = reader.GetString(1);
                            m.mokkinimi = reader.GetString(1);
                            m.katuosoite = reader.GetString(1);
                            m.hinta = reader.GetDouble(3);
                            m.kuvaus = reader.GetString(1);
                            m.henkilomaara = reader.GetInt32(0);
                            m.varustelu = reader.GetString(1);

                            mok.Add(m);
                        }
                    }
                }
            }
            return mok;
        }

        private void frmMokit_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.alue' table. You can move, or remove it, as needed.
            this.alueTableAdapter.Fill(this.dataSet1.alue);
            // TODO: This line of code loads data into the 'dataSet1.mokki' table. You can move, or remove it, as needed.
            this.mokkiTableAdapter.Fill(this.dataSet1.mokki);
            connection = new OdbcConnection("Dsn=Village Newbies;uid=root");
            connection.Open();

            // Create a new ODBC data adapter and select all rows from the table
            dataAdapter = new OdbcDataAdapter("SELECT * FROM mokki", connection);

            // Create a new DataTable and fill it with the rows from the table
            dataTable = new DataTable();
            dataAdapter.Fill(dataTable);

            // Set the DataSource property of the DataGridView control to the DataTable
            dgvMokit.DataSource = dataTable;

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
            newRow["mokki_id"] = tbMokkiId.Text;
            newRow["alue_id"] = tbAlueId.Text;
            newRow["postinro"] = tbPostinumero.Text;
            newRow["mokkinimi"] = tbMokinnimi.Text;
            newRow["katuosoite"] = tbKatuosoite.Text;
            newRow["hinta"] = tbHinta.Text;
            newRow["kuvaus"] = tbKuvaus.Text;
            newRow["henkilomaara"] = tbHenkilomaara.Text;
            newRow["varustelu"] = tbVarustelu.Text;

            dataTable.Rows.Add(newRow);
            dataAdapter.Update(dataTable);

            tbMokkiId.Text = String.Empty;
            tbAlueId.Text = String.Empty;
            tbPostinumero.Text = String.Empty;
            tbMokinnimi.Text = String.Empty;
            tbKatuosoite.Text = String.Empty;
            tbHinta.Text = String.Empty;
            tbKuvaus.Text = String.Empty;
            tbHenkilomaara.Text = String.Empty;
            tbVarustelu.Text = String.Empty;

        }

    }
}
