using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;
using System.Windows.Forms;

namespace _20200721_DuomenuBazesUzduotis
{
    public partial class Form1 : Form
    {
        private const string ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\GitHub\CSharp20200601\_20200721_DuomenuBazesUzduotis\_20200721_DuomenuBazesUzduotis\RobotDataBase.mdf;Integrated Security=True";

        public Form1()
        {
            InitializeComponent();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            DataContext db = new DataContext(ConnectionString);
            var tableData = db.GetTable<DrawingInDB>().Where(x=> x.Sheet.Uzsakymai.OrderNumber == OrderNumberTxtbx.Text);
            ShowDataInfo.DataSource = tableData.
                Select(x => new { x.Sheet.Amount, 
                    x.Code, x.Package, x.TrueName, 
                    x.Sheet.Uzsakymai.Name, x.Sheet.Uzsakymai.DeliveryDate });
        }

    }
}
