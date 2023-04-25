using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace R13_MokkiBook
{
    public partial class frmUusiPalvelu : Form
    {
        private DataGridViewRow selectedRow;
        public frmUusiPalvelu(DataGridViewRow selectedRow)
        {
            InitializeComponent();

            this.selectedRow = selectedRow;

            string palveluId = selectedRow.Cells["palveluId"].Value.ToString();
            string palveluNimi = selectedRow.Cells["palveluNimi"].Value.ToString();
            // ...retrieve other columns' data...

            // populate the form's controls with the data
            palveluIdTextBox.Text = palveluId;
            palveluNimiTextBox.Text = palveluNimi;
            // ...populate other controls...
        }

        public void saveButton_Click(object sender, EventArgs e)
        {
            selectedRow.Cells["Palvelu_id"].Value = palveluIdTextBox.Text;
            selectedRow.Cells["nimi"].Value = palveluNimiTextBox.Text;
            // ...update other columns' data...

            // save the changes to the database
            dataGridView1.EndEdit();
            palveluTableAdapter1.Update(dataSet1);
            Close();
        }

        private void frmUusiPalvelu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.palvelu' table. You can move, or remove it, as needed.
            this.palveluTableAdapter1.Fill(this.dataSet1.palvelu);

        }

        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.palveluTableAdapter1.FillBy1(this.dataSet1.palvelu);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
