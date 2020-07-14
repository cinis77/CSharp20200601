using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20200714_DataBingsSuEvents
{
    public partial class Form1 : Form
    {
        DuomenuBind bind;
        public Form1()
        {
            InitializeComponent();
            bind = new DuomenuBind();
            Form2 form = new Form2(bind);
            form.Show();
            DuomenuEilute.DataBindings.Add("Text", bind, "Tekstas", false, DataSourceUpdateMode.OnPropertyChanged);
            DataBindings.Add("Text", bind, "Tekstas");
        }
    }
}
