using _20200616_Klasės.CodeBehindClasses;
using System;

namespace _20200616_Klasės
{
    class Automobilis
    {
        private string Marke;
        public string Gamintojas { get; }
        public int GamybosMetai { get; private set; }
        public ManoKlase KitaManoKlase;
        public int MyProperty { get; set; }

        private int myVar;

        public int ManoProperty
        {
            get 
            { 
                return myVar; 
            }
            set 
            {
                if (myVar != value)
                {
                    myVar = value;
                }
               
            }
        }


        public int Rida 
        { 
            get
            {
                MetodasB();
                return Rida;
            }
            set
            {
                MetodasA();
                GamybosMetai += 200;
                
            }
        }
        private string Spalva;

        public string MarkeGet()
        {
            return Marke;
        }

        public void MarkeSet(string marke, string psw)
        {
            Marke = marke;
        }

        public double RidaPerMetus()
        {
            return (double)Rida / (DateTime.Today.Year - GamybosMetai);
        }

        protected void MetodasA()
        {
            GamybosMetai = 2000;
        }

        internal void MetodasB()
        {
 
        }

        internal void MetodasB(string elemento)
        {

        }


        /// <summary>
        /// Pilnas konstruktorius
        /// </summary>
        /// <param name="Gamintojas"></param>
        /// <param name="marke"></param>
        /// <param name="gamybosMetus"></param>
        /// <param name="Rida"></param>
        public Automobilis(string Gamintojas, string marke, int gamybosMetus, int Rida)
        {
            Marke = marke;
            GamybosMetai = gamybosMetus;
            this.Gamintojas = Gamintojas;
            this.Rida = Rida;
            MetodasA();
        }

        /// <summary>
        /// Vienas Is elementu
        /// </summary>
        /// <param name="Gamintojas"></param>
        public Automobilis(string Gamintojas)
        {

        }

        public Automobilis(int gamybosMetai)
        {

        }

        /// <summary>
        /// Pagal nutylejima konstruktorius
        /// </summary>
        public Automobilis()
        {

        }
    }
}
