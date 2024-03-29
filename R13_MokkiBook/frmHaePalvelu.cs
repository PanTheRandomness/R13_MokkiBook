﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace R13_MokkiBook
{
    public partial class frmHaePalvelu : Form
    {//Pan
        public Varaus kasiteltavavaraus;
        public Palvelu valittupalvelu;
        public VarauksenPalvelut lisattava;
        public List<VarauksenPalvelut> varauksenpalvelut;
        public List<Palvelu> palvelut;
        public int valitturivi = -1;
        public int palvelumaara;
        public string connectionString = "Dsn=Village Newbies;uid=root";
        public string query;
        public bool varauksessaonjopalvelu = false;
        public frmHaePalvelu(Varaus tuotu, List<VarauksenPalvelut> tuotulista)
        {
            InitializeComponent();
            kasiteltavavaraus = tuotu;
            LokiinTallentaminen("Palvelujen hakusivu avattiin varaukselle " + kasiteltavavaraus.varaus_id.ToString() + " käyttäjältä: ");
            query = "SELECT * FROM palvelu WHERE palvelu.alue_id = (SELECT mokki.alue_id FROM mokki WHERE mokki.mokki_id = (SELECT varaus.mokki_mokki_id FROM varaus WHERE varaus.varaus_id = " + kasiteltavavaraus.varaus_id + "));";
            TuoData();
            palvelut = GetPalvelut();
            varauksenpalvelut = tuotulista;
        }

        //Lokiin tallentaminen: Tämän teki Hanna
        public void LokiinTallentaminen(string teksti)
        {
            string kayttaja = Environment.UserName;

            StreamWriter sw = new StreamWriter("Kirjautumistiedot.txt", true);
            sw.WriteLine(DateTime.Now.ToString() + " " + teksti + " " + kayttaja);
            sw.Close();
        }

        //Täyttää datagridview:n
        public void TuoData()
        {
            OdbcConnection connection = new OdbcConnection(connectionString);
            connection.Open();
            DataTable dataTable = new DataTable();
            using (OdbcDataAdapter adapter = new OdbcDataAdapter(query, connection))
            {
                adapter.FillSchema(dataTable, SchemaType.Source);
                adapter.Fill(dataTable);
            }
            dgvAlueenPalvelut.DataSource = dataTable;
            dgvAlueenPalvelut.Columns[0].HeaderText = "Palvelutunnus";
            dgvAlueenPalvelut.Columns[1].HeaderText = "Aluetunnus";
            dgvAlueenPalvelut.Columns[2].HeaderText = "Nimi";
            dgvAlueenPalvelut.Columns[3].HeaderText = "Tyyppi";
            dgvAlueenPalvelut.Columns[4].HeaderText = "Kuvaus";
            dgvAlueenPalvelut.Columns[5].HeaderText = "Hinta";
            dgvAlueenPalvelut.Columns[6].HeaderText = "ALV";
        }

        //Palauttaa listan kaikista palveluista
        public List<Palvelu> GetPalvelut()
        {
            List<Palvelu> pp = new List<Palvelu>();

            using (OdbcConnection connection = new OdbcConnection(connectionString))
            {
                connection.Open();
                using (OdbcCommand command = new OdbcCommand(query, connection))
                {
                    using (OdbcDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Palvelu p = new Palvelu();
                            p.palvelu_id = reader.GetInt32(0);
                            p.alue_id = reader.GetInt32(1);
                            p.nimi = reader.GetString(2);
                            p.tyyppi = reader.GetInt32(3);
                            p.kuvaus = reader.GetString(4);
                            p.hinta = reader.GetDouble(5);
                            p.alv = reader.GetDouble(6);
                            pp.Add(p);
                        }
                    }
                }
            }
            return pp;
        }

        //Ottaa talteen lisättävän määrän
        private void nudMaara_ValueChanged(object sender, EventArgs e)
        {
            palvelumaara = (int)nudMaara.Value;
        }

        //Validoi lisäyksen ja luo uuden varausken_palvelut-instancen tai muokkaa vanhaa
        private void btnLisaa_Click(object sender, EventArgs e)
        {
            if (nudMaara.Value == 0 || palvelumaara == 0)
            {
                MessageBox.Show("Ei voi lisätä: määrä 0.");
            }
            else
            {
                lisattava = new VarauksenPalvelut();
                lisattava.varaus_id = kasiteltavavaraus.varaus_id;
                lisattava.palvelu_id = valittupalvelu.palvelu_id;
                lisattava.lkm = palvelumaara;

                //Tarkistaa onko varauksessa jo valmiiksi ko. palvelu- jos kyllä: päivittää lukumäärän, jos ei: lisää palvelun varaukseen
                foreach(VarauksenPalvelut vap in varauksenpalvelut)
                {
                    if((vap.varaus_id == lisattava.varaus_id) && (vap.palvelu_id == lisattava.palvelu_id))
                    {
                        varauksessaonjopalvelu = true;
                        lisattava.lkm = vap.lkm + (int)nudMaara.Value;
                    }
                }
                if (!varauksessaonjopalvelu)
                {
                    using (OdbcConnection connection = new OdbcConnection(connectionString))
                    {
                        connection.Open();
                        string lisaysquery = "INSERT INTO varauksen_palvelut(varaus_id, palvelu_id, lkm) VALUES(" + lisattava.varaus_id + ", " + lisattava.palvelu_id + ", " + lisattava.lkm + ");";
                        using (OdbcCommand cmd = new OdbcCommand(lisaysquery, connection))
                        {
                            cmd.ExecuteNonQuery();
                        }
                        LokiinTallentaminen("Varaukseen " + lisattava.varaus_id.ToString() + " lisättiin " + lisattava.lkm.ToString() + " kpl palvelua " + lisattava.palvelu_id.ToString() + " käyttäjältä: ");
                    }
                }
                else
                {
                    using (OdbcConnection connection = new OdbcConnection(connectionString))
                    {
                        connection.Open();
                        string paivitysquery = "UPDATE varauksen_palvelut SET varaus_id = " + lisattava.varaus_id + ", palvelu_id = " + lisattava.palvelu_id + ", lkm = " + lisattava.lkm + " WHERE varaus_id = " + lisattava.varaus_id + " AND palvelu_id = " + lisattava.palvelu_id + "; ";
                        using (OdbcCommand cmd = new OdbcCommand(paivitysquery, connection))
                        {
                            cmd.ExecuteNonQuery();
                        }
                        LokiinTallentaminen("Varaukseen " + lisattava.varaus_id.ToString() + " lisättiin " + lisattava.lkm.ToString() + " kpl palvelua " + lisattava.palvelu_id.ToString() + " käyttäjältä: ");
                    }
                }
                MessageBox.Show("Palvelu lisättiin varaukseen.");
            }
        }

        //Tallentaa sulkemisen lokiin
        private void frmHaePalvelu_FormClosed(object sender, FormClosedEventArgs e)
        {
            LokiinTallentaminen("Palvelujen hakusivu suljettiin varaukselle " + kasiteltavavaraus.varaus_id.ToString() + " käyttäjältä: ");
        }

        //Varmistaa sulkemishalukkuuden
        private void frmHaePalvelu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Haluatko varmasti poistua?", "", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        //Valitsee rivin datagridview:sta. Error, jos valitaan tyhjä dgv-rivi
        private void dgvAlueenPalvelut_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            valitturivi = dgvAlueenPalvelut.CurrentRow.Index;
            valittupalvelu = palvelut[valitturivi];
            tbKuvaus.Text = valittupalvelu.kuvaus;
        }
    }
}
