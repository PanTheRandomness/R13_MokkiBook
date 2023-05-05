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
using System.IO;

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
            lokiinTallentaminen("Laskut-osio avattiin käyttäjältä: ");
        }

        private void frmLaskut_Load(object sender, EventArgs e)
        {
            try
            {
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
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

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
                            lasku.lasku_id = reader.GetInt32(0);
                            lasku.varaus_id = reader.GetInt32(1);
                            lasku.summa = reader.GetInt32(2);
                            lasku.alv = reader.GetInt32(3);

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
            try
            {
                DataRow newRow = dataTable.NewRow();
                newRow["lasku_id"] = txtLaskuID.Text;
                newRow["varaus_id"] = txtVarausID.Text;
                newRow["summa"] = txtSumma.Text;
                newRow["alv"] = txtAlv.Text;

                dataTable.Rows.Add(newRow);
                dataAdapter.Update(dataTable);

                txtLaskuID.Text = String.Empty;
                txtVarausID.Text = String.Empty;
                txtSumma.Text = String.Empty;
                txtAlv.Text = String.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnPaivita_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow currentRow = ((DataRowView)dataGridView1.CurrentRow.DataBoundItem).Row;

            currentRow["lasku_id"] = txtLaskuID.Text;
            currentRow["varaus_id"] = txtVarausID.Text;
            currentRow["summa"] = txtSumma.Text;
            currentRow["alv"] = txtAlv.Text;

            dataAdapter.Update(dataTable);

            txtLaskuID.Text = String.Empty;
            txtSumma.Text = String.Empty;
            txtVarausID.Text = String.Empty;
            txtAlv.Text = String.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            lokiinTallentaminen("Laskut-osiosta muokattiin laskuja käyttäjältä: ");
        }

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
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

        private void btnTyhjenna_Click(object sender, EventArgs e)
        {
            txtLaskuID.Text = String.Empty;
            txtSumma.Text = String.Empty;
            txtVarausID.Text = String.Empty;
            txtAlv.Text = String.Empty;
        }

        public void lokiinTallentaminen(string teksti)

        {
            string kayttaja = Environment.UserName;

            StreamWriter sw = new StreamWriter("Kirjautumistiedot.txt", true);
            sw.WriteLine(DateTime.Now.ToString() + " " + teksti + " " + kayttaja);
            sw.Close();
        }
    }
}
