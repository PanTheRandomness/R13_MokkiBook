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
        private OdbcConnection connection;
        private OdbcDataAdapter dataAdapter;
        private DataTable dataTable;
        public frmLaskut()
        {
            InitializeComponent();
            laskut = GetLaskut();
        }

        private void frmLaskut_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.lasku' table. You can move, or remove it, as needed.
            this.laskuTableAdapter.Fill(this.dataSet1.lasku);
            connection = new OdbcConnection("Dsn=Village Newbies;uid=root");
            connection.Open();
            dataAdapter = new OdbcDataAdapter("SELECT * FROM lasku", connection);
            dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            OdbcCommandBuilder commandBuilder = new OdbcCommandBuilder(dataAdapter);
            dataAdapter.InsertCommand = commandBuilder.GetInsertCommand();
            System.Data.DataSet dataSet = new System.Data.DataSet();
            dataAdapter.Fill(dataSet1);

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

        private void btnLisaa_Click(object sender, EventArgs e)
        {

        }

        private void btnPaivita_Click(object sender, EventArgs e)
        {
            // Get the current DataRow from the DataGridView control
            DataRow currentRow = ((DataRowView)dataGridView1.CurrentRow.DataBoundItem).Row;

            // Update the values of the current DataRow with the input from the TextBox controls
            currentRow["lasku_id"] = txtLaskuID.Text;
            currentRow["varaus_id"] = txtVarausID.Text;
            currentRow["summa"] = txtSumma.Text;
            currentRow["alv"] = txtAlv.Text;

            // Update the database
            dataAdapter.Update(dataTable);

           /* txtLaskuID.Text = String.Empty;
            txtVarausID.Text = String.Empty;
            txtSumma.Text = String.Empty;
            txtAlv.Text = String.Empty; */
        }
        private void dataGridView1_SelectionChanged_1(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            if (dgv.CurrentRow != null)
            {
                txtLaskuID.Text = dgv.CurrentRow.Cells["lasku_id"].Value.ToString();
                txtVarausID.Text = dgv.CurrentRow.Cells["varaus_id"].Value.ToString();
                txtSumma.Text = dgv.CurrentRow.Cells["summa"].Value.ToString();
                txtAlv.Text = dgv.CurrentRow.Cells["alv"].Value.ToString();
            }
        }
    }
}
