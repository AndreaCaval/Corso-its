using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Triangolo : FigureGeometriche
    {

        public double Altezza { get; private set; }
        public double Base { get; private set; }

        public Triangolo(double l1, double l2, double l3) : base(l1, l2, l3) { }

        public override double Area()
        {
            double semiperimetro = Perimetro() / 2;
            double area = Math.Sqrt(semiperimetro * (semiperimetro - Lati[0]) * (semiperimetro - Lati[1]) * (semiperimetro - Lati[2]));
            return area;
        }

    }
}
