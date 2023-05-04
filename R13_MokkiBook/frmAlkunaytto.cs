﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace R13_MokkiBook
{
    public partial class frmAlkunaytto : Form
    {
        public frmAlkunaytto()
        {
            InitializeComponent();
            lokiinTallentaminen("Ohjelma avattiin käyttäjältä: ");
        }

        private void frmAlkunaytto_Load(object sender, EventArgs e)
        {
           
        }

        private void btnVaraukset_Click(object sender, EventArgs e)
        {
            frmVaraukset va = new frmVaraukset();
            va.ShowDialog();
        }

        private void btnMokit_Click(object sender, EventArgs e)
        {
            frmMokit mo = new frmMokit();
            mo.ShowDialog();
        }

        private void btnAlueet_Click(object sender, EventArgs e)
        {
            frmAlueet al = new frmAlueet();
            al.ShowDialog();
        }

        private void btnAsiakkaat_Click(object sender, EventArgs e)
        {
            frmAsiakkaat asi = new frmAsiakkaat();
            asi.ShowDialog();
        }

        private void btnPalvelut_Click(object sender, EventArgs e)
        {
            frmPalvelut pa = new frmPalvelut();
            pa.ShowDialog();
        }

        private void btnLaskut_Click(object sender, EventArgs e)
        {
            frmLaskut la = new frmLaskut();
            la.ShowDialog();
        }

        /* Lokiin tallentaminen */

        public void lokiinTallentaminen(string teksti)

        {
            string kayttaja = Environment.UserName;

            StreamWriter sw = new StreamWriter("Kirjautumistiedot.txt", true);
            sw.WriteLine(DateTime.Now.ToString() + " " + teksti + " " + kayttaja);
            sw.Close();
        }
    }
}
