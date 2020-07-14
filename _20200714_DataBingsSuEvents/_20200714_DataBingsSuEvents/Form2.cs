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
    public partial class Form2 : Form
    {
        DuomenuBind Binding;

        public Form2(DuomenuBind bind)
        {
            InitializeComponent();
            Binding = bind;
            label1.DataBindings.Add("Text", Binding, "Tekstas");
        }
    }
}
