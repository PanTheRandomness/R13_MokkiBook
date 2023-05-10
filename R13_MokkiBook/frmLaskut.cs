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
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Data.SqlClient;

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
        public void tsBtnTulosta_Click(object sender, EventArgs e)
        {
            try
            {
                // Define the path and file name for the generated PDF
                string fileName = "Bill.pdf";

                // Create a new PDF document
                Document document = new Document();

                // Create a new FileStream object to write the PDF to disk
                FileStream fileStream = new FileStream(fileName, FileMode.Create);

                // Create a new PdfWriter object to write to the PDF stream
                PdfWriter writer = PdfWriter.GetInstance(document, fileStream);

                // Open the document
                document.Open();

                // Add a title to the document
                document.Add(new Paragraph("Lasku"));

                // Check if any row is selected in the DataGridView
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    // Get the selected row from the DataGridView
                    DataGridViewRow row = dataGridView1.SelectedRows[0];

                    // Add the transaction data to the document
                    document.Add(new Paragraph("Lasku ID: " + row.Cells["lasku_id"].Value.ToString()));
                    document.Add(new Paragraph("Varaus ID: " + row.Cells["varaus_id"].Value.ToString()));
                    document.Add(new Paragraph("Summa: " + row.Cells["summa"].Value.ToString() + " +alv"));
                    document.Add(new Paragraph("Alv: " + row.Cells["alv"].Value.ToString()));

                    // Search for varaus_id by lasku_id
                    OdbcConnection connection = new OdbcConnection("Dsn=Village Newbies;uid=root");
                    
                    connection.Open();
                    string lasku_id = row.Cells["lasku_id"].Value.ToString();
                    OdbcCommand command1 = new OdbcCommand("SELECT varaus_id FROM lasku WHERE lasku_id = ?", connection);
                    command1.Parameters.AddWithValue("@lasku_id", lasku_id);
                    OdbcDataReader reader1 = command1.ExecuteReader();
                    if (reader1.Read())
                    {
                        string varaus_id = reader1.GetString(0);
                        document.Add(new Paragraph("Varaus ID: " + varaus_id));
                    }

                    // Add the remaining transaction data to the document
                    document.Add(new Paragraph("Summa: " + row.Cells["summa"].Value.ToString() + " +alv"));
                    document.Add(new Paragraph("Alv: " + row.Cells["alv"].Value.ToString()));

                    // Create a new PdfPTable object to hold the line items
                    PdfPTable table = new PdfPTable(4);
                    table.WidthPercentage = 100;

                    // Add the column headers to the table
                    table.AddCell(new PdfPCell(new Phrase("Lasku_id")));
                    table.AddCell(new PdfPCell(new Phrase("Varaus_id")));
                    table.AddCell(new PdfPCell(new Phrase("Summa")));
                    table.AddCell(new PdfPCell(new Phrase("alv")));

                     // Add the line items from the selected row to the table
                     table.AddCell(new PdfPCell(new Phrase(row.Cells["lasku_id"].Value.ToString())));
                     table.AddCell(new PdfPCell(new Phrase(row.Cells["varaus_id"].Value.ToString())));
                     table.AddCell(new PdfPCell(new Phrase(row.Cells["summa"].Value.ToString())));
                     table.AddCell(new PdfPCell(new Phrase(row.Cells["alv"].Value.ToString())));
                     // Add the table to the document
                     document.Add(table);
                    
                }

                //UUTTA

                // Create a new ODBC connection to the database
               

                // Create a new ODBC command to retrieve additional data
                OdbcCommand command = new OdbcCommand("SELECT * FROM asiakas", connection);

                // Open the database connection
                

                // Execute the command and retrieve the data using a data reader
                OdbcDataReader reader = command.ExecuteReader();

                // Create a new PdfPTable object to hold the additional data
                PdfPTable additionalTable = new PdfPTable(2);
                additionalTable.WidthPercentage = 100;

                // Add the column headers to the additional table

                additionalTable.AddCell(new PdfPCell(new Phrase("asiakas_id")));
                additionalTable.AddCell(new PdfPCell(new Phrase("postinro")));

                // Loop through the data reader and add the data to the additional table
                while (reader.Read())
                {
                    additionalTable.AddCell(new PdfPCell(new Phrase(reader.GetString(0))));
                    additionalTable.AddCell(new PdfPCell(new Phrase(reader.GetString(1))));
                }

                // Add the additional table to the document
                document.Add(additionalTable);

                // Close the database connection and data reader


                // Close the data reader
                reader.Close();
                connection.Close();

                document.Close();
                fileStream.Close();

                // Open the generated PDF file in the default PDF viewer
                System.Diagnostics.Process.Start(fileName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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

        private void toolStripTextBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string searchTerm = toolStripTextBox1.Text;
                DataTable table = new DataTable();
                string connectionString = "Dsn=Village Newbies;uid=root";

                if (string.IsNullOrEmpty(searchTerm))
                {
                    string sql = $"SELECT * FROM lasku";
                    using (OdbcConnection connection = new OdbcConnection(connectionString))
                    {
                        using (OdbcDataAdapter adapter = new OdbcDataAdapter(sql, connection))
                        {
                            adapter.Fill(table);
                        }
                    }
                    dataGridView1.DataSource = table;
                }
                else
                {
                    string sql = $"SELECT * FROM lasku WHERE lasku_id = '{searchTerm}'";
                    using (OdbcConnection connection = new OdbcConnection(connectionString))
                    {
                        using (OdbcDataAdapter adapter = new OdbcDataAdapter(sql, connection))
                        {
                            adapter.Fill(table);
                        }
                    }
                    dataGridView1.DataSource = table;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmLaskut_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Haluatko varmasti sulkea ikkunan?", "Varmista", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
