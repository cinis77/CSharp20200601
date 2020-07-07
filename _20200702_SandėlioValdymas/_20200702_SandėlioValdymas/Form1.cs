using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20200702_SandėlioValdymas
{
    public partial class Form1 : Form
    {
        private List<Preke> Sandelys;

        private Preke PasirinktaPreke;
        public Form1()
        {
            InitializeComponent();
            Sandelys = new List<Preke>();
            //SandelioVaizdas.DataSource = Sandelys;
        }

        private void NewItemCreateButton_Click(object sender, EventArgs e)
        {
            CreateNewItemForm form = new CreateNewItemForm(Sandelys, Refresh);
            form.Show();
        }

        private void Refresh(List<Preke> sandelys)
        {
            SandelioVaizdas.DataSource = null;
            SandelioVaizdas.DataSource = sandelys;
            SandelioVaizdas.Refresh();
            SandelioVaizdas.Update();
            Sandelys = sandelys;
        }

        private void SandelioVaizdas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var pasirinktasElementas = SandelioVaizdas.Rows[e.RowIndex].Cells[1].Value;
            foreach (var item in Sandelys)
            {
                if (item.Id == Convert.ToInt32(SandelioVaizdas.Rows[e.RowIndex].Cells[0].Value))
                {
                    PasirinktaPreke = item;
                    break;
                }
            }
            SelectedItemLabel.Text = pasirinktasElementas.ToString();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            if (PasirinktaPreke != null)
            {
                foreach (var item in Sandelys)
                {
                    if (item.Id == PasirinktaPreke.Id)
                    {
                        item.Kaina = int.Parse(PriceText.Text);
                        break;
                    }
                }
                SandelioVaizdas.DataSource = null;
                SandelioVaizdas.DataSource = Sandelys;
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (PasirinktaPreke != null)
            {
                Sandelys.Remove(PasirinktaPreke);
                PasirinktaPreke = null;
                SelectedItemLabel.Text = "-";
                SandelioVaizdas.DataSource = null;
                SandelioVaizdas.DataSource = Sandelys;
            }
        }
    }
}
