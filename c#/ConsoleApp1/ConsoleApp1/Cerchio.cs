using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Cerchio : FigureGeometriche
    {
        public Cerchio(double r1) : base(r1) { }

        public override double Perimetro()
        {
            return Math.PI * 2 * Lati[0];
        }

        public override double Area()
        {
            return Math.PI * Math.Pow(Lati[0], 2);
        }
    }
}
