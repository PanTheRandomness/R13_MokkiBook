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
using System.Reflection;

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
                string fileName = "Lasku.pdf";

                Document document = new Document();

                FileStream fileStream = new FileStream(fileName, FileMode.Create);

                PdfWriter writer = PdfWriter.GetInstance(document, fileStream);

                document.Open();


                Bitmap image = Properties.Resources.MokkiBookLogo;
                iTextSharp.text.Image logoImage = iTextSharp.text.Image.GetInstance(Properties.Resources.MokkiBookLogo, System.Drawing.Imaging.ImageFormat.Png);

                PdfContentByte canvas = writer.DirectContent;
                logoImage.SetAbsolutePosition(470, 770);
                logoImage.ScaleAbsolute(90, 50);
                canvas.AddImage(logoImage);


                document.Add(new Paragraph("Varauksenne lasku"));
                document.Add(new Paragraph(" "));

                if (dataGridView1.SelectedRows.Count > 0)
                {
                    DataGridViewRow row = dataGridView1.SelectedRows[0];

                    // Add the transaction data to the document
                    document.Add(new Paragraph("Lasku ID: " + row.Cells["lasku_id"].Value.ToString()));
                    document.Add(new Paragraph("Varaus ID: " + row.Cells["varaus_id"].Value.ToString()));
                    document.Add(new Paragraph("Summa: " + row.Cells["summa"].Value.ToString() + " + alv"));
                    document.Add(new Paragraph("Alv: " + row.Cells["alv"].Value.ToString()));


                    PdfPTable table = new PdfPTable(4);
                    table.WidthPercentage = 100;
                     document.Add(table);
                }
                double totalSum = 0.0;
                // iterate over the rows in the DataTable
                foreach (DataRow rows in dataTable.Rows)
                {
                    // add the value of the "Summa" column to the total sum
                    totalSum += Convert.ToDouble(rows["Summa"]);

                    // convert the "Alv" value from a percentage to a decimal value and add it to the total sum
                    double alvPercentage = Convert.ToDouble(rows["alv"]);
                    double alvDecimal = alvPercentage / 100.0;
                    totalSum += (Convert.ToDouble(rows["summa"]) * alvDecimal);
                }

                // output the total sum to the PDF document
                document.Add(new Paragraph("Total sum: " + totalSum));




                connection.Close();

                document.Close();
                fileStream.Close();

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

        private void txtLaskuID_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtSumma_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }
    }
}
