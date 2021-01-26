using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Quadrato : FigureGeometriche
    {
        public Quadrato(double l1) : base(l1, l1, l1, l1) { }

        public Quadrato(Triangolo t) : base(t.Componi().Lati[0], t.Componi().Lati[1], t.Componi().Lati[2], t.Componi().Lati[3]) { }
        
        public double Diagonale()
        {
            return Lati[0] * Math.Sqrt(2);
        }

        public Triangolo Riduci()
        {
            Triangolo t = new Triangolo(Lati[0], Lati[1], Diagonale());
            return t;
        }
    }
}
