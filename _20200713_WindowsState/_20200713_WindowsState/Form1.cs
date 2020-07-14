using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20200713_WindowsState
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
            Action act = Maksimizuoti;
            act += Metodas; //Subscribe
            act += Metodas;
            Form2 form = new Form2(act);
            form.Show();
            act -= Maksimizuoti; // Unsubscribe

            Action<int> action = Metodas;
            action = MetodasA;

            Func<string> function = Metod;
            Func<int, string> function2 = Methodas10;
           // Func<int, int, double, double> function3 = Methodas123;


            List<int> skaiciai = new List<int>() { 1, 2, 4, 3, 8, 9, 8, 100 };
            int i = 5;
            
            Func<int, bool> filtras = x => x > i;
            var elementai = skaiciai.Where(filtras).Select(x=> x);
            elementai.ToList().ForEach(x => Console.WriteLine(x));

            foreach (var item in elementai)
            {
                Console.WriteLine(item);
            }
        }

        private bool SuPavadinimus(int x)
        {
            if (x > 5)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

      
        private string Methodas10(int sk)
        {
            return sk.ToString();
        }

        private string Metod()
        {
            return "";
        }

        private void MetodasA(int skaicius)
        {

        }

        private void Metodas(int sk)
        {

        }

        private void Metodas()
        {
            MessageBox.Show("Labas");
        }

        private void Maksimizuoti()
        {
            WindowState = FormWindowState.Maximized;
        }
    }
}
