using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Drawing.Printing;
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
        //Kommenteissa virheellisistä varauksista (lähinnä tässä pähkäillessä) syntyneiden varauksien yms. poistokoodit
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

            /*using (OdbcConnection connection = new OdbcConnection(connectionString))
            {
                connection.Open();
                string poistoquery = "DELETE FROM lasku WHERE varaus_id = 4;";
                using (OdbcCommand cmd = new OdbcCommand(poistoquery, connection))
                {
                    cmd.ExecuteNonQuery();
                }
            }*/

            //poista virheellinen varaus:

            /*using (OdbcConnection connection = new OdbcConnection(connectionString))
            {
                connection.Open();
                string poistoquery = "DELETE FROM varaus WHERE varaus_id = 4;";
                using (OdbcCommand cmd = new OdbcCommand(poistoquery, connection))
                {
                    cmd.ExecuteNonQuery();
                }
            }*/

            // jos on tullut virheellisiä varauksia useampia:

            /*foreach (Varaus varaus in varaukset)
            {
                if (varaus.varaus_id ==4)
                    PoistaVaraus(varaus);
            }*/
        }

        //Hakee listan kaikista tehdyistä varauksista
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
                            //Korjausta varten
                            /*if (varaus.varaus_id == 4)
                                break;*/
                            varaus.asiakas_id = reader.GetInt32(1);
                            varaus.mokki_id = reader.GetInt32(2);
                            /*if (varaus.varaus_id < 4)
                            {*/
                                varaus.varattu_pvm = reader.GetDateTime(3);
                                varaus.vahvistus_pvm = reader.GetDateTime(4);
                                varaus.varattu_alkupvm = reader.GetDateTime(5);
                                varaus.varattu_loppupvm = reader.GetDateTime(6);
                           /* }
                            else
                            {
                                varaus.varattu_pvm = nyt;
                                varaus.vahvistus_pvm = nyt;
                                varaus.varattu_alkupvm = nyt;
                                varaus.varattu_loppupvm = nyt;
                            }*/
                            var.Add(varaus);
                        }
                    }
                }
            }
            return var;
        }

        //Hakee listan kaikista alueista
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

        //Hakee käsiteltävän varauksen
        public Varaus GetValittuVaraus()
        {
            Varaus v = new Varaus();
            v.varaus_id = varaukset[valitturivi].varaus_id;
            v.asiakas_id = varaukset[valitturivi].asiakas_id;
            v.mokki_id = varaukset[valitturivi].mokki_id;
            //Vikakorjaus
            /*if (v.varaus_id > 4)
            {*/
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

        //Valitsee rivin datagridview:sta
        private void dgvVaraukset_SelectionChanged(object sender, EventArgs e)
        {
            //Error, jos valitaan tyhjä dgv-rivi
            valitturivi = dgvVaraukset.CurrentRow.Index;
            valittuvaraus = GetValittuVaraus();
        }

        //Käynnistää raportin tulostuksen
        private void btnRaportti_Click(object sender, EventArgs e)
        {
            PrintDocument printDocument = new PrintDocument();
            printDocument.PrintPage += new PrintPageEventHandler(PrintDocument_PrintPage);

            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDocument;

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument.Print();
            }
        }

        //Tulostaa raportin
        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            //kannattaa tulostaa vaakaan
            DataGridViewPrinter dataGridViewPrinter = new DataGridViewPrinter(dgvVaraukset, e.Graphics, e.MarginBounds, Color.Black, true);
            bool morePages = dataGridViewPrinter.DrawDataGridView();

            e.HasMorePages = morePages;
        }

        //Avaa uuden varauksen luontisivun
        private void btnUusi_Click(object sender, EventArgs e)
        {
            frmUusiVaraus uv = new frmUusiVaraus();
            uv.ShowDialog();
        }

        //Avaa varauksen muokkaussivun (uusi nimi contextmenussa text.ominaisuudella "Muokkaa"
        private void tsmiVarauksenPalvelut_Click(object sender, EventArgs e)
        {
            frmVarauksenPalvelut vp = new frmVarauksenPalvelut(valittuvaraus);
            vp.ShowDialog();
        }

        //Varmistaa poistohalukkuuden.
        private void tsmiPoista_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Haluatko varmasti poistaa varauksen?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                PoistaVaraus(valittuvaraus);
            }
        }

        //Poistaa varauksen. Tässä tulee error 'ei alustettu', mutta poisto onnistuu, kun taulun päivittää
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

        //Hakee varauksista annetuihin kriteereihin sopivat
        private void btnHae_Click_1(object sender, EventArgs e)
        {
            if (ValidPvm())
            {
                if (tbAlue.TextLength > 0)
                {
                    if (ValidAluetunnus())
                    {
                        hakuquery = "SELECT * FROM varaus WHERE varattu_alkupvm >= '" + hakualku.ToString("yyyy-MM-dd") + "' AND varattu_loppupvm <= '" + hakuloppu.ToString("yyyy-MM-dd") + "' AND mokki_mokki_id IN (SELECT mokki_id FROM mokki WHERE alue_id = " + tbAlue.Text + ");";
                        PaivitaTaulu();
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

        //Varmistaa, että haun päivämäärät on syötetty oikein
        public bool ValidPvm()
        {
            if(hakualku < hakuloppu)
                return true;
            else if(hakualku.Equals(hakuloppu))
                return true;
            else
                return false;
        }

        //Varmistaa, että haun aluetunnus on syötetty oikein
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

        //Tyhjentää haun ja palauttaa alkuperäisen näkymän
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

        //Päivittää datagrigview:n
        public void PaivitaTaulu()
        {
            try
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
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        //Varmistaa, että alue-boksiin syötetään vain numeroita
        private void tbAlue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if((!Char.IsDigit(e.KeyChar)) && (e.KeyChar != (char)8))
                e.Handled = true;
        }

        //Ottaa haun alkupäivämäärän talteen
        private void dtpAlku_ValueChanged(object sender, EventArgs e)
        {
            hakualku = dtpAlku.Value;
        }

        //Ottaa haun loppupäivämäärän talteen
        private void dtpLoppu_ValueChanged(object sender, EventArgs e)
        {
            hakuloppu = dtpLoppu.Value;
        }

        //Lokiin tallennus: tämän teki Hanna
        public void LokiinTallentaminen(string teksti)
        {
            string kayttaja = Environment.UserName;

            StreamWriter sw = new StreamWriter("Kirjautumistiedot.txt", true);
            sw.WriteLine(DateTime.Now.ToString() + " " + teksti + " " + kayttaja);
            sw.Close();
        }

        //Varmistaa sulkemishalukkuuden
        private void frmVaraukset_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Haluatko varmasti poistua?", "", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        //Käyttäjälle mahdollisuus päivittää taulu (esim. uuden lisäyksen tai muutoksen jälkeen) sulkematta nykyistä ikkunaa
        private void btnPaivita_Click(object sender, EventArgs e)
        {
            hakuquery = "SELECT * FROM varaus;";
            PaivitaTaulu();
        }
    }
    //Luokka & sen funktiot tulostusta varten, ei täydellinen, mutta toimii
    public class DataGridViewPrinter
    {
        private DataGridView dataGridView;
        private Graphics graphics;
        private Rectangle bounds;
        private Color textColor;
        private bool includeColumnHeaders;
        private int rowIndex;
        private bool morePages;
        public DataGridViewPrinter(DataGridView dataGridView, Graphics graphics, Rectangle bounds, Color textColor, bool includeColumnHeaders)
        {
            this.dataGridView = dataGridView;
            this.graphics = graphics;
            this.bounds = bounds;
            this.textColor = textColor;
            this.includeColumnHeaders = includeColumnHeaders;

            rowIndex = 0;
            morePages = false;
        }
        public bool DrawDataGridView()
        {
            int height = dataGridView.ColumnHeadersHeight + dataGridView.Rows.Cast<DataGridViewRow>().Sum(row => row.Height);

            if (includeColumnHeaders)
            {// noh.. piti saada tulostettua tuo otsikkorivi, mutta ei nyt onnistu, joten tulostaa vaan sen ylimmän rivin :D
                DrawRow(dataGridView.Rows[rowIndex].Cells, new SolidBrush(textColor), bounds.Y);
                height += dataGridView.Rows[0].Height;
            }

            while (rowIndex < dataGridView.Rows.Count)
            {
                if (height + dataGridView.Rows[rowIndex].Height > bounds.Height)
                {
                    morePages = true;
                    return morePages;
                }
                DrawRow(dataGridView.Rows[rowIndex].Cells, new SolidBrush(textColor), bounds.Y + height);
                height += dataGridView.Rows[rowIndex].Height;
                rowIndex++;
            }
            morePages = false;
            return morePages;
        }
        private void DrawRow(DataGridViewCellCollection cells, Brush brush, int y)
        {
            int x = bounds.X;

            foreach (DataGridViewCell cell in cells)
            {
                Rectangle cellBounds = new Rectangle(x, y, cell.OwningColumn.Width, cell.Size.Height);
                graphics.DrawString(cell.FormattedValue.ToString(), dataGridView.Font, brush, cellBounds, StringFormat.GenericDefault);

                x += cell.OwningColumn.Width;
            }
        }
    }
}
