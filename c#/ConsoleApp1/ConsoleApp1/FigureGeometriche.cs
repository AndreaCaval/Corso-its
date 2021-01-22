using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class FigureGeometriche
    {
        public double[] Lati { get; private set; }

        public FigureGeometriche (params double[] lati)
        {
            Lati = new double[lati.Length];
            for (int i = 0; i < lati.Length; i++)
            {
                Lati[i] = lati[i];
            }
        }

        public virtual double Perimetro()
        {
            double perimetro = 0;

            for (int i = 0; i < Lati.Length; i++)
            {
                perimetro += Lati[i];
            }

            return perimetro;
        }

        public virtual double Area()
        {
            double area = 0;

            area = Lati[0] * Lati[1];

            return area;
        }

        public double Diagonale()
        {
            return 2.2;
        }
    }
}
