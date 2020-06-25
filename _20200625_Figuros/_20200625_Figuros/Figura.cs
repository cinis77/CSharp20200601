using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200625_Figuros
{
    abstract class Figura
    {
        public abstract double Plotas();

        public abstract double Perimetras();

      
    }

    #region Trikampio klase
    class Trikampis : Figura
    {
        public double a { get; set; }
        public double b { get; set; }

        public override double Plotas()
        {
            return (a * b) / 2;
        }

        public override double Perimetras()
        {
            var c = Math.Sqrt(a * a + b * b);
            return a + b + c;
        }

    }
    #endregion Trikampio klase

    #region Staciakampio klase
    class Staciakampis : Figura
    {
        public double a { get; set; }
        public double b { get; set; }

        public override double Plotas()
        {
            return a * b;
        }

        public override double Perimetras()
        {
            return 2 * a + 2 * b;
        }
    }
    #endregion Staciakampio klase

    #region Kvadrato klase
    class Kvadratas : Figura
    {
        public double a { get; set; }

        public override double Plotas()
        {
           
            return Math.Pow(a, 2);
        }

        public override double Perimetras()
        {
            return 4 * a;
        }
    }
    #endregion Kvadrato klase

    #region Apskritimas
    class Apskritimas : Figura
    {
        public double R { get; set; }

        public override double Plotas()
        {
            return Math.PI * R * R;
        }

        public override double Perimetras()
        {
            return Math.PI * 2 * R;
        }
    }
    #endregion Apskiritimas
}
