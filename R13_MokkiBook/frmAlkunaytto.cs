using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
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
        }

        private void frmAlkunaytto_Load(object sender, EventArgs e)
        {
            string connetionString;
            SqlConnection cnn;
            connetionString = @"Data Source=Village Newbies;uid=root";
            //connetionString = @"Data Source=WIN-50GP30FGO75(?);Initial Catalog=Village Newbies;User ID=root;Password=Ruutti";
            cnn = new SqlConnection(connetionString);
            cnn.Open();
            MessageBox.Show("Connection Open  !");
            cnn.Close();
        }
    }
}
