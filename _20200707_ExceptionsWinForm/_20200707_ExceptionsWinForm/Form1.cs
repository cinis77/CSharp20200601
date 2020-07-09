using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20200707_ExceptionsWinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SugeneruotiKlaida();
            }
            catch (BibliotekaSugeneravauPatsException ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void SugeneruotiKlaida()
        {
            VykstaVeiksmas vyksta = new VykstaVeiksmas();
            vyksta.Metodas();
        }
    }
}
