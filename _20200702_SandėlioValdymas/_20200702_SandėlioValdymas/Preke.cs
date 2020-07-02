using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20200702_SandėlioValdymas
{
    public class Preke
    {
        public int Id { get; }

        public string Name { get; }

        public string Vieta { get; private set; }

        public string Paemejas { get; private set; }

        public int Kaina { get; set; }

        public Preke(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public void PadėtiPreke(string vieta)
        {
            Vieta = vieta;
        }

        public void PaimtiPreke(string paemejas)
        {
            Vieta = null;
            Paemejas = paemejas;
        }

    }

    class ElektroninePreke : Preke
    {
        public ElektroninePreke(string name, int id) : base(id, name)
        {

        }    
    }

    class ApyvuokosPreke : Preke
    {
        public ApyvuokosPreke(string name, int id) : base(id,name)
        {

        }
    }

    class Baldas : Preke
    {
        public Baldas(string name, int id) : base(id, name)
        {

        }
    }
}
