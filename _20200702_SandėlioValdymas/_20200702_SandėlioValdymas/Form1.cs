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
        public Form1()
        {
            InitializeComponent();
            Sandelys = new List<Preke>();
            SandelioVaizdas.DataSource = Sandelys;
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
            
            var pasirinktasElementas = SandelioVaizdas;
            MessageBox.Show(pasirinktasElementas.ToString()) ;
        }
    }
}
