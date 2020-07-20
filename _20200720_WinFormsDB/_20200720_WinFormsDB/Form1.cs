using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20200720_WinFormsDB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void klientaiBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.klientaiBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.vartotojaiDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'vartotojaiDataSet.Klientai' table. You can move, or remove it, as needed.
            this.klientaiTableAdapter.Fill(this.vartotojaiDataSet.Klientai);

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.klientaiTableAdapter.FillBy(this.vartotojaiDataSet.Klientai);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
