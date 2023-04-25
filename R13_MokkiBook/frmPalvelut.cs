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
    public partial class frmPalvelut : Form
    {
        public frmPalvelut()
        {
            InitializeComponent();
        }



        private void frmPalvelut_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.palvelu' table. You can move, or remove it, as needed.
            this.palveluTableAdapter.Fill(this.dataSet1.palvelu);
        }

        private void label1_Click(object sender, EventArgs e) //otsikko
        {

        }
    
        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.palveluTableAdapter.FillBy(this.dataSet1.palvelu);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void TsBtnLisaa_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = dataGridView1.CurrentRow;
            if (selectedRow != null)
            {
                frmUusiPalvelu editForm = new frmUusiPalvelu(selectedRow);
                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    // update the selected row with the new data
                  //  selectedRow.Cells["palveluId"].Value = editForm.palveluIdTextBox.Text;
                    //selectedRow.Cells["palveluNimi"].Value = editForm.palveluNimiTextBox.Text;
                    // ...update other columns' data...

                    // save the changes to the database
                    try
                    {
                        this.Validate();
                        this.palveluBindingSource.EndEdit();
                       // this.palveluTableAdapter.UpdateAll(this.dataSet1);
                        MessageBox.Show("Changes saved successfully.");
                    }
                    catch (System.Exception ex)
                    {
                        MessageBox.Show("Error saving changes: " + ex.Message);
                    }
                }
            }
            else
            {
                // show an error message if no row is selected
                MessageBox.Show("Please select a row to edit.");
            }
        }
    }
}
