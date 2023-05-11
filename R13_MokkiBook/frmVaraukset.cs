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

namespace R13_MokkiBook
{
    public partial class frmVaraukset : Form
    {//Pan
        public string connectionString = "Dsn=Village Newbies;uid=root";
        public string hakuquery;
        public int valitturivi = -1;
        public DateTime nyt = DateTime.Now;
        public DateTime hakualku = DateTime.Now;
        public DateTime hakuloppu = DateTime.Now;
        public Varaus valittuvaraus;
        public List<Varaus> varaukset;
        public List<Alue> alueet;

        public frmVaraukset()
        {
            InitializeComponent();
            varaukset = GetVaraukset();
            alueet = GetAlueet();
            LokiinTallentaminen("Varaukset-osio avattiin käyttäjältä: ");

            //jos palveluita ja virheellinen varaus: 
            /*using (OdbcConnection connection = new OdbcConnection(connectionString))
            {
                connection.Open();
                string poistoquery = "DELETE FROM varauksen_palvelut WHERE varaus_id > 3;";
                using (OdbcCommand cmd = new OdbcCommand(poistoquery, connection))
                {
                    cmd.ExecuteNonQuery();
                }
            }*/
            //jos laskuja ja virheellinen varaus:
            using (OdbcConnection connection = new OdbcConnection(connectionString))
            {
                connection.Open();
                string poistoquery = "DELETE FROM lasku WHERE varaus_id = 4;";
                using (OdbcCommand cmd = new OdbcCommand(poistoquery, connection))
                {
                    cmd.ExecuteNonQuery();
                }
            }
            //poista virheellinen varaus:
            using (OdbcConnection connection = new OdbcConnection(connectionString))
            {
                connection.Open();
                string poistoquery = "DELETE FROM varaus WHERE varaus_id = 4;";
                using (OdbcCommand cmd = new OdbcCommand(poistoquery, connection))
                {
                    cmd.ExecuteNonQuery();
                }
            }
            //Muista poistaa tämä!! Vain korjausta varten!!!!! (Jos on tullut vahingossa lisäiltyä jotain väärää, joka haluaa kaataa koko homman...)
            /*foreach (Varaus varaus in varaukset)
            {
                if (varaus.varaus_id ==4)
                    PoistaVaraus(varaus);
            }*/
        }

        public List<Varaus> GetVaraukset()
        {
            List<Varaus> var = new List<Varaus>();
            string query = "SELECT * FROM varaus";

            using (OdbcConnection connection = new OdbcConnection(connectionString))
            {
                connection.Open();
                using (OdbcCommand command = new OdbcCommand(query, connection))
                {
                    using (OdbcDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Varaus varaus = new Varaus();
                            varaus.varaus_id = reader.GetInt32(0);
                            //Muista poistaa tämä!! vain korjausta varten!!!!! Jos on tullut vahingossa lisäiltyä jotain väärää
                            if (varaus.varaus_id == 4)
                                break;
                            varaus.asiakas_id = reader.GetInt32(1);
                            varaus.mokki_id = reader.GetInt32(2);
                            if (varaus.varaus_id < 4)
                            {
                                varaus.varattu_pvm = reader.GetDateTime(3);
                                varaus.vahvistus_pvm = reader.GetDateTime(4);
                                varaus.varattu_alkupvm = reader.GetDateTime(5);
                                varaus.varattu_loppupvm = reader.GetDateTime(6);
                            }
                            else
                            {
                                varaus.varattu_pvm = nyt;
                                varaus.vahvistus_pvm = nyt;
                                varaus.varattu_alkupvm = nyt;
                                varaus.varattu_loppupvm = nyt;
                            }
                            var.Add(varaus);
                        }
                    }
                }
                string korjausquery = "UPDATE varaus SET varattu_pvm = " + nyt.ToShortDateString() + ", vahvistus_pvm = " + nyt.ToShortDateString() + ", varattu_alkupvm = " + nyt.ToShortDateString() + ", varattu_loppupvm = " + nyt.ToShortDateString() + " WHERE varaus_id = 4;";
                using (OdbcCommand cmd = new OdbcCommand(korjausquery, connection))
                {
                    cmd.ExecuteNonQuery();
                }
            }
            return var;
        }
        public List<Alue> GetAlueet()
        {
            List<Alue> alu = new List<Alue>();
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
                            Alue a = new Alue();
                            a.alue_id = reader.GetInt32(0);
                            a.nimi = reader.GetString(1);
                            alu.Add(a);
                        }
                    }
                }
            }
            return alu;
        }
        public Varaus GetValittuVaraus()
        {
            Varaus v = new Varaus();
            v.varaus_id = varaukset[valitturivi].varaus_id;
            v.asiakas_id = varaukset[valitturivi].asiakas_id;
            v.mokki_id = varaukset[valitturivi].mokki_id;
            //MUISTA POISTAA IFFI Vikakorjaus
            //if (v.varaus_id > 4)
            //{
                v.varattu_pvm = varaukset[valitturivi].varattu_pvm;
                v.vahvistus_pvm = varaukset[valitturivi].vahvistus_pvm;
                v.varattu_alkupvm = varaukset[valitturivi].varattu_alkupvm;
                v.varattu_loppupvm = varaukset[valitturivi].varattu_loppupvm;
            //}
            return v;
        }
        private void frmVaraukset_Load(object sender, EventArgs e)
        {
            this.varausTableAdapter.Fill(this.dataSet1.varaus);
        }

        private void dgvVaraukset_SelectionChanged(object sender, EventArgs e)
        {
            //HUUTAA JOS KLIKKAA ULKOPUOLELTA
            valitturivi = dgvVaraukset.CurrentRow.Index;
            valittuvaraus = GetValittuVaraus();
        }

        private void btnRaportti_Click(object sender, EventArgs e)
        {
            pdRaportti.ShowDialog();
            //MITÄ VIELÄ?
        }

        private void btnUusi_Click(object sender, EventArgs e)
        {
            frmUusiVaraus uv = new frmUusiVaraus();
            uv.ShowDialog();
        }

        private void tsmiMuokkaa_Click(object sender, EventArgs e)
        {
            //VALIDOI

            //frmUusiVaraus muokkaus = new frmUusiVaraus();
            //muokkaus.ShowDialog();
        }

        private void tsmiVarauksenPalvelut_Click(object sender, EventArgs e)
        {
            frmVarauksenPalvelut vp = new frmVarauksenPalvelut(valittuvaraus);
            vp.ShowDialog();
        }

        private void tsmiPoista_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Haluatko varmasti poistaa varauksen?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                PoistaVaraus(valittuvaraus);
            }
        }
        public void PoistaVaraus(Varaus v)
        {
            using (OdbcConnection connection = new OdbcConnection(connectionString))
            {
                connection.Open();
                string poistoquery = "DELETE FROM varaus WHERE varaus_id = " + v.varaus_id + ";";
                using (OdbcCommand cmd = new OdbcCommand(poistoquery, connection))
                {
                    cmd.ExecuteNonQuery();
                }
            }
            PaivitaTaulu();
            LokiinTallentaminen("Poistettiin varaus " + v.varaus_id.ToString() + " käyttäjältä: ");
        }
        private void btnHae_Click_1(object sender, EventArgs e)
        {
            if (ValidPvm())
            {
                if (tbAlue.TextLength > 0)
                {
                    if (ValidAluetunnus())
                    {
                        hakuquery = "SELECT * FROM varaus WHERE varattu_alkupvm >= " + hakualku.ToShortDateString() + " AND varattu_loppupvm <= " + hakuloppu.ToShortDateString() + " AND mokki_mokki_id IN (SELECT mokki_id FROM mokki WHERE alue_id = " + tbAlue.Text + ");";
                        PaivitaTaulu();
                        //MIKSEI NÄYTÄ??
                    }
                    else
                        MessageBox.Show("Aluetunnusta ei tunnistettu.");
                }
                else
                    MessageBox.Show("Hakua ei voitu suorittaa: Syötä aluetunnus.");
            }
            else
                MessageBox.Show("Hakua ei voitu suorittaa: Varauksen alkupäivämäärän on oltava ennen sen päättymispäivämäärää.");
        }

        public bool ValidPvm()
        {
            if(hakualku < hakuloppu)
                return true;
            else if(hakualku.Equals(hakuloppu))
                return true;
            else
                return false;
        }

        public bool ValidAluetunnus()
        {
            bool tunnus_loytyi = false;
            int tbTunnus = int.Parse(tbAlue.Text);
            foreach(Alue a in alueet)
            {
                if(a.alue_id == tbTunnus)
                    tunnus_loytyi = true;
            }
            return tunnus_loytyi;
        }

        private void btnTyhjennaHaku_Click(object sender, EventArgs e)
        {
            hakuquery = "SELECT * FROM varaus";
            tbAlue.Text = String.Empty;
            dtpAlku.Value = nyt;
            dtpLoppu.Value = nyt;
            hakualku = nyt;
            hakuloppu = nyt;
            PaivitaTaulu();
        }

        public void PaivitaTaulu()
        {
            OdbcConnection connection = new OdbcConnection(connectionString);
            connection.Open();
            DataTable dataTable = new DataTable();
            using (OdbcDataAdapter adapter = new OdbcDataAdapter(hakuquery, connection))
            {
                adapter.FillSchema(dataTable, SchemaType.Source);
                adapter.Fill(dataTable);
            }
            dgvVaraukset.DataSource = dataTable;

            dgvVaraukset.Columns[0].HeaderText = "Varaustunnus";
            dgvVaraukset.Columns[1].HeaderText = "Asiakastunnus";
            dgvVaraukset.Columns[2].HeaderText = "Mökki";
            dgvVaraukset.Columns[3].HeaderText = "Varaus tehty";
            dgvVaraukset.Columns[4].HeaderText = "Varaus vahvistettu";
            dgvVaraukset.Columns[5].HeaderText = "Varauksen alkupäivä";
            dgvVaraukset.Columns[6].HeaderText = "Varauksen päättymispäivä";
        }

        private void tbAlue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if((!Char.IsDigit(e.KeyChar)) && (e.KeyChar != (char)8))
                e.Handled = true;
        }

        private void dtpAlku_ValueChanged(object sender, EventArgs e)
        {
            hakualku = dtpAlku.Value;
        }

        private void dtpLoppu_ValueChanged(object sender, EventArgs e)
        {
            hakuloppu = dtpLoppu.Value;
        }

        public void LokiinTallentaminen(string teksti)
        {
            string kayttaja = Environment.UserName;

            StreamWriter sw = new StreamWriter("Kirjautumistiedot.txt", true);
            sw.WriteLine(DateTime.Now.ToString() + " " + teksti + " " + kayttaja);
            sw.Close();
        }

        private void frmVaraukset_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Haluatko varmasti poistua?", "", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
