using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.Odbc;
using System.Drawing;
using System.IO;
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
        public List<Posti> postit;
        public Asiakas luotuasiakas;

        public string query;
        private OdbcConnection connection;
        private OdbcDataAdapter dataAdapter;
        private DataTable dataTable;


        public frmAsiakkaat()
        {
            InitializeComponent();
            asiakkaat = GetAsiakkaat();
            postit = GetPostit();
            luotuasiakas = new Asiakas();
            lokiinTallentaminen("Asiakkaat-osio avattiin käyttäjältä: ");
            this.FormClosing += new FormClosingEventHandler(frmAsiakkaat_FormClosing);
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
                            a.etunimi = reader.GetString(2);
                            a.sukunimi = reader.GetString(3);
                            a.lahiosoite = reader.GetString(4);
                            a.email = reader.GetString(5);
                            a.puhelinnro = reader.GetString(6);

                            asi.Add(a);
                        }
                    }
                }
            }
            return asi;
        }


        private void frmAsiakkaat_Load(object sender, EventArgs e)
        {
            try
            {

                this.asiakasTableAdapter.Fill(this.dataSet1.asiakas);
                connection = new OdbcConnection("Dsn=Village Newbies;uid=root");
                connection.Open();
                dataAdapter = new OdbcDataAdapter("SELECT * FROM asiakas", connection);
                dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                dgvAsiakkaat.DataSource = dataTable;
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

        //Lisää uusi asiakas. Tarkistaa että kaikki kentät on täytetty, jos ei ole tulee virheilmoitus.
        private void btnLisaa_Click(object sender, EventArgs e)
        {

            luotuasiakas.asiakas_id = int.Parse(tbAsiakasid.Text);
            luotuasiakas.postinro = tbPostiNro.Text;
            luotuasiakas.etunimi = tbEtunimi.Text;
            luotuasiakas.sukunimi = tbSukunimi.Text;
            luotuasiakas.lahiosoite = tbLahiosoite.Text;
            luotuasiakas.email = tbEmail.Text;
            luotuasiakas.puhelinnro = tbPuhelinnro.Text;


            try
            {

                string connectionString = "Dns=Village Newbies;uib=root";
                if (!PostiLoytyi(luotuasiakas.postinro))
                    LuoPosti(luotuasiakas.postinro, tbPostitoimipaikka.Text);
                using (OdbcConnection connection = new OdbcConnection(connectionString))
                {
                    connection.Open();
                    string lisaysquery = "INSERT INTO asiakas(asiakas_id, postinro, etunimi, sukunimi, lahiosoite, email, puhelinnro) VALUES(" + luotuasiakas.asiakas_id + ", '" + luotuasiakas.postinro + "', '" + luotuasiakas.etunimi + "', '" + luotuasiakas.sukunimi + "', '" + luotuasiakas.lahiosoite + "', '" + luotuasiakas.email + "', '" + luotuasiakas.puhelinnro + "');";
                    using (OdbcCommand cmd = new OdbcCommand(lisaysquery, connection))
                    {
                        cmd.ExecuteNonQuery();
                    }


                    if (tbAsiakasid.Text.Trim() == "" || tbPostiNro.Text.Trim() == "" || tbEtunimi.Text.Trim() == "" ||
                    tbSukunimi.Text.Trim() == "" || tbLahiosoite.Text.Trim() == "" || tbEmail.Text.Trim() == "" ||
                    tbPuhelinnro.Text.Trim() == "")

                    {
                        MessageBox.Show("Täytä kaikki kentät!");
                    }

                    else
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
                }
            
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        public void LuoPosti(string pnro, string ptp)
        {
            string connectionString = "Dsn=Village Newbies;uid=root";
            using (OdbcConnection connection = new OdbcConnection(connectionString))
            {
                connection.Open();
                string lisaysquery = "INSERT INTO posti(postinro, toimipaikka) VALUES(" + pnro + ", '" + ptp + "');";
                using (OdbcCommand cmd = new OdbcCommand(lisaysquery, connection))
                {
                    cmd.ExecuteNonQuery();
                }

            }
            postit = GetPostit();
        }

        public List<Posti> GetPostit()
        {
            List<Posti> po = new List<Posti>();
            string connectionString = "Dsn=Village Newbies;uid=root";
            string query = "SELECT * FROM posti;";

            using (OdbcConnection connection = new OdbcConnection(connectionString))
            {
                connection.Open();
                using (OdbcCommand command = new OdbcCommand(query, connection))
                {
                    using (OdbcDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Posti p = new Posti();
                            p.postinro = reader.GetString(0);
                            p.toimipaikka = reader.GetString(1);
                            po.Add(p);
                        }
                    }
                }
            }
            return po;
        }
        public bool PostiLoytyi(string pn)
        {
            foreach (Posti p in postit)
            {
                if (p.postinro == pn)
                    return true;
            }
            return false;
        }

        //Tietojen muokkaaminen
        private void btnMuokkaa_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow currentRow = ((DataRowView)dgvAsiakkaat.CurrentRow.DataBoundItem).Row;

                currentRow["asiakas_id"] = tbAsiakasid.Text;
                currentRow["postinro"] = tbPostiNro.Text;
                currentRow["etunimi"] = tbEtunimi.Text;
                currentRow["sukunimi"] = tbSukunimi.Text;
                currentRow["lahiosoite"] = tbLahiosoite.Text;
                currentRow["email"] = tbEmail.Text;
                currentRow["puhelinnro"] = tbPuhelinnro.Text;

                dataAdapter.Update(dataTable);

                tbAsiakasid.Text = String.Empty;
                tbPostiNro.Text = String.Empty;
                tbEtunimi.Text = String.Empty;
                tbSukunimi.Text = String.Empty;
                tbLahiosoite.Text = String.Empty;
                tbEmail.Text = String.Empty;
                tbPuhelinnro.Text = String.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            lokiinTallentaminen("Asiakkaat-osiosta muokattiin tietoja käyttäjältä: ");

        }

        //Tietojen poistaminen. Poistaa valitun rivin.
        private void btnPoista_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow currentRow = ((DataRowView)dgvAsiakkaat.CurrentRow.DataBoundItem).Row;

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
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            lokiinTallentaminen("Asiakas-osiosta poistettiin tietoja käyttäjältä: ");
        }

        // Avaa rivin tuplaklikillä tekstiboxeihin.
        private void dgvAsiakkaat_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            if (dgv.CurrentRow != null)
            {
                tbAsiakasid.Text = dgv.CurrentRow.Cells["asiakas_id"].Value.ToString();
                tbPostiNro.Text = dgv.CurrentRow.Cells["postinro"].Value.ToString();
                tbEtunimi.Text = dgv.CurrentRow.Cells["etunimi"].Value.ToString();
                tbSukunimi.Text = dgv.CurrentRow.Cells["sukunimi"].Value.ToString();
                tbLahiosoite.Text = dgv.CurrentRow.Cells["lahiosoite"].Value.ToString();
                tbEmail.Text = dgv.CurrentRow.Cells["email"].Value.ToString();
                tbPuhelinnro.Text = dgv.CurrentRow.Cells["puhelinnro"].Value.ToString();
            }

        }

        // Tyhjentää kentät
        private void btnTyhjenna_Click(object sender, EventArgs e)
        {
            try
            {
                tbAsiakasid.Text = String.Empty;
                tbPostiNro.Text = String.Empty;
                tbEtunimi.Text = String.Empty;
                tbSukunimi.Text = String.Empty;
                tbLahiosoite.Text = String.Empty;
                tbEmail.Text = String.Empty;
                tbPuhelinnro.Text = String.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        //Nimen eka kirjain korjataan isoksi
        private void tbEtunimi_Leave(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            string nimi = tb.Text.Trim();

            if (nimi.Length > 0)
            {
                nimi = nimi.Substring(0, 1).ToUpper() + nimi.Substring(1, nimi.Length - 1).ToLower();
                tb.Text = nimi;
            }

        }
        //Etunimi voi olla max 20 merkkiä
        private void tbEtunimi_KeyPress(object sender, KeyPressEventArgs e)
        {
            tbEtunimi.MaxLength = 20;
        }

        //Sukunimi voi olla max 40 merkkiä
        private void tbSukunimi_KeyPress(object sender, KeyPressEventArgs e)
        {
            tbSukunimi.MaxLength = 40;
        }

        //Osoitteen eka kirjain korjataan isoksi
        private void tbLahiosoite_Leave(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            string nimi = tb.Text.Trim();

            if (nimi.Length > 0)
            {
                nimi = nimi.Substring(0, 1).ToUpper() + nimi.Substring(1, nimi.Length - 1).ToLower();
                tb.Text = nimi;
            }

        }
        //Osoitteessa voi olla max 40 merkkiä
        private void tbLahiosoite_KeyPress(object sender, KeyPressEventArgs e)
        {
            tbLahiosoite.MaxLength = 40;
        }
        //Emailissa voi olla max 50 merkkiä
        private void tbEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            tbEmail.MaxLength = 50;
        }
        //Puhelinnumerossa voi olla max 15 merkkiä
        private void tbPuhelinnro_KeyPress(object sender, KeyPressEventArgs e)
        {
            tbPuhelinnro.MaxLength = 15;
        }

        //Lokiin tallentaminen

        public void lokiinTallentaminen(string teksti)

        {
            string kayttaja = Environment.UserName;

            StreamWriter sw = new StreamWriter("Kirjautumistiedot.txt", true);
            sw.WriteLine(DateTime.Now.ToString() + " " + teksti + " " + kayttaja);
            sw.Close();
        }

        //postinumeroksi voi syöttää vain lukuja ja maksimipituus 5 merkkiä:
        private void tbPostiNro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
            tbPostiNro.MaxLength = 5;
        }

        //Asiakas-id voi olla vain numero

        private void tbAsiakasid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }

        }

        // Hakutoiminto, joka hakee asiakas-id:n mukaan. Jos asiakasta ei löydy, tekee virheilmoitukset.
        private void btnHae_Click(object sender, EventArgs e)
        {
            string searchValue = tbHae.Text.Trim();
            if (dgvAsiakkaat != null)
            {
                dgvAsiakkaat.ClearSelection();
                if (!string.IsNullOrEmpty(searchValue))
                {
                    if (int.TryParse(searchValue, out int id))
                    {
                        foreach (DataGridViewRow row in dgvAsiakkaat.Rows)
                        {
                            if (row.Cells["asiakas_id"].Value != null && row.Cells["asiakas_id"].Value.ToString().Equals(searchValue))
                            {
                                dgvAsiakkaat.CurrentCell = row.Cells["asiakas_id"];
                                row.Selected = true;
                                break;
                            }
                        }
                        if (!dgvAsiakkaat.SelectedRows.Count.Equals(1))
                        {
                            MessageBox.Show("Asiakasta ei löytynyt");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Hae Asiakas_id numerolla");
                    }
                }
                else
                {
                    MessageBox.Show("Haku ei voi olla tyhjä");
                }
            }
        }

        // Sulkeminen. Kysyy haluatko varmasti sulkea.

        private void frmAsiakkaat_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Haluatko varmasti sulkea ikkunan?", "Varmista", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }


    }
}
