using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Threading.Tasks;

namespace _20200714_DataBingsSuEvents
{
    public delegate void DelegatasIvykiui(object sender, EventArgs e);

    class KlaseSuIvykiu
    {
        public event DelegatasIvykiui ManoIvykis;

        public void SugeneruotiIvyki()
        {
            if (ManoIvykis != null)
            {
                ManoIvykis(this, new EventArgs());
            }
        }
    }


    public class DuomenuBind : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private string _Tekstas;

        public string Tekstas
        {
            get
            {
                return _Tekstas;
            }
            set
            {
                if (value != _Tekstas)
                {
                    _Tekstas = value;
                    NotifyChange("Tekstas");
                }
            }
        }


        private void NotifyChange(string nameOfProperty)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(nameOfProperty));
            }
        }
    }
}
