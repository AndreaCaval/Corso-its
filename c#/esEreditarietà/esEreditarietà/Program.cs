using System;

namespace esEreditarietà
{
    class Program
    {
        static void Main(string[] args)
        {
            Punto2D p1 = new Punto2D(5.4, 6.2);
            Punto2D p2 = new Punto2D(5.9, 8.2);

            double distanza = p1.CalcolaDistanza(p2);
            Console.WriteLine("La distanza tra i due punti è: "+distanza);
        }

        public class Punto2D
        {
            public double X { get; private set; }
            public double Y { get; private set; }

            public Punto2D(double x, double y)
            {
                X = x;
                Y = y;
            }

            public double CalcolaDistanza(Punto2D p)
            {
                double distanza = 0; double p_x = 0; double p_y = 0;

                p_x = Math.Pow(X - p.X, 2);
                p_y = Math.Pow(Y - p.Y, 2);

                distanza = Math.Sqrt(p_x + p_y);

                return distanza;
            }
        }
    }
}
