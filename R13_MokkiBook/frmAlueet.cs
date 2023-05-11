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
            this.FormClosing += new FormClosingEventHandler(frmAlueet_FormClosing);
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

        //Lisää uusi alue. Tarkistaa että kaikki kentät on täytetty, jos ei ole tulee virheilmoitus.

        private void btnLisaa_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbAlueId.Text.Trim() == "" || tbNimi.Text.Trim() == "")
                {
                    MessageBox.Show("Täytä kaikki kentät!");
                }
                else
                {
                    DataRow newRow = dataTable.NewRow();
                    newRow["alue_id"] = tbAlueId.Text;
                    newRow["nimi"] = tbNimi.Text;

                    dataTable.Rows.Add(newRow);
                    dataAdapter.Update(dataTable);

                    tbAlueId.Text = String.Empty;
                    tbNimi.Text = String.Empty;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void frmAlueet_Load(object sender, EventArgs e)
        {
            connection = new OdbcConnection("Dsn=Village Newbies;uid=root");
            connection.Open();
            dataAdapter = new OdbcDataAdapter("SELECT * FROM alue", connection);
            dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            dgvAlue.DataSource = dataTable;
            OdbcCommandBuilder commandBuilder = new OdbcCommandBuilder(dataAdapter);
            dataAdapter.InsertCommand = commandBuilder.GetInsertCommand();
            System.Data.DataSet dataSet = new System.Data.DataSet();
            dataAdapter.Fill(dataSet1);
        }

        // Muokkaaminen, eli tallentaa muokkauksen.

        private void btnMuokkaa_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbAlueId.Text.Trim() == "" || tbNimi.Text.Trim() == "")
            {
                MessageBox.Show("Täytä kaikki kentät!");
            }
            else
            {
                DataRow currentRow = ((DataRowView)dgvAlue.CurrentRow.DataBoundItem).Row;

                currentRow["alue_id"] = tbAlueId.Text;
                currentRow["nimi"] = tbNimi.Text;


                dataAdapter.Update(dataTable);


                tbAlueId.Text = String.Empty;
                tbNimi.Text = String.Empty;

                lokiinTallentaminen("Alueet-osiosta muokattiin tietoja käyttäjältä: ");
            }
        }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
}

        // Poistaminen. Poistaa valitun rivin.

        private void btnPoista_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow currentRow = ((DataRowView)dgvAlue.CurrentRow.DataBoundItem).Row;

                currentRow.Delete();
                dataAdapter.Update(dataTable);

                tbAlueId.Text = String.Empty;
                tbNimi.Text = String.Empty;

                lokiinTallentaminen("Alueet-osiosta poistettiin tietoja käyttäjältä: ");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void dgvAlue_SelectionChanged(object sender, EventArgs e)
        {
       
        }

        // Avaa rivin tupla clickillä tekstiboxeihin.

        private void dgvAlue_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            if (dgv.CurrentRow != null)
            {
                tbAlueId.Text = dgv.CurrentRow.Cells["alue_id"].Value.ToString();
                tbNimi.Text = dgv.CurrentRow.Cells["nimi"].Value.ToString();
               
            }
        }

        // Tyhjentää kentät

        private void btnTyhjenna_Click(object sender, EventArgs e)
        {
            tbAlueId.Text = String.Empty;
            tbNimi.Text = String.Empty;
        }

        // Lokiin tallentaminen

        public void lokiinTallentaminen(string teksti)

        {
            string kayttaja = Environment.UserName;

            StreamWriter sw = new StreamWriter("Kirjautumistiedot.txt", true);
            sw.WriteLine(DateTime.Now.ToString() + " " + teksti + " " + kayttaja);
            sw.Close();
        }

        // Haku toiminto, joka hakee alue id mukaan. Jos aluetta ei löydy tekee virheilmoitukset.

        private void btnHae_Click(object sender, EventArgs e)
        {
            try
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
                                if (row.Cells["alue_id"].Value != null && row.Cells["alue_id"].Value.ToString().Equals(searchValue))
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
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        // Muuttaa nimen ensimmäisen kirjaimen isoksi. Max 40 merkkiä nimessä.

        private void tbNimi_Leave(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            string nimi = tb.Text.Trim();

            if (nimi.Length > 0)
            {
                nimi = nimi.Substring(0, 1).ToUpper() + nimi.Substring(1, nimi.Length - 1).ToLower();
                tb.Text = nimi;
            }
        }

        private void tbNimi_KeyPress(object sender, KeyPressEventArgs e)
        {
            tbNimi.MaxLength = 40;
        }

        // Alue idseen voi syöttää vain numeroita.

        private void tbAlueId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        // Sulkeminen. Kysyy haluatko varmasti sulkea.

        private void frmAlueet_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Haluatko varmasti sulkea ikkunan?", "Varmista", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

    }
}
