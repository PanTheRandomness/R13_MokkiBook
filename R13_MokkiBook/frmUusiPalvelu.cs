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

namespace R13_MokkiBook
{
    public partial class frmUusiPalvelu : Form
    {
        public Palvelu valittupalvelu = new Palvelu();
        public List<Palvelu> palvelut;
        public string query;
        public frmUusiPalvelu()
        {
            InitializeComponent();
            palvelut = GetPalvelut();
        }



        public void saveButton_Click(object sender, EventArgs e)
        {
            string connectionString = "Dsn=Village Newbies;uid=root";

            using (OdbcConnection con = new OdbcConnection(connectionString))
            {
                con.Open();
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (!row.IsNewRow && row.Cells["palvelu_id"].Value != null)
                    {
                        int palvelu_id = (int)row.Cells["palvelu_id"].Value;
                        string query = "UPDATE palvelu SET nimi=@nimi, tyyppi=@tyyppi, kuvaus=@kuvaus, hinta=@hinta, alv=@alv WHERE palvelu_id=@palvelu_id";

                        using (OdbcCommand cmd = new OdbcCommand(query, con))
                        {
                            cmd.Parameters.AddWithValue("@nimi", row.Cells["nimi"].Value);
                            cmd.Parameters.AddWithValue("@tyyppi", row.Cells["tyyppi"].Value);
                            cmd.Parameters.AddWithValue("@kuvaus", row.Cells["kuvaus"].Value);
                            cmd.Parameters.AddWithValue("@hinta", row.Cells["hinta"].Value);
                            cmd.Parameters.AddWithValue("@alv", row.Cells["alv"].Value);
                            cmd.Parameters.AddWithValue("@palvelu_id", palvelu_id);
                            cmd.ExecuteNonQuery();
                        }
                    }
                }
                con.Close();
            }
            MessageBox.Show("All rows updated");
        }

        private void frmUusiPalvelu_Load(object sender, EventArgs e)
        {
            this.palveluTableAdapter1.Fill(this.dataSet1.palvelu);
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
                            palvelu.palvelu_id = reader.GetInt32(0);
                            palvelu.nimi = reader.GetString(1);
                            palvelu.tyyppi = reader.GetString(1);
                            palvelu.kuvaus = reader.GetString(1);
                            palvelu.hinta = reader.GetInt32(0);
                            palvelu.alv = reader.GetInt32(0);

                            pal.Add(palvelu);
                        }
                    }
                }
            }

            return pal;
        }
    }
}
