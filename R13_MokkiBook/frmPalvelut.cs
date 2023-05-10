using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.Odbc;
using System.IO;

namespace R13_MokkiBook
{
    public partial class frmPalvelut : Form
    {
        public Palvelu valittupalvelu = new Palvelu();
        public List<Palvelu> palvelut;
        public string query;


        public frmPalvelut()
        {
            InitializeComponent();
            palvelut = GetPalvelut();
            lokiinTallentaminen("Palvelut-osio avattiin käyttäjältä: ");
        }


        private void frmPalvelut_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.palvelu' table. You can move, or remove it, as needed.
            this.palveluTableAdapter.Fill(this.dataSet1.palvelu);
        }

        public List<Palvelu> GetPalvelut()
        {
            List<Palvelu> pal = new List<Palvelu>();
            string connectionString = "Dsn=Village Newbies;uid=root";
            string query = "SELECT * FROM palvelu";

            using (OdbcConnection connection = new OdbcConnection(connectionString))
            {
                connection.Open();
                using (OdbcCommand command = new OdbcCommand(query, connection))
                {
                    using (OdbcDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Palvelu palvelu = new Palvelu();
                            palvelu.palvelu_id = reader.GetInt32(1); //Muutin että hakee vaan palvelu_id:n (Sama asia)

                            pal.Add(palvelu);
                        }
                    }
                }
            }
            return pal;
        }

        private void TsBtnLisaa_Click_1(object sender, EventArgs e)
        {
            frmUusiPalvelu up = new frmUusiPalvelu();
            up.ShowDialog();
        }


        public void lokiinTallentaminen(string teksti)

        {
            string kayttaja = Environment.UserName;

            StreamWriter sw = new StreamWriter("Kirjautumistiedot.txt", true);
            sw.WriteLine(DateTime.Now.ToString() + " " + teksti + " " + kayttaja);
            sw.Close();
        }

        private void txtHaku_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string searchTerm = txtHaku.Text;
                DataTable table = new DataTable();
                string connectionString = "Dsn=Village Newbies;uid=root";

                if (string.IsNullOrEmpty(searchTerm))
                {
                    string sql = $"SELECT * FROM palvelu";
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
                    string sql = $"SELECT * FROM palvelu WHERE palvelu_id = '{searchTerm}'";
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

    private void TsBtnHae_Click(object sender, EventArgs e)
        {
            
        }

        private void frmPalvelut_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Haluatko varmasti sulkea ikkunan?", "Varmista", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
