using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20200618_WinForms
{
    public partial class Form1 : Form
    {
        List<ManoVisiZmones> zmon;

        public Form1()
        {
            InitializeComponent();
            zmon = new List<ManoVisiZmones>()
            {
                new ManoVisiZmones(){Id = 1, Vardas = "Roka", UserName = "Rokas69"},
                new ManoVisiZmones(){Id = 2, Vardas = "Ugne", UserName = "Ugne123"},
                new ManoVisiZmones(){Id = 3, Vardas = "Povilas", UserName = "Pofkis123"}
            };
            
        }

        private void BMygtukoPavadimas_Click(object sender, EventArgs e)
        {
            BMygtukoPavadimas.Text = "Paspaudžiau mygtuką";
            string tekstas = "Jus ivedete " + UserText.Text+ " "  + PswText.Text;
            MessageBox.Show(tekstas);
            if (CBManoPavadinimas.Checked)
            {
                DuomenuAtvaizdavimas.DataSource = zmon;
            }
            Login.Visible = !Login.Visible;
            PBNuotrauka.BackgroundImage = Image.FromFile("KR1000Titan_Header.jpg");
            PBNuotrauka.BackgroundImageLayout = ImageLayout.Stretch;
        }

    }


    class ManoVisiZmones
    {
        public int Id { get; set; }
        public string Vardas { get; set; }
        public string UserName { get; set; }
    }

}
