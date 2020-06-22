using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20200622_Teleloto
{
    public partial class Form1 : Form
    {
        //Klasei globalus elementas
        Random rng = new Random();

        private TextBox[] bilietas;



        public Form1()
        {
            InitializeComponent();
            bilietas = new TextBox[25]{ M1, M2, M3, M4, M5, 
                J1, J2, J3, J4, J5, R1, R2, R3, R4, R5,
            G1, G2, G3, G4, G5, Z1, Z2, Z3, Z4, Z5};
        }

        private void BGeneruoti_Click(object sender, EventArgs e)
        {
            TextBox[] melyni = { M1, M2, M3, M4, M5 };
            TextBox[] juodi = { J1, J2, J3, J4, J5 };
            TextBox[] raudoni = { R1, R2, R3, R4, R5 };
            TextBox[] geltoni = { G1, G2, G3, G4, G5 };
            TextBox[] zali = { Z1, Z2, Z3, Z4, Z5 };

            UžPildytiStulpeli(melyni, 1, 16);
            UžPildytiStulpeli(juodi, 16, 31);
            UžPildytiStulpeli(raudoni, 31, 46);
            UžPildytiStulpeli(geltoni, 46, 61);
            UžPildytiStulpeli(zali, 61, 76);
           
        }

        private void UžPildytiStulpeli(TextBox[] stulpelis, int pradzia, int pabaiga)
        {
            List<int> bilietoSkaiciai = new List<int>();
            int i = 0;
            while (i < stulpelis.Length)
            {
                int kamuoliukas = rng.Next(pradzia, pabaiga);
                bool naujas = true;

                foreach (var skaicius in bilietoSkaiciai)
                {
                    if (kamuoliukas == skaicius)
                    {
                        naujas = false;
                        break;
                    }
                }

                if (naujas)
                {
                    stulpelis[i].Text = kamuoliukas.ToString();
                    bilietoSkaiciai.Add(kamuoliukas);
                    i++;
                }
            }
        }

        private void BPlay_Click(object sender, EventArgs e)
        {
            Išvalyti();
            int i = 0;
            List<int> istrauktiKamuoliukai = new List<int>();

            while (i < 45)
            {
                int kamuoliukas = rng.Next(1, 76);

                bool naujas = true;
                foreach (var kam in istrauktiKamuoliukai)
                {
                    if (kam == kamuoliukas)
                    {
                        naujas = false;
                        break;
                    }
                }

                if (naujas)
                {
                    istrauktiKamuoliukai.Add(kamuoliukas);
                    i++;
                    PazymetiBiliete(kamuoliukas);
                    IštrauktiKamuoliukai.Text += kamuoliukas + " ";
                }
            }
        }

        private void Išvalyti()
        {
            IštrauktiKamuoliukai.Text = "";
            for (int i = 0; i < bilietas.Length; i++)
            {
                bilietas[i].BackColor = Color.White;
            }
        }

        private void PazymetiBiliete(int kamuoliuka)
        {
            for (int i = 0; i < bilietas.Length; i++)
            {
                if (bilietas[i].Text == kamuoliuka.ToString())
                {
                    bilietas[i].BackColor = Color.Green;
                }
            }
        }
    }
}
