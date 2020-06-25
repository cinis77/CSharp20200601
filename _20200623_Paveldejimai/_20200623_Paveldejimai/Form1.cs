using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20200623_Paveldejimai
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SugeneruotiTextBoxElementa();
        }

        private void SugeneruotiTextBoxElementa()
        {
            TextBox manoElementas = new TextBox();
            manoElementas.Location = new Point(10,  10);
            manoElementas.Size = new Size(150, 24);
            Controls.Add(manoElementas);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    MessageBox.Show(((TextBox)item).Text);
                }
            }
        }
    }
}
