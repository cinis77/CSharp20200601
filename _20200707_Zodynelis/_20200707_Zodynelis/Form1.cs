using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20200707_Zodynelis
{
    public partial class Form1 : Form
    {

        Dictionary<TabPage, string> Komentarai;

        public Form1()
        {
            InitializeComponent();
            Komentarai = new Dictionary<TabPage, string>();
        }

        private void NewTab_Click(object sender, EventArgs e)
        {
            TabPage page = new TabPage();
            page.Text = "aaa";
            Tabai.TabPages.Add(page);
            Komentarai.Add(page, "");
        }

        private void CommentText_TextChanged(object sender, EventArgs e)
        {
            Komentarai[Tabai.SelectedTab] = CommentText.Text;

            foreach (var item in Komentarai)
            {

                if (Komentarai.Count)
                {

                }

                if (item.Value == "")
                {
                    
                }
            }
        }

        private void Tabai_SelectedIndexChanged(object sender, EventArgs e)
        {
            CommentText.Text = Komentarai[Tabai.SelectedTab];
        }
    }
}
