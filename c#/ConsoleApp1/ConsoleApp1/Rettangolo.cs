using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Rettangolo : FigureGeometriche
    {

        public Rettangolo(double l1, double l2) : base(l1, l2, l1, l2) { }

        public Rettangolo(Triangolo t) : base(t.Componi().Lati[0], t.Componi().Lati[1], t.Componi().Lati[2], t.Componi().Lati[3]) { }

        public double Diagonale()
        {
            return Math.Sqrt(Math.Pow(Lati[0], 2) + Math.Pow(Lati[1], 2));
        }

        public Triangolo Riduci()
        {           
            Triangolo t = new Triangolo(Lati[0], Lati[1], Diagonale());
            return t;
        }
    }
}
