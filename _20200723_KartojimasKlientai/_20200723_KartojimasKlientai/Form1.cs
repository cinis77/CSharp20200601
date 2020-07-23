using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20200723_KartojimasKlientai
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddNew_Click(object sender, EventArgs e)
        {
            TextBox kiekisNaujas = new TextBox();
            kiekisNaujas.Size = Kiekistxt.Size;
            kiekisNaujas.Location = new Point(Kiekistxt.Location.X, Kiekistxt.Location.Y + 30);
            PrekiusSarasas.Controls.Add(kiekisNaujas);

            TextBox kodasNaujas = new TextBox();
            kodasNaujas.Size = KodasTxt.Size;
            kodasNaujas.Location = new Point(KodasTxt.Location.X, KodasTxt.Location.Y + 30);
            PrekiusSarasas.Controls.Add(kodasNaujas);

            TextBox pavadinimasNaujas = new TextBox();
            pavadinimasNaujas.Size = Pavadinimas.Size;
            pavadinimasNaujas.Location = new Point(Pavadinimas.Location.X, Pavadinimas.Location.Y + 30);
            PrekiusSarasas.Controls.Add(pavadinimasNaujas);

            TextBox vienetoNaujas = new TextBox();
            vienetoNaujas.Size = VntKainatxt.Size;
            vienetoNaujas.Location = new Point(VntKainatxt.Location.X, VntKainatxt.Location.Y + 30);
            PrekiusSarasas.Controls.Add(vienetoNaujas);

            TextBox visaNaujas = new TextBox();
            visaNaujas.Size = VisaKainaTxt.Size;
            visaNaujas.Location = new Point(VisaKainaTxt.Location.X, VisaKainaTxt.Location.Y + 30);
            PrekiusSarasas.Controls.Add(visaNaujas);
        }
    }
}
