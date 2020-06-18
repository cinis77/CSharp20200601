using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20200618_PaveiksliukoUzkrovimas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            string path = null;
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "*.jpg|*.jpg";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    path = ofd.FileName;
                }
            }

            if (!string.IsNullOrEmpty(path))
            {
                Paveiksliukas.BackgroundImage = Image.FromFile(path);
                Paveiksliukas.BackgroundImageLayout = ImageLayout.Stretch;
                KeliasText.Text = path;
            }
        }
    }
}
