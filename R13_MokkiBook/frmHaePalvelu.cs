﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace R13_MokkiBook
{
    public partial class frmHaePalvelu : Form
    {
        public Varaus kasiteltavavaraus;
        public Palvelu valittupalvelu;
        public int valitturivi = -1;
        public string connectionString = "Dsn=Village Newbies;uid=root";
        public string query;
        public List<Palvelu> palvelut;
        public frmHaePalvelu(Varaus tuotu)
        {
            InitializeComponent();
            kasiteltavavaraus = tuotu;
            query = "SELECT * FROM palvelu WHERE palvelu.alue_id = (SELECT mokki.alue_id FROM mokki WHERE mokki.mokki_id = (SELECT varaus.mokki_mokki_id FROM varaus WHERE varaus.varaus_id = " + kasiteltavavaraus.varaus_id + "));";
            TuoData();
            palvelut = GetPalvelut();
        }
        public void TuoData()
        {
            OdbcConnection connection = new OdbcConnection(connectionString);
            connection.Open();
            //datagridviewin yhdistäminen tiettyyn kyselyyn
            DataTable dataTable = new DataTable();
            using (OdbcDataAdapter adapter = new OdbcDataAdapter(query, connection))
            {
                adapter.FillSchema(dataTable, SchemaType.Source);
                adapter.Fill(dataTable);
            }
            dgvAlueenPalvelut.DataSource = dataTable;
        }
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
                            p.tyyppi = reader.GetString(3);
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

        private void dgvAlueenPalvelut_SelectionChanged(object sender, EventArgs e)
        {
            valitturivi = dgvAlueenPalvelut.CurrentRow.Index;
            valittupalvelu = palvelut[valitturivi];
            tbKuvaus.Text = valittupalvelu.kuvaus;
        }

        private void nudMaara_ValueChanged(object sender, EventArgs e)
        {
            //EI VOI OLLA 0!!
        }

        private void btnLisaa_Click(object sender, EventArgs e)
        {
            //Palaa edelliseen (VarauksenPalvelut)
        }
    }
}
