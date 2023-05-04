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
        private OdbcConnection connection;
        private OdbcDataAdapter dataAdapter;
        private DataTable dataTable;
        public frmUusiPalvelu()
        {
            InitializeComponent();
            palvelut = GetPalvelut();
        }

        public void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Create a new DataRow and set its values to the input from the TextBox controls
                DataRow newRow = dataTable.NewRow();
                newRow["palvelu_id"] = txtPalveluID.Text;
                newRow["alue_id"] = txtAlueID.Text;
                newRow["nimi"] = txtNimi.Text;
                newRow["tyyppi"] = txtTyyppi.Text;
                newRow["kuvaus"] = txtKuvaus.Text;
                newRow["hinta"] = txtHinta.Text;
                newRow["alv"] = txtAlv.Text;

                // Add the new row to the DataTable and update the database
                dataTable.Rows.Add(newRow);
                dataAdapter.Update(dataTable);

                txtPalveluID.Text = String.Empty;
                txtAlueID.Text = String.Empty;
                txtNimi.Text = String.Empty;
                txtTyyppi.Text = String.Empty;
                txtKuvaus.Text = String.Empty;
                txtHinta.Text = String.Empty;
                txtAlv.Text = String.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void frmUusiPalvelu_Load(object sender, EventArgs e)
        {
            try
            {
                this.palveluTableAdapter1.Fill(this.dataSet1.palvelu);

                // Create a new ODBC connection and open it
                connection = new OdbcConnection("Dsn=Village Newbies;uid=root");
                connection.Open();

                // Create a new ODBC data adapter and select all rows from the table
                dataAdapter = new OdbcDataAdapter("SELECT * FROM palvelu", connection);

                // Create a new DataTable and fill it with the rows from the table
                dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                // Set the DataSource property of the DataGridView control to the DataTable
                dataGridView1.DataSource = dataTable;

                // Create an OdbcCommandBuilder object to automatically generate insert, update, and delete commands
                OdbcCommandBuilder commandBuilder = new OdbcCommandBuilder(dataAdapter);

                // Set the InsertCommand property of the dataAdapter to the generated insert command
                dataAdapter.InsertCommand = commandBuilder.GetInsertCommand();

                // Create a new DataSet object to hold the data retrieved from the database
                System.Data.DataSet dataSet = new System.Data.DataSet();

                // Fill the DataSet with data from the database
                dataAdapter.Fill(dataSet1);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

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

        private void btnPaivita_Click(object sender, EventArgs e)
        {
            try
            {
                // Get the current DataRow from the DataGridView control
                DataRow currentRow = ((DataRowView)dataGridView1.CurrentRow.DataBoundItem).Row;

                // Update the values of the current DataRow with the input from the TextBox controls
                currentRow["palvelu_id"] = txtPalveluID.Text;
                currentRow["alue_id"] = txtAlueID.Text;
                currentRow["nimi"] = txtNimi.Text;
                currentRow["tyyppi"] = txtTyyppi.Text;
                currentRow["kuvaus"] = txtKuvaus.Text;
                currentRow["hinta"] = txtHinta.Text;
                currentRow["alv"] = txtAlv.Text;

                // Update the database
                dataAdapter.Update(dataTable);

                txtPalveluID.Text = String.Empty;
                txtAlueID.Text = String.Empty;
                txtNimi.Text = String.Empty;
                txtTyyppi.Text = String.Empty;
                txtKuvaus.Text = String.Empty;
                txtHinta.Text = String.Empty;
                txtAlv.Text = String.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        } 
        private void fillBy2ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.palveluTableAdapter1.FillBy2(this.dataSet1.palvelu);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void btnPoista_Click(object sender, EventArgs e)
        {
            // Get the current DataRow from the DataGridView control
            DataRow currentRow = ((DataRowView)dataGridView1.CurrentRow.DataBoundItem).Row;

            // Delete the current DataRow from the DataTable and update the database
            currentRow.Delete();
            dataAdapter.Update(dataTable);
            txtPalveluID.Text = String.Empty;
            txtAlueID.Text = String.Empty;
            txtNimi.Text = String.Empty;
            txtTyyppi.Text = String.Empty;
            txtKuvaus.Text = String.Empty;
            txtHinta.Text = String.Empty;
            txtAlv.Text = String.Empty;
        }

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            if (dgv.CurrentRow != null)
            {
                txtPalveluID.Text = dgv.CurrentRow.Cells["palvelu_id"].Value.ToString();
                txtAlueID.Text = dgv.CurrentRow.Cells["alue_id"].Value.ToString();
                txtNimi.Text = dgv.CurrentRow.Cells["nimi"].Value.ToString();
                txtTyyppi.Text = dgv.CurrentRow.Cells["tyyppi"].Value.ToString();
                txtKuvaus.Text = dgv.CurrentRow.Cells["kuvaus"].Value.ToString();
                txtHinta.Text = dgv.CurrentRow.Cells["hinta"].Value.ToString();
                txtAlv.Text = dgv.CurrentRow.Cells["alv"].Value.ToString();
            }
        }

        private void btnTyhjenna_Click(object sender, EventArgs e) //tyhjennetään rivit
        {
                txtPalveluID.Text = String.Empty;
                txtAlueID.Text = String.Empty;
                txtNimi.Text = String.Empty;
                txtTyyppi.Text = String.Empty;
                txtKuvaus.Text = String.Empty;
                txtHinta.Text = String.Empty;
                txtAlv.Text = String.Empty;

        }
    }
}
