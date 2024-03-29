﻿using System;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using TextBox = System.Windows.Forms.TextBox;

namespace R13_MokkiBook
{
    public partial class frmMokit : Form
    {

        public Mokki valittuMokki = new Mokki();
        public List<Mokki> mokit;
        public List<Posti> postit;
        public Mokki luotumokki;

        public string query;
        private OdbcConnection connection;
        private OdbcDataAdapter dataAdapter;
        private DataTable dataTable;

        public frmMokit()
        {
            InitializeComponent();
            mokit = GetMokit();
            postit = GetPostit();
            luotumokki = new Mokki();
            lokiinTallentaminen("Mökit-osio avattiin käyttäjältä: ");
            this.FormClosing += new FormClosingEventHandler(frmMokit_FormClosing);
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
                            m.alue_id = reader.GetInt32(1);
                            m.postinro = reader.GetString(2);
                            m.mokkinimi = reader.GetString(3);
                            m.katuosoite = reader.GetString(4);
                            m.hinta = reader.GetDouble(5);
                            m.kuvaus = reader.GetString(6);
                            m.henkilomaara = reader.GetInt32(7);
                            m.varustelu = reader.GetString(8);

                            mok.Add(m);
                        }
                    }
                }
            }
            return mok;
        }

        private void frmMokit_Load(object sender, EventArgs e)
        {
            this.alueTableAdapter.Fill(this.dataSet1.alue);
            this.mokkiTableAdapter.Fill(this.dataSet1.mokki);
            connection = new OdbcConnection("Dsn=Village Newbies;uid=root");
            connection.Open();
            dataAdapter = new OdbcDataAdapter("SELECT * FROM mokki", connection);
            dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            dgvMokit.DataSource = dataTable;
            OdbcCommandBuilder commandBuilder = new OdbcCommandBuilder(dataAdapter);
            dataAdapter.InsertCommand = commandBuilder.GetInsertCommand();
            System.Data.DataSet dataSet = new System.Data.DataSet();
            dataAdapter.Fill(dataSet1);

        }

        //Lisää uusi mökki. Tarkistaa että kaikki kentät on täytetty, jos ei ole tulee virheilmoitus.

        private void btnLisaa_Click(object sender, EventArgs e)
        {
            luotumokki.mokki_id = int.Parse(tbMokkiId.Text);
            luotumokki.alue_id = int.Parse(tbAlueId.Text);
            luotumokki.postinro = tbPostinumero.Text;
            luotumokki.mokkinimi = tbMokinnimi.Text;
            luotumokki.katuosoite = tbKatuosoite.Text;
            luotumokki.hinta = double.Parse(tbHinta.Text);
            luotumokki.kuvaus = tbKuvaus.Text;
            luotumokki.henkilomaara = int.Parse(tbHenkilomaara.Text);
            luotumokki.varustelu = tbVarustelu.Text;
            luotumokki.postitoimipaikka = tbPostitoimipaikka.Text;

            try
            {
                string connectionString = "Dsn=Village Newbies;uid=root";
                if (!PostiLoytyi(luotumokki.postinro))
                    LuoPosti(luotumokki.postinro, tbPostitoimipaikka.Text);
                using (OdbcConnection connection = new OdbcConnection(connectionString))
                {
                    connection.Open();
                    string lisaysquery = "INSERT INTO mokki(mokki_id, alue_id, postinro, mokkinimi, katuosoite, hinta, kuvaus, henkilomaara, varustelu) VALUES(" + luotumokki.mokki_id + ", '" + luotumokki.alue_id + "', '" + luotumokki.postinro + "', '" + luotumokki.mokkinimi + "', '" + luotumokki.katuosoite + "', '" + luotumokki.hinta + "', '" + luotumokki.kuvaus + "',  '" + luotumokki.henkilomaara + "', '" + luotumokki.varustelu + "');";
                    using (OdbcCommand cmd = new OdbcCommand(lisaysquery, connection))
                    {
                        cmd.ExecuteNonQuery();
                    }
                    {

                        if (tbMokkiId.Text.Trim() == "" || tbAlueId.Text.Trim() == "" || tbPostinumero.Text.Trim() == "" ||
                         tbMokinnimi.Text.Trim() == "" || tbKatuosoite.Text.Trim() == "" || tbHinta.Text.Trim() == "" ||
                         tbKuvaus.Text.Trim() == "" || tbHenkilomaara.Text.Trim() == "" || tbVarustelu.Text.Trim() == "" || tbPostitoimipaikka.Text.Trim() == "")
                        {
                            MessageBox.Show("Täytä kaikki kentät!");
                        }
                        else
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
                            tbPostitoimipaikka.Text = String.Empty;
                        }
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
            string query = "SELECT * FROM posti";

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

        // Muokkaaminen, eli tallentaa muokkauksen.

        private void btnMuokkaa_Click(object sender, EventArgs e)
        {
           try
           
            {
                luotumokki.mokki_id = int.Parse(tbMokkiId.Text);
                luotumokki.alue_id = int.Parse(tbAlueId.Text);
                luotumokki.postinro = tbPostinumero.Text;
                luotumokki.mokkinimi = tbMokinnimi.Text;
                luotumokki.katuosoite = tbKatuosoite.Text;
                luotumokki.hinta = double.Parse(tbHinta.Text);
                luotumokki.kuvaus = tbKuvaus.Text;
                luotumokki.henkilomaara = int.Parse(tbHenkilomaara.Text);
                luotumokki.varustelu = tbVarustelu.Text;
                luotumokki.postitoimipaikka = tbPostitoimipaikka.Text;
                string connectionString = "Dsn=Village Newbies;uid=root";
                if (!PostiLoytyi(luotumokki.postinro))
                    LuoPosti(luotumokki.postinro, tbPostitoimipaikka.Text);
                using (OdbcConnection connection = new OdbcConnection(connectionString))
                {
                    connection.Open();
                    string mokkiquery = "UPDATE mokki SET alue_id = ?, postinro = ?, mokkinimi = ?, katuosoite = ?, hinta = ?, kuvaus = ?, henkilomaara = ?, varustelu = ? WHERE mokki_id = ?";
                    using (OdbcCommand cmd = new OdbcCommand(mokkiquery, connection))
                    {
                        if (tbMokkiId.Text.Trim() == "" || tbAlueId.Text.Trim() == "" || tbPostinumero.Text.Trim() == "" ||
                      tbMokinnimi.Text.Trim() == "" || tbKatuosoite.Text.Trim() == "" || tbHinta.Text.Trim() == "" ||
                      tbKuvaus.Text.Trim() == "" || tbHenkilomaara.Text.Trim() == "" || tbVarustelu.Text.Trim() == "")
                        {
                            MessageBox.Show("Täytä kaikki kentät!");
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@alue_id", luotumokki.alue_id);
                            cmd.Parameters.AddWithValue("@postinro", luotumokki.postinro);
                            cmd.Parameters.AddWithValue("@mokkinimi", luotumokki.mokkinimi);
                            cmd.Parameters.AddWithValue("@katuosoite", luotumokki.katuosoite);
                            cmd.Parameters.AddWithValue("@hinta", luotumokki.hinta);
                            cmd.Parameters.AddWithValue("@kuvaus", luotumokki.kuvaus);
                            cmd.Parameters.AddWithValue("@henkilomaara", luotumokki.henkilomaara);
                            cmd.Parameters.AddWithValue("@varustelu", luotumokki.varustelu);
                            cmd.Parameters.AddWithValue("@mokki_id", luotumokki.mokki_id);
                            cmd.ExecuteNonQuery();


                            string queryString = "SELECT * FROM mokki";
                            using (OdbcCommand command = new OdbcCommand(queryString, connection))
                            {
                                using (OdbcDataReader reader = command.ExecuteReader())
                                {
                                    DataTable table = new DataTable();
                                    table.Load(reader);
                                    dgvMokit.DataSource = table;
                                }
                            }


                            tbMokkiId.Text = String.Empty;
                            tbAlueId.Text = String.Empty;
                            tbPostinumero.Text = String.Empty;
                            tbMokinnimi.Text = String.Empty;
                            tbKatuosoite.Text = String.Empty;
                            tbHinta.Text = String.Empty;
                            tbKuvaus.Text = String.Empty;
                            tbHenkilomaara.Text = String.Empty;
                            tbVarustelu.Text = String.Empty;
                            tbPostitoimipaikka.Text = String.Empty;
                        }
                    }

                    lokiinTallentaminen("Mökit-osiosta muokattiin tietoja käyttäjältä: ");
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

                DataRow currentRow = ((DataRowView)dgvMokit.CurrentRow.DataBoundItem).Row;

                    currentRow.Delete();
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
                    tbPostitoimipaikka.Text = String.Empty;


                lokiinTallentaminen("Mökit-osiosta poistettiin tietoja käyttäjältä: ");
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        private void tbMokkiId_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvMokit_SelectionChanged(object sender, EventArgs e)
        {

        }

        // Avaa rivin tupla clickillä tekstiboxeihin.

        private void dgvMokit_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            if (dgv.CurrentRow != null)
            {
                tbMokkiId.Text = dgv.CurrentRow.Cells["mokki_id"].Value.ToString();
                tbAlueId.Text = dgv.CurrentRow.Cells["alue_id"].Value.ToString();
                tbPostinumero.Text = dgv.CurrentRow.Cells["postinro"].Value.ToString();
                tbMokinnimi.Text = dgv.CurrentRow.Cells["mokkinimi"].Value.ToString();
                tbKatuosoite.Text = dgv.CurrentRow.Cells["katuosoite"].Value.ToString();
                tbHinta.Text = dgv.CurrentRow.Cells["hinta"].Value.ToString();
                tbKuvaus.Text = dgv.CurrentRow.Cells["kuvaus"].Value.ToString();
                tbHenkilomaara.Text = dgv.CurrentRow.Cells["henkilomaara"].Value.ToString();
                tbVarustelu.Text = dgv.CurrentRow.Cells["varustelu"].Value.ToString();
            }
        }

        // Tyhjentää kentät

        private void btnTyhjenna_Click(object sender, EventArgs e)
        {
            tbMokkiId.Text = String.Empty;
            tbAlueId.Text = String.Empty;
            tbPostinumero.Text = String.Empty;
            tbMokinnimi.Text = String.Empty;
            tbKatuosoite.Text = String.Empty;
            tbHinta.Text = String.Empty;
            tbKuvaus.Text = String.Empty;
            tbHenkilomaara.Text = String.Empty;
            tbVarustelu.Text = String.Empty;
            tbPostitoimipaikka.Text = String.Empty;
        }

        // Lokiin tallentaminen

        public void lokiinTallentaminen(string teksti)

        {
            string kayttaja = Environment.UserName;

            StreamWriter sw = new StreamWriter("Kirjautumistiedot.txt", true);
            sw.WriteLine(DateTime.Now.ToString() + " " + teksti + " " + kayttaja);
            sw.Close();
        }

        // Haku toiminto, joka hakee mökki id mukaan. Jos mökkiä ei löydy tekee virheilmoitukset.

        private void btnHae_Click(object sender, EventArgs e)
        {
            string searchValue = tbHae.Text.Trim();
            if (dgvMokit != null)
            {
                dgvMokit.ClearSelection();
                if (!string.IsNullOrEmpty(searchValue))
                {
                    if (int.TryParse(searchValue, out int id))
                    {
                        foreach (DataGridViewRow row in dgvMokit.Rows)
                        {
                            if (row.Cells["mokki_id"].Value != null && row.Cells["mokki_id"].Value.ToString().Equals(searchValue))
                            {
                                dgvMokit.CurrentCell = row.Cells["mokki_id"];
                                row.Selected = true;
                                break;
                            }
                        }
                        if (!dgvMokit.SelectedRows.Count.Equals(1))
                        {
                            MessageBox.Show("Mökkiä ei löytynyt");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Hae Mökki_id numerolla");
                    }
                }
                else
                {
                    MessageBox.Show("Haku ei voi olla tyhjä");
                }
            }
        }

        // Postinumeroon voi syöttää vain numeroita sekä max 5 numeroa.

        private void tbPostinumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }

            tbPostinumero.MaxLength = 5;
        }

        // Muuttaa mökin nimen ensimmäisen kirjaimen isoksi.Nimessä saa olla max 45 kirjainta.

        private void tbMokinnimi_Leave(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            string nimi = tb.Text.Trim();

            if (nimi.Length > 0)
            {
                nimi = nimi.Substring(0, 1).ToUpper() + nimi.Substring(1, nimi.Length - 1).ToLower();
                tb.Text = nimi;
            }
        }

        private void tbMokinnimi_KeyPress(object sender, KeyPressEventArgs e)
        {
            tbMokinnimi.MaxLength = 45;
        }

        // Muuttaa katuosoitteen ensimmäisen kirjaimen isoksi. Katuosoitteessa saa olla max 45 kirjainta.

        private void tbKatuosoite_Leave(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            string nimi = tb.Text.Trim();

            if (nimi.Length > 0)
            {
                nimi = nimi.Substring(0, 1).ToUpper() + nimi.Substring(1, nimi.Length - 1).ToLower();
                tb.Text = nimi;
            }
        }

        private void tbKatuosoite_KeyPress(object sender, KeyPressEventArgs e)
        {
            tbKatuosoite.MaxLength = 45;
        }


        // Mökki idseen voi syöttää vain numeroita.

        private void tbMokkiId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        // Alue idseen voi syöttää vain numeroita.

        private void tbAlueId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        // Henkilömäärään voi syöttää vain numeroita.

        private void tbHenkilomaara_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        // Tarkistaa, että hinta on double tyyppinen. Hinnassa saa olla 11 merkkiä (8 + 2, sekä pilkku)

        private void tbHinta_Leave(object sender, EventArgs e)
        {
            double hinta;

            if (!double.TryParse(tbHinta.Text, out hinta))
            {
                MessageBox.Show("Virheellinen hinta!");
                return;
            }

        }

        private void tbHinta_KeyPress(object sender, KeyPressEventArgs e)
        {
            tbHinta.MaxLength = 11;
        }


        // Varusteluun ei voi syöttää yli 100 merkkiä.

        private void tbVarustelu_KeyPress(object sender, KeyPressEventArgs e)
        {
            tbVarustelu.MaxLength = 100;
        }

        // Kuvaukseen ei voi syöttää yli 150 merkkiä.

        private void tbKuvaus_KeyPress(object sender, KeyPressEventArgs e)
        {
            tbKuvaus.MaxLength = 150;
        }
        
        // Sulkeminen. Kysyy haluatko varmasti sulkea.

        private void frmMokit_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Haluatko varmasti sulkea ikkunan?", "Varmista", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
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

        private void tbHenkilomaara_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
