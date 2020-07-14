using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20200713_Viesbutis
{
    public partial class Form1 : Form
    {
        List<Viesbutis> Viesbuciai;

        public Form1()
        {
            InitializeComponent();
            Viesbuciai = new List<Viesbutis>();

            Viesbutis vies = new Viesbutis();
            vies.Pavadinimas = "ABC";
            vies.Kamabariai.Add(new Kambarys()
            {
                Kaina = 78.88,
                Uzimtas = false,
            });
            vies.Kamabariai.Add(new Kambarys()
            {
                Kaina = 68.88,
                Uzimtas = false,
            });
            vies.Kamabariai.Add(new Kambarys()
            {
                Kaina = 108.88,
                Uzimtas = true,
            });

            Viesbuciai.Add(vies);

            Viesbutis viesas = new Viesbutis();
            viesas.Pavadinimas = "CDF";
            viesas.Kamabariai.Add(new Kambarys()
            {
                Kaina = 39.99,
                Uzimtas = false,
            });
            viesas.Kamabariai.Add(new Kambarys()
            {
                Kaina = 48.89,
                Uzimtas = false,
            });
            viesas.Kamabariai.Add(new Kambarys()
            {
                Kaina = 200.18,
                Uzimtas = true,
            });
            Viesbuciai.Add(viesas);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var pigiausi = Viesbuciai.Select(x => x.Kamabariai.Min(y=>y.Kaina));
            Kambariai.DataSource = pigiausi;
        }

        private void BrangiausiB_Click(object sender, EventArgs e)
        {
            var brangiausi = Viesbuciai.Select(x => x.Kamabariai.Where(y=> y.Kaina == x.Kamabariai.Max(z=>z.Kaina)).ToList()).ToList();
            List<Kambarys> brangiausis = new List<Kambarys>();
            brangiausi.ForEach(x => x.ForEach(y => brangiausis.Add(y)));
            Kambariai.DataSource = brangiausis;
        }

        private void NeuzimtiB_Click(object sender, EventArgs e)
        {
            var neuzimti = Viesbuciai.Select((x => x.Kamabariai.Where(y => !y.Uzimtas).ToList())).ToList();
            List<Kambarys> neuzimtiKamabriai = new List<Kambarys>();
            neuzimti.ForEach(x => x.ForEach(y => neuzimtiKamabriai.Add(y)));
            Kambariai.DataSource = neuzimtiKamabriai;
        }
    }
}
