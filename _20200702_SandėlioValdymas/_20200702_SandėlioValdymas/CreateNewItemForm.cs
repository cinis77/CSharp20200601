using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20200702_SandėlioValdymas
{
    public partial class CreateNewItemForm : Form
    {
        private readonly List<Preke> AddList;
        private Action<List<Preke>> Refresh;

        public CreateNewItemForm(List<Preke> sandelys, Action<List<Preke>> refresh)
        {
            InitializeComponent();
            AddList = sandelys;
            Refresh = refresh;
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void Elektronine_CheckedChanged(object sender, EventArgs e)
        {
            Elektronine.Enabled = false;
            Apyvuoko.Enabled = false;
            Baldas.Enabled = false;
            NameOfItem.Visible = true;
            PriceText.Visible = true;
            SaveItem.Visible = true;
        }

        private void SaveItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(NameOfItem.Text) || string.IsNullOrWhiteSpace(NameOfItem.Text))
            {
                MessageBox.Show("Ivesti prekes pavadinima");
            }
            else
            {
                if (Elektronine.Checked)
                {
                    Random rng = new Random();
                    ElektroninePreke el = new ElektroninePreke(NameOfItem.Text,rng.Next());
                    AddList.Add(el);
                }
                else if (Apyvuoko.Checked)
                {
                    Random rng = new Random();

                    ApyvuokosPreke ap = new ApyvuokosPreke(NameOfItem.Text, rng.Next());
                    AddList.Add(ap);
                }
                else if (Baldas.Checked)
                {
                    Random rng = new Random();
                    Baldas baldas = new Baldas(NameOfItem.Text, rng.Next());
                    AddList.Add(baldas);
                }
                else
                {
                    MessageBox.Show("Nezinoma klaida");
                }
                Refresh(AddList);
                Close();
            }
        }

        private void Apyvuoko_CheckedChanged(object sender, EventArgs e)
        {
            Elektronine.Enabled = false;
            Apyvuoko.Enabled = false;
            Baldas.Enabled = false;
            NameOfItem.Visible = true;
            PriceText.Visible = true;
            SaveItem.Visible = true;
        }

        private void Baldas_CheckedChanged(object sender, EventArgs e)
        {
            Elektronine.Enabled = false;
            Apyvuoko.Enabled = false;
            Baldas.Enabled = false;
            NameOfItem.Visible = true;
            PriceText.Visible = true;
            SaveItem.Visible = true;
        }
    }
}
