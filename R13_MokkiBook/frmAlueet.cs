using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.IO;
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
            lokiinTallentaminen("Alueet-osio avattiin käyttäjältä: ");
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
            DataRow newRow = dataTable.NewRow();
            newRow["alue_id"] = tbAlueId.Text;
            newRow["nimi"] = tbNimi.Text;

            dataTable.Rows.Add(newRow);
            dataAdapter.Update(dataTable);

            tbAlueId.Text = String.Empty;
            tbNimi.Text = String.Empty;
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

        private void btnMuokkaa_Click(object sender, EventArgs e)
        {
            DataRow currentRow = ((DataRowView)dgvAlue.CurrentRow.DataBoundItem).Row;

            currentRow["alue_id"] = tbAlueId.Text;
            currentRow["nimi"] = tbNimi.Text;


            dataAdapter.Update(dataTable);


            tbAlueId.Text = String.Empty;
            tbNimi.Text = String.Empty;

            lokiinTallentaminen("Alueet-osiosta muokattiin tietoja käyttäjältä: ");
        }

        private void btnPoista_Click(object sender, EventArgs e)
        {
            DataRow currentRow = ((DataRowView)dgvAlue.CurrentRow.DataBoundItem).Row;

            currentRow.Delete();
            dataAdapter.Update(dataTable);

            tbAlueId.Text = String.Empty;
            tbNimi.Text = String.Empty;

            lokiinTallentaminen("Alueet-osiosta poistettiin tietoja käyttäjältä: ");
        }

        private void dgvAlue_SelectionChanged(object sender, EventArgs e)
        {
       
        }

        private void dgvAlue_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            if (dgv.CurrentRow != null)
            {
                tbAlueId.Text = dgv.CurrentRow.Cells["alue_id"].Value.ToString();
                tbNimi.Text = dgv.CurrentRow.Cells["nimi"].Value.ToString();
               
            }
        }

        private void btnTyhjenna_Click(object sender, EventArgs e)
        {
            tbAlueId.Text = String.Empty;
            tbNimi.Text = String.Empty;
        }

        /* Lokiin tallentaminen */

        public void lokiinTallentaminen(string teksti)

        {
            string kayttaja = Environment.UserName;

            StreamWriter sw = new StreamWriter("lokitiedot.txt", true);
            sw.WriteLine(DateTime.Now.ToString() + " " + teksti + " " + kayttaja);
            sw.Close();
        }

        private void btnHae_Click(object sender, EventArgs e)
        {
            string searchValue = tbHae.Text.Trim();
            if (dgvAlue != null)
            {
                dgvAlue.ClearSelection();
                if (!string.IsNullOrEmpty(searchValue))
                {
                    if (int.TryParse(searchValue, out int id))
                    {
                        foreach (DataGridViewRow row in dgvAlue.Rows)
                        {
                            if (row.Cells["alue_id"].Value != null && row.Cells["mokki_id"].Value.ToString().Equals(searchValue))
                            {
                                dgvAlue.CurrentCell = row.Cells["alue_id"];
                                row.Selected = true;
                                break;
                            }
                        }
                        if (!dgvAlue.SelectedRows.Count.Equals(1))
                        {
                            MessageBox.Show("Aluetta ei löytynyt");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Hae Alue_id numerolla");
                    }
                }
                else
                {
                    MessageBox.Show("Haku ei voi olla tyhjä");
                }
            }
        }
    }
    }
}
